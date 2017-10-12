using System;
using System.Net;

namespace _04.Download_file
{
    class Program
    {
        static string Input()
        {
            string fileURL = Console.ReadLine();
            return fileURL;
        }
        static void Main()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(Input(), "TelerikNinja.png");
            }
            catch (WebException wEx)
            {
                Console.Error.WriteLine(wEx.Message);
            }
            catch (ArgumentException argEx)
            {
                Console.Error.WriteLine(argEx.Message);
            }

            
        }
    }
}
