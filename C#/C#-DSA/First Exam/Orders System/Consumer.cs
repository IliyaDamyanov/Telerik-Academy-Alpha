//using System;
//
//namespace Orders_System
//{
//    public class Consumer : IComparable<Consumer>
//    {
//        public string Name { get; set; }
//
//        public decimal Price { get; set;}
//
//        public string ConsumerName { get; set; }
//
//        public int CompareTo(Consumer other)
//        {
//            int result = this.Name.CompareTo(other.Name);
//
//            return result;
//        }
//
//        public override string ToString()
//        {
//            return string.Format("{0};{1};{2:F2}", this.Name, this.ConsumerName, this.Price);
//        }
//    }
//}
