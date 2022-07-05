using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes.Armors
{
    public class LightArmor : Armor
    {
        
        public LightArmor(ArmorType type) : base(type)
        {
            BaseStat = Stat.AGILITY;
            if (Type == ArmorType.PADDED)
            {
                StealthHindrance = true;
            }
        }
    }
}
