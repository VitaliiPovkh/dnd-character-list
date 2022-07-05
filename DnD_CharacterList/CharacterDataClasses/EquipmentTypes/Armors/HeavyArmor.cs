using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes.Armors
{
    public class HeavyArmor : Armor
    {
        public HeavyArmor(ArmorType type) : base(type)
        {
            BaseStat = Stat.STRENGTH;
            StealthHindrance = true;
            switch (Type)
            {
                case ArmorType.CHAIN_MAIL:
                    ReqiredStrength = 13;
                    break;
                case ArmorType.SPLINT:
                case ArmorType.PLATE:
                    ReqiredStrength = 15;
                    break;
                default:
                    ReqiredStrength = 0;
                    break;

            }
        }
    }
}
