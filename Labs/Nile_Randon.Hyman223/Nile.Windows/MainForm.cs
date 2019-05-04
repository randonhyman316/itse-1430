/***********************
 * Randon Hyman
 * ITSE 1430 
 * 5/3/2018
 * ********************/

using System;
using System.Windows.Forms;
using System.Configuration;
using Nile.Stores.Sql;
using System.Data.SqlClient;

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

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            UpdateList();
        }

        #region Event Handlers
        
        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save product
            try
            {
                _database.Add(child.Product);
                UpdateList();
            } catch
            {
                MessageBox.Show(this, "Cannot Add. Perhaps duplicate entry.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

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

            //Delete product
            try
            {
                _database.Remove(product.Id);
                UpdateList();
            }
            catch
            {
                MessageBox.Show(this, $"Cannot delete '{product.Name}'", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void EditProduct ( Product product )
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save product
            try
            {
                _database.Update(child.Product);
                UpdateList();
            }
            catch
            {
                MessageBox.Show(this, $"Cannot update '{product.Name}'", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList ()
        {
           
            _bsProducts.DataSource = _database.GetAll();
            
        }
        public static System.Configuration.ConnectionStringSettingsCollection ConnectionStrings { get;  }

        static string connString = ConfigurationManager.ConnectionStrings["NileDatabase"].ConnectionString;
        private readonly SqlProductDatabase _database = new SqlProductDatabase(connString);
        #endregion

        private void OnHelpAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Randon Hyman\nITSE 1430\nMW 7:30-9:45", "About", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
