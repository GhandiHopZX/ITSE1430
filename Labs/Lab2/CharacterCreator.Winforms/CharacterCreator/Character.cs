using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        //values for the character attributes

        private string _name = "";

        // Races and Professions based on Legend of Mana, Secret (of Mana) Series.
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

        public int characterID;
        public string[] Profession { get => _profession; set => _profession = value; }
        public string[] Race { get => _race; set => _race = value; }
        public string Name { get => _name; set => _name = value; }

        //Constructor
        public Character(Character character)
        {
            
        }

    }
}

