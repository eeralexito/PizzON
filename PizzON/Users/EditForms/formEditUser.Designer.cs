namespace PizzON.EditForms
{
    partial class formEditUser
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
            this.btnRol = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRol
            // 
            this.btnRol.Location = new System.Drawing.Point(12, 47);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(79, 36);
            this.btnRol.TabIndex = 0;
            this.btnRol.Text = "Tipo de usuario";
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(157, 47);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(75, 36);
            this.btnPassword.TabIndex = 1;
            this.btnPassword.Text = "Contraseña";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elige que desea modificar";
            // 
            // formEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 95);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnRol);
            this.Name = "formEditUser";
            this.Text = "formEditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label label1;
    }
}