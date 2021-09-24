namespace CLIENTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textNis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMeses = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.textIva = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.texTotal = new System.Windows.Forms.TextBox();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textConsumo = new System.Windows.Forms.TextBox();
            this.textLectura = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNis
            // 
            this.textNis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textNis.Location = new System.Drawing.Point(105, 59);
            this.textNis.Name = "textNis";
            this.textNis.Size = new System.Drawing.Size(162, 29);
            this.textNis.TabIndex = 0;
            this.textNis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNis_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(56, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(305, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mes";
            // 
            // comboBoxMeses
            // 
            this.comboBoxMeses.AutoCompleteCustomSource.AddRange(new string[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeses.DropDownWidth = 50;
            this.comboBoxMeses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxMeses.FormattingEnabled = true;
            this.comboBoxMeses.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxMeses.Location = new System.Drawing.Point(359, 59);
            this.comboBoxMeses.Name = "comboBoxMeses";
            this.comboBoxMeses.Size = new System.Drawing.Size(49, 29);
            this.comboBoxMeses.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConsultar.Location = new System.Drawing.Point(455, 55);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(93, 34);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.textCosto);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.textConsumo);
            this.panel1.Controls.Add(this.textLectura);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(25, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 208);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(267, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto a cancelar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 2);
            this.panel2.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.95506F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.04494F));
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textIva, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textMonto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.texTotal, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(188, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 103);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button8.Location = new System.Drawing.Point(3, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 28);
            this.button8.TabIndex = 17;
            this.button8.Text = "TOTAL";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textIva
            // 
            this.textIva.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textIva.Location = new System.Drawing.Point(99, 37);
            this.textIva.Name = "textIva";
            this.textIva.ReadOnly = true;
            this.textIva.Size = new System.Drawing.Size(160, 29);
            this.textIva.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button7.Location = new System.Drawing.Point(3, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 28);
            this.button7.TabIndex = 15;
            this.button7.Text = "I.V.A 13%";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 28);
            this.button6.TabIndex = 14;
            this.button6.Text = "Monto";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textMonto
            // 
            this.textMonto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textMonto.Location = new System.Drawing.Point(99, 3);
            this.textMonto.Name = "textMonto";
            this.textMonto.ReadOnly = true;
            this.textMonto.Size = new System.Drawing.Size(160, 29);
            this.textMonto.TabIndex = 14;
            // 
            // texTotal
            // 
            this.texTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.texTotal.Location = new System.Drawing.Point(99, 71);
            this.texTotal.Name = "texTotal";
            this.texTotal.ReadOnly = true;
            this.texTotal.Size = new System.Drawing.Size(160, 29);
            this.texTotal.TabIndex = 18;
            // 
            // textCosto
            // 
            this.textCosto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textCosto.Location = new System.Drawing.Point(563, 17);
            this.textCosto.Name = "textCosto";
            this.textCosto.ReadOnly = true;
            this.textCosto.Size = new System.Drawing.Size(74, 29);
            this.textCosto.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button5.Location = new System.Drawing.Point(450, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 34);
            this.button5.TabIndex = 11;
            this.button5.Text = "Costo por m3";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textConsumo
            // 
            this.textConsumo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textConsumo.Location = new System.Drawing.Point(109, 16);
            this.textConsumo.Name = "textConsumo";
            this.textConsumo.ReadOnly = true;
            this.textConsumo.Size = new System.Drawing.Size(107, 29);
            this.textConsumo.TabIndex = 9;
            // 
            // textLectura
            // 
            this.textLectura.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textLectura.Location = new System.Drawing.Point(325, 15);
            this.textLectura.Name = "textLectura";
            this.textLectura.ReadOnly = true;
            this.textLectura.Size = new System.Drawing.Size(65, 29);
            this.textLectura.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button4.Location = new System.Drawing.Point(252, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "Lectura";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.Location = new System.Drawing.Point(19, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Consumo:";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button3.Location = new System.Drawing.Point(387, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "m3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Consulta facturacion";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDesconectar.Location = new System.Drawing.Point(402, 393);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(146, 39);
            this.btnDesconectar.TabIndex = 7;
            this.btnDesconectar.Text = "Desconectarse";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConectar.Location = new System.Drawing.Point(571, 393);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(130, 39);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectarse";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.comboBoxMeses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNis);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMeses;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textConsumo;
        private System.Windows.Forms.TextBox textLectura;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textIva;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.TextBox texTotal;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
    }
}

