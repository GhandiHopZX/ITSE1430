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
      
        private string _name { get; set; }
        string[] _profession;
        string[] _race;
        //stats//
        private int _strength { get; set; }
        private int _intelligence { get; set; }
        private int _agility { get; set; }
        private int _constitution { get; set; }
        private int _charisma { get; set; }

        public int min { get; set; }
        public int max { get; set; }
    }
}
