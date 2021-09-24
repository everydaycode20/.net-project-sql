namespace GUI
{
    partial class UserCategorias
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
            this.comboCodigoCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDescripcion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboCodigoCategoria
            // 
            this.comboCodigoCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCodigoCategoria.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.comboCodigoCategoria.FormattingEnabled = true;
            this.comboCodigoCategoria.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboCodigoCategoria.Location = new System.Drawing.Point(386, 59);
            this.comboCodigoCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboCodigoCategoria.Name = "comboCodigoCategoria";
            this.comboCodigoCategoria.Size = new System.Drawing.Size(199, 38);
            this.comboCodigoCategoria.TabIndex = 18;
            this.comboCodigoCategoria.SelectedIndexChanged += new System.EventHandler(this.comboCodigoCategoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(420, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Codigo Categoria";
            // 
            // comboDescripcion
            // 
            this.comboDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDescripcion.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.comboDescripcion.FormattingEnabled = true;
            this.comboDescripcion.Location = new System.Drawing.Point(386, 135);
            this.comboDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboDescripcion.Name = "comboDescripcion";
            this.comboDescripcion.Size = new System.Drawing.Size(199, 38);
            this.comboDescripcion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(440, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descripcion";
            // 
            // btnRegistrarCategoria
            // 
            this.btnRegistrarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.btnRegistrarCategoria.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCategoria.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnRegistrarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.btnRegistrarCategoria.Image = global::GUI.Properties.Resources.icono_agregar_categoria;
            this.btnRegistrarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCategoria.Location = new System.Drawing.Point(309, 231);
            this.btnRegistrarCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            this.btnRegistrarCategoria.Size = new System.Drawing.Size(353, 55);
            this.btnRegistrarCategoria.TabIndex = 21;
            this.btnRegistrarCategoria.Text = "Registrar categoria de servicio";
            this.btnRegistrarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarCategoria.UseVisualStyleBackColor = false;
            this.btnRegistrarCategoria.Click += new System.EventHandler(this.btnRegistrarCategoria_Click);
            // 
            // UserCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btnRegistrarCategoria);
            this.Controls.Add(this.comboDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCodigoCategoria);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserCategorias";
            this.Size = new System.Drawing.Size(950, 571);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCodigoCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarCategoria;
    }
}
