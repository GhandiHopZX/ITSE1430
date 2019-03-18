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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked( object sender, ToolStripItemClickedEventArgs e )
        {

        }

        private void QuitSelected( object sender, EventArgs e )
        {
            Close();
        }

        /// global variables
        #region
        static bool Quit_SC;
        static bool Alt_F4;
        static bool Fkey;
        #endregion


        // alt F4 check
        private void KeyCombos( object sender, KeyEventArgs e )
        {
            // buttons n' stuff for quit shortcut
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                Alt_F4 = true;
            }

            if (Alt_F4 == true)
            { Close(); }

            // Shortcut for Help menu
            if (e.KeyCode == Keys.F)
            {
                Fkey = true;
            }

            // Shortcut for NewCharacter menu
            //var windowChar = new CharacterForm()
            if (e.Control && e.KeyCode == Keys.N)
            {
                var charForm = new CharForm();
                charForm.Activate();
                charForm.Show();
            }

            //var windowAbout = new AboutBox1();
            if (Fkey == true)
            {
                var abform = new About();
                abform.Activate();
                abform.Show();
            }
            
        }

        private void OnAboutSelected( object sender, EventArgs e )
        {
            var abform = new About();
            abform.Activate();
            abform.Show();
        }

        private void OnCharFormSelected( object sender, EventArgs e )
        {
            var charForm = new CharForm();
            charForm.Activate();
            charForm.Show();
        }
    }
}
