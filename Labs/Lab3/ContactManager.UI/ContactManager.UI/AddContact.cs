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
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        public Contact Contact { get; set; }

        //closed when canceled
        private void ContactCancelButton_Click( object sender, EventArgs e )
        {
            Close();
        }

        //Saving when canceled
        private void OnSaveContact( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var contact = SaveData();
        }

        private void AddContact_Load( object sender, EventArgs e )
        {

        }

        //Saves UI into new game
        private Contact SaveData()
        {
            var contact = new Contact();
            contact.Name = contact_namebox.Text;
            contact.Email = contact_emailbox.Text;

            //Demoting Constructor
            var contact2 = new Contact();

            return contact;
        }

    }
}
