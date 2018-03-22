using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ninject;
using Ninject.Parameters;
using PizzON.EditForms;
using PizzON.Employees;
using PizzON.Negocio.Modelo;
using PizzON.Shared;

namespace PizzON
{
    public partial class formEdit : Form
    {
        String chosed;
        private int option;
        public formEdit()
        {
            InitializeComponent();
            dataGridViewElegir.ReadOnly = true;            
        }
        public  void setDataGridView<T>(T entity)
        {

            if (entity.GetType() == typeof(List<Usuarios>))
            {
                option = 1;
                btnTitle.Text = "Elige usuario:";

                dataGridViewElegir.DataSource = entity;
                dataGridViewElegir.Columns[0].HeaderText = "Usuario";
                dataGridViewElegir.Columns[1].HeaderText = "Contraseña";
                dataGridViewElegir.Columns[2].HeaderText = "Privilegios";
                dataGridViewElegir.SettingFormStyle(14);
            }else if(entity.GetType() == typeof(List<Empleado>))
            {
                option = 2;
                btnTitle.Text = "Elige empleado:";
                
                dataGridViewElegir.DataSource = entity;
                dataGridViewElegir.SettingFormStyle(8);
                dataGridViewElegir.Columns[0].HeaderText = "Seguridad Social";
                dataGridViewElegir.Columns[1].HeaderText = "DNI/NIE";
                dataGridViewElegir.Columns[2].HeaderText = "Nombre";
                dataGridViewElegir.Columns[3].HeaderText = "Apellidos";
                dataGridViewElegir.Columns[4].HeaderText = "Teléfono";
                dataGridViewElegir.Columns[5].HeaderText = "Dirección";
                dataGridViewElegir.Columns[6].HeaderText = "Tipo empleado";
                dataGridViewElegir.Columns[7].Visible = false;
            }else if (entity.GetType() == typeof(List<Producto>))
            {
                option = 3;

            }
            else if (entity.GetType() == typeof(List<Ingrediente>))
            {
                option = 4;

            }
        }


        private void dataGridViewElegir_Click(object sender, EventArgs e)
        {
            var form = Program.NinjectKernel.Get<formBoss>();
            switch (option)
            {
                case 1:                    
                    chosed = dataGridViewElegir.CurrentRow.Cells["usuario"].Value.ToString();
                    if(chosed == "admin")                    
                        MessageBox.Show("No se puede modificar el usuario administrador!");                    
                    else
                    {                      
                        var frmEditUser = Program.NinjectKernel.Get<formEditUser>(new ConstructorArgument("user", chosed));
                        //frm.Show();
                        form.AddFormToPanel(frmEditUser);
                        Console.WriteLine("estoy pulsado");
                    }break;


                case 2:
                    chosed = dataGridViewElegir.CurrentRow.Cells["numero_seguridad_social"].Value.ToString();
                    var frmEditEmployee = Program.NinjectKernel.Get<formEditEmployee>(new ConstructorArgument("Employee", chosed));
                    form.AddFormToPanel(frmEditEmployee);
                    break;


                case 3:
                    break;
                case 4:
                    break;

            }    
        }

        


    }
}
