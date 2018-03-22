namespace PizzON
{
    partial class formEdit
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
            this.btnTitle = new System.Windows.Forms.Label();
            this.dataGridViewElegir = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElegir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTitle
            // 
            this.btnTitle.AutoSize = true;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.Location = new System.Drawing.Point(218, 9);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(50, 18);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.Text = "Titulo";
            // 
            // dataGridViewElegir
            // 
            this.dataGridViewElegir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewElegir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElegir.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewElegir.Name = "dataGridViewElegir";
            this.dataGridViewElegir.Size = new System.Drawing.Size(476, 519);
            this.dataGridViewElegir.TabIndex = 1;
            this.dataGridViewElegir.Click += new System.EventHandler(this.dataGridViewElegir_Click);
            // 
            // formEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 580);
            this.Controls.Add(this.dataGridViewElegir);
            this.Controls.Add(this.btnTitle);
            this.Name = "formEdit";
            this.Text = "formEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElegir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnTitle;
        private System.Windows.Forms.DataGridView dataGridViewElegir;
    }
}