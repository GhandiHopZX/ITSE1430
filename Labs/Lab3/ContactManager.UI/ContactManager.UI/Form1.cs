using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// global variables
        #region
        static bool Alt_F4;
        static bool Fkey;
        #endregion

        private void Form1_KeyDown( object sender, KeyEventArgs e )
        {
            //// buttons n' stuff for quit shortcut
            //if (e.Alt && e.KeyCode == Keys.F4)
            //{
            //    Alt_F4 = true;
            //}

            //if (Alt_F4 == true)
            //{ Close(); }

            // Shortcut for Help menu
            if (e.KeyCode == Keys.F1)
            {
                Fkey = true;
            }
            
            //var windowAbout = new AboutBox1();
            if (Fkey == true)
            {
                var abform = new AboutBox1();
                abform.Activate();
                abform.Show();
            }
        }

        private void AboutToolStripMenuItem_Click( object sender, EventArgs e )
        {
            var abform = new AboutBox1();
            abform.Activate();
            abform.Show();
        }

        private void ExitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Close();
        }
    }
}
