using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes
{
    public enum WeaponType
    {

    }

    public class Weapon
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public List<Dice> DamageDices { get; private set; }
        public bool Hindrance { get; set; }
        public bool Advantage { get; set; }

        public Weapon()
        {
            DamageDices = new List<Dice>();
        }
    }
}
