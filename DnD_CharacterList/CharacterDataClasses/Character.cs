using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses
{
    public enum Race
    {
        HUMAN, ELF, HALF_ELF, GNOME, DWARF,
        DRAGONBORN, CHANGELING, ORC, HALF_ORC,
        SATYR, TABAXI, TIEFLING 
    }

    public enum Class
    {
        BARD, BARBARIAN, WARRIOR, WIZARD, DRUID,
        PRIEST, INVENTOR, WARLOCK, MONK, PALADIN, 
        DODGER, PATHFINDER, SORCERER
    }

    public class Character
    {
        /*
         * TODO:
         * Relocate non-input data calculations from form classes to character classes
         * Example: level calculations, depending from expirience value
         * or
         * ArmorClass, depending from character`s equipment
         */
        private int currentHP;

        public string? Name { get; set; }
        public string? Race { get; set; } // Enum ??
        public string? Class { get; set; } // Enum ??
        public string? Sex { get; set; }
        public int MaxHP { get; private set; }
        public int CurrentHP
        {
            get { return currentHP; }
            set 
            {
                if (value > MaxHP)
                {
                    currentHP = MaxHP;
                }
                else
                {
                    currentHP = value;
                }
            }
        }
        public int Expirience { get; set; }
        public int Level { get; private set; }
        public int ArmourClass { get; private set; } //?
        public int Initiative { get; set;}
        public bool[] LifeThrows { get; private set; }
        public bool[] DeathThrows { get; private set; }
        public Personality CharactersPersonality { get; private set; }
        public Equipment CharactersEquipment { get; private set; }
        public Inventory CharactersInventory { get; private set; }
        public Stats CharactersStats { get; private set; }
        public Ownership CharactersOwnership { get; private set; }
        public Notes CharactersNotes { get; private set; }
        public Spells CharactersSpells { get; private set; }


        private readonly List<int> expirienceMilestones;

        public Character()
        {
            MaxHP = 28; //temp
           CurrentHP = MaxHP;//temp

            LifeThrows = new bool[3];
            DeathThrows = new bool[3];

            CharactersPersonality = new Personality();
            CharactersEquipment = new Equipment();
            CharactersInventory = new Inventory();
            CharactersStats = new Stats();
            CharactersOwnership = new Ownership();
            CharactersNotes = new Notes();
            CharactersSpells = new Spells();

            expirienceMilestones = new List<int>()
            {
                300, 900, 2700, 6500, 14000, 23000,
                34000, 48000, 64000, 85000, 100000,
                120000, 140000, 165000, 195000, 225000,
                265000, 305000, 355000
            };
        }
        
        public void RecalculateLevel()
        {
            int biggerMilestone = expirienceMilestones.Find(x =>
            {
                int lastMilestone = expirienceMilestones[expirienceMilestones.Count - 1];
                return Expirience < x || (x == lastMilestone && Expirience >= lastMilestone);
            });

            int level = expirienceMilestones.IndexOf(biggerMilestone) + 1;
            if (Expirience >= expirienceMilestones[level - 1])
            {
                level++;
            }
            Level = level;
        }
        public void HpDamageHeal(int value)
        {
            try
            {
               CurrentHP = CurrentHP + value;
                if (CurrentHP < 0) { CurrentHP = 0;}
                if (CurrentHP > MaxHP) { CurrentHP = MaxHP; }
                
            }
            catch { }

        }
    }
}
