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

        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {

        }

        private void textBox1_Validating( object sender, CancelEventArgs e )
        {
            var txb = sender as TextBox;

            if (txb.Text.Length == 0)
            {
                errorProvider1.SetError(txb, "This field needs a name.");
                e.Cancel = true;
            } else
                errorProvider1.SetError(txb, "");
        }

        private void textBox1_Validated( object sender, CancelEventArgs e )
        {
            
        }

        private void button1_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBox1_Validating( object sender, CancelEventArgs e )
        {
            var txb = sender as ComboBox;

            if (txb.Text.Length == 0)
            {
                errorProvider2.SetError(txb, "Class needs to be selected.");
                e.Cancel = true;
            } else
                errorProvider2.SetError(txb, "");
        }
    }
}
