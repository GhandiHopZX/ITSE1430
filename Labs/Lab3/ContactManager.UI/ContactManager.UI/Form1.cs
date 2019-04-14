using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Type;

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

        public object contact { get; set; }
        #endregion

        private void Form1_KeyDown( object sender, KeyEventArgs e )
        {

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

            //New window Add Contact Form
            if (e.KeyCode == Keys.Insert)
            {
                var AddCForm = new AddContact();
                AddCForm.ShowDialog();
            }
        }

        //BindList
        private void BindList2()
        {
            //Bind games to listbox
            var emu = splitContainer1.Panel1;
            var emos = splitContainer1.Panel2;

            ListBox box;
            //emu.ControlAdded += ;
            //Can use AddRange now that we don't care about null items
            //var enumor = _games.GetAll();
            //var enumoror = enumor.GetEnumerator();
            //while (enumoror.MoveNext())
            //{
            //    var item = enumoror.Current;
            //};
            ////foreach (var item in enumor)
            //{
            //};

            var items = _contacts.GetAll();
            items = items.OrderBy(GetCName);
            //foreach (var game in _games)
            //{
            //    if (game != null)
            //        _listGames.Items.Add(game);
            //};
        }

        private IContactDatabase _contacts;

        private string GetCName( Contact contact )
        {
            return contact.Name;
        }

        private string GetCEmail(Contact contact)
        {
            return contact.Email; 
        }

        // about form open
        private void AboutToolStripMenuItem_Click( object sender, EventArgs e )
        {
            var abform = new AboutBox1();
            abform.ShowDialog();
        }

        //Close
        private void ExitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Close();
        }

        //New Contact Window
        private void AddNewContact( object sender, EventArgs e )
        {
            var AddCForm = new AddContact();
            AddCForm.ShowDialog();
        }

        private void Form1_Load( object sender, EventArgs e )
        {

        }
    }
}
