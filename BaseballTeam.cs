using System;

namespace Inheritance_dotnet
{
    public class BaseballTeam : SportsTeam
    {
        
        public int HomeRuns { get; set; } = 0;
        public string MostValuablePlayer { get; set; } 
        public bool HasWonChampionship { get; set; } = false;

        public BaseballTeam()
        {

        }
    }
}