namespace PizzON
{
    partial class formNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNewUser));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbLength = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProviderNewUser = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(171, 131);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(162, 26);
            this.txtUser.TabIndex = 0;
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(171, 190);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(167, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(167, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar contraseña:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(171, 246);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(162, 26);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(356, 464);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(132, 104);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.BackgroundImage")));
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndo.Location = new System.Drawing.Point(12, 12);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(87, 87);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Empleado",
            "Jefe"});
            this.cbRol.Location = new System.Drawing.Point(171, 299);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(162, 28);
            this.cbRol.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(168, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 468);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 100);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLength.ForeColor = System.Drawing.Color.Red;
            this.lbLength.Location = new System.Drawing.Point(182, 369);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(138, 20);
            this.lbLength.TabIndex = 11;
            this.lbLength.Text = "Longitud mínima 8";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUpper.ForeColor = System.Drawing.Color.Red;
            this.lblUpper.Location = new System.Drawing.Point(186, 395);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(125, 20);
            this.lblUpper.TabIndex = 12;
            this.lblUpper.Text = "Letra mayúscula";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblChar.ForeColor = System.Drawing.Color.Red;
            this.lblChar.Location = new System.Drawing.Point(190, 423);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(122, 20);
            this.lblChar.TabIndex = 13;
            this.lblChar.Text = "Uso un carácter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Criterios mínimos contraseña:";
            // 
            // errorProviderNewUser
            // 
            this.errorProviderNewUser.ContainerControl = this;
            // 
            // formNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formNewUser";
            this.Text = "Nuevo usuario";
            this.Load += new System.EventHandler(this.formNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProviderNewUser;
    }
}