//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Wintellect.PowerCollections;
//
//namespace Orders_System
//{
//    class Orders
//    {
//        public static void Run()
//        {
//            Dictionary<string, OrderedSet<Consumer>> dictByConsum = new Dictionary<string, OrderedSet<Consumer>>();
//            SortedList<int, Consumer> setByPrice = new SortedList<int, Consumer>();
//            int N = int.Parse(Console.ReadLine());
//
//            for (int i = 0; i < N; i++)
//            {
//                string command = Console.ReadLine();
//                string[] commandName = command.Split(' ');
//                switch (commandName[0])
//                {
//                    case "AddOrder":
//                        StringBuilder name = new StringBuilder();
//                        string[] commandParams = commandName[commandName.Length - 1].Split(';');
//                        for (int j = 1; j < commandName.Length - 1; j++)
//                        {
//                            name.Append(commandName[j] + " ");
//                        }
//                        name.Append(commandParams[0]);
//                        decimal price = decimal.Parse(commandParams[1]);
//                        string consumer = commandParams[2];
//
//                        Consumer cons = new Consumer();
//                        cons.Name = name.ToString();
//                        cons.Price = price;
//                        cons.ConsumerName = consumer;
//
//                        if (!dictByConsum.ContainsKey(consumer))
//                        {
//                            dictByConsum.Add(consumer, new OrderedSet<Consumer>());
//                            dictByConsum[cons.ConsumerName].Add(cons);
//                        }
//                        else
//                        {
//                            dictByConsum[consumer].Add(cons);
//                        }
//
//                        setByPrice.Add(cons);
//
//                        Console.WriteLine("Order added");
//                        break;
//                    case "FindOrdersByConsumer":
//                        string consumerName = commandName[1];
//                        if (dictByConsum.ContainsKey(consumerName))
//                        {
//                            StringBuilder s = new StringBuilder();
//                            var consum = dictByConsum[consumerName];
//                            for (int l = 0; l < consum.Count; l++)
//                            {
//                                if (l == consum.Count - 1)
//                                {
//                                    s.Append("{" + consum[l] + "}");
//                                }
//                                else
//                                {
//                                    s.Append("{" + consum[l] + "}" + "\n");
//                                }
//                            }
//
//
//                            Console.WriteLine(string.Format("{0}",s));
//                        }
//                        else
//                        {
//                            Console.WriteLine("No orders found");
//                        }
//                        break;
//                    case "DeleteOrders":
//                        consumerName = commandName[1];
//                        if (dictByConsum.ContainsKey(consumerName))
//                        {
//                            int count = dictByConsum[consumerName].Count;
//                            dictByConsum.Remove(consumerName);
//                            Console.WriteLine("{0} orders deleted",count);
//                        }
//                        else
//                        {
//                            Console.WriteLine("No orders found");
//                        }                       
//                        break;
//                    case "FindOrdersByPriceRange":
//                        string[] prices = commandName[1].Split(';');
//                        long min = long.Parse(prices[0]);
//                        long max = long.Parse(prices[1]);
//                        var listByPrices = setByPrice.
//                        break;
//                    //case "ranklist":
//                    //    int start = int.Parse(commandParams[1]) - 1;
//                    //    int end = int.Parse(commandParams[2]) - 1;
//                    //    int count = end - start + 1;
//                    //    var rankedPlayers = playersRanklist.Range(start, count);
//                    //
//                    //    int playerPosition = start + 1;
//                    //    string rankingResult = string.Join("; ",
//                    //        rankedPlayers.Select(p => string.Format("{0}. {1}", playerPosition++, p.ToString())));
//                    //
//                    //    rankingResult.TrimEnd(';', ' ');
//                    //
//                    //    Console.WriteLine(rankingResult);
//                    //    break;
//                }
//            }
//        }
//    }
//}
//