using DnD_CharacterList.CharacterDataClasses.EquipmentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses
{
    public class Equipment
    {
        public Armor? EquippedArmor { get; private set; }
        public Weapon[] EquippedWeapons { get; private set; }
        public List<OtherEquipment> EquippedItems { get; private set; }

        public Equipment()
        {
            EquippedArmor = null;
            EquippedWeapons = new Weapon[3];
            EquippedItems = new List<OtherEquipment>();
        }

        public void ChangeArmor(string typeName)
        {
            EquippedArmor = ArmorCreator.CreateArmor(typeName);
        }
    }

    

    

    
}
