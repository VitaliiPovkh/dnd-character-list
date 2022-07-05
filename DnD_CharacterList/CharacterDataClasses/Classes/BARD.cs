using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
   
    public class BARD : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubClassesTypes = {"School Of Knowless", "School Of Swords", "School Of Charm", "School Of Whispers",
            "School Of Oratory", "School Of Creation" };
            return (SubClassesTypes);
        }
    }

}
