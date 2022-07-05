using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class WISARD : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {
            "School Of Incarnation", "School Of Conscription", "School Of Illusion", "School Of Necromancy",
           "School Of encing", "School Of Charm", "School Of Transformation",
            "School Of Divination", "School Of WarMagic", "School O fBladesong", "Chronomag", "Graviturge", "Order Of Scribes"
            };
            return (SubclassesTypes);
        }
    }
}
