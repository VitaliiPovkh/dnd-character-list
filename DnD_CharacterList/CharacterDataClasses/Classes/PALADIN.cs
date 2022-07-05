using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class PALADIN : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {
             "Path Of Allegiance", "Path Of Ancients", "Path Of Vengeance", "Path Of Redemption",
             "Path Of Subjugation", "Path Of Crown", "Path Of Glory", "Path Of Keepers", "Perjurer" };
            return (SubclassesTypes);
        }
    }
}
