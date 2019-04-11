using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            DialogResult = DialogResult.Cancel;
            Close();
        }

       
        //Saving when canceled
        private void OnSaveContact( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var contact = SaveData();

            try
            {
              ObjectValidator.Validate(contact);
            }

            catch (ValidationException)
            {
                MessageBox.Show(this,
                    "Contact invalid.",
                    "Error",
                    MessageBoxButtons.OK);
                return;
            };

            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();
        }

        //formatting
        private void AddContact_Load( object sender, EventArgs e )
        {
            sender = AnchorStyles.Top;
            sender = AnchorStyles.Bottom;
            sender = AnchorStyles.Left;
            sender = AnchorStyles.Right;
        }

        //Saves UI into new game
        private Contact SaveData()
        {
            var contact = new Contact {
                Name = contact_namebox.Text,
                Email = contact_emailbox.Text
            };

            //Demoting Constructor
            var contact2 = new Contact(contact_namebox.Text, contact_emailbox.Text);

            return contact;
        }

        private void contact_namebox_Validating( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                errorProvider1.SetError(tb, "Contact name is required.");
                e.Cancel = true;

            } else
                errorProvider1.SetError(tb, "");
        }

        private void contact_emailbox_Validating( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                errorProvider2.SetError(tb, "Email is required.");
                e.Cancel = true;
            } else
                errorProvider2.SetError(tb, "");
        }
    }
}
