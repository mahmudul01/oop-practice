using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lift = new Elevator();
            lift.Open();

            lift.Enter(4);
            lift.Close();

            lift.Open();
            lift.Exit(2);
            lift.Close();
            lift.Emergency();

            Console.WriteLine($"Total person in the lift: {lift.TotalPersons}");
            var doorStatus = lift.IsOpeded ? "Open" : "Closed";
            Console.WriteLine($"Door Status: {doorStatus}");
        }
    }
}
