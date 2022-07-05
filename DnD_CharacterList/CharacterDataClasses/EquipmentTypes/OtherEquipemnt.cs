using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes
{
    public class OtherEquipment
    {
        public string? Name { get; set; }
        public int ArmorClass { get; set; }
        public string? Effect { get; set; }
        public Dice DamageDice { get; private set; }

        public OtherEquipment()
        {
            DamageDice = Dice.EIGHT;
        }
    }
}
