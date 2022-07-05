using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class INVENTOR : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {
            "Alchemist", "Aritlerist", "Warsmith", "Armorsmith"
            };
            return (SubclassesTypes);
        }
    }
}
