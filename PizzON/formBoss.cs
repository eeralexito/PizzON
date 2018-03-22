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
using PizzON.Products;
using PizzON.Properties;

namespace PizzON
{
    public partial class formBoss : Form
    {
        private FlowLayoutPanel panelSub;
        private List<Button> buttons;
        private readonly IUsersAPI _apiUsers;
        private readonly IEmployeesAPI _apiEmployees;
        private readonly IProductsAPI _apiProducts;
        private readonly IIngredientsAPI _apiIngredients;
        private bool exit;
        private int type;


        public formBoss(IUsersAPI apiUsers, IEmployeesAPI apiEmployees, IProductsAPI apiProducts, IIngredientsAPI apiIngredients)
        {
            InitializeComponent();
            
            panelSub = new FlowLayoutPanel();
            buttons = new List<Button>();
            exit = false;
            type = 0;

            //Asignamos las variables api
            _apiUsers           = apiUsers;
            _apiEmployees       = apiEmployees;
            _apiProducts        = apiProducts;
            _apiIngredients     = apiIngredients;
        }

        private void formBoss_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.icono;
            CreateSubPanel();
        }

        
        public void metodo(Form form)
        {
            AddFormToPanel(form);
        }
       
        //Creacion subPanel
        private void CreateSubPanel()
        {
            #region New buttons
            Button btnCreate = new Button();
            btnCreate.Name = "btnCreate";
            btnCreate.Image = Resources.Create;
            btnCreate.Text = "NUEVO";
            btnCreate.Click += new EventHandler(btnCreate_Click);

            Button btnEdit = new Button();
            btnEdit.Name = "btnEdit";
            btnEdit.Image = Resources.Edit;
            btnEdit.Text = "EDITAR";
            btnEdit.Click += new EventHandler(btnEdit_Click);

            Button btnDelete = new Button();
            btnDelete.Name = "btnDelete";
            btnDelete.Image = Resources.Delete;
            btnDelete.Text = "BORRAR";
            btnDelete.Click += new EventHandler(btnDelete_Click);

            Button btnView = new Button();
            btnView.Name = "btnView";
            btnView.Image = Resources.View;
            btnView.Text = "VER";
            btnView.Click += new EventHandler(btnView_Click);

            buttons.Add(btnCreate);
            buttons.Add(btnEdit);
            buttons.Add(btnDelete);
            buttons.Add(btnView);
            #endregion

            //Common properties
            foreach (Button b in buttons)
            {
                b.Size = new Size(188, 80);
                //b.Location = new Point(3, 3);
                b.UseVisualStyleBackColor = true;
                b.FlatAppearance.BorderSize = 0;
                b.FlatStyle = FlatStyle.Flat;
                b.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                panelSub.Controls.Add(b);
            }

            #region SubPanel
            // panelSub       
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new Size(194, 351);
            this.panelSub.Visible = false;
            #endregion

        }


        #region SUBPANEL CLICKS
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create();            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }        

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewButtons();
        }        
        #endregion
        private void btn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnPizza":

                    break;
            }
            
        }
        //Botones para Ver
        private void ViewButtons()
        {
            panelMDI.Controls.Clear();
            switch (type)
            {
                case 1:
                    #region Botones Ver Usuarios
                    Button btnEmployees = new Button();
                    panelMDI.Controls.Add(btnEmployees);
                    btnEmployees.Location = new Point(140, 84);
                    btnEmployees.Name = "btnEmployees";
                    btnEmployees.Text = "Ver empleados";
                    btnEmployees.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    btnEmployees.Size = new Size(150, 100);
                    btnEmployees.UseVisualStyleBackColor = true;
                    btnEmployees.Click += new EventHandler(btnEmployes_Click);

                    Button btnBosses = new Button();
                    panelMDI.Controls.Add(btnBosses);
                    btnBosses.Location = new Point(140, 244);
                    btnBosses.Name = "btnBosses";
                    btnBosses.Text = "Ver jefes";
                    btnBosses.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    btnBosses.Size = new Size(150, 100);
                    btnBosses.UseVisualStyleBackColor = true;
                    btnBosses.Click += new EventHandler(btnBosses_Click);

                    Button btnAllUsers = new Button();
                    panelMDI.Controls.Add(btnAllUsers);
                    btnAllUsers.Location = new Point(140, 394);
                    btnAllUsers.Name = "btnAll";
                    btnAllUsers.Text = "Ver todos";
                    btnAllUsers.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    btnAllUsers.Size = new Size(150, 100);
                    btnAllUsers.UseVisualStyleBackColor = true;
                    btnAllUsers.Click += new EventHandler(btnAllUsers_Click);
                    #endregion
                    break;
                case 2:
                    #region Botoenes Ver Empelados

                    //Boton para ver cocineros
                    Button btnChef = new Button();
                    panelMDI.Controls.Add(btnChef);
                    btnChef.Location = new Point(20, 30);
                    btnChef.Name = "btnChef";
                    btnChef.Text = "Cocineros";
                    btnChef.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    btnChef.Size = new Size(160, 160);
                    btnChef.UseVisualStyleBackColor = true;
                    btnChef.Click += new EventHandler(btnChef_Click);

                    //Boton para ver camareros
                    Button btnWaiter = new Button();
                    panelMDI.Controls.Add(btnWaiter);
                    btnWaiter.Location = new Point(20, 430);
                    btnWaiter.Name = "btnChef";
                    btnWaiter.Text = "Camareros";
                    btnWaiter.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    btnWaiter.Size = new Size(160, 160);
                    btnWaiter.UseVisualStyleBackColor = true;
                    btnWaiter.Click += new EventHandler(btnWaiter_Click);

                    //Boton para ver repartidores
                    Button btnDeliver = new Button();
                    panelMDI.Controls.Add(btnDeliver);
                    btnDeliver.Location = new Point(335, 30);
                    btnDeliver.Name = "btnChef";
                    btnDeliver.Text = "Repartidores";
                    btnDeliver.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    btnDeliver.Size = new Size(160, 160);
                    btnDeliver.UseVisualStyleBackColor = true;
                    btnDeliver.Click += new EventHandler(btnDeliver_Click);

                    //Boton para ver recepcionistas
                    Button btnRecep = new Button();
                    panelMDI.Controls.Add(btnRecep);
                    btnRecep.Location = new Point(335, 430);
                    btnRecep.Name = "btnChef";
                    btnRecep.Text = "Recepcionistas";
                    btnRecep.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    btnRecep.Size = new Size(160, 160);
                    btnRecep.UseVisualStyleBackColor = true;
                    btnRecep.Click += new EventHandler(btnRecep_Click);

                    //Boton para ver todos los empleados
                    Button btnAllEmployees = new Button();
                    panelMDI.Controls.Add(btnAllEmployees);
                    btnAllEmployees.Location = new Point(175, 225);
                    btnAllEmployees.Name = "btnChef";
                    btnAllEmployees.Text = "TODOS";
                    btnAllEmployees.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    btnAllEmployees.Size = new Size(160, 160);
                    btnAllEmployees.UseVisualStyleBackColor = true;
                    btnAllEmployees.Click += new EventHandler(btnAllEmployees_Click);
                    #endregion
                    break;
                case 3:
                    var list = _apiProducts.GetCategories();
                    int x = 50, y = 50;
                    for(int i = 0; i < list.Count; i++)
                    {
                       
                            
                        Button btn = new Button();                        
                        btn.Name = btn + list[i];
                        btn.Text = list[i];
                        btn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        btn.Size = new Size(160, 160);
                        btn.Location = new Point(x, y);
                        btn.UseVisualStyleBackColor = true;
                        btn.Click += new EventHandler(btn_Click);
                        panelMDI.Controls.Add(btn);

                        x += 200;
                        if (x > 300)
                        {
                            y += 200;
                            x = 50;
                        }

                    }











                    ////Boton para ver cocineros
                    //Button btnPizza = new Button();
                    //panelMDI.Controls.Add(btnPizza);
                    
                    //btnPizza.Name = "btnPizza";
                    //btnPizza.Text = "Pizza";
                    //btnPizza.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    //btnPizza.Size = new Size(160, 160);
                    //btnPizza.UseVisualStyleBackColor = true;
                    //btnPizza.Click += new EventHandler(btnPizza_Click);

                    ////Boton para ver cocineros
                    //Button btnSandwich = new Button();
                    //panelMDI.Controls.Add(btnSandwich);
                    //btnSandwich.Location = new Point(20, 30);
                    //btnSandwich.Name = "btnPizza";
                    //btnSandwich.Text = "Pizza";
                    //btnSandwich.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    //btnSandwich.Size = new Size(160, 160);
                    //btnSandwich.UseVisualStyleBackColor = true;
                    //btnSandwich.Click += new EventHandler(btnPizza_Click);

                    ////Boton para ver cocineros
                    //Button btnSalad = new Button();
                    //panelMDI.Controls.Add(btnSalad);
                    //btnSalad.Location = new Point(20, 30);
                    //btnSalad.Name = "btnPizza";
                    //btnSalad.Text = "Pizza";
                    //btnSalad.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    //btnSalad.Size = new Size(160, 160);
                    //btnSalad.UseVisualStyleBackColor = true;
                    //btnSalad.Click += new EventHandler(btnPizza_Click);

                    ////Boton para ver cocineros
                    //Button btnAppetizer = new Button();
                    //panelMDI.Controls.Add(btnAppetizer);
                    //btnAppetizer.Location = new Point(20, 30);
                    //btnAppetizer.Name = "btnPizza";
                    //btnAppetizer.Text = "Pizza";
                    //btnAppetizer.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    //btnAppetizer.Size = new Size(160, 160);
                    //btnAppetizer.UseVisualStyleBackColor = true;
                    //btnAppetizer.Click += new EventHandler(btnPizza_Click);

                    ////Boton para ver cocineros
                    //Button btnSoda = new Button();
                    //panelMDI.Controls.Add(btnSoda);
                    //btnSoda.Location = new Point(20, 30);
                    //btnSoda.Name = "btnPizza";
                    //btnSoda.Text = "Pizza";
                    //btnSoda.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    //btnSoda.Size = new Size(160, 160);
                    //btnSoda.UseVisualStyleBackColor = true;
                    //btnSoda.Click += new EventHandler(btnPizza_Click);

                    ////Boton para ver cocineros
                    //Button btnDessert = new Button();
                    //panelMDI.Controls.Add(btnDessert);
                    //btnDessert.Location = new Point(20, 30);
                    //btnDessert.Name = "btnPizza";
                    //btnDessert.Text = "Pizza";
                    //btnDessert.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    //btnDessert.Size = new Size(160, 160);
                    //btnDessert.UseVisualStyleBackColor = true;
                    //btnDessert.Click += new EventHandler(btnPizza_Click);

                    break;
            }
        }

        


        #region Eventos Ver empleados Click
        private async void btnChef_Click(object sender, EventArgs e)
        {
            await Show_MDI_Chefs();
        }
        private async void btnWaiter_Click(object sender, EventArgs e)
        {
            await Show_MDI_Waiters();
        }
        private async void btnDeliver_Click(object sender, EventArgs e)
        {
            await Show_MDI_Delivers();
        }
        private async void btnRecep_Click(object sender, EventArgs e)
        {
            await Show_MDI_Receptionists();
        }
        private async void btnAllEmployees_Click(object sender, EventArgs e)
        {
            await Show_MDI_All_Employees();
        }
        #endregion

        #region Eventos Ver usuarios Click
        private async void btnAllUsers_Click(object sender, EventArgs e)
        {
            await Show_MDI_All_Users();
        }

        private async void btnBosses_Click(object sender, EventArgs e)
        {
            await Show_MDI_Bosses();
        }

        private async void btnEmployes_Click(object sender, EventArgs e)
        {
            await Show_MDI_Employees();
        }
        #endregion

        #region Eventos Ver Productos Click
        private async void btnPizza_Click(object sender, EventArgs e)
        {
            await Show_MDI_Pizzas();
        }
        private async void btnSandwich_Click(object sender, EventArgs e)
        {
            await Show_MDI_Sandwich();
        }
        private async void btnSalad_Click(object sender, EventArgs e)
        {
            await Show_MDI_Salad();
        }
        private async void btnAppetizer_Click(object sender, EventArgs e)
        {
            await Show_MDI_Appetizer();
        }
        private async void btnSoda_Click(object sender, EventArgs e)
        {
            await Show_MDI_Soda();
        }
        private async void btnDessert_Click(object sender, EventArgs e)
        {
            await Show_MDI_Dessert();
        }
        private async void btnAllProducts_Click(object sender, EventArgs e)
        {
            await Show_MDI_All_Products();
        }

        #endregion
        private void Create()
        {
            switch (type)
            {
                case 1:
                    Show_MDI_NewUser();
                    break;
                case 2:
                    Show_MDI_NewEmployee();
                    break;                    
                case 3:
                    Show_MDI_NewProduct();
                    break;
                case 4:
                    Show_MDI_NewIngredient();
                    break;
            }
        }  

        private async void Edit()
        {
            
            switch (type)
            {
                case 1:
                    await Show_MDI_EditUser();
                    break;
                case 2:
                    await Show_MDI_EditEmployee();
                    break;
                case 3:
                    await Show_MDI_EditProduct();
                    break;
                case 4:
                    break;
            }
        }

        private void Delete()
        {
            switch (type)
            {
                case 1:
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

    

        //Controlamos el click de los botones de la izquierda
        private void FillFlowPanel(Button btn, bool option)
        {
            Button[] buttons = { btnUsers, btnEmployees, btnProducts, btnIngredients, btnClose, btnExit };
            Control[] pushed = { btn, panelSub, btnClose, btnExit };

            flowPanel.Controls.Clear();
            panelSub.Visible = option;
            flowPanel.Controls.AddRange(!option?buttons:pushed);
            
        }

        #region Botones panel izquierda

        private void btnUsers_Click(object sender, EventArgs e)
        {
            //CreateSubPanel();
            FillFlowPanel(btnUsers, !panelSub.Visible);
            type = 1;
            
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            //CreateSubPanel();
            FillFlowPanel(btnEmployees, !panelSub.Visible);
            type = 2;
            
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //CreateSubPanel();
            FillFlowPanel(btnProducts, !panelSub.Visible);
            type = 3;
           
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            //CreateSubPanel();
            FillFlowPanel(btnIngredients, !panelSub.Visible);
            type = 4;
            
        }
        #endregion
       
        //Cerrar sesion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = Program.NinjectKernel.Get<formLogIn>();
            frm.ShowDialog();
        }

        //Salir del programa
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            exit = true;
        }
        
        //Controlamos el cierre del progrma para que cierre sesion
        private void formBoss_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!exit)
            {
                this.Hide();
                var frm = Program.NinjectKernel.Get<formLogIn>();
                frm.ShowDialog();
            }

        }

        //Ajustamos el formulario al panel
        private void panelMDI_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < this.panelMDI.Controls.Count; i++)
            {
                var tipo = this.panelMDI.Controls[i].GetType();
                if(tipo == typeof(Form))
                    panelMDI.Controls[i].Size = panelMDI.Size;
            }
        }

        //Añadir un formulario al panel 
        public void AddFormToPanel(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            panelMDI.Controls.Clear();
            panelMDI.Controls.Add(frm);
            frm.Show();

        }

        #region MDI Users
        private void Show_MDI_NewUser()
        {
            var frm = Program.NinjectKernel.Get<formNewUser>();
            AddFormToPanel(frm);
        }
        
        private async Task Show_MDI_EditUser()
        {
            var frm = Program.NinjectKernel.Get<formEdit>();
            var list = await Task.Run(async () =>
            {
                return await _apiUsers.GetAllUsers();
            });
            frm.setDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Employees()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiUsers.GetEmployes();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Bosses()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiUsers.GetBoss();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_All_Users()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiUsers.GetAllUsers();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);

        }
        #endregion
        #region MDI Employees
        private void Show_MDI_NewEmployee()
        {
            var frm = Program.NinjectKernel.Get<formNewEmployee>();
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_EditEmployee()
        {
            var frm = Program.NinjectKernel.Get<formEdit>();
            var list = await Task.Run(async () =>
            {
                return await _apiEmployees.getAllEmployees();
            });
            frm.setDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Chefs()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiEmployees.getChefs();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Waiters()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiEmployees.getWaiters();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Delivers()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiEmployees.getDelivers();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Receptionists()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiEmployees.getReceptionists();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_All_Employees()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiEmployees.getAllEmployees();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        #endregion
        #region MDI Producto        
        private void Show_MDI_NewProduct()
        {
            var frm = Program.NinjectKernel.Get<formNewProduct>();
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_EditProduct()
        {
            var frm = Program.NinjectKernel.Get<formEdit>();
            var list = await Task.Run(async () =>
            {
                return await _apiProducts.GetAllProducts();
            });
            frm.setDataGridView(list);
            AddFormToPanel(frm);
        }
        
        private async Task Show_MDI_Pizzas()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiProducts.GetPizzas();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Sandwich()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiProducts.GetSandwichs();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Salad()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiProducts.GetSalad();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Appetizer()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiProducts.GetAppetizer();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Soda()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiProducts.GetSoda();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_Dessert()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiProducts.GetDessert();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }

        private async Task Show_MDI_All_Products()
        {
            var frm = Program.NinjectKernel.Get<formShowData>();
            var list = await Task.Run(async () =>
            {
                return await _apiProducts.GetAllProducts();
            });
            frm.AddDataToDataGridView(list);
            AddFormToPanel(frm);
        }
        
        #endregion
        #region MDI Ingredient
        private async Task Show_MDI_NewIngredient()
        {
            throw new NotImplementedException();
        }
        #endregion
    }


}
