using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzON.Negocio.API;
using PizzON.Negocio.Modelo;
using PizzON.Properties;

namespace PizzON.Products
{
    public partial class formNewProduct : Form
    {
        private readonly IProductsAPI _api;

        public formNewProduct(IProductsAPI api)
        {
            InitializeComponent();
            _api = api;
        }

        private void formNewProduct_Load(object sender, EventArgs e)
        {
            txtCategoria.Items.Clear();
            this.Icon = Resources.icono;
            foreach(var p in _api.GetCategories())
            txtCategoria.Items.Add(p);
        }

        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _api.NewProduct(GetProduct());
                btnClear_Click(sender, e);
            }
        }

        private Producto GetProduct()
        {
            var product = new Producto();
            product.nombre = txtNombre.Text;
            product.categoria = txtCategoria.Text;
            MessageBox.Show(txtPrecio.Text);
            product.precio = Convert.ToDecimal(txtPrecio.Text);

            return product;
        }





















        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control tx in Controls)
            {
                if (tx is TextBoxBase)
                    tx.Text = string.Empty;
            }
            txtCategoria.Text = string.Empty;
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            txtCategoria.DropDownStyle = ComboBoxStyle.DropDown;
            toolTipProducts.SetToolTip(this.btnAddCat, "Introduzca la nueva categoria en el cuadro de la izquierda.");

        }

        private void btnAddCat_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void txtCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCategoria.Items.Add(txtCategoria.Text);
                txtCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            }
                
        }

        private void txtCategoria_MouseHover(object sender, EventArgs e)
        {
            if(txtCategoria.DropDownStyle == ComboBoxStyle.DropDown)
            {

                toolTipProducts.SetToolTip(this.txtCategoria, "Introduzca la nueva categoria y pulse Intro");
            }
        }
    }
}
