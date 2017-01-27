﻿using ClientWindow;
using ControlCCRC.Protocols;
using Management;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ControlCCRC
{
    class ListenerHandler
    {
        private Thread thread;
        private String identifier;
        private bool lastNode;
        private BinaryWriter writer;

        private TcpClient client;
        private RoutingController rc;
        private ConnectionController cc;
        private Dictionary<String, BinaryWriter> socketHandler;



        public ListenerHandler(TcpClient client, RoutingController rc, ConnectionController cc,ref Dictionary<String, BinaryWriter> socketHandler)
        {
            this.client = client;
            this.rc = rc;
            this.cc = cc;
            this.socketHandler = socketHandler;

            thread = new Thread(new ParameterizedThreadStart(handleThread));
            thread.Start(client);
        }

        private void handleThread(Object obj)
        {
            TcpClient client = (TcpClient)obj;
            BinaryReader reader = new BinaryReader(client.GetStream());
            writer = new BinaryWriter(client.GetStream());
            Boolean noError = true;
            while (noError)
            {
                string received_data = reader.ReadString();
                JMessage received_object = JMessage.Deserialize(received_data);
                if (received_object.Type == typeof(RCtoLRMSignallingMessage))
                {
                    RCtoLRMSignallingMessage lrmMsg = received_object.Value.ToObject<RCtoLRMSignallingMessage>();
                    switch (lrmMsg.State)
                    {
                        case RCtoLRMSignallingMessage.LRM_INIT:
                            consoleWriter("LRM_INIT");
                            identifier = lrmMsg.NodeName;
                            rc.initLRMNode(identifier);
                            socketHandler.Add(identifier, writer);
                            consoleWriter("SOCKETHANDLER KONIEC");
                            break;
                        case RCtoLRMSignallingMessage.LRM_TOPOLOGY_ADD:
                            consoleWriter("LRM_TOP_ADD");
                            rc.addTopologyElementFromLRM(identifier, lrmMsg.ConnectedNode, lrmMsg.ConnectedNodePort);
                            break;
                        case RCtoLRMSignallingMessage.LRM_TOPOLOGY_DELETE:
                            consoleWriter("LRM_TOP_DEL");
                            rc.deleteTopologyElementFromLRM(lrmMsg.ConnectedNode);
                            break;
                    }
                }
                else if (received_object.Type == typeof(RCtoRCSignallingMessage))
                {
                    RCtoRCSignallingMessage rcMsg = received_object.Value.ToObject<RCtoRCSignallingMessage>();
                    socketHandler.Add(rcMsg.Identifier, writer);

                    switch(rcMsg.State)
                    {
                        case RCtoRCSignallingMessage.COUNTED_ALL_PATHS_CONFIRM:
                            rc.lowerRcSendedConnectionsAction(rcMsg.NodeConnectionsAndWeights);
                            break;
                        case RCtoRCSignallingMessage.COUNTED_ALL_PATHS_REFUSE:
                            break;
                    }
                }
                else if (received_object.Type == typeof(CCtoCCSignallingMessage))
                {
                    CCtoCCSignallingMessage ccMsg = received_object.Value.ToObject<CCtoCCSignallingMessage>();
                    
                    switch (ccMsg.State)
                    {
/////////////////////////
                       
                    }
                }
            }
        }
        public bool isLastNode()
        {
            return lastNode;
        }

        public void writeFIB(List<FIB> fibs)
        {
            CCtoCCSignallingMessage msg = new CCtoCCSignallingMessage();
            msg.Fib_table = fibs;
            msg.State = CCtoCCSignallingMessage.CC_UP_FIB_CHANGE;

            String send_object = JMessage.Serialize(JMessage.FromValue(msg));
            writer.Write(send_object);
        }


        private void consoleWriter(String msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Write("#" + DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString() + "#:[RC]" + msg);
            Console.Write(Environment.NewLine);
        }
    }
}
