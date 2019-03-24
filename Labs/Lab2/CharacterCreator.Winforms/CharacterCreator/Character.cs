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

        //Races and Professions based on Legend of Mana, Secret (of Mana) Series.
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

        public int CharacterID { get; set; }

        public string[] Profession { get => _profession; set => _profession = value; }
        public string Swordsman { get => _profession.ElementAt(0); }
        public string Knight { get => _profession.ElementAt(1); }
        public string Paladin { get => _profession.ElementAt(2); }
        public string Rouge { get => _profession.ElementAt(3); }
        public string Wizard { get => _profession.ElementAt(4); }

        public string[] Race { get => _race; set => _race = value; }
        public string Demi_Human { get => _race.ElementAt(0); }
        public string Faerie { get => _race.ElementAt(1); }
        public string Siren { get => _race.ElementAt(2); }
        public string Jumi { get => _race.ElementAt(3); }
        public string Beastman { get => _race.ElementAt(4); }
        public string Dragoon { get => _race.ElementAt(5); }
        public string Human { get => _race.ElementAt(6); }

        public string Name { get => _name; set => _name = value; }
        public int Strength { get => _strength; set => _strength = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Agility { get => _agility; set => _agility = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }
        public int Charisma { get => _charisma; set => _charisma = value; }
        

        public bool Validate()
        {
            var items = new List<ValidationResult>();

            //Name is required
            if (String.IsNullOrEmpty(Name))
                items.Add(new ValidationResult("Name is required.", new[] { nameof(Name) }));


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

