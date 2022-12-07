using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_engine.Models
{
    public class Player
    { 
       public string? Name { get; set; }
       public string? CharacterClass { get; set; }
       public  int Hitponts { get; set; }
       public  int ExperiencePoints { get; set; }
       public  int Level { get; set; }
       public int Gold { get; set; }

    }    
}



