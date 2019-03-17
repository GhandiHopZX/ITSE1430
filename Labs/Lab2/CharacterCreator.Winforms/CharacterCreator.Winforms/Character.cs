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

        //pulling from the Character class
        public Character character { get; set; }

        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
        }

        private void textBox1_Validating( object sender, CancelEventArgs e )
        {
            var txb = sender as TextBox;

            if (txb.Text.Length == 0)
            {
                errorProvider1.SetError(txb, "This field needs a name.");
                //e.Cancel = true;
            } else
                errorProvider1.SetError(txb, "");
        }

        private void button1_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBox1_Validating( object sender, CancelEventArgs e )
        {
            var txb2 = sender as ComboBox;

            if (txb2.SelectionLength == 0)
            {
                errorProvider2.SetError(txb2, "Class needs to be selected.");
                //e.Cancel = false;
            } else
                errorProvider2.SetError(txb2, "");
        }

        private void comboBox2_Validating( object sender, CancelEventArgs e )
        {
            var txb3 = sender as ComboBox;

            if (txb3.SelectionLength == 0)
            {
                errorProvider2.SetError(txb3, "Profession needs to be selected.");
                //e.Cancel = false;
            } else
                errorProvider2.SetError(txb3, "");
        }
    }
}
