namespace GUI
{
    partial class UserHidrometros
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
            this.textNumeroSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNIS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.gridClientesHidrometros = new System.Windows.Forms.DataGridView();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarHidrometro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesHidrometros)).BeginInit();
            this.SuspendLayout();
            // 
            // textNumeroSerie
            // 
            this.textNumeroSerie.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.textNumeroSerie.Location = new System.Drawing.Point(208, 170);
            this.textNumeroSerie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNumeroSerie.Name = "textNumeroSerie";
            this.textNumeroSerie.Size = new System.Drawing.Size(132, 36);
            this.textNumeroSerie.TabIndex = 15;
            this.textNumeroSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumeroSerie_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(74, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Numero de serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(74, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Categoria";
            // 
            // textMarca
            // 
            this.textMarca.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.textMarca.Location = new System.Drawing.Point(135, 76);
            this.textMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(205, 36);
            this.textMarca.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(74, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marca";
            // 
            // textNIS
            // 
            this.textNIS.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.textNIS.Location = new System.Drawing.Point(117, 30);
            this.textNIS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNIS.Name = "textNIS";
            this.textNIS.Size = new System.Drawing.Size(223, 36);
            this.textNIS.TabIndex = 9;
            this.textNIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNIS_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(74, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "NIS";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(150, 122);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(190, 38);
            this.comboBoxCategoria.TabIndex = 16;
            // 
            // gridClientesHidrometros
            // 
            this.gridClientesHidrometros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClientesHidrometros.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridClientesHidrometros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientesHidrometros.Location = new System.Drawing.Point(22, 272);
            this.gridClientesHidrometros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridClientesHidrometros.Name = "gridClientesHidrometros";
            this.gridClientesHidrometros.Size = new System.Drawing.Size(910, 280);
            this.gridClientesHidrometros.TabIndex = 17;
            // 
            // textBusqueda
            // 
            this.textBusqueda.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.textBusqueda.Location = new System.Drawing.Point(562, 226);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(370, 36);
            this.textBusqueda.TabIndex = 19;
            this.textBusqueda.TextChanged += new System.EventHandler(this.textBusqueda_TextChanged);
            this.textBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBusqueda_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(558, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Buscar por identificacion";
            // 
            // btnRegistrarHidrometro
            // 
            this.btnRegistrarHidrometro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.btnRegistrarHidrometro.FlatAppearance.BorderSize = 0;
            this.btnRegistrarHidrometro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarHidrometro.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnRegistrarHidrometro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.btnRegistrarHidrometro.Image = global::GUI.Properties.Resources.icono_agregar_hidrometro;
            this.btnRegistrarHidrometro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarHidrometro.Location = new System.Drawing.Point(651, 30);
            this.btnRegistrarHidrometro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarHidrometro.Name = "btnRegistrarHidrometro";
            this.btnRegistrarHidrometro.Size = new System.Drawing.Size(281, 64);
            this.btnRegistrarHidrometro.TabIndex = 18;
            this.btnRegistrarHidrometro.Text = "Registrar nuevo hidrometro";
            this.btnRegistrarHidrometro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarHidrometro.UseVisualStyleBackColor = false;
            this.btnRegistrarHidrometro.Click += new System.EventHandler(this.btnRegistrarHidrometro_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(22, 226);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Actualizar lista";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserHidrometros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.btnRegistrarHidrometro);
            this.Controls.Add(this.gridClientesHidrometros);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textNumeroSerie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNIS);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserHidrometros";
            this.Size = new System.Drawing.Size(950, 571);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesHidrometros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumeroSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.DataGridView gridClientesHidrometros;
        private System.Windows.Forms.Button btnRegistrarHidrometro;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}
