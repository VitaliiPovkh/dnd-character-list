using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class DODGER : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {
               "Thief", "Assassin", "Mystic Trickster", "Duelist",
               "Schemer", "Scout", "Investigator", "Phantom", "Soulblade"
            };
            return (SubclassesTypes);
        }
    }
}
