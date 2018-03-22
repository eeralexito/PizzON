namespace PizzON.Products
{
    partial class formNewProduct
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
            this.components = new System.ComponentModel.Container();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.btnChoseIngredient = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.toolTipProducts = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderProducts = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 478);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 104);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(356, 478);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(132, 104);
            this.btnCreate.TabIndex = 36;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(12, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 23);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtNombre.Location = new System.Drawing.Point(94, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(394, 26);
            this.txtNombre.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Categoría:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ingredientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Precio:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBox2.Location = new System.Drawing.Point(127, 124);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 159);
            this.textBox2.TabIndex = 42;
            // 
            // txtCategoria
            // 
            this.txtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoria.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Items.AddRange(new object[] {
            "PIZZA",
            "BOCATA",
            "PASTA",
            "ENSALADA",
            "ENTRANTE",
            "REFRESCO",
            "POSTRE"});
            this.txtCategoria.Location = new System.Drawing.Point(105, 4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(125, 28);
            this.txtCategoria.TabIndex = 44;
            this.txtCategoria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCategoria_KeyUp);
            this.txtCategoria.MouseHover += new System.EventHandler(this.txtCategoria_MouseHover);
            // 
            // btnChoseIngredient
            // 
            this.btnChoseIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnChoseIngredient.Location = new System.Drawing.Point(314, 124);
            this.btnChoseIngredient.Name = "btnChoseIngredient";
            this.btnChoseIngredient.Size = new System.Drawing.Size(156, 159);
            this.btnChoseIngredient.TabIndex = 45;
            this.btnChoseIngredient.Text = "Añadir Ingrediente";
            this.btnChoseIngredient.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtPrecio.Location = new System.Drawing.Point(80, 327);
            this.txtPrecio.Mask = "99.99";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(41, 26);
            this.txtPrecio.TabIndex = 46;
            this.txtPrecio.ValidatingType = typeof(System.DateTime);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCat.Location = new System.Drawing.Point(248, 4);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(168, 32);
            this.btnAddCat.TabIndex = 47;
            this.btnAddCat.Text = "Añadir Categoría";
            this.toolTipProducts.SetToolTip(this.btnAddCat, "Pulse para introducir una nueva categoría");
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            this.btnAddCat.MouseHover += new System.EventHandler(this.btnAddCat_MouseHover);
            // 
            // errorProviderProducts
            // 
            this.errorProviderProducts.ContainerControl = this;
            // 
            // formNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 594);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnChoseIngredient);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblName);
            this.Name = "formNewProduct";
            this.Text = "formNewProduct";
            this.Load += new System.EventHandler(this.formNewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox txtCategoria;
        private System.Windows.Forms.Button btnChoseIngredient;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.ToolTip toolTipProducts;
        private System.Windows.Forms.ErrorProvider errorProviderProducts;
    }
}