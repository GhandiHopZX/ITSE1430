using System;
using System.Windows.Forms;

namespace GameManager.Host.Winforms
{
    /// <summary>Allows adding or editing a game.</summary>
    public partial class GameForm : Form
    {
        public GameForm() //: base()
        {
            InitializeComponent();
        }

        /// <summary>Gets or sets the property being edited.</summary>
        public Game Game { get; set; }

        //Called when the user saves the game
        private void OnSave( object sender, EventArgs e )
        {
            Game = SaveData();

            DialogResult = DialogResult.OK;
            Close();
        }

        //Called when the user cancels the add/edit
        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private decimal ReadDecimal( TextBox control )
        {
            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }

        //Loads UI with game
        private void LoadData( Game game )
        {
            en_Name.Text = game.Name;
            en_Publisher.Text = game.Publisher;
            en_Price.Text = game.Price.ToString();
            _cbOwned.Checked = game.Owned;
            _cbCompleted.Checked = game.Completed;
        }

        //Saves UI into new game
        private Game SaveData()
        {
            var game = new Game();
            game.Name = en_Name.Text;
            game.Publisher = en_Publisher.Text;
            game.Price = ReadDecimal(en_Price);
            game.Owned = en_Owned.Checked;
            game.Completed = en_Completed.Checked;

            //Demoing ctor 

            var game2 = new Game(_txtName.Text, ReadDecimal(_txt...))

            return game;
        }

        //Defined in type
        //Derived types may override and change it
        protected virtual void CanBeChanged() { }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //Init UI if editing a game
            if (Game != null)
                LoadData(Game);
        }
    }
}
