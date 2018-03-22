namespace PizzON
{
    partial class formBoss
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBoss));
            this.panelMDI = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnIngredients = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMDI
            // 
            this.panelMDI.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMDI.Location = new System.Drawing.Point(203, 0);
            this.panelMDI.Name = "panelMDI";
            this.panelMDI.Size = new System.Drawing.Size(516, 619);
            this.panelMDI.TabIndex = 1;
            this.panelMDI.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMDI_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(232, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 351);
            this.panel1.TabIndex = 2;
            // 
            // flowPanel
            // 
            this.flowPanel.BackColor = System.Drawing.Color.Blue;
            this.flowPanel.Controls.Add(this.btnUsers);
            this.flowPanel.Controls.Add(this.btnEmployees);
            this.flowPanel.Controls.Add(this.btnProducts);
            this.flowPanel.Controls.Add(this.btnIngredients);
            this.flowPanel.Controls.Add(this.btnClose);
            this.flowPanel.Controls.Add(this.btnExit);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowPanel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(200, 619);
            this.flowPanel.TabIndex = 2;
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = global::PizzON.Properties.Resources.User;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(3, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(194, 116);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "      Usuarios";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployees.Image = global::PizzON.Properties.Resources.Employees;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(3, 125);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(194, 113);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "      Empleados";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(3, 244);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(194, 113);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "      Productos";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnIngredients
            // 
            this.btnIngredients.FlatAppearance.BorderSize = 0;
            this.btnIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngredients.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredients.Image = ((System.Drawing.Image)(resources.GetObject("btnIngredients.Image")));
            this.btnIngredients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngredients.Location = new System.Drawing.Point(3, 363);
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.Size = new System.Drawing.Size(194, 113);
            this.btnIngredients.TabIndex = 0;
            this.btnIngredients.Text = "      Ingredientes";
            this.btnIngredients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngredients.UseVisualStyleBackColor = true;
            this.btnIngredients.Click += new System.EventHandler(this.btnIngredients_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(3, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(194, 56);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "      Cerrar        Sesión";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(3, 544);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(199, 75);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "   Salir";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formBoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 619);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.panelMDI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formBoss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formJefe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formBoss_FormClosed);
            this.Load += new System.EventHandler(this.formBoss_Load);
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panelMDI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnIngredients;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExit;
    }
}