using System;
using System.IO;

namespace DirectoryTraverserDFS_NakovBook_
{
    public class Program
    {
        public static void Main()
        {
            DirectoryTraverserBFS.TraverseDir("C:\\ ");
            DirectoryTraverserDFS.TraverseDir("C:\\");
        }
    }
}
