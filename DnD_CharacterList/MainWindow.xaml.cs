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
        private double healthbar;
   
        public Character CharacterData { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            RaceBox.SelectionChanged += RaceBox_SelectionChanged;
            ClassBox.SelectionChanged += ClassBox_SelectionChanged_1;
            XpBox.TextChanged += XpBox_TextChanged;

            CharacterData = new Character();
            MaxHealth.Content = CharacterData.MaxHP;
            CurrentHealth.Text = CharacterData.CurrentHP.ToString();
        }


        private void DamageHealBar_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {    if (e.Key == System.Windows.Input.Key.Enter)
             {  CharacterData.HpDamageHeal(int.Parse(DamageHealBar.Text));
                CurrentHealth.Text = CharacterData.CurrentHP.ToString();
                healthbar = (double)CharacterData.CurrentHP / CharacterData.MaxHP * 100;
                HealthBar.Value = (int)healthbar;
                DamageHealBar.Text = "";
             }
        }
        private void DamageHealBar_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        private void RaceBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CharacterData.SetRace(RaceBox.SelectedIndex);
        }
        private void ClassBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            CharacterData.SetClass(ClassBox.SelectedIndex);
         
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
        private void SEXM_Checked(object sender, RoutedEventArgs e)
        {
            CharacterData.Sex = "Male";
        }
        private void SEXW_Checked(object sender, RoutedEventArgs e)
        {
            CharacterData.Sex = "Female";
        }
    }
}