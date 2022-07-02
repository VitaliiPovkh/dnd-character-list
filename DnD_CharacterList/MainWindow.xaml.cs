using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using DnD_CharacterList.CharacterDataClasses;

namespace DnD_CharacterList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICharacterWindow
    {
        private string[] charRace;
        private string[] charClass;

        

        public Character CharacterData { get; set; }

        public MainWindow()
        {   
            InitializeComponent();

            RaceBox.SelectionChanged += RaceBox_SelectionChanged;
            ClassBox.SelectionChanged += ClassBox_SelectionChanged_1;
            XpBox.TextChanged += XpBox_TextChanged;

            charRace = new string[] 
            {
                "Human", "Elf", "Half-Elf", "Gnome", "Dwarf",
                "Dragonborn", "Changeling", "Ork", "Half-Ork",
                "Satyr", "Tabaxy", "Tiefling" 
            };

            charClass = new string[] 
            { 
                "Bard", "Barbarian", "Warrior", "Wizard", "Druid",
                "Priest","Inventor", "Warlock", "Monk", "Paladin", 
                "Dodger", "Pathfinder", "Corcerer"
            };

            

            CharacterData = new Character();
        }
       
        
        private void RaceBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void ClassBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }
       
        
        private void XpBox_TextChanged(object sender, RoutedEventArgs e) {
            int xpcount = 0;
            int.TryParse(XpBox.Text, out xpcount);

            CharacterData.Expirience = xpcount;
            CharacterData.RecalculateLevel();
            LevelCount.Content = CharacterData.Level; 
        }
        private void equipment_ButtonClick(object sender, RoutedEventArgs e)
        {   
            EquipmentWindow equipment = new EquipmentWindow();
            equipment.Show();
        }
        private void PersonalityButtonClick(object sender, RoutedEventArgs e)
        {
            PersonalityWindow personalityWindow = new PersonalityWindow(CharacterData);
            personalityWindow.Show();
        }
        private void StatsButtonClick(object sender, RoutedEventArgs e)
        {
            StatsWindow stats = new StatsWindow(CharacterData);
            stats.Show();
        }
        private void Ownership_ButtonClick(object sender, RoutedEventArgs e) 
        {
            OwnershipWindow ownership = new OwnershipWindow(CharacterData);
            ownership.Show();
        }
        private void Map_ButtonClick(object sender, RoutedEventArgs e)
        { 
            MapWindow map = new MapWindow(CharacterData);
            map.Show();
        }
        private void Note_ButtonClick(object sender, RoutedEventArgs e)
        {
            NoteWindow note = new NoteWindow(CharacterData);
            note.Show();
        }
        private void Inventory_ButtonClick(object sender, RoutedEventArgs e)
        {
            InventoryWindow inventory = new InventoryWindow(CharacterData);
            inventory.Show();
        }
        private void Spells_ButtonClick(object sender, RoutedEventArgs e)
        {
            SpellWindow spell = new SpellWindow(CharacterData);
            spell.Show();
        }
        private void Dices_ButtonClick(object sender, RoutedEventArgs e)
        {
            ThrowDicesWindow dicesWindow = new ThrowDicesWindow(CharacterData);
            dicesWindow.Show();
        }

    }
}