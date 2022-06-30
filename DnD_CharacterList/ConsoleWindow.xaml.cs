using DnD_CharacterList.CharacterDataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DnD_CharacterList
{
    /// <summary>
    /// Логика взаимодействия для ConsoleWindow.xaml
    /// </summary>
    public partial class ConsoleWindow : CharacterWindow
    {
        public ConsoleWindow(Character character)
        {
            InitializeComponent();
            CharacterData = character;
        }
    }
}
