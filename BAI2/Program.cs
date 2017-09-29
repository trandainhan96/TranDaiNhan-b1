using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace BAI2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Nhap ten mien hoac IP: ");
            string host = Console.ReadLine();

            IPHostEntry e = Dns.GetHostEntry(host);
            Console.WriteLine("HostName: {0}", e.HostName);

            foreach(string s in e.Aliases)
                Console.WriteLine("\t Alias: {0 \n",s);

            foreach (IPAddress i in e.AddressList)
                Console.WriteLine("\t IP: {0},i"); */
            IPHostEntry ipHostEntry = new IPHostEntry();
            Console.Write("Nhap ten hostname hoac IP: ");
            string input = Console.ReadLine();
            ipHostEntry = Dns.GetHostEntry(input);

            try
            {
                Console.WriteLine("Hostname: " + ipHostEntry.HostName);
                Console.WriteLine("IPs: ");
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    Console.WriteLine(ip.ToString());
                }
                Console.WriteLine("Aliases: ");
                if (ipHostEntry.Aliases.Length == 0)
                {
                    Console.WriteLine("No aliases");
                }
                else
                {
                    foreach (string alias in ipHostEntry.Aliases)
                    {
                        Console.WriteLine(alias);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.ReadKey();
        }
    }
}
