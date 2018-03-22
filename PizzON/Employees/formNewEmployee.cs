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

namespace PizzON
{
    public partial class formNewEmployee : Form
    {
        private readonly IEmployeesAPI _api;
        public formNewEmployee(IEmployeesAPI api)
        {
            InitializeComponent();
            _api = api;
        }

        private void txtTypeID_TextChanged(object sender, EventArgs e)
        {
            if ( txtTypeID.Text == "DNI" )
                txtID.Mask = "99999999-L";
            else
                txtID.Mask = "L-9999999-L";
        }
        private Empleado getEmployee()
        {
            Empleado emp = new Empleado();
            emp.numero_seguridad_social = Int64.Parse(txtSS.Text);
            emp.tipo_empleado = txtTypeEmployee.Text;
            emp.dni_nie = txtID.Text;
            emp.nombre = txtName.Text;
            emp.apellidos = txtSurname.Text;
            emp.telefono = txtPhone.Text;
            emp.direccion = txtAddress.Text;

            return emp;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _api.NewEmployee(getEmployee());
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(Control tx in Controls)
            {
                if(tx is TextBoxBase)
                    tx.Text = string.Empty;
            }
        }

        private void formNewEmployee_Load(object sender, EventArgs e)
        {
            txtSS.Focus();
        }

        private void txtTypeID_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.D)
            {
                txtID.Text = "DNI";
                txtID.Mask = "99999999-L";
            }
            if (e.KeyCode == Keys.N)
            {
                txtID.Text = "NIE";
                txtID.Mask = "L-9999999-L";
            }

        }

        private void txtTypeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (txtTypeID.Text == "DNI")
                    txtID.Mask = "99999999-L";
                else
                    txtID.Mask = "L-9999999-L";
            }
        }
    }
}
