﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace BAI_01
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                Console.WriteLine(ip.ToString());
                Console.WriteLine();

            }
            
            
        }
    }
}
