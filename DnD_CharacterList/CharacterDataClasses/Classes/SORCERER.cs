using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class SORCERER : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {
              "Dragon Blood Heritage", "WildMagic", "Divine Soul", "Shadow Magic",
              "Storm Sorcery", "Aberrant Mind", "Clockwork Soul"
            };
            return (SubclassesTypes);
        }
    }
}
