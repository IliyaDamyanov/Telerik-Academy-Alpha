//using System;
//
//namespace Player_Ranking
//{
//    public class Player : IComparable<Player>
//    {
//        public string Name { get; set; }
//
//        public string Type { get; set; }
//
//        public int Age { get; set; }
//
//        public int CompareTo(Player other)
//        {
//            int result = this.Name.CompareTo(other.Name);
//            if (result == 0)
//            {
//                result = this.Age.CompareTo(other.Age) * -1;
//                // This also works
//                // result = other.Age.CompareTo(this.Age)
//            }
//
//            return result;
//        }
//
//        public override string ToString()
//        {
//            return string.Format("{0}({1})", this.Name, this.Age);
//        }
//    }
//}
