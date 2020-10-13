using Microsoft.VisualBasic;
using System;

namespace UnderstandingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "OldsMobile";
            myCar.Model = "Cutlass Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
            Console.ReadLine(); 
        }
        
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 159000; 
            else
                carValue = 2000;

            return carValue;
        }

    }
}
