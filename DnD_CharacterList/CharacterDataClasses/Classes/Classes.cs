using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public abstract class ClassesType
    {
        public abstract string[] Choose();
        public string[] SubClassesTypes;
    }

    public class ClassChoose 
    {
        

        public string[] Choose(String ClassT)
        {
            
            switch (ClassT)
            {
                case "BARD":
                    {
                        BARD SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "BARBARIAN":
                    {
                        BARBARIAN SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "WARRIOR":
                    {
                        WARRIOR SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "WISARD":
                    {
                        WISARD SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "DRUID":
                    {
                        DRUID SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "PRIEST":
                    {
                        PRIEST SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "INVENTOR":
                    {
                        INVENTOR SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "WARLOCK":
                    {
                        WARLOCK SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "MONK":
                    {
                        MONK SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "PALADIN":
                    {
                        PALADIN SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "DODGER":
                    {
                        DODGER SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "PATHFINDER":
                    {
                        PATHFINDER SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }
                case "SORCERER":
                    {
                        SORCERER SubType = new();
                        string[] subsnums = SubType.Choose();
                        return (subsnums);
                    }

                default: return (new string[1]);
            }

        }
       
    }
}
