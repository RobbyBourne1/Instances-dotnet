using System;

namespace Inheritance_dotnet
{
    public abstract class SportsTeam 
        {
            public string Sport { get; set; }
            public string Colors { get; set; }
            public int Championships { get; set; } = 0;
            public string Name { get; set; }

            public override string ToString()
            {
                return $"My favorite {Sport} team is {Name} and their colors are {Colors} and they have won {Championships} championships.";
            }
        }    
}