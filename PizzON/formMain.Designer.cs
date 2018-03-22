namespace PizzON
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNrPedido = new System.Windows.Forms.Label();
            this.btnPizza = new System.Windows.Forms.Button();
            this.bttnBocata = new System.Windows.Forms.Button();
            this.btnRefresco = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.lvDetallesPedido = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido:";
            // 
            // lblNrPedido
            // 
            this.lblNrPedido.AutoSize = true;
            this.lblNrPedido.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrPedido.Location = new System.Drawing.Point(269, 9);
            this.lblNrPedido.Name = "lblNrPedido";
            this.lblNrPedido.Size = new System.Drawing.Size(23, 25);
            this.lblNrPedido.TabIndex = 1;
            this.lblNrPedido.Text = "0";
            // 
            // btnPizza
            // 
            this.btnPizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPizza.BackgroundImage")));
            this.btnPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPizza.Location = new System.Drawing.Point(29, 70);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(147, 122);
            this.btnPizza.TabIndex = 2;
            this.btnPizza.UseVisualStyleBackColor = true;
            // 
            // bttnBocata
            // 
            this.bttnBocata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnBocata.BackgroundImage")));
            this.bttnBocata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnBocata.Location = new System.Drawing.Point(193, 70);
            this.bttnBocata.Name = "bttnBocata";
            this.bttnBocata.Size = new System.Drawing.Size(147, 122);
            this.bttnBocata.TabIndex = 3;
            this.bttnBocata.UseVisualStyleBackColor = true;
            // 
            // btnRefresco
            // 
            this.btnRefresco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresco.BackgroundImage")));
            this.btnRefresco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresco.Location = new System.Drawing.Point(193, 207);
            this.btnRefresco.Name = "btnRefresco";
            this.btnRefresco.Size = new System.Drawing.Size(147, 122);
            this.btnRefresco.TabIndex = 4;
            this.btnRefresco.UseVisualStyleBackColor = true;
            // 
            // btnPasta
            // 
            this.btnPasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasta.BackgroundImage")));
            this.btnPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasta.Location = new System.Drawing.Point(29, 207);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(147, 122);
            this.btnPasta.TabIndex = 5;
            this.btnPasta.UseVisualStyleBackColor = true;
            // 
            // lvDetallesPedido
            // 
            this.lvDetallesPedido.Location = new System.Drawing.Point(473, 70);
            this.lvDetallesPedido.Name = "lvDetallesPedido";
            this.lvDetallesPedido.Size = new System.Drawing.Size(133, 427);
            this.lvDetallesPedido.TabIndex = 6;
            this.lvDetallesPedido.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalles del pedido:";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvDetallesPedido);
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.btnRefresco);
            this.Controls.Add(this.bttnBocata);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.lblNrPedido);
            this.Controls.Add(this.label1);
            this.Name = "formMain";
            this.Text = "formPrincipal";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNrPedido;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button bttnBocata;
        private System.Windows.Forms.Button btnRefresco;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.ListView lvDetallesPedido;
        private System.Windows.Forms.Label label2;
    }
}