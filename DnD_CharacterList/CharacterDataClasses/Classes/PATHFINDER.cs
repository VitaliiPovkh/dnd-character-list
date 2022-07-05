using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class PATHFINDER : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {
               "Hunter", "Beastmaster", "Horizon Walker", "Shadowhunter",
               "Monster Slayer", "Fairy Wanderer", "Swarm Keeper"
            };
            return (SubclassesTypes);
        }
    }
}
