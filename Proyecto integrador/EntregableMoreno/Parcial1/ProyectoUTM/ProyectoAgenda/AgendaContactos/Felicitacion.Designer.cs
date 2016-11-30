namespace AgendaContactos
{
    partial class Felicitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Felicitacion));
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cerrar.Location = new System.Drawing.Point(606, 2);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(23, 23);
            this.cerrar.TabIndex = 0;
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Felicitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(631, 413);
            this.Controls.Add(this.cerrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Felicitacion";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Felicitacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cerrar;
    }
}