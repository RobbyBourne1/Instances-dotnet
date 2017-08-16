using System;

namespace Inheritance_dotnet
{
    public class BaseballTeam : SportsTeam
    {
        
        public int HomeRuns { get; set; } = 0;
        public string MostValuablePlayer { get; set; } 

        public BaseballTeam(string MVP)
        {
            MostValuablePlayer = MVP;
        }

        public void Team()
        {
            var team = new BaseballTeam("Yadier Molina");

            team.Name = "St. Louis Cardinals";
            team.Sport = "Baseball";
            team.Colors = "Red and White";
            team.Championships = 11;
            Console.WriteLine(team);

            team = new BaseballTeam("Aaron Rodgers");
            team.Name = "Green Bay Packers";
            team.Sport = "FootBall";
            team.Colors = "Green and Gold";
            team.Championships = 4;
            Console.WriteLine(team);
        }
    }
}