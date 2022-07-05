using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class MONK : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {
             "Path Of The OpenHand", "Shadow", "Four Elements", "Kensei", "Drunken Master", "Long Death", "Solar Soul",
             "Mercy", "Astral Body" };
            return (SubclassesTypes);
        }
    }
}
