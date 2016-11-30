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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCinemex = new System.Windows.Forms.TabPage();
            this.ricCinemex = new System.Windows.Forms.RichTextBox();
            this.cobSede = new System.Windows.Forms.ComboBox();
            this.tpCinepolis = new System.Windows.Forms.TabPage();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ricCinepolis = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImprimirCP = new System.Windows.Forms.Button();
            this.cobCP = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tpCinemex.SuspendLayout();
            this.tpCinepolis.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCinemex);
            this.tabControl1.Controls.Add(this.tpCinepolis);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 373);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpCinemex
            // 
            this.tpCinemex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpCinemex.Controls.Add(this.ricCinemex);
            this.tpCinemex.Controls.Add(this.panel2);
            this.tpCinemex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpCinemex.Location = new System.Drawing.Point(4, 22);
            this.tpCinemex.Name = "tpCinemex";
            this.tpCinemex.Padding = new System.Windows.Forms.Padding(3);
            this.tpCinemex.Size = new System.Drawing.Size(774, 347);
            this.tpCinemex.TabIndex = 0;
            this.tpCinemex.Text = "Cinemex";
            this.tpCinemex.UseVisualStyleBackColor = true;
            // 
            // ricCinemex
            // 
            this.ricCinemex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ricCinemex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricCinemex.Location = new System.Drawing.Point(226, 3);
            this.ricCinemex.Name = "ricCinemex";
            this.ricCinemex.Size = new System.Drawing.Size(541, 337);
            this.ricCinemex.TabIndex = 2;
            this.ricCinemex.Text = "";
            // 
            // cobSede
            // 
            this.cobSede.Dock = System.Windows.Forms.DockStyle.Top;
            this.cobSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobSede.FormattingEnabled = true;
            this.cobSede.Items.AddRange(new object[] {
            "Todos"});
            this.cobSede.Location = new System.Drawing.Point(0, 0);
            this.cobSede.Name = "cobSede";
            this.cobSede.Size = new System.Drawing.Size(223, 28);
            this.cobSede.TabIndex = 1;
            this.cobSede.SelectedIndexChanged += new System.EventHandler(this.cobSede_SelectedIndexChanged);
            // 
            // tpCinepolis
            // 
            this.tpCinepolis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpCinepolis.Controls.Add(this.ricCinepolis);
            this.tpCinepolis.Controls.Add(this.panel1);
            this.tpCinepolis.Location = new System.Drawing.Point(4, 22);
            this.tpCinepolis.Name = "tpCinepolis";
            this.tpCinepolis.Padding = new System.Windows.Forms.Padding(3);
            this.tpCinepolis.Size = new System.Drawing.Size(774, 347);
            this.tpCinepolis.TabIndex = 1;
            this.tpCinepolis.Text = "Cinépolis";
            this.tpCinepolis.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarToolStripMenuItem,
            this.minimizarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 70);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(0, 281);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(223, 56);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Imprimir";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnImprimirCP);
            this.panel1.Controls.Add(this.cobCP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 337);
            this.panel1.TabIndex = 2;
            // 
            // ricCinepolis
            // 
            this.ricCinepolis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ricCinepolis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricCinepolis.Location = new System.Drawing.Point(226, 3);
            this.ricCinepolis.Name = "ricCinepolis";
            this.ricCinepolis.Size = new System.Drawing.Size(541, 337);
            this.ricCinepolis.TabIndex = 1;
            this.ricCinepolis.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReporte);
            this.panel2.Controls.Add(this.cobSede);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 337);
            this.panel2.TabIndex = 5;
            // 
            // btnImprimirCP
            // 
            this.btnImprimirCP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnImprimirCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirCP.Location = new System.Drawing.Point(0, 281);
            this.btnImprimirCP.Name = "btnImprimirCP";
            this.btnImprimirCP.Size = new System.Drawing.Size(223, 56);
            this.btnImprimirCP.TabIndex = 6;
            this.btnImprimirCP.Text = "Imprimir";
            this.btnImprimirCP.UseVisualStyleBackColor = true;
            // 
            // cobCP
            // 
            this.cobCP.Dock = System.Windows.Forms.DockStyle.Top;
            this.cobCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobCP.FormattingEnabled = true;
            this.cobCP.Items.AddRange(new object[] {
            "Todos",
            "Cinemex Canek",
            "Cinemex City Center Mérida",
            "Cinemex Galerías Mérida",
            "Cinemex Galerías Mérida Platino",
            "Cinemex Gran Plaza Mérida",
            "Cinemex Macroplaza Mérida",
            "Cinemex Península Montejo Platino",
            "Cinemex Rex Mérida"});
            this.cobCP.Location = new System.Drawing.Point(0, 0);
            this.cobCP.Name = "cobCP";
            this.cobCP.Size = new System.Drawing.Size(223, 28);
            this.cobCP.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 373);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tpCinemex.ResumeLayout(false);
            this.tpCinepolis.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCinemex;
        private System.Windows.Forms.TabPage tpCinepolis;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cobSede;
        private System.Windows.Forms.RichTextBox ricCinemex;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.RichTextBox ricCinepolis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImprimirCP;
        private System.Windows.Forms.ComboBox cobCP;
    }
}

