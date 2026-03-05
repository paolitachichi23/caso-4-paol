namespace caso_4_paol
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaFact = new System.Windows.Forms.TextBox();
            this.txtMontoFact = new System.Windows.Forms.TextBox();
            this.lvFacturas = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalFact = new System.Windows.Forms.Label();
            this.lblTotalSub = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENDEDOR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° FACTURA";
            // 
            // txtNumFact
            // 
            this.txtNumFact.Location = new System.Drawing.Point(129, 110);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.Size = new System.Drawing.Size(200, 20);
            this.txtNumFact.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(338, 120);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(75, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "FECHA FACT.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "MONTO FACT.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFechaFact
            // 
            this.txtFechaFact.Location = new System.Drawing.Point(419, 113);
            this.txtFechaFact.Name = "txtFechaFact";
            this.txtFechaFact.Size = new System.Drawing.Size(104, 20);
            this.txtFechaFact.TabIndex = 6;
            // 
            // txtMontoFact
            // 
            this.txtMontoFact.Location = new System.Drawing.Point(129, 166);
            this.txtMontoFact.Name = "txtMontoFact";
            this.txtMontoFact.Size = new System.Drawing.Size(200, 20);
            this.txtMontoFact.TabIndex = 7;
            // 
            // lvFacturas
            // 
            this.lvFacturas.HideSelection = false;
            this.lvFacturas.Location = new System.Drawing.Point(129, 207);
            this.lvFacturas.Name = "lvFacturas";
            this.lvFacturas.Size = new System.Drawing.Size(487, 152);
            this.lvFacturas.TabIndex = 8;
            this.lvFacturas.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "MONTO ASIGANDOS AL VENDEDOR POR EL GERISTRO DE FACTURAS\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "NUM FACTURA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "FECHA DE FACTURACION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "MONTO FACTURADO\r\n";
            // 
            // lblTotalFact
            // 
            this.lblTotalFact.AutoSize = true;
            this.lblTotalFact.Location = new System.Drawing.Point(126, 410);
            this.lblTotalFact.Name = "lblTotalFact";
            this.lblTotalFact.Size = new System.Drawing.Size(95, 13);
            this.lblTotalFact.TabIndex = 13;
            this.lblTotalFact.Text = "TOTAL FACTURA\r\n";
            // 
            // lblTotalSub
            // 
            this.lblTotalSub.AutoSize = true;
            this.lblTotalSub.Location = new System.Drawing.Point(299, 410);
            this.lblTotalSub.Name = "lblTotalSub";
            this.lblTotalSub.Size = new System.Drawing.Size(102, 13);
            this.lblTotalSub.TabIndex = 14;
            this.lblTotalSub.Text = "TOTAL SUBTOTAL";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(456, 410);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(118, 13);
            this.lblComision.TabIndex = 15;
            this.lblComision.Text = "COMISION ASIGNADA";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(422, 166);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(527, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(541, 55);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 13);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "FECHA ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblTotalSub);
            this.Controls.Add(this.lblTotalFact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvFacturas);
            this.Controls.Add(this.txtMontoFact);
            this.Controls.Add(this.txtFechaFact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtNumFact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFact;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaFact;
        private System.Windows.Forms.TextBox txtMontoFact;
        private System.Windows.Forms.ListView lvFacturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalFact;
        private System.Windows.Forms.Label lblTotalSub;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFecha;
    }
}

