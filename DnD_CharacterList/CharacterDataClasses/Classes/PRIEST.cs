using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class PRIEST : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {
            "Domain Of Storm", "Domain Of War", "Domain Of Life", "Domain Of Knowledge",
            "Domain Of Deceit", "Domain Of Nature", "Domain Of Light", "Domain Of Forge",
           "Domain Of Rest", "Domain Of Order", "Domain Of Death", "Domain Of Magic",
            "Domain Of Twilight", "Domain Of Peace"
            };
            return (SubclassesTypes);
        }
    }
}
