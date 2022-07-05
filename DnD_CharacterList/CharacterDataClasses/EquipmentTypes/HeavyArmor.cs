using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes
{
    public class HeavyArmor : Armor
    {
        public HeavyArmor(ArmorType type) : base(type)
        {
            BaseStat = Stat.NO_STAT;
        }
    }
}
