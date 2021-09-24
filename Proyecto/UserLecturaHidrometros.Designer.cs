namespace GUI
{
    partial class UserLecturaHidrometros
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxNisLectura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.boxLectura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textLecturaAnterior = new System.Windows.Forms.TextBox();
            this.btnLectura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNisLectura
            // 
            this.comboBoxNisLectura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNisLectura.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.comboBoxNisLectura.FormattingEnabled = true;
            this.comboBoxNisLectura.Location = new System.Drawing.Point(249, 70);
            this.comboBoxNisLectura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxNisLectura.Name = "comboBoxNisLectura";
            this.comboBoxNisLectura.Size = new System.Drawing.Size(199, 38);
            this.comboBoxNisLectura.TabIndex = 20;
            this.comboBoxNisLectura.SelectedIndexChanged += new System.EventHandler(this.comboBoxNisLectura_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(180, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "NIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(180, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mes";
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMes.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Location = new System.Drawing.Point(249, 124);
            this.comboBoxMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(96, 38);
            this.comboBoxMes.TabIndex = 24;
            this.comboBoxMes.SelectedIndexChanged += new System.EventHandler(this.comboBoxMes_SelectedIndexChanged);
            // 
            // boxLectura
            // 
            this.boxLectura.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.boxLectura.Location = new System.Drawing.Point(249, 172);
            this.boxLectura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxLectura.Name = "boxLectura";
            this.boxLectura.Size = new System.Drawing.Size(96, 36);
            this.boxLectura.TabIndex = 25;
            this.boxLectura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxLectura_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(180, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Lectura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(353, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "m3";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(184, 309);
            this.calendario.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(180, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fecha lectura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(421, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "m3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(180, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Lectura mes anterior";
            // 
            // textLecturaAnterior
            // 
            this.textLecturaAnterior.Enabled = false;
            this.textLecturaAnterior.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.textLecturaAnterior.Location = new System.Drawing.Point(341, 218);
            this.textLecturaAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textLecturaAnterior.Name = "textLecturaAnterior";
            this.textLecturaAnterior.ReadOnly = true;
            this.textLecturaAnterior.Size = new System.Drawing.Size(72, 36);
            this.textLecturaAnterior.TabIndex = 30;
            // 
            // btnLectura
            // 
            this.btnLectura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.btnLectura.FlatAppearance.BorderSize = 0;
            this.btnLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLectura.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnLectura.Image = global::GUI.Properties.Resources.icono_agregar_lectura;
            this.btnLectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLectura.Location = new System.Drawing.Point(594, 407);
            this.btnLectura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLectura.Name = "btnLectura";
            this.btnLectura.Size = new System.Drawing.Size(301, 64);
            this.btnLectura.TabIndex = 22;
            this.btnLectura.Text = "Registrar categoria de servicio";
            this.btnLectura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLectura.UseVisualStyleBackColor = false;
            this.btnLectura.Click += new System.EventHandler(this.btnLectura_Click);
            // 
            // UserLecturaHidrometros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.textLecturaAnterior);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxLectura);
            this.Controls.Add(this.comboBoxMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLectura);
            this.Controls.Add(this.comboBoxNisLectura);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserLecturaHidrometros";
            this.Size = new System.Drawing.Size(950, 571);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNisLectura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLectura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.TextBox boxLectura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textLecturaAnterior;
    }
}
