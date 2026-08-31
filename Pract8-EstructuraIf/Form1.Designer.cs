namespace Pract8_EstructuraIf
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.rdbSumar = new System.Windows.Forms.RadioButton();
            this.rdbRestar = new System.Windows.Forms.RadioButton();
            this.rdbMulti = new System.Windows.Forms.RadioButton();
            this.rdbDivision = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDivision);
            this.groupBox1.Controls.Add(this.rdbMulti);
            this.groupBox1.Controls.Add(this.rdbRestar);
            this.groupBox1.Controls.Add(this.rdbSumar);
            this.groupBox1.Location = new System.Drawing.Point(549, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(450, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(623, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(806, 64);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(98, 26);
            this.txtResult.TabIndex = 3;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresa los valores y selecciona una opción ";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(751, 70);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(18, 20);
            this.lblIgual.TabIndex = 5;
            this.lblIgual.Text = "=";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(576, 70);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(0, 20);
            this.lblOperacion.TabIndex = 6;
            this.lblOperacion.Click += new System.EventHandler(this.lblOperacion_Click);
            // 
            // rdbSumar
            // 
            this.rdbSumar.AutoSize = true;
            this.rdbSumar.Location = new System.Drawing.Point(13, 46);
            this.rdbSumar.Name = "rdbSumar";
            this.rdbSumar.Size = new System.Drawing.Size(81, 24);
            this.rdbSumar.TabIndex = 0;
            this.rdbSumar.TabStop = true;
            this.rdbSumar.Text = "Sumar";
            this.rdbSumar.UseVisualStyleBackColor = true;
            this.rdbSumar.CheckedChanged += new System.EventHandler(this.rdbSumar_CheckedChanged);
            // 
            // rdbRestar
            // 
            this.rdbRestar.AutoSize = true;
            this.rdbRestar.Location = new System.Drawing.Point(13, 76);
            this.rdbRestar.Name = "rdbRestar";
            this.rdbRestar.Size = new System.Drawing.Size(77, 24);
            this.rdbRestar.TabIndex = 7;
            this.rdbRestar.TabStop = true;
            this.rdbRestar.Text = "Resta";
            this.rdbRestar.UseVisualStyleBackColor = true;
            this.rdbRestar.CheckedChanged += new System.EventHandler(this.rdbRestar_CheckedChanged);
            // 
            // rdbMulti
            // 
            this.rdbMulti.AutoSize = true;
            this.rdbMulti.Location = new System.Drawing.Point(13, 106);
            this.rdbMulti.Name = "rdbMulti";
            this.rdbMulti.Size = new System.Drawing.Size(128, 24);
            this.rdbMulti.TabIndex = 8;
            this.rdbMulti.TabStop = true;
            this.rdbMulti.Text = "Multiplicación";
            this.rdbMulti.UseVisualStyleBackColor = true;
            this.rdbMulti.CheckedChanged += new System.EventHandler(this.rdbMulti_CheckedChanged);
            // 
            // rdbDivision
            // 
            this.rdbDivision.AutoSize = true;
            this.rdbDivision.Location = new System.Drawing.Point(13, 140);
            this.rdbDivision.Name = "rdbDivision";
            this.rdbDivision.Size = new System.Drawing.Size(88, 24);
            this.rdbDivision.TabIndex = 9;
            this.rdbDivision.TabStop = true;
            this.rdbDivision.Text = "División";
            this.rdbDivision.UseVisualStyleBackColor = true;
            this.rdbDivision.CheckedChanged += new System.EventHandler(this.rdbDivision_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 450);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.RadioButton rdbDivision;
        private System.Windows.Forms.RadioButton rdbMulti;
        private System.Windows.Forms.RadioButton rdbRestar;
        private System.Windows.Forms.RadioButton rdbSumar;
    }
}

