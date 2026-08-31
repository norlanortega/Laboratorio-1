namespace Discount
{
    partial class Form1
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
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblDescuentoP = new System.Windows.Forms.Label();
            this.lblVentaFinal = new System.Windows.Forms.Label();
            this.txtValorV = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtDescuentoP = new System.Windows.Forms.TextBox();
            this.txtVentaFinal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(267, 100);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(89, 20);
            this.lblValorVenta.TabIndex = 0;
            this.lblValorVenta.Text = "Valor venta";
            this.lblValorVenta.Click += new System.EventHandler(this.lblValorVenta_Click);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(267, 156);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(100, 20);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento $";
            this.lblDescuento.Click += new System.EventHandler(this.lblDescuento_Click);
            // 
            // lblDescuentoP
            // 
            this.lblDescuentoP.AutoSize = true;
            this.lblDescuentoP.Location = new System.Drawing.Point(266, 196);
            this.lblDescuentoP.Name = "lblDescuentoP";
            this.lblDescuentoP.Size = new System.Drawing.Size(105, 20);
            this.lblDescuentoP.TabIndex = 2;
            this.lblDescuentoP.Text = "Descuento %";
            this.lblDescuentoP.Click += new System.EventHandler(this.lblDescuentoP_Click);
            // 
            // lblVentaFinal
            // 
            this.lblVentaFinal.AutoSize = true;
            this.lblVentaFinal.Location = new System.Drawing.Point(267, 235);
            this.lblVentaFinal.Name = "lblVentaFinal";
            this.lblVentaFinal.Size = new System.Drawing.Size(90, 20);
            this.lblVentaFinal.TabIndex = 3;
            this.lblVentaFinal.Text = "Venta Final";
            this.lblVentaFinal.Click += new System.EventHandler(this.lblVentaFinal_Click);
            // 
            // txtValorV
            // 
            this.txtValorV.Location = new System.Drawing.Point(390, 97);
            this.txtValorV.Name = "txtValorV";
            this.txtValorV.Size = new System.Drawing.Size(100, 26);
            this.txtValorV.TabIndex = 4;
            this.txtValorV.TextChanged += new System.EventHandler(this.txtValorV_TextChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(390, 156);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 26);
            this.txtDescuento.TabIndex = 5;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // txtDescuentoP
            // 
            this.txtDescuentoP.Location = new System.Drawing.Point(390, 193);
            this.txtDescuentoP.Name = "txtDescuentoP";
            this.txtDescuentoP.Size = new System.Drawing.Size(100, 26);
            this.txtDescuentoP.TabIndex = 6;
            this.txtDescuentoP.TextChanged += new System.EventHandler(this.txtDescuentoP_TextChanged);
            // 
            // txtVentaFinal
            // 
            this.txtVentaFinal.Location = new System.Drawing.Point(390, 241);
            this.txtVentaFinal.Name = "txtVentaFinal";
            this.txtVentaFinal.Size = new System.Drawing.Size(100, 26);
            this.txtVentaFinal.TabIndex = 7;
            this.txtVentaFinal.TextChanged += new System.EventHandler(this.txtVentaFinal_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1059, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 62);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(567, 100);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 38);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(567, 150);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 38);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(567, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 38);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Sallir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVentaFinal);
            this.Controls.Add(this.txtDescuentoP);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtValorV);
            this.Controls.Add(this.lblVentaFinal);
            this.Controls.Add(this.lblDescuentoP);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblValorVenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblDescuentoP;
        private System.Windows.Forms.Label lblVentaFinal;
        private System.Windows.Forms.TextBox txtValorV;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtDescuentoP;
        private System.Windows.Forms.TextBox txtVentaFinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

