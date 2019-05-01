/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        public Product product { get; set; }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            UpdateList();
        }

        #region Event Handlers

        private void OnFileExit( object sender, EventArgs e ) => Close();

        private void OnProductAdd( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");
            do
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                   
                    //if (!ValidateChildren())
                    return;
                try
                {
                    _database.Add(child.Product);
                    
                    break;
                } catch (Exception ex)
                {
                    DisplayError("Add Failure", ex.Message);
                };
                //TODO: Handle errors DONE
                //Save product
              
            }
            while (true);
            UpdateList();
        }

        private void DisplayError( string title, string message ) =>
       MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void OnProductEdit( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available.");
                return;
            };

            EditProduct(product);
        }        

        private void OnProductDelete( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);
        }        
                
        private void OnEditRow( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);
			
			//Don't continue with key
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Private Members

        private void DeleteProduct ( Product product )
        {
            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Handle errors
            //Delete product
            _database.Remove(product.Id);
            UpdateList();
        }

        private void EditProduct( Product product )
        {
            var form = new MainForm();

            
            if (GetSelectedProduct() == null)
                return;

            var child = new ProductDetailForm("Product Details");
            child.Product = GetSelectedProduct();

            while (true)
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;
                try
                {
                    //TODO: Handle errors
                    //Save product
                    _database.Update(GetSelectedProduct().Id, child.Product);
                    if (child.Name == null)
                        
                        break;
                }
                catch (Exception M)
                {
                    DisplayError("Updated Failed", M.Message);
                };
            };

            UpdateList();
        }

        private void DisplayError( Exception m )
        {
            MessageBox.Show(this, m.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList()
        {
            //TODO: Handle errors done i think
            _bsProducts.List.Clear();

            //Linq i Think
            var kisto = _database.GetAll();

            if (kisto == null)
                return;

            while (true)

            try
            {
                //var products = _database.GetAll().OrderBy(p => p.Name);

                //_bsProducts.List.Add(products.ToArray());

                _bsProducts.DataSource = _database.GetAll().OrderBy(p => p.Name);
            

            } catch (ArgumentNullException e)
            {
                DisplayError("Update Failure", e.Message);
            };
            
        }

        private readonly IProductDatabase _database = new Nile.Stores.MemoryProductDatabase();
        #endregion

        private void EditProduct()
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            var form = new ProductDetailForm() { Product = product };
            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    _database.Update(product.Id, form.Product);
                    break;
                } catch (Exception e)
                {
                    DisplayError("Updated Failed", e.Message);
                };
            };

            UpdateList();
        }

        private void MainForm_KeyDown( object sender, KeyEventArgs e )
        {
            if (e.KeyCode == Keys.F)
            {
                //e.SuppressKeyPress = false;
                var about = new AboutBox1();
                about.Activate();
                about.Show();
                about.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
        {
            var about = new AboutBox1();
            about.ShowDialog();
        }

        private void MainForm_KeyPress( object sender, KeyPressEventArgs e )
        {
        }

        private void MainForm_KeyUp( object sender, KeyEventArgs e )
        {
            var about = new AboutBox1();
            if (e.KeyCode == Keys.F1)
                about.ShowDialog();
        }

        private void _gridProducts_Validating( object sender,
            System.ComponentModel.CancelEventArgs e )
        {
           
        }
    }
}
