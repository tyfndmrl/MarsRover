using MarsRover.Core;
using MarsRover.Core.Entities;
using MarsRover.Core.Entities.Enums;
using MarsRover.Core.Interfaces;
using System;
using System.Text;

namespace MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteCaseOutput();
            var place = new Place(5,5);
            IRover rover = new Rover(place, new Position(1,2), Direction.N);
            rover.Process("LMLMLMLMM");

            Console.WriteLine(rover.ToString());

            rover.SetPosition(new Position(3, 3), Direction.E);
            rover.Process("MMRMMRMRRM");

            Console.WriteLine(rover.ToString());

            Console.ReadLine();
        }

        public static void WriteCaseOutput()
        {
            Console.WriteLine("Test Input:");
            Console.WriteLine(CreateCaseInput());
            Console.WriteLine();
            Console.WriteLine("Expected Output:");

            string CreateCaseInput()
            {
                var sBuilder = new StringBuilder();
                sBuilder.AppendLine("5 5");
                sBuilder.AppendLine("1 2 N");
                sBuilder.AppendLine("LMLMLMLMM");
                sBuilder.AppendLine("3 3 E");
                sBuilder.Append("MMRMMRMRRM");
                return sBuilder.ToString();
            }
        }
    }
}
