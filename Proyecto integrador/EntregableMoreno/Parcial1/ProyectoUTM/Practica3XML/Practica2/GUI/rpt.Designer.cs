namespace Practica2.GUI
{
    partial class rpt
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
            this.crvLibro = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvLibro
            // 
            this.crvLibro.ActiveViewIndex = -1;
            this.crvLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvLibro.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvLibro.Location = new System.Drawing.Point(20, 60);
            this.crvLibro.Name = "crvLibro";
            this.crvLibro.Size = new System.Drawing.Size(499, 518);
            this.crvLibro.TabIndex = 0;
            // 
            // rpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 598);
            this.Controls.Add(this.crvLibro);
            this.Name = "rpt";
            this.Text = "rpt";
            this.Load += new System.EventHandler(this.rpt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvLibro;
    }
}