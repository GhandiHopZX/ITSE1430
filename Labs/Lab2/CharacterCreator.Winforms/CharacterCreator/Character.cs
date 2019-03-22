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

        private string Swordsman = "Swordsman";
        private string Knight = "Knight";
        private string Paladin = "Paladin";
        private string Rouge = "Rouge";
        private string Wizard = "Wizard";

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

        public string Name { get => _name; set => _name = value; }

        public string Swordsman1 { get => Swordsman; set => Swordsman = value; }
        public string Knight1 { get => Knight; set => Knight = value; }
        public string Paladin1 { get => Paladin; set => Paladin = value; }
        public string Rouge1 { get => Rouge; set => Rouge = value; }
        public string Wizard1 { get => Wizard; set => Wizard = value; }
       

        public int Strength { get => _strength; set => _strength = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Agility { get => _agility; set => _agility = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }
        public int Charisma { get => _charisma; set => _charisma = value; }

        public static int Min => _min;

        public static int Max => _max;

        public string[] Race { get => _race; set => _race = value; }

        public bool Validate()
        {
            //Name is needed
            if (String.IsNullOrEmpty(_name))
                return false;

            if (_strength < _min)
                return false;

            if (_intelligence < _max)
                return false;

            if (_agility < _min)
                return false;

            if (_constitution < _min)
                return false;

            if (_charisma < _min)
                return false;

            if (_strength > _max)
                return false;

            if (_intelligence > _max)
                return false;

            if (_agility > _max)
                return false;

            if (_constitution > _max)
                return false;

            if (_charisma > _max)
                return false;

            return true;
        }
        
    }
}

