using System;

namespace _15.Replace_tags
{
    class Program
    {
        static void Main()
        {
            string html = Console.ReadLine();
            int startIndexOfUrl = html.IndexOf("<a href=\"") + 9;
            while (startIndexOfUrl>=9)
            {            
                int endIndexOfUrl = html.IndexOf("\">");
                string url = html.Substring(startIndexOfUrl, (endIndexOfUrl - startIndexOfUrl));
                int startIndexOfText = html.IndexOf("\">") + 2;
                int endIndexOfText = html.IndexOf("</a>");
                string text = html.Substring(startIndexOfText, (endIndexOfText - startIndexOfText));
                string substringToInsert = string.Concat("[" + text + "](" + url + ")");
                int startIndexOfSubstrintToDelete = html.IndexOf("<a");
                int endIndexOfSubstrintToDelete = html.IndexOf("a>") + 1;
                string substringToDelete = html.Substring(startIndexOfSubstrintToDelete, (endIndexOfSubstrintToDelete - startIndexOfSubstrintToDelete) + 1);
                html = html.Replace(substringToDelete, substringToInsert);
                startIndexOfUrl = html.IndexOf("<a href=\"") + 9;
            }
            Console.WriteLine(html);
        }
    }
}
