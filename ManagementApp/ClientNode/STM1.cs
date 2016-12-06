﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNode
{
    
    public class STM1
    {
        //RSOH
        //MSOH
        public VirtualContainer4 vc4;
        public VirtualContainer3[] vc3List = new VirtualContainer3[3];//sa trzy kontenery vc3 a nie dwa

        public STM1()
        {
            //stub
        }
        public STM1(VirtualContainer4 vc4)
        {
            this.vc4 = vc4;
        }
        public STM1(VirtualContainer3[] vc3, int[] pos)
        {
            for(int i=0; i<pos.Length; i++)
            {
                this.vc3List[pos[i]] = vc3[i];
            }
        }
        

    }

   



    public class VirtualContainer3
    {
        public int POH;
        public string C3;
        public VirtualContainer3(int POH, string C3)
        {
            this.POH = POH;
            this.C3 = C3;
        }
    }

    public class VirtualContainer4
    {
        public int POH;
        public string C4;
        public VirtualContainer4(int POH, string C4)
        {
            this.POH = POH;
            this.C4 = C4;
        }
    }

    
}