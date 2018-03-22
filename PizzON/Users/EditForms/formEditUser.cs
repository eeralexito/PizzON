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
using Ninject.Parameters;
using PizzON.Negocio.API;
using PizzON.Negocio.Modelo;

namespace PizzON.EditForms
{
    public partial class formEditUser : Form
    {
        private readonly IUsersAPI _api;
        Usuarios user;
        public formEditUser(IUsersAPI api, String user)
        {
            InitializeComponent();
            _api = api;
            this.user = _api.GetUser(user);
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            if (user.privilegio == "jefe")
                user.privilegio = "empleado";
            else
                user.privilegio = "jefe";
            _api.EditUser(user);
            this.Hide();
            var frm = Program.NinjectKernel.Get<formBoss>();
            frm.ShowDialog();
            
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = Program.NinjectKernel.Get<formEditUser2>(new ConstructorArgument("user",user.usuario));
            frm.ShowDialog();
        }

    }
}
