namespace PizzON
{
    partial class formNewEmployee
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
            this.txtTypeID = new System.Windows.Forms.ComboBox();
            this.lblSS = new System.Windows.Forms.Label();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTypeEmployee = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtSS = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.txtSurname = new System.Windows.Forms.MaskedTextBox();
            this.txtTypeEmployee = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTypeID
            // 
            this.txtTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTypeID.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtTypeID.FormattingEnabled = true;
            this.txtTypeID.Items.AddRange(new object[] {
            "DNI",
            "NIE"});
            this.txtTypeID.Location = new System.Drawing.Point(272, 91);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(83, 28);
            this.txtTypeID.TabIndex = 1;
            this.txtTypeID.TextChanged += new System.EventHandler(this.txtTypeID_TextChanged);
            this.txtTypeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTypeID_KeyDown);
            this.txtTypeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTypeID_KeyUp);
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.lblSS.Location = new System.Drawing.Point(32, 56);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(214, 23);
            this.lblSS.TabIndex = 1;
            this.lblSS.Text = "Número Seguridad Social:";
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTypeID.Location = new System.Drawing.Point(32, 91);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(163, 23);
            this.lblTypeID.TabIndex = 2;
            this.lblTypeID.Text = "Tipo Identificación:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(32, 127);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(211, 23);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Número de Identificación:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(32, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.lblSurname.Location = new System.Drawing.Point(32, 224);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(89, 23);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Apellidos:";
            // 
            // lblTypeEmployee
            // 
            this.lblTypeEmployee.AutoSize = true;
            this.lblTypeEmployee.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTypeEmployee.Location = new System.Drawing.Point(32, 159);
            this.lblTypeEmployee.Name = "lblTypeEmployee";
            this.lblTypeEmployee.Size = new System.Drawing.Size(133, 23);
            this.lblTypeEmployee.TabIndex = 6;
            this.lblTypeEmployee.Text = "Tipo Empleado:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(32, 260);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(81, 23);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Teléfono:";
            // 
            // txtSS
            // 
            this.txtSS.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSS.Location = new System.Drawing.Point(272, 56);
            this.txtSS.Mask = "99999999999";
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(83, 26);
            this.txtSS.TabIndex = 0;
            this.txtSS.ValidatingType = typeof(int);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtID.Location = new System.Drawing.Point(272, 127);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(83, 26);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtName.Location = new System.Drawing.Point(272, 192);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(107, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtSurname.Location = new System.Drawing.Point(272, 224);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(107, 26);
            this.txtSurname.TabIndex = 5;
            // 
            // txtTypeEmployee
            // 
            this.txtTypeEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTypeEmployee.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtTypeEmployee.FormattingEnabled = true;
            this.txtTypeEmployee.Items.AddRange(new object[] {
            "Cocinero/a",
            "Camaerero/a",
            "Recepcionista",
            "Repartidor/a"});
            this.txtTypeEmployee.Location = new System.Drawing.Point(272, 159);
            this.txtTypeEmployee.Name = "txtTypeEmployee";
            this.txtTypeEmployee.Size = new System.Drawing.Size(107, 28);
            this.txtTypeEmployee.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtPhone.Location = new System.Drawing.Point(272, 260);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(107, 26);
            this.txtPhone.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(32, 291);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(84, 23);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtAddress.Location = new System.Drawing.Point(272, 295);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(83, 59);
            this.txtAddress.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(356, 478);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(132, 104);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 478);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 104);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // formNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 594);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTypeEmployee);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTypeEmployee);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTypeID);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.txtTypeID);
            this.Name = "formNewEmployee";
            this.Text = "NewEmployee";
            this.Load += new System.EventHandler(this.formNewEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtTypeID;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblTypeEmployee;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox txtSS;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtSurname;
        private System.Windows.Forms.ComboBox txtTypeEmployee;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
    }
}