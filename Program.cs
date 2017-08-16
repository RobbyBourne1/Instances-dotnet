using System;

namespace Inheritance_dotnet
{
    class Program
    {
        public class Vehicle
        {
            public string Make { get; set; }
            public string YearMade { get; set; }
            public bool IsSUV { get; set; } = false;
            public DateTime DayLogged { get; set; } = DateTime.Now;
            public string OwnerName { get; set; }

            public Vehicle (string make, string yearMade)
            {
                Make = make;
                YearMade = yearMade;
            }

            public Boolean SUV(string owner)
            {
                IsSUV = true;
                OwnerName = owner;
                return IsSUV;
            }

            public override string ToString()
            {
                return $"{OwnerName} has bought a {YearMade}, {Make} and is not an SUV {IsSUV} on {DayLogged}";
            }
        }
        static void Main(string[] args)
        {
          
            var baseball = new BaseballTeam("Yadier Molina");

            baseball.Team();


            var car = new Vehicle("VolksWagen", "2012");
            car.SUV("Robby Bourne");

            Console.WriteLine(car);

        }
    }
}

