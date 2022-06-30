using System.Windows;
using System.Windows.Controls;
using DnD_CharacterList.CharacterDataClasses;

namespace DnD_CharacterList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : CharacterWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            RaceBox.SelectionChanged += RaceBox_SelectionChanged;
            ClassBox.SelectionChanged += ClassBox_SelectionChanged_1;
            XpBox.TextChanged += XpBox_TextChanged;

            CharacterData = new Character();
        }

        private void RaceBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (RaceBox.SelectedIndex)
            {
                //Human
                case 0:
                    break;
                //Elf
                case 1:
                    break;
                //half-Elf
                case 2:
                    break;
                //Gnome
                case 3:
                    break;
                //Dwarf
                case 4:
                    break;
                //Dragonborn... FUS RO DAH!!!!!! 
                case 5:
                    break;
                //Changeling
                case 6:
                    break;
                //Ork
                case 7:
                    break;
                //Half-Ork
                case 8:
                    break;
                //Satyr
                case 9:
                    break;
                //Tabaxy
                case 10:
                    break;
                //Tiefling
                case 11:
                    break;
            }


        }

        private void ClassBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            switch (ClassBox.SelectedIndex)
            {
                //Bard
                case 0: 
                    break;
                //Barbarian
                case 1:
                    break;
                //Warrior
                case 2:
                    break;
                //Wolshebnik
                case 3:
                    break;
                //Druid
                case 4:
                    break;
                //Priest
                case 5:
                    break;
                //inventor
                case 6:
                    break;
                //Koldun
                case 7:
                    break;
                //Monk
                case 8:
                    break;
                //retro-paladin
                case 9:
                    break;
                //plut
                case 10:
                    break;
                //sledopyt
                case 11:
                    break;
                //Charodey
                case 12:
                    break;





            }
        }
       
        private void StatsButton_Click(object sender, RoutedEventArgs e)
        {
            StatsWindow stats = new StatsWindow(CharacterData);
            stats.Show();
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




    }
}