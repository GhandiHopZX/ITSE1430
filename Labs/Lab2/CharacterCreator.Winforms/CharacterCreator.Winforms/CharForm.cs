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
        public string[] copu2 = { };
        new int CStrNumeric = 0;
        new int CIntNumeric = 0;
        new int CChaNumeric = 0;
        new int CAgiNumeric = 0;
        new int CConNumeric = 0; //check if zeroed out...

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
        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var character = SaveData();

            ////Validate at business level using IValidatableObject
            //try
            //{
            //    new ObjectValidator().Validate(character);
            //} catch (ValidationException)
            //{
            //    MessageBox.Show(this, "Game not valid.", "Error", MessageBoxButtons.OK);
            //    return;
            //};
            //if (!game.Validate())
            //{
            //    MessageBox.Show(this, "Game not valid.", "Error", MessageBoxButtons.OK);
            //    return;
            //};

            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadName( Character character )
        {
            //NewId = character.characterID; // Come back to this one?
            NameBox2.Text = Name;
            //ProfessionBox1.SelectedItem = character.Profession; // done
            //RaceBox2.SelectedItem = character.Race;
            IntNumeric.Value = character.Intelligence;
            StrNumeric.Value = character.Strength;
            ChaNumeric.Value = character.Charisma;
            AgiNumeric.Value = character.Agility;
            ConNumeric.Value = character.Constitution;
        }

        public void Numerics( NumericUpDown numeric )
        {

        }
        
        private Character SaveData()
        { 
            var character = new Character();
            Name = NameBox2.Text;
            //prof look up
            //race
            character.Intelligence = CIntNumeric;
            character.Strength = CStrNumeric;
            character.Charisma = CChaNumeric;
            character.Agility = CAgiNumeric;
            character.Constitution = CConNumeric;

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
        
        // Private readonly list for the set of characters
        private readonly List<Character> _items = new List<Character>();

        // Loading Items
        private void LoadProfessions(Character[] items)
        {
            
        }

        private void Cancel( object sender, EventArgs e )
        {
            Close();
        }
        
        private void NameBox2_Validating( object sender, CancelEventArgs e )
        {
            var txb = sender as TextBox;

            if (txb.Text.Length == 0)
            {
                errorProvider1.SetError(txb, "This field needs a name.");
                //e.Cancel = true;
            } else
                errorProvider1.SetError(txb, "");
        }

        private void RaceBox2_Validating( object sender, CancelEventArgs e )
        {
            var txb2 = sender as ComboBox;
            
            var character = new Character();
            var source = character.Race;

            sender = source;
            txb2.DataSource = source;

        }

        private void ProfessionBox1_Validating( object sender, CancelEventArgs e )
        {
            var txb3 = sender as ComboBox;
            
            //if (txb3.SelectionLength == 0)
            //{
            //    errorProvider3.SetError(txb3,
            //        "Profession needs to be selected.");

            //} else
            //{
            //    errorProvider3.SetError(txb3, "");
            //    e.Cancel = true;
            //}


            var character = new Character();
            var source = character.Profession;
            

            sender = source;
            txb3.DataSource = source;
        }

        private void ProfessionBox1_Validated( object sender, EventArgs e )
        {
            //var nwk = ProfessionBox1.SelectedItem.ToString();

            //ProfessionBox1.DisplayMember = nwk;
            
        }

        private void RaceBox2_Validated( object sender, EventArgs e )
        {
            //var nwk = RaceBox2.SelectedItem.ToString();

            //RaceBox2.DisplayMember = nwk;
        }

        // lists for combobox
        List<string> comboList = new List<string>();
        List<string> comboListR = new List<string>();

        private void profList()
        {
            var profin = new Character();

            //ProfessionBox1.Items.Add(Character.Profession);
            comboList.Add(profin.Swordsman);
            comboList.Add(profin.Knight);
            comboList.Add(profin.Paladin);
            comboList.Add(profin.Rouge);
            comboList.Add(profin.Wizard);
        }

        private void raceList()
        {
            var racein = new Character();

            //RaceBox2.Items.Add(Character.Race);
            comboListR.Add(racein.Faerie);
            comboListR.Add(racein.Demi_Human);
            comboListR.Add(racein.Siren);
            comboListR.Add(racein.Jumi);
            comboListR.Add(racein.Beastman);
            comboListR.Add(racein.Dragoon);
            comboListR.Add(racein.Human);
        }

        private void ProfessionBox1_TextChanged( object sender, EventArgs e )
        {
            string curtext = ProfessionBox1.Text;
            insertIntoComboBox(curtext);   //insert the current text into combobox
            ProfessionBox1.Select(curtext.Length, 0); //if you don't do this, the cursor goes back to index 0 :-(
        }

        private void RaceBox2_TextChanged( object sender, EventArgs e )
        {
            string curtext = RaceBox2.Text;
            insertIntoComboBox(curtext);   //insert the current text into combobox
            RaceBox2.Select(curtext.Length, 0); //if you don't do this, the cursor goes back to index 0 :-(

        }

        private void insertIntoComboBox1( string curtext )
        {
            RaceBox2.Items.Clear();
            //only add the current text if it's not already in the list of defaults and not empty string
            if (comboList.Contains(curtext) == false && curtext.Length > 0)
                RaceBox2.Items.Add(curtext);
            foreach (string s in comboList)
                RaceBox2.Items.Add(s);
        }

        private void insertIntoComboBox( string curtext )
        {
            ProfessionBox1.Items.Clear();
            //only add the current text if it's not already in the list of defaults and not empty string
            if (comboList.Contains(curtext) == false && curtext.Length > 0)
                ProfessionBox1.Items.Add(curtext);
            foreach (string s in comboList)
                ProfessionBox1.Items.Add(s);
        }


        private void bindingSource2_CurrentChanged( object sender, EventArgs e )
        {
            profList();
        }

        private void bindingSource1_CurrentChanged( object sender, EventArgs e )
        {
            raceList();
        }
        

        /*
             //contains a list of default items for the combobox items
    List<string> comboList = new List<string>();
    
    //fills the defaults for the combobox items
    private void initComboList()
    {
        comboList.Add("red");
        comboList.Add("blue");
        comboList.Add("green");
    }

    //initializes the combobox items
    private void initCombobox()
    {
        comboBox1.Items.Clear();
        foreach (string s in comboList)
            comboBox1.Items.Add(s);
    }

    //occurs when the text changes in the combobox
    private void comboBox1_TextChanged(object sender, EventArgs e)
    {
        string curtext = comboBox1.Text;
        insertIntoComboBox(curtext);   //insert the current text into combobox
        comboBox1.Select(curtext.Length, 0); //if you don't do this, the cursor goes back to index 0 :-(
    }
    <<
    //called whenever is desired to insert the current text into the combobox items
    private void insertIntoComboBox(string curtext)
    {
        comboBox1.Items.Clear();
        //only add the current text if it's not already in the list of defaults and not empty string
        if (comboList.Contains(curtext) == false && curtext.Length > 0)
            comboBox1.Items.Add(curtext);
        foreach (string s in comboList)
                comboBox1.Items.Add(s);
    }

    //called whenever combobox loses focus
    private void comboBox1_Leave(object sender, EventArgs e)
    {
        initCombobox();
    }
         */
    }
}
