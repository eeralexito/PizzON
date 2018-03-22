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
using Ninject;
using PizzON.Properties;

namespace PizzON
{
    public partial class formLogIn : Form
    {
        private readonly IUsersAPI _api;
        //public static String usuario;
        public formLogIn(IUsersAPI api)
        {
            InitializeComponent();
            _api = api;
        }
        private void formLogIn_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.icono;
            
            ConfigSize();
        }
        private void ConfigSize()
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int x = this.Size.Width;
            int y = this.Size.Height;
            this.Size = new Size(Convert.ToInt32(width - width / 6.25), Convert.ToInt32(height - height / 6.25));
            this.
            lblTitle.Location = new Point(Convert.ToInt32(x/2.3), Convert.ToInt32(y/15));
            lblUser.Location = new Point(Convert.ToInt32(x / 2.3), Convert.ToInt32(y / 3.7));
            lblPassword.Location = new Point(Convert.ToInt32(x / 2.3), Convert.ToInt32(y / 3));
            txtUser.Location = new Point(Convert.ToInt32(x / 2.3), Convert.ToInt32(y / 3.35));
            txtPassword.Location = new Point(Convert.ToInt32(x / 2.3), Convert.ToInt32(y / 2.7));
            btnLogIn.Location = new Point(Convert.ToInt32(x / 2.3), Convert.ToInt32(y / 2));
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Size.ToString());
            if (_api.Connect(txtUser.Text, txtPassword.Text))
            {
                //usuario = txtUser.Text;

                //Si es jefe
                var tipoUsuario = _api.GetUser(txtUser.Text);
                if (tipoUsuario.privilegio == "jefe")
                {
                    var frm = Program.NinjectKernel.Get<formBoss>();
                    this.Hide();
                    frm.Show();              
                }
                else //Si es un empleado
                {
                    this.Hide();
                    var frm = Program.NinjectKernel.Get<formMain>();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña INCORRECTA!");
                txtPassword.Text = String.Empty;
                txtPassword.Focus();
            }




        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogIn_Click(sender, e);
        }

        private void formLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void formLogIn_Resize(object sender, EventArgs e)
        {
            ConfigSize();
        }
    }
}
