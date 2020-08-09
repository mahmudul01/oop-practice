using System;
using System.Collections.Generic;
using System.Text;

namespace Elevator
{
    public class Elevator
    {
        private int MaximumNumber = 8;
        public bool IsOpeded { get; private set; } = false;
        public int TotalPersons { get; private set; }

        public void Open()
        {
            if (IsOpeded == true)
            {
                throw new InvalidOperationException("Lift is already opened.");
            }

            Console.WriteLine("Opening the door.");

            IsOpeded = true;
        }
        public void Enter(int number)
        {

            if (!IsOpeded)
            {
                throw new InvalidOperationException("Lift is closed.");
            }

            if ((TotalPersons + number) > MaximumNumber)
            {
                throw new InvalidOperationException("Overloaded.");
            }

            TotalPersons = TotalPersons + number;

            Console.WriteLine($"Entering person in the lift: { number}");
            Console.WriteLine($"Total person in the lift: {TotalPersons}");
        }
        public void Close()
        {
            //if (!isOpeded)
            if (IsOpeded == false)
            {
                throw new InvalidOperationException("Lift is already closed.");
            }
            Console.WriteLine("Closing the door.");
            IsOpeded = false;
        }
        public void Exit(int number)
        {
            if (IsOpeded == false)
            {
                Console.WriteLine("Lift is already closed.");
            }
            TotalPersons = TotalPersons - number;
            Console.WriteLine($"Exiting peorson:{number}");
            Console.WriteLine($"Total person in the lift:  {TotalPersons}");
            IsOpeded = true;
        }
        public void Emergency()
        {
            Console.WriteLine("=============");
            Console.WriteLine("Emergecy call");
            Open();
            Exit(TotalPersons);
            Close();
        }
    }
}
