﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses.Classes
{
    public class WARLOCK : ClassesType
    {
        public override string[] Choose()
        {
            string[] SubclassesTypes = {
            "Archfea", "Fiend", "Great Ancient", "Immortal", "Witchblade", "Celestial", "Genius", "Abyssal"
            };
            return (SubclassesTypes);
        }
    }
}
