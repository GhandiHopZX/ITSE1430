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

        public int characterID { get; set; }
        public string[] Profession { get => _profession; set => _profession = value; }
        public string[] Race { get => _race; set => _race = value; }
        public string Name { get => _name; set => _name = value; }
        public int Strength { get => _strength; set => _strength = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Agility { get => _agility; set => _agility = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }
        public int Charisma { get => _charisma; set => _charisma = value; }

        public bool Validate()
        {
            //Name is needed
            if (String.IsNullOrEmpty(Name))
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

