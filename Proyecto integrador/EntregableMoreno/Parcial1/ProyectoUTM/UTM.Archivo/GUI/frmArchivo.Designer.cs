namespace UTM.SI.GUI
{
    partial class frmArchivo
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
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnTraer = new System.Windows.Forms.Button();
            this.txtParcial1 = new System.Windows.Forms.TextBox();
            this.txtParcial2 = new System.Windows.Forms.TextBox();
            this.txtParcial3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(0, 0);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(606, 230);
            this.txtDatos.TabIndex = 0;
            // 
            // btnTraer
            // 
            this.btnTraer.Location = new System.Drawing.Point(612, 8);
            this.btnTraer.Name = "btnTraer";
            this.btnTraer.Size = new System.Drawing.Size(121, 75);
            this.btnTraer.TabIndex = 1;
            this.btnTraer.Text = "Traer";
            this.btnTraer.UseVisualStyleBackColor = true;
            this.btnTraer.Click += new System.EventHandler(this.btnTraer_Click);
            // 
            // txtParcial1
            // 
            this.txtParcial1.Location = new System.Drawing.Point(24, 255);
            this.txtParcial1.Multiline = true;
            this.txtParcial1.Name = "txtParcial1";
            this.txtParcial1.Size = new System.Drawing.Size(272, 112);
            this.txtParcial1.TabIndex = 2;
            // 
            // txtParcial2
            // 
            this.txtParcial2.Location = new System.Drawing.Point(322, 255);
            this.txtParcial2.Multiline = true;
            this.txtParcial2.Name = "txtParcial2";
            this.txtParcial2.Size = new System.Drawing.Size(272, 112);
            this.txtParcial2.TabIndex = 2;
            // 
            // txtParcial3
            // 
            this.txtParcial3.Location = new System.Drawing.Point(612, 255);
            this.txtParcial3.Multiline = true;
            this.txtParcial3.Name = "txtParcial3";
            this.txtParcial3.Size = new System.Drawing.Size(272, 112);
            this.txtParcial3.TabIndex = 2;
            // 
            // frmArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 386);
            this.Controls.Add(this.txtParcial3);
            this.Controls.Add(this.txtParcial2);
            this.Controls.Add(this.txtParcial1);
            this.Controls.Add(this.btnTraer);
            this.Controls.Add(this.txtDatos);
            this.Name = "frmArchivo";
            this.Text = "frmArchivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnTraer;
        private System.Windows.Forms.TextBox txtParcial1;
        private System.Windows.Forms.TextBox txtParcial2;
        private System.Windows.Forms.TextBox txtParcial3;
    }
}