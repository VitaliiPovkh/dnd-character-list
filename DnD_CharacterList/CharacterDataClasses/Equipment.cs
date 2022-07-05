using DnD_CharacterList.CharacterDataClasses.EquipmentTypes;
using DnD_CharacterList.CharacterDataClasses.EquipmentTypes.Armors;
using DnD_CharacterList.CharacterDataClasses.EquipmentTypes.Weapons;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace DnD_CharacterList.CharacterDataClasses
{
    public enum ArmorType
    {
        PADDED,
        LEATHER,
        STUDDED_LEATHER,
        HIDE,
        CHAIN_SHIRT,
        SCALE_MAIL,
        BREASTPLATE,
        HALF_PLATE,
        RING_MAIL,
        CHAIN_MAIL,
        SPLINT,
        PLATE
    }

    public class Equipment
    {
        public Armor? EquippedArmor { get; private set; }
        public Weapon[] EquippedWeapons { get; private set; }
        public List<OtherEquipment> EquippedItems { get; private set; }

        private static ReadOnlyDictionary<string, ArmorType> TypeNames { get; set; }

        public Equipment()
        {
            EquippedArmor = null;
            EquippedWeapons = new Weapon[3];
            EquippedItems = new List<OtherEquipment>();       
        }

        static Equipment()
        {
            TypeNames = new ReadOnlyDictionary<string, ArmorType>(new Dictionary<string, ArmorType>()
            {
                { "Стеганый" , ArmorType.PADDED },
                { "Кожаный" , ArmorType.LEATHER },
                { "Проклёпанный кожаный" , ArmorType.STUDDED_LEATHER },
                { "Шкурный" , ArmorType.HIDE },
                { "Кольчужная рубаха" , ArmorType.CHAIN_SHIRT },
                { "Чешуйчатый" , ArmorType.SCALE_MAIL },
                { "Кираса" , ArmorType.BREASTPLATE },
                { "Полулаты" , ArmorType.HALF_PLATE },
                { "Колечный" , ArmorType.RING_MAIL },
                { "Кольчужный" , ArmorType.CHAIN_MAIL },
                { "Наборный" , ArmorType.SPLINT },
                { "Латы" , ArmorType.PLATE }
            });
        }

        public void ChangeArmor(string typeName)
        {
            TypeNames.TryGetValue(typeName, out ArmorType type);
            Armor? armor = null;
            switch (type)
            {
                case ArmorType.PADDED:
                case ArmorType.LEATHER:
                case ArmorType.STUDDED_LEATHER:
                    armor = new LightArmor(type);
                    break;
                case ArmorType.HIDE:
                case ArmorType.CHAIN_SHIRT:
                case ArmorType.SCALE_MAIL:
                case ArmorType.BREASTPLATE:
                case ArmorType.HALF_PLATE:
                    armor = new MediumArmor(type);
                    break;
                case ArmorType.RING_MAIL:
                case ArmorType.CHAIN_MAIL:
                case ArmorType.SPLINT:
                case ArmorType.PLATE:
                    armor = new HeavyArmor(type);
                    break;
                default:
                    break;
            }
            EquippedArmor = armor;
        }

        public static string[] GetArmorNames()
        {
            string[] names = new string[TypeNames.Count];
            TypeNames.Keys.CopyTo(names, 0);
            return names;
        }
    }

    

    

    
}
