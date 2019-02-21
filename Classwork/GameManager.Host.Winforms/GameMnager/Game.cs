using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    /// represents a game
    /// represents a game
    /// represents a game
    /// represents a game
    public class Game
    {
        public string dope
        {
            get { return dope = "dopeage" + Name; }
            set {
                string m = "";
                Name += m + dope;
            }
        }
        /// <summary>Name of the game.</summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }

        private string _name = "";

        /// <summary>Publisher of the game.</summary>
        public string Publisher
        {
            get { return _publisher ?? ""; }
            set { _publisher = value; }
        }
        private string _publisher = "";

        // a reference integer
        static int a
        {
            get { return a; }
            set { a = value; }
        }

        static int b( ref int a ) { return a; }

        //Calculated property
        public bool IsCoolGame
        {
            get { return Publisher != "EA"; }
        }

        //Setter only
        //public string Password
        //{
        //    set { }
        //}

        //Auto property
        public decimal Price { get; set; }

        //public decimal Price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}
        //private decimal _price;

        /// <summary>
        /// old method 
        /// </summary>
        //public bool Owned
        //{
        //    get { return _owned; }
        //    set { _owned = value; }
        //}
        //private bool _owned;

        //public bool Completed
        //{
        //    get { return _completed; }
        //    set { _completed = value; }
        //}
        //private bool _completed;

        ///auto Property type
        public bool Owned { get; set; } = true;

        public bool Completed { get; set; }

        //mixed accessibility
        public double Rate
        {
            get;
            internal set;
        }

        public void Foo()
        {
            //NOT DETERMINISTIC 
            // this should be a method
            var now = DateTime.Now;
        }

        //Can init the data as well
        //public string[] Genres { get; set; }

         // Don't use array properties because they are inefficient and require cloning.
        //public string[] Genres
        //{
        //    get {
        //        var temp = new string[_genres.Length];
        //        Array.Copy(_genres, temp, _genres.Length);
        //        return temp;
        //    }
        //}
        //private string[] _genres;

        //public string[] genres = new string[10];
        //private decimal realPrice = Price;

        /// <summary>Validates the object.</summary>
        /// <returns>true if valid or false otherwise.</returns>
        public bool Validate( /* Game this */ )
        {
            //Redundant dude
            //var str = this.Name;

            //Name is required
            if (String.IsNullOrEmpty(Name))
                return false;

            //Price >= 0
            if (Price < 0)
                return false;

            //Only if you need to pass the instance to somebody else
            //MyType.Foo(this);

            return true;
        }
    }
}
