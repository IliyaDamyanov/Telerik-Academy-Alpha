using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_loves_paper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // edin neefektiven nachin da si napravish graf
            // ne se muchi da go gledash , ne sojih property dali imat naslednici
            Graph graph = new Graph();
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string command = Console.ReadLine();
                string[] commands = command.Split(' ');
                if (commands[2]=="before")
                {
                    int value = int.Parse(commands[3]);
                    int parrent = int.Parse(commands[0]);
                    var node = new Node(value, parrent);
                    if (graph.Nodes.Count==0)
                    {
                        graph.Nodes.Add(node);
                    }
                    for (int m = 0; m < graph.Nodes.Count; m++)
                    {
                        if (graph.Nodes[m].Value==value)
                        {
                            if (!graph.Nodes[m].Parrents.Contains(parrent))
                            {
                                graph.Nodes[m].Parrents.Add(parrent);
                            }
                            break;
                        }
                        if ((m== graph.Nodes.Count-1) && graph.Nodes[m].Value != value)
                        {
                            graph.Nodes.Add(node);
                        }                      
                    }
                }
                else if (commands[2] == "after")
                {
                    int value = int.Parse(commands[0]);
                    int parrent = int.Parse(commands[3]);
                    var node = new Node(value, parrent);
                    if (graph.Nodes.Count == 0)
                    {
                        graph.Nodes.Add(node);
                    }
                    for (int m = 0; m < graph.Nodes.Count; m++)
                    {
                        if (graph.Nodes[m].Value == value)
                        {
                            if (!graph.Nodes[m].Parrents.Contains(parrent))
                            {
                                graph.Nodes[m].Parrents.Add(parrent);
                            }
                            break;
                        }
                        if ((m == graph.Nodes.Count - 1) && graph.Nodes[m].Value != value)
                        {
                            graph.Nodes.Add(node);
                        }
                    }
                }
                

            }
        }


        public class Node
        {
            private List<int> parrents = new List<int>();

            public Node (int value, int parrent)
            {
                this.Value = value;
                this.Parrents.Add(parrent);
            }
            public int Value { get; set; }

            public List<int> Parrents
            {
                get
                {
                    return this.parrents;
                }
                set
                {
                    this.parrents = value;
                }
            }
        }

        public class Graph
        {
            public List<Node> Nodes { get; set; }
        }
    }
}
