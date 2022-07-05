using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class BARBARIAN : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {"Path Of The Berserk", "Path Of The Totem Warrior", "Path Of Paffin", "Path Of Guardian Ancestor",
            "Path Of Fanatic", "Path Of Raging In Battle", "Path Of Wild Magic", "Path Of Beast" };
            return (SubclassesTypes);
        }
    }

}
