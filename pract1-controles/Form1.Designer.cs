namespace pract1_controles
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
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblThedateIs = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(248, 83);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(33, 20);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Dia";
            this.lblDay.Click += new System.EventHandler(this.lblDay_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(252, 166);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(39, 20);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Mes";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(229, 267);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 20);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "año";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(471, 360);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 62);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(573, 360);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 43);
            this.btnOut.TabIndex = 4;
            this.btnOut.Text = "salir";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lblThedateIs
            // 
            this.lblThedateIs.AutoSize = true;
            this.lblThedateIs.Location = new System.Drawing.Point(657, 115);
            this.lblThedateIs.Name = "lblThedateIs";
            this.lblThedateIs.Size = new System.Drawing.Size(86, 20);
            this.lblThedateIs.TabIndex = 5;
            this.lblThedateIs.Text = "la fecha es";
            this.lblThedateIs.Click += new System.EventHandler(this.lblThedateIs_Click);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(359, 83);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 26);
            this.txtDay.TabIndex = 6;
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(359, 160);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 26);
            this.txtMonth.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(345, 267);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 26);
            this.txtYear.TabIndex = 8;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1289, 559);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblThedateIs);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblDay);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblLaFechaEs;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblThedateIs;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
    }
}

