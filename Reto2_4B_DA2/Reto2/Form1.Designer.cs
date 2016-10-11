namespace Reto2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCinepolis = new System.Windows.Forms.TabPage();
            this.tpCinemex = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpCinepolis.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCinepolis);
            this.tabControl1.Controls.Add(this.tpCinemex);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 491);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tpCinepolis
            // 
            this.tpCinepolis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpCinepolis.Controls.Add(this.textBox1);
            this.tpCinepolis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpCinepolis.Location = new System.Drawing.Point(4, 22);
            this.tpCinepolis.Name = "tpCinepolis";
            this.tpCinepolis.Padding = new System.Windows.Forms.Padding(3);
            this.tpCinepolis.Size = new System.Drawing.Size(765, 465);
            this.tpCinepolis.TabIndex = 0;
            this.tpCinepolis.Text = "Cinepolis";
            this.tpCinepolis.UseVisualStyleBackColor = true;
            // 
            // tpCinemex
            // 
            this.tpCinemex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpCinemex.Location = new System.Drawing.Point(4, 22);
            this.tpCinemex.Name = "tpCinemex";
            this.tpCinemex.Padding = new System.Windows.Forms.Padding(3);
            this.tpCinemex.Size = new System.Drawing.Size(765, 465);
            this.tpCinemex.TabIndex = 1;
            this.tpCinemex.Text = "Cinemex";
            this.tpCinemex.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(755, 455);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 491);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpCinepolis.ResumeLayout(false);
            this.tpCinepolis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCinepolis;
        private System.Windows.Forms.TabPage tpCinemex;
        private System.Windows.Forms.TextBox textBox1;
    }
}

