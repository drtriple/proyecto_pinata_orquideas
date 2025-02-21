namespace main_pinata_orquideas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVDocena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.grpAPagar = new System.Windows.Forms.GroupBox();
            this.lblSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPorcDscto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVrDscto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVrIVA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotAPag = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.grpDetalles.SuspendLayout();
            this.grpAPagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Piñata las Orquídeas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.label2);
            this.grpDetalles.Controls.Add(this.cmbProducto);
            this.grpDetalles.Controls.Add(this.label5);
            this.grpDetalles.Controls.Add(this.txtVDocena);
            this.grpDetalles.Controls.Add(this.label4);
            this.grpDetalles.Controls.Add(this.txtCant);
            this.grpDetalles.Controls.Add(this.label3);
            this.grpDetalles.Controls.Add(this.txtIVA);
            this.grpDetalles.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.grpDetalles.Location = new System.Drawing.Point(20, 90);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(380, 270);
            this.grpDetalles.TabIndex = 1;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles del Pedido";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Producto:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(150, 40);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(200, 26);
            this.cmbProducto.TabIndex = 1;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vr. Docena:";
            // 
            // txtVDocena
            // 
            this.txtVDocena.Font = new System.Drawing.Font("Arial", 12F);
            this.txtVDocena.Location = new System.Drawing.Point(150, 90);
            this.txtVDocena.Name = "txtVDocena";
            this.txtVDocena.ReadOnly = true;
            this.txtVDocena.Size = new System.Drawing.Size(200, 26);
            this.txtVDocena.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad:";
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCant.Location = new System.Drawing.Point(150, 140);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(200, 26);
            this.txtCant.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(20, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "% IVA:";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIVA.Location = new System.Drawing.Point(150, 190);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(200, 26);
            this.txtIVA.TabIndex = 7;
            // 
            // grpAPagar
            // 
            this.grpAPagar.Controls.Add(this.lblSubtotal);
            this.grpAPagar.Controls.Add(this.label6);
            this.grpAPagar.Controls.Add(this.lblPorcDscto);
            this.grpAPagar.Controls.Add(this.label7);
            this.grpAPagar.Controls.Add(this.lblVrDscto);
            this.grpAPagar.Controls.Add(this.label8);
            this.grpAPagar.Controls.Add(this.lblVrIVA);
            this.grpAPagar.Controls.Add(this.label9);
            this.grpAPagar.Controls.Add(this.lblTotAPag);
            this.grpAPagar.Controls.Add(this.label10);
            this.grpAPagar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.grpAPagar.Location = new System.Drawing.Point(20, 420);
            this.grpAPagar.Name = "grpAPagar";
            this.grpAPagar.Size = new System.Drawing.Size(380, 253);
            this.grpAPagar.TabIndex = 5;
            this.grpAPagar.TabStop = false;
            this.grpAPagar.Text = "A Pagar";
            this.grpAPagar.Visible = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Enabled = false;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSubtotal.Location = new System.Drawing.Point(140, 39);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(200, 26);
            this.lblSubtotal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Subtotal: ";
            // 
            // lblPorcDscto
            // 
            this.lblPorcDscto.Enabled = false;
            this.lblPorcDscto.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPorcDscto.Location = new System.Drawing.Point(140, 122);
            this.lblPorcDscto.Name = "lblPorcDscto";
            this.lblPorcDscto.Size = new System.Drawing.Size(200, 26);
            this.lblPorcDscto.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(20, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Porc. Dscto: ";
            // 
            // lblVrDscto
            // 
            this.lblVrDscto.Enabled = false;
            this.lblVrDscto.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVrDscto.Location = new System.Drawing.Point(140, 81);
            this.lblVrDscto.Name = "lblVrDscto";
            this.lblVrDscto.Size = new System.Drawing.Size(200, 26);
            this.lblVrDscto.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Valor Dsco: ";
            // 
            // lblVrIVA
            // 
            this.lblVrIVA.Enabled = false;
            this.lblVrIVA.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVrIVA.Location = new System.Drawing.Point(140, 163);
            this.lblVrIVA.Name = "lblVrIVA";
            this.lblVrIVA.Size = new System.Drawing.Size(200, 26);
            this.lblVrIVA.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(20, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Vr. IVA: ";
            // 
            // lblTotAPag
            // 
            this.lblTotAPag.Enabled = false;
            this.lblTotAPag.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTotAPag.Location = new System.Drawing.Point(140, 203);
            this.lblTotAPag.Name = "lblTotAPag";
            this.lblTotAPag.Size = new System.Drawing.Size(200, 26);
            this.lblTotAPag.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(20, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total A Pagar: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(50, 380);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(160, 380);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 23);
            this.btnFacturar.TabIndex = 3;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(270, 380);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 4;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(424, 685);
            this.Controls.Add(this.grpAPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnTerminar);
            this.Name = "Form1";
            this.Text = "Práctica 1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.grpAPagar.ResumeLayout(false);
            this.grpAPagar.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7, label8, label9, label10;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.TextBox txtVDocena, txtCant, txtIVA;
        private System.Windows.Forms.Button btnLimpiar, btnFacturar, btnTerminar;
        private System.Windows.Forms.GroupBox grpDetalles;

        private System.Windows.Forms.GroupBox grpAPagar;
        private System.Windows.Forms.TextBox lblSubtotal, lblPorcDscto, lblVrDscto, lblVrIVA, lblTotAPag;
    }
}

