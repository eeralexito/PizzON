using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzON.Negocio;
using PizzON.Negocio.API;
using PizzON.Negocio.Modelo;
using PizzON.Properties;
using PizzON.Shared.Validators;

namespace PizzON
{
    public partial class formNewUser : Form
    {
        private readonly IUsersAPI _api;
        Usuarios _model;
        public formNewUser(IUsersAPI api, Usuarios model)
        {
            InitializeComponent();
            _api = api;
            _model = model;
        }

        private void formNewUser_Load(object sender, EventArgs e)
        {
            ValidateControls();
            this.Icon = Resources.icono;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                FillUser();
                NewUser();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckRequierements();
        }





        private void FillUser()
        {
            _model.usuario = txtUser.Text;
            _model.contrasena = txtPassword.Text;
            _model.privilegio = cbRol.Text;
        }

        private void NewUser()
        {
            bool exist = _api.GetUser(_model.usuario) != null;

            if (exist)
                MessageBox.Show("USUARIO YA EXISTE!");
            else
            {
                if (_model.ValidarUsuario())
                {
                    _api.NewUser(_model);
                    MessageBox.Show("Usuario creado correctamente!");
                }
                else
                    MessageBox.Show("Datos incorrectos!");
            }


        }
        
        private void CheckRequierements()
        {
            bool Upper = false;
            bool Charac = false;

            if (txtPassword.Text.Length > 7)
                lbLength.ForeColor = Color.Green;
            else
                lbLength.ForeColor = Color.Red;

            for (int i = 0; i < txtPassword.Text.Length; i++)
            {
                if (!Char.IsLetterOrDigit(txtPassword.Text[i]))
                    Charac = true;
                if (Char.IsUpper(txtPassword.Text[i]))
                    Upper = true;
            }
            lblChar.ForeColor = Charac ? Color.Green : Color.Red;
            lblUpper.ForeColor = Upper ? Color.Green : Color.Red;

        }

        private void Clear()
        {
            txtUser.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtConfirmPassword.Text = String.Empty;
            cbRol.Text = String.Empty;
        }

        private void ValidateControls()
        {
            txtUser.RequieredValidator(errorProviderNewUser, "Nombre de usuario obligatorio!");
            txtPassword.RequieredValidator(errorProviderNewUser, "Contraseña obligatoria!");
            txtConfirmPassword.RequieredValidator(errorProviderNewUser, "Confirma la contraseña!");
            cbRol.RequieredValidator(errorProviderNewUser, "Elige el tipo de usuario!");

        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            String mensajeError = "Usuario ya existe!";
            if (!_api.UserExist(txtUser.Text))
            {
                if (errorProviderNewUser.GetError(txtUser) == mensajeError)
                {
                    errorProviderNewUser.SetError(txtUser, string.Empty);
                }                    
            }
            else
            {
                errorProviderNewUser.SetError(txtUser, mensajeError);
                //e.Cancel = true;

            }

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            String mensajeError = "Las contraseñas no coinciden!";
            if(txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProviderNewUser.SetError(txtConfirmPassword, mensajeError);
                //e.Cancel = true;
            }
            else
            {
                if (errorProviderNewUser.GetError(txtConfirmPassword) == mensajeError)
                {
                    errorProviderNewUser.SetError(txtConfirmPassword, string.Empty);
                }
            }
        }
    }
}
