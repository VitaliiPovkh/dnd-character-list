using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes
{
    

    public abstract class Armor
    {
        public string? Name { get; set; }
        public ArmorType Type { get; private set; }
        public int ArmorClass { get; set; }
        public Stat BaseStat { get; protected set; }

        protected Armor(ArmorType type)
        {
            Type = type;
        }
        
    }
}
