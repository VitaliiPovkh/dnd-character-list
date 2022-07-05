using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class DRUID : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {
            "Circle Of Earth", "Circle Of Moon", "Circle Of Shepherd", "Circle Of Dreams", "Circle Of Disputes",
            "Circle Of Stars", "Circle Of Wild Fire"
            };
            return (SubclassesTypes);
        }
    }
}
