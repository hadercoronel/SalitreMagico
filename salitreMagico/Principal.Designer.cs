namespace salitreMagico
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.ingresarParqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.ingresarParqueToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.registrarPasaporteToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // registrarPasaporteToolStripMenuItem
            // 
            this.registrarPasaporteToolStripMenuItem.Name = "registrarPasaporteToolStripMenuItem";
            this.registrarPasaporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarPasaporteToolStripMenuItem.Text = "Registrar Pasaporte";
            this.registrarPasaporteToolStripMenuItem.Click += new System.EventHandler(this.registrarPasaporteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(78, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salitre Magico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenidos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(330, 5);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(0, 18);
            this.lblNombreUsuario.TabIndex = 3;
            // 
            // ingresarParqueToolStripMenuItem
            // 
            this.ingresarParqueToolStripMenuItem.Name = "ingresarParqueToolStripMenuItem";
            this.ingresarParqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarParqueToolStripMenuItem.Text = "Ingresar Parque";
            this.ingresarParqueToolStripMenuItem.Click += new System.EventHandler(this.ingresarParqueToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 271);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPasaporteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem ingresarParqueToolStripMenuItem;
    }
}