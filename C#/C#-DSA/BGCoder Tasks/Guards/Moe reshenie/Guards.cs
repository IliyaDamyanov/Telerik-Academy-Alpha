using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guards.Moe_reshenie
{
    public class Guards
    {
        private const long normalStep = 1;
        private const long guardsWatch = 3;
        private const long guard = 100000000;

        public static void Run()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            string[] file = reader.Read().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            string[] mazeDimensions = file[0].Split(' ');
            int rows = int.Parse(mazeDimensions[0]);
            int columns = int.Parse(mazeDimensions[1]);
            long[,] maze = new long[rows, columns];
            int guardsNumber = int.Parse(file[1]);
            for (int i = 0, j = 2; i < guardsNumber; i++, j++)
            {
                string[] guardDescription = file[j].Split(' ');
                int guardRow = int.Parse(guardDescription[0]);
                int guardColumn = int.Parse(guardDescription[1]);
                string guardDirection = guardDescription[2];
                maze[guardRow, guardColumn] = guard;
                switch (guardDirection)
                {
                    case "L":
                        if (guardColumn != 0 && maze[guardRow, guardColumn - 1] != guard)
                        {
                            maze[guardRow, guardColumn - 1] = guardsWatch;
                        }
                        break;
                    case "R":
                        if (guardColumn != columns - 1 && maze[guardRow, guardColumn + 1] != guard)
                        {
                            maze[guardRow, guardColumn + 1] = guardsWatch;
                        }
                        break;
                    case "U":
                        if (guardRow != 0 && maze[guardRow - 1, guardColumn] != guard)
                        {
                            maze[guardRow - 1, guardColumn] = guardsWatch;
                        }
                        break;
                    case "D":
                        if (guardRow != rows - 1 && maze[guardRow + 1, guardColumn] != guard)
                        {
                            maze[guardRow + 1, guardColumn] = guardsWatch;
                        }
                        break;
                }
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    maze[i, j] = maze[i, j] == 0 ? 1 : maze[i, j];
                }
            }

            for (int i = 1; i < columns; i++)
            {
                maze[0, i] += (maze[0, i - 1]);
            }

            for (int i = 1; i < rows; i++)
            {
                maze[i, 0] += (maze[i - 1, 0]);
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    maze[i, j] += Math.Min(maze[i - 1, j], maze[i, j - 1]);
                }
            }

            writer.Write(maze[rows - 1, columns - 1] < guard ? maze[rows - 1, columns - 1].ToString() : "Meow");
        }
    }

    public class FileReader : IReader
    {
        public string Read()
        {
            using (StreamReader reader = new StreamReader("input3.txt"))
            {
                return reader.ReadToEnd(); ;
            }
        }
    }

    public class ConsoleReader : IReader
    {
        public string Read()
        {
            string file = string.Empty;
            int guards;
            file += string.Format("{0}{1}", Console.ReadLine(), Environment.NewLine);
            file += string.Format("{0}{1}", guards = int.Parse(Console.ReadLine()), Environment.NewLine);
            for (int i = 0; i < guards; i++)
            {
                file += string.Format("{0}{1}", Console.ReadLine(), Environment.NewLine);
            }

            return file;
        }
    }

    //ot writer nqma nujda , zashoto vseki pyt iskam na consolata da si izliza , ama da ima
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }

    public interface IWriter
    {
        void Write(string text);
    }

    public interface IReader
    {
        string Read();
    }
}
