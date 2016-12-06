﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManagementApp
{
    class CloudCableHandler
    {
        //private 
        private List<NodeConnection> connections;
        private TcpClient client;
        private BinaryWriter writer;
        private    BinaryReader reader;
        private TcpListener listener;

        public CloudCableHandler(List<NodeConnection> connections, int cloudPort)
        {
            this.connections = connections;
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), cloudPort);
            Thread thread = new Thread(new ThreadStart(listenForCloud));
            thread.Start();
        }

        private void listenForCloud()
        {
            listener.Start();

            client = listener.AcceptTcpClient();
            writer = new BinaryWriter(client.GetStream());
            reader = new BinaryReader(client.GetStream());
        }

        public void updateConnections()
        {
            foreach(NodeConnection con in connections)
            {
                String data = JSON.Serialize(JSON.FromValue(con));
                writer.Write(data);
            }
        }
        public void updateOneConnection()
        {
            String data = JSON.Serialize(JSON.FromValue(connections.Last()));
            writer.Write(data);
        }
    }
}