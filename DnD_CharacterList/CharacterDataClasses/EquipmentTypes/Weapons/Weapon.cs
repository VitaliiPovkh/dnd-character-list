using System.Collections.Generic;


namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes.Weapons
{

    public enum DamageType
    {
        PIERCING,
        SLASHING,
        BLUDGEONING,
        ACID,
        COLD,
        FIRE,
        FORCE,
        LIGHTNING,
        NECROTIC,
        POISON,
        PSYCHIC,
        RADIANT,
        THUNDER
    }

    public enum WeaponMaterial
    {
        STANDART,
        SILVER,
        ADAMANT
    }

    public enum HandsRequirement
    {
        ONEHANDED,
        DOUBLEHANDED,
        UNIVERSAL
    }

    public enum WeaponSize
    {
        SMALL,
        AVARAGE,
        LARGE
    }

    public class Weapon
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public List<Dice> DamageDices { get; private set; }
        public bool Hindrance { get; set; }
        public bool Advantage { get; set; }
        public DamageType DamageType { get; set; }
        public WeaponMaterial WeaponMaterial { get; set; }
        public HandsRequirement HandsRequirement { get; set; }
        public WeaponSize WeaponSize { get; set; }


        public Weapon()
        {
            DamageDices = new List<Dice>();
        }
    }
}
