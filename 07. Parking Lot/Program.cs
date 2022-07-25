using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmd = input.Split(", ");
                switch (cmd[0])
                {
                    case "IN":
                        parking.Add(cmd[1]);
                        break;
                    case "OUT":
                        parking.Remove(cmd[1]);
                        break;
                }
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }
        }
    }
}
