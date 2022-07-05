using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace DnD_CharacterList.CharacterDataClasses.EquipmentTypes
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

    public static class ArmorCreator
    {
        private static ReadOnlyDictionary<string, ArmorType> TypeNames { get; set; }


        static ArmorCreator()
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

        public static Armor? CreateArmor(string name)
        {
            TypeNames.TryGetValue(name, out ArmorType type);
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
            return armor;
        }
    }
}
