using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using PizzON.Negocio;
using PizzON.Negocio.API;

namespace PizzON.EditForms
{
    public partial class formEditUser2 : Form
    {
        private readonly IUsersAPI _api;

        public formEditUser2(IUsersAPI api, String user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var user = _api.GetUser(lblUser.Text);
            if(txtPassword.Text == txtConfirmPassword.Text)
            {
                user.contrasena = txtPassword.Text;
                if (user.ValidarUsuario())
                {
                    _api.EditUser(user);
                    var frm = Program.NinjectKernel.Get<formBoss>();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Contraseña no cumple los requisitos minimos!");
                    txtPassword.Text = string.Empty;
                    txtConfirmPassword.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden!");
                txtConfirmPassword.Text = string.Empty;
            }
        }
    }
}
