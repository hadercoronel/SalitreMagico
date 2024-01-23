namespace salitreMagico
{
    partial class RegistrarPasaporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioRegular = new System.Windows.Forms.TextBox();
            this.cboxTipoPasaporte = new System.Windows.Forms.ComboBox();
            this.cboxFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.cboxEstacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdVendedor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Pasaporte:";
            // 
            // txtPrecioRegular
            // 
            this.txtPrecioRegular.BackColor = System.Drawing.Color.White;
            this.txtPrecioRegular.Enabled = false;
            this.txtPrecioRegular.Location = new System.Drawing.Point(41, 194);
            this.txtPrecioRegular.Name = "txtPrecioRegular";
            this.txtPrecioRegular.ReadOnly = true;
            this.txtPrecioRegular.Size = new System.Drawing.Size(152, 20);
            this.txtPrecioRegular.TabIndex = 1;
            // 
            // cboxTipoPasaporte
            // 
            this.cboxTipoPasaporte.FormattingEnabled = true;
            this.cboxTipoPasaporte.Location = new System.Drawing.Point(41, 99);
            this.cboxTipoPasaporte.Name = "cboxTipoPasaporte";
            this.cboxTipoPasaporte.Size = new System.Drawing.Size(152, 21);
            this.cboxTipoPasaporte.TabIndex = 2;
            this.cboxTipoPasaporte.SelectedIndexChanged += new System.EventHandler(this.cboxTipoPasaporte_SelectedIndexChanged);
            // 
            // cboxFecha
            // 
            this.cboxFecha.Location = new System.Drawing.Point(223, 100);
            this.cboxFecha.Name = "cboxFecha";
            this.cboxFecha.Size = new System.Drawing.Size(200, 20);
            this.cboxFecha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio regular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID del cliente:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(41, 237);
            this.txtIdCliente.MaxLength = 11;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(152, 20);
            this.txtIdCliente.TabIndex = 9;
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCliente_KeyPress);
            // 
            // cboxEstacion
            // 
            this.cboxEstacion.FormattingEnabled = true;
            this.cboxEstacion.Location = new System.Drawing.Point(41, 148);
            this.cboxEstacion.Name = "cboxEstacion";
            this.cboxEstacion.Size = new System.Drawing.Size(152, 21);
            this.cboxEstacion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nro Estacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado:";
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Location = new System.Drawing.Point(223, 148);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(200, 21);
            this.cboxEstado.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(142, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 41);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pasaporte";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnComprar.Location = new System.Drawing.Point(177, 328);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(120, 29);
            this.btnComprar.TabIndex = 17;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "ID vendedor:";
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.BackColor = System.Drawing.Color.White;
            this.txtIdVendedor.Enabled = false;
            this.txtIdVendedor.Location = new System.Drawing.Point(43, 280);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Size = new System.Drawing.Size(152, 20);
            this.txtIdVendedor.TabIndex = 19;
            this.txtIdVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdVendedor_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(223, 200);
            this.txtDescripcion.MaxLength = 300;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(200, 100);
            this.txtDescripcion.TabIndex = 20;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(303, 328);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 29);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // RegistrarPasaporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 369);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdVendedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboxEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxEstacion);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxFecha);
            this.Controls.Add(this.cboxTipoPasaporte);
            this.Controls.Add(this.txtPrecioRegular);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarPasaporte";
            this.Text = "Pasaporte";
            this.Load += new System.EventHandler(this.Pasaporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioRegular;
        private System.Windows.Forms.ComboBox cboxTipoPasaporte;
        private System.Windows.Forms.DateTimePicker cboxFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.ComboBox cboxEstacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdVendedor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCerrar;
    }
}