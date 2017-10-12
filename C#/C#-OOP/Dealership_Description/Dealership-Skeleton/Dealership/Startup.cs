using Dealership.Engine;
using Dealership.Models;
using System;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            DealershipEngine.Instance.Start();
        }
    }
}
