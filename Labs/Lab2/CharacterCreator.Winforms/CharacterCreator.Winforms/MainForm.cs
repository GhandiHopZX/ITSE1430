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
        public bool Alt_F4 { get; set; }
        public bool Fkey { get; set; }
        #endregion


        // alt F4 check
        private void MainForm_KeyDown( object sender, KeyEventArgs e )
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

            if (Fkey == true)
            {
                var abform = new About();
                abform.Activate();
                abform.Show();
            }
            //var windowAbout = new AboutBox1();
            
        }

        private void aboutToolStripMenuItem1_Click( object sender, EventArgs e )
        {
            var abform = new About();
            abform.Activate();
            abform.Show();
        }
    }
}
