using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace Player_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, OrderedSet<Player>> playersByType = new Dictionary<string, OrderedSet<Player>>();
            BigList<Player> rankList = new BigList<Player>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split(' ');
                switch (commands[0])
                {
                    case "add":
                        string name = commands[1];
                        string type = commands[2];
                        int age = int.Parse(commands[3]);
                        int position = int.Parse(commands[4]);
                        Player player = new Player(name, type, age);

                        if (!playersByType.ContainsKey(player.Type))
                        {
                            playersByType.Add(player.Type, new OrderedSet<Player>() { player });
                        }
                        else
                        {
                            playersByType[player.Type].Add(player);
                        }

                        rankList.Insert(position - 1, player);
                        Console.WriteLine("Added player {0} to position {1}",player.Name,position);
                        break;
                    case "find":
                        string playersType = commands[1];
                        if (playersByType.ContainsKey(playersType))
                        {
                            string resultString = string.Format("Type {0}: {1}", playersType, string.Join("; ", playersByType[playersType].Take(5)));
                            resultString.TrimEnd(';', ' ');
                            Console.WriteLine(resultString);
                        }
                        else
                        {
                            Console.WriteLine("Type {0}: ", playersType);
                        }
                        break;
                    case "ranklist":
                        int start = int.Parse(commands[1]);
                        int end = int.Parse(commands[2]);
                        IList<Player> ranks = rankList.Range(start - 1, end - start + 1);
                        int index = start;
                        string rankingResult = string.Join("; ", ranks.Select(playa => string.Format("{0}. {1}", index++, playa.ToString())));
                        rankingResult.TrimEnd(';', ' ');
                        Console.WriteLine(rankingResult);
                        break;
                }
            }
        }
    }

    public class Player : IComparable<Player>
    {
        public Player(string name, string type, int age)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public int CompareTo(Player other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result==0)
            {
                result = this.Age.CompareTo(other.Age) * -1;
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Age);
        }
    }
}
