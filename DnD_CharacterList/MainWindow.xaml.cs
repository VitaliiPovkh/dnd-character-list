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
        private string[] CharRace;
        private string[] CharClass;
        public Character CharacterData { get; set; }
        public MainWindow()
        {   InitializeComponent();
            RaceBox.SelectionChanged += RaceBox_SelectionChanged;
            ClassBox.SelectionChanged += ClassBox_SelectionChanged_1;
            XpBox.TextChanged += XpBox_TextChanged;
            CharRace = new string[] {"Human","Elf","Half-Elf","Gnome","Dwarf","Dragonborn","Changeling",
            "Ork","Half-Ork","Satyr","Tabaxy","Tiefling" };
            CharClass = new string[] { "Bard", "Barbarian", "Warrior", "Wizard", "Druid", "Priest",
                "Inventor","Warlock", "Monk","Paladin","Dodger", "Pathfinder","Corcerer"};
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
            try{xpcount = int.Parse(XpBox.Text);} 
            catch {}
            
            switch (xpcount) 
            {
                case <300: LevelCount.Content = "1";
                    break;
                case < 900:
                    LevelCount.Content = "2";
                    break;
                case < 2700:
                    LevelCount.Content = "3";
                    break;
                case < 6500:
                    LevelCount.Content = "4";
                    break;
                case < 14000:
                    LevelCount.Content = "5";
                    break;
                case < 23000:
                    LevelCount.Content = "6";
                    break;
                case < 34000:
                    LevelCount.Content = "7";
                    break;
                case < 48000:
                    LevelCount.Content = "8";
                    break;
                case < 64000:
                    LevelCount.Content = "9";
                    break;
                case < 85000:
                    LevelCount.Content = "10";
                    break;
                case < 100000:
                    LevelCount.Content = "11";
                    break;
                case < 120000:
                    LevelCount.Content = "12";
                    break;
                case < 140000:
                    LevelCount.Content = "13";
                    break;
                case < 165000:
                    LevelCount.Content = "14";
                    break;
                case < 195000:
                    LevelCount.Content = "15";
                    break;
                case < 225000:
                    LevelCount.Content = "16";
                    break;
                case < 265000:
                    LevelCount.Content = "17";
                    break;
                case < 305000:
                    LevelCount.Content = "18";
                    break;
                case < 355000:
                    LevelCount.Content = "19";
                    break;
                case >=355000:
                    LevelCount.Content = "20";
                    break;

            }



        }
        private void equipment_ButtonClick(object sender, RoutedEventArgs e)
        {
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