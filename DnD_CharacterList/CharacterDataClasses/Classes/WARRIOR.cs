using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class WARRIOR : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {"Martial Arts Master", "Mystical Knight", "Champion", "Trooper",
            "Mystic Archer", "Samurai", "Purple Dragon Knight"};
            return (SubclassesTypes);
        }
    }
}
