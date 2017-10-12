using System;

namespace _12.Parse_URL
{
    class Program
    {
        static void PrintProtocol(string address)
        {
            int index = address.IndexOf(':');
            string substring = address.Substring(0, index);
            Console.WriteLine("[protocol] = " + substring);
        }
        static void PrintServerAndResource(string address)
        {
            int startIndex = address.IndexOf("//");
            int endIndex = address.IndexOf("/", startIndex + 2);
            string substringServer = address.Substring(startIndex + 2, endIndex - startIndex-2);
            Console.WriteLine("[server] = " + substringServer);
            string substringResource = address.Substring(endIndex, address.Length - endIndex);
            Console.WriteLine("[resource] = " + substringResource);
        }
        static void Main()
        {
            string address = Console.ReadLine();
            PrintProtocol(address);
            PrintServerAndResource(address);
        }
    }
}
