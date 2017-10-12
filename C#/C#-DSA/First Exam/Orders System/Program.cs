using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace Orders_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Orders.Run();
        }
    }

    class Orders
    {
        public static void Run()
        {
            Dictionary<string, OrderedSet<Consumer>> dictByConsum = new Dictionary<string, OrderedSet<Consumer>>();
            SortedList<decimal, Consumer> setByPrice = new SortedList<decimal, Consumer>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string command = Console.ReadLine();
                if (command.Contains("AddOrder"))
                {
                    int startIndex = command.IndexOf(';');
                    int lastIndex = command.LastIndexOf(';');
                    string name = command.Substring(9,startIndex-9);
                    decimal price = decimal.Parse(command.Substring(startIndex + 1, (lastIndex - startIndex - 1)));
                    string consumer = command.Substring(lastIndex+1);

                    Consumer cons = new Consumer();
                    cons.Name = name;
                    cons.Price = price;
                    cons.ConsumerName = consumer;

                    if (!dictByConsum.ContainsKey(consumer))
                    {
                        dictByConsum.Add(consumer, new OrderedSet<Consumer>());
                        dictByConsum[cons.ConsumerName].Add(cons);
                    }
                    else
                    {
                        dictByConsum[consumer].Add(cons);
                    }

                    setByPrice.Add(cons.Price, cons);

                    Console.WriteLine("Order added");
                }

                else if (command.Contains("FindOrdersByConsumer"))
                {
                    string consumerName = string.Empty;
                    consumerName = command.Substring(21);
                    if (dictByConsum.ContainsKey(consumerName))
                    {
                        StringBuilder s = new StringBuilder();
                        var consum = dictByConsum[consumerName];
                        for (int l = 0; l < consum.Count; l++)
                        {
                            if (l == consum.Count - 1)
                            {
                                s.Append("{" + consum[l] + "}");
                            }
                            else
                            {
                                s.Append("{" + consum[l] + "}" + "\n");
                            }
                        }
                
                
                        Console.WriteLine(string.Format("{0}", s));
                    }
                    else
                    {
                        Console.WriteLine("No orders found");
                    }
                }
                else if (command.Contains("DeleteOrders"))
                {
                    string consumerName = string.Empty;
                    consumerName = command.Substring(13);
                    if (dictByConsum.ContainsKey(consumerName))
                    {
                        int count = dictByConsum[consumerName].Count;
                        dictByConsum.Remove(consumerName);
                        Console.WriteLine("{0} orders deleted", count);
                    }
                    else
                    {
                        Console.WriteLine("No orders found");
                    }
                }
                else if (command.Contains("FindOrdersByPriceRange"))
                {
                    string[] commandName = command.Split(' ');
                    string[] prices = commandName[1].Split(';');
                    decimal min = decimal.Parse(prices[0]);
                    decimal max = decimal.Parse(prices[1]);
                    StringBuilder priceSB = new StringBuilder();
                    int counter = 0;
                    string result = string.Empty;
                    foreach (KeyValuePair<decimal, Consumer> pair in setByPrice)
                    {
                        if (pair.Key >= min && pair.Key <= max)
                        {
                            priceSB.Append("{" + pair.Value + "}" + "\n");
                            counter++;
                        }
                    }
                    result = priceSB.ToString();
                    result = result.TrimEnd('\n');
                    if (counter == 0)
                    {
                        Console.WriteLine("No orders found");
                    }
                    else
                    {
                        Console.WriteLine(result);
                    }
                }
                else
                {
                    continue;
                }               
            }
        }
    }

    public class Consumer : IComparable<Consumer>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ConsumerName { get; set; }

        public int CompareTo(Consumer other)
        {
            int result = this.Name.CompareTo(other.Name);

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2:F2}", this.Name, this.ConsumerName, this.Price);
        }
    }
}
