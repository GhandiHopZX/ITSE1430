using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharForm : Form
    {
        public CharForm()
        {
            InitializeComponent();
        }

        public Character Character { get; set; }

        private void NameBoxChanged( object sender, EventArgs e )
        {
        }

        private void NameBox( object sender, CancelEventArgs e )
        {
            var txb = sender as TextBox;

            if (txb.Text.Length == 0)
            {
                errorProvider1.SetError(txb, "This field needs a name.");
                //e.Cancel = true;
            } else
                errorProvider1.SetError(txb, "");
        }

        // turns the arrays needed to become the items for each box

        //public void ProfToArray( Character character, string[] source, ComboBox boxy )
        //{
        //    character.Profession = source;
        //    boxy.DataSource = source.ToList();
        //    return;
        //}

        //public void RaceToArray( Character character, string[] source, ComboBox boxy )
        //{
        //    character.Race = source;
        //    boxy.DataSource = source.ToList();
        //    return;
        //}

        private void LoadName( Character character )
        {
            //NewId = character.characterID;
            _NameBox.Text = character.Name;
            _ProfessionBox.DataSource = character.Profession; // double check these
            _RaceBox.DataSource = character.Race;
            Intelligence.Value = character.Intelligence;
            Strength.Value = character.Strength;
            Charisma.Value = character.Charisma;
            Agility.Value = character.Agility;
            Constitution.Value = character.Constitution;
        }

        private Character SaveData()
        {
            var character = new Character {
                Name = _NameBox.Text
            };
            //prof
            //character.Race = _RaceBox.Items;
            //character.Intelligence = Intelligence.DataBindings;
            //character.Strength = Strength.Value;
            //character.Charisma = Charisma.Value;
            //character.Agility = Agility.Value;
            //character.Constitution = Constitution.Value;

            //Demoting constructor
            var character2 = new Character(/* add stuff here? */);

            return character;
        }

        // Defined Override and change for any type that can change it
        protected virtual void CanBeChanged() { }

        // Override
        protected override void OnLoad( EventArgs e )
        {
            //this.OnLoad(e);
            base.OnLoad(e);

            //Init UI if editing a game
            if (Character != null)
                LoadName(Character);

            ValidateChildren();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RaceBox( object sender, CancelEventArgs e )
        {
            var txb2 = sender as ComboBox;

            if (txb2.SelectionLength == 0)
            {
                errorProvider2.SetError(txb2, "field needs to be selected.");
                //e.Cancel = false;
            } else
            { errorProvider2.SetError(txb2, ""); }

            var character = new Character();
            var source = character.Race;
            //ComboBox boxy = ProfessionBox;

            sender = source.ToList();
            txb2.DataSource = source;
        }

        private void ProfessionBox( object sender, CancelEventArgs e )
        {
            var txb3 = sender as ComboBox;

            if (txb3.SelectionLength == 0)
            {
                errorProvider3.SetError(txb3,
                    "Profession needs to be selected.");
                //e.Cancel = false;
            } else
            {
                errorProvider3.SetError(txb3, "");
            }

            var character = new Character();
            var source = character.Profession;
            //ComboBox boxy = ProfessionBox;

            sender = source.ToList();
            txb3.DataSource = source;
        }

        private void OnAddButton( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;
            var character = SaveData();

            if (!character.Validate())
            {
                MessageBox.Show(this, "Character data is not valid.",
                    "Error", MessageBoxButtons.OK);
                return;
            };

            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        ////pulling from the Character class

        //public int NewId { get; set; }
        //public string NewName { get; set; }
        //public string[] NewRace { get; set; }
        //public string[] NewP { get; set; }

        //public void NewChar( Character character )
        //{
        //    character.Name = NewName;
        //    character.characterID = NewId;
        //    character.Profession = NewP;
        //    character.Race = NewRace;
        //}

        //getting all the characters sent back to storage
        private int GetIndex( string name )
        {
            for (var index = 0; index < _items.Count; ++index)
                if (String.Compare(_items[index]?.Name, name, true) == 0)
                    return index;

            return -1;
        }

        // Ids
        private int GetIndex( int CharacterID )
        {
            for (var index = 0; index < _items.Count; ++index)
                if (_items[index]?.CharacterID == CharacterID)
                    return index;

            return -1;
        }

        private void FormCopyList( Character target, CharForm source )
        {

        }

        // Private readonly list for the set of characters
        private readonly List<Character> _items = new List<Character>();


    }
}
