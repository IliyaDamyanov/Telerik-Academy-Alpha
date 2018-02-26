using Dealership.Engine;
using Dealership.Models;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            //DealershipEngine.Instance.Start();
            Comment comment = new Comment("test") { Author = "Ivan" };
            Comment comment2 = new Comment("test2") { Author = "Pesho" };

            Truck truck = new Truck("Truck", "Focus", 2000, 4);
            Car car = new Car("Ford", "Focus", 1000, 4);
            car.Comments.Add(comment);
            car.Comments.Add(comment2);

            User user = new User("test", "asdasdasd", "asdasd", "adsasdasd", Common.Enums.Role.Normal);
            user.AddVehicle(truck);
            user.AddVehicle(car);
            System.Console.WriteLine(user.PrintVehicles());
        }
    }
}
