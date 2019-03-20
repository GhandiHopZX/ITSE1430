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
            var character = new Character();
            var professions = new
            character.Name = _NameBox.Text;
            character.Profession = _ProfessionBox.; // like i said above
            character.Race = _RaceBox.Items;
            character.Intelligence = Intelligence.DataBindings;
            character.Strength = Strength.Value;
            character.Charisma = Charisma.Value;
            character.Agility = Agility.Value;
            character.Constitution = Constitution.Value;

            //Demoting constructor
            var character2 = new Character(/* add stuff here? */);

            return character;
        }

        // Loading the character
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
                errorProvider2.SetError(txb2, "");
        }

        private void ProfessionBox( object sender, CancelEventArgs e )
        {
            var txb3 = sender as ComboBox;

            if (txb3.SelectionLength == 0)
            {
                errorProvider3.SetError(txb3, "Profession needs to be selected.");
                //e.Cancel = false;
            } else
                errorProvider3.SetError(txb3, "");
        }

        private void OnAddButton( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;
            var character = SaveData();

            if (!character.Validate())
            {
                MessageBox.Show(this, "Character data is not valid.", "Error", MessageBoxButtons.OK);
                return;
            };

            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private class BindingList
        {
            public Character Character { get; set; }

            //pulling from the Character class

            public int NewId { get; set; }
            public string NewName { get; set; }
            public string[] NewRace { get; set; }
            public string[] NewP { get; set; }

            public void NewChar( Character character )
            {
                character.Name = NewName;
                character.characterID = NewId;
                character.Profession = NewP;
                character.Race = NewRace;
            }


        }
    }
}
