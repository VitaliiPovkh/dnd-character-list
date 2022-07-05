using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes
{
    public class MediumArmor : Armor
    {
        public MediumArmor(ArmorType type) : base(type)
        {
            BaseStat = Stat.AGILITY;
        }
    }
}
