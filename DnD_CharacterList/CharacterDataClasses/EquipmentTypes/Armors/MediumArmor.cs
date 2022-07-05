using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes.Armors
{
    public class MediumArmor : Armor
    {
        private int statBonus;
        public override int StatBonus 
        { 
            get { return statBonus; }
            set 
            {
                if (value > 2)
                {
                    statBonus = 2;
                }
                else
                {
                    statBonus = 2;
                }
            }
        }
        public MediumArmor(ArmorType type) : base(type)
        {
            BaseStat = Stat.AGILITY;
            if (Type == ArmorType.SCALE_MAIL || Type == ArmorType.HALF_PLATE)
            {
                StealthHindrance = true;
            }
        }
    }
}
