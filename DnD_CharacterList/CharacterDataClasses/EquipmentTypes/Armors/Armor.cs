using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes.Armors
{
    

    public abstract class Armor
    {
        public string? Name { get; set; }
        public ArmorType Type { get; private set; }
        public int ArmorClass { get; set; }
        public Stat BaseStat { get; protected set; }
        public virtual int StatBonus { get; set; }
        public int ReqiredStrength { get; protected set; }
        public bool StealthHindrance { get; protected set; }

        protected Armor(ArmorType type)
        {
            Type = type;
            StealthHindrance = false;
        }
        
    }
}
