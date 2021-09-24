namespace SERVIDOR
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
            this.textEstatus = new System.Windows.Forms.TextBox();
            this.labelClientesConectados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEstatus
            // 
            this.textEstatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textEstatus.Location = new System.Drawing.Point(12, 12);
            this.textEstatus.Multiline = true;
            this.textEstatus.Name = "textEstatus";
            this.textEstatus.ReadOnly = true;
            this.textEstatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEstatus.Size = new System.Drawing.Size(416, 337);
            this.textEstatus.TabIndex = 0;
            // 
            // labelClientesConectados
            // 
            this.labelClientesConectados.AutoSize = true;
            this.labelClientesConectados.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelClientesConectados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.labelClientesConectados.Location = new System.Drawing.Point(558, 12);
            this.labelClientesConectados.Name = "labelClientesConectados";
            this.labelClientesConectados.Size = new System.Drawing.Size(23, 28);
            this.labelClientesConectados.TabIndex = 2;
            this.labelClientesConectados.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SERVIDOR.Properties.Resources.icono_cliente;
            this.pictureBox1.Location = new System.Drawing.Point(527, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelClientesConectados);
            this.Controls.Add(this.textEstatus);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Servidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEstatus;
        private System.Windows.Forms.Label labelClientesConectados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

