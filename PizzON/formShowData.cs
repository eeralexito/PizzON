using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzON.Negocio.Modelo;
using PizzON.Properties;
using PizzON.Shared;

namespace PizzON
{
    public partial class formShowData : Form
    {



        public formShowData()
        {
            InitializeComponent();
        }

        private void formShowData_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.icono;

        }
        public void AddDataToDataGridView<T>(T entities)
        {            
            dataGridView.DataSource = entities;
            if (entities.GetType() == typeof(List<Usuarios>))
            {
                dataGridView.SettingFormStyle(14);
                dataGridView.Columns[0].HeaderText = "Usuario";
                dataGridView.Columns[1].HeaderText = "Contraseña";
                dataGridView.Columns[2].HeaderText = "Privilegios";
                
            }
            else if(entities.GetType() == typeof(List<Empleado>))
            {
                dataGridView.SettingFormStyle(9);
                dataGridView.Columns[0].HeaderText = "Seguridad Social";
                dataGridView.Columns[1].HeaderText = "DNI/NIE";
                dataGridView.Columns[2].HeaderText = "Nombre";
                dataGridView.Columns[3].HeaderText = "Apellidos";
                dataGridView.Columns[4].HeaderText = "Teléfono";
                dataGridView.Columns[5].HeaderText = "Dirección";
                dataGridView.Columns[6].Visible = false;
                dataGridView.Columns[7].Visible = false;
            }
        }


    }
}
