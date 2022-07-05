using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes
{
    public class LightArmor : Armor
    {
        
        public LightArmor(ArmorType type) : base(type)
        {
            BaseStat = Stat.AGILITY;
        }
    }
}
