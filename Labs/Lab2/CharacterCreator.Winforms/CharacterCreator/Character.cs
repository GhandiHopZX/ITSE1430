﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        //values for the character attributes

        private string _name;

        private string[] _profession = 
            { "Swordsman", "Knight", "Paladin", "Rouge", "Wizard" };
        private string[] _race = 
            { "Demi Human", "Faerie", "Siren", "Jumi", "Beastman", "Dragoon", "Human" };

        //stats//
        private int _strength;
        private int _intelligence;
        private int _agility;
        private int _constitution;
        private int _charisma;

        const int _min = 0;
        const int _max = 100;
    }
}
