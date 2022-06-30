using System.Windows;
using DnD_CharacterList.CharacterDataClasses;


namespace DnD_CharacterList
{
    public abstract class CharacterWindow : Window
    {
        public Character CharacterData { get; protected set; }
    }
}
