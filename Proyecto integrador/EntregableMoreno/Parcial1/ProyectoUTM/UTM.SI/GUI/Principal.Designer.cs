namespace UTM.SI.GUI
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspClose = new System.Windows.Forms.ToolStripButton();
            this.tspCollapse = new System.Windows.Forms.ToolStripButton();
            this.tsphepl = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.nbPrincipal = new MT.WindowsUI.NavigationPane.NavigateBar();
            this.nbbArchivo = new MT.WindowsUI.NavigationPane.NavigateBarButton();
            this.nbbXML = new MT.WindowsUI.NavigationPane.NavigateBarButton();
            this.nbbSQLite = new MT.WindowsUI.NavigationPane.NavigateBarButton();
            this.nbbPracticas = new MT.WindowsUI.NavigationPane.NavigateBarButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.nbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Universidad Tecnólogica Metropolitana";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::UTM.SI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspClose,
            this.tspCollapse,
            this.tsphepl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 100);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(954, 29);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspClose
            // 
            this.tspClose.Image = global::UTM.SI.Properties.Resources.Cerrar;
            this.tspClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspClose.Name = "tspClose";
            this.tspClose.Size = new System.Drawing.Size(26, 26);
            // 
            // tspCollapse
            // 
            this.tspCollapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspCollapse.Image = global::UTM.SI.Properties.Resources.Comprimir;
            this.tspCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspCollapse.Name = "tspCollapse";
            this.tspCollapse.Size = new System.Drawing.Size(23, 26);
            this.tspCollapse.Text = "toolStripButton2";
            // 
            // tsphepl
            // 
            this.tsphepl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsphepl.Image = global::UTM.SI.Properties.Resources.Ayuda;
            this.tsphepl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsphepl.Name = "tsphepl";
            this.tsphepl.Size = new System.Drawing.Size(23, 26);
            this.tsphepl.Text = "toolStripButton3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(954, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // nbPrincipal
            // 
            this.nbPrincipal.AlwaysUseSystemColors = false;
            this.nbPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nbPrincipal.CollapsibleWidth = 32;
            this.nbPrincipal.Controls.Add(this.nbbArchivo);
            this.nbPrincipal.Controls.Add(this.nbbXML);
            this.nbPrincipal.Controls.Add(this.nbbSQLite);
            this.nbPrincipal.Controls.Add(this.nbbPracticas);
            this.nbPrincipal.DisplayedButtonCount = 4;
            this.nbPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbPrincipal.Location = new System.Drawing.Point(0, 129);
            this.nbPrincipal.MinimumSize = new System.Drawing.Size(22, 100);
            this.nbPrincipal.Name = "nbPrincipal";
            this.nbPrincipal.NavigateBarButtons.AddRange(new MT.WindowsUI.NavigationPane.NavigateBarButton[] {
            this.nbbArchivo,
            this.nbbXML,
            this.nbbSQLite,
            this.nbbPracticas});
            this.nbPrincipal.NavigateBarColorTable = ((MT.WindowsUI.NavigationPane.NavigateBarColorTable)(resources.GetObject("nbPrincipal.NavigateBarColorTable")));
            this.nbPrincipal.NavigateBarDisplayedButtonCount = 4;
            this.nbPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nbPrincipal.SelectedButton = this.nbbArchivo;
            this.nbPrincipal.Size = new System.Drawing.Size(245, 339);
            this.nbPrincipal.TabIndex = 6;
            this.nbPrincipal.Text = "Ejemplo";
            this.nbPrincipal.OnNavigateBarButtonSelected += new MT.WindowsUI.NavigationPane.NavigateBar.OnNavigateBarButtonEventHandler(this.nbPrincipal_OnNavigateBarButtonSelected);
            // 
            // nbbArchivo
            // 
            this.nbbArchivo.Caption = "Archivo";
            this.nbbArchivo.CaptionDescription = "Archivo";
            this.nbbArchivo.Cursor = System.Windows.Forms.Cursors.Default;
            this.nbbArchivo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nbbArchivo.Image = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbArchivo.IsSelected = true;
            this.nbbArchivo.IsShowCollapseScreenCaption = false;
            this.nbbArchivo.Key = "8A351B5A0B5140B3BC5227D8435AA547";
            this.nbbArchivo.Location = new System.Drawing.Point(0, 179);
            this.nbbArchivo.MinimumSize = new System.Drawing.Size(22, 20);
            this.nbbArchivo.MouseOverImage = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbArchivo.Name = "nbbArchivo";
            this.nbbArchivo.SelectedImage = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbArchivo.Size = new System.Drawing.Size(245, 32);
            this.nbbArchivo.TabIndex = 4;
            this.nbbArchivo.ToolTipText = "NavigateBarButton";
            // 
            // nbbXML
            // 
            this.nbbXML.Caption = "XML";
            this.nbbXML.CaptionDescription = "XML";
            this.nbbXML.Cursor = System.Windows.Forms.Cursors.Default;
            this.nbbXML.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nbbXML.Image = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbXML.IsSelected = false;
            this.nbbXML.IsShowCollapseScreenCaption = false;
            this.nbbXML.Key = "308D21D946814CF7A407ABF26FFDBBB4";
            this.nbbXML.Location = new System.Drawing.Point(0, 211);
            this.nbbXML.MinimumSize = new System.Drawing.Size(22, 20);
            this.nbbXML.MouseOverImage = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbXML.Name = "nbbXML";
            this.nbbXML.SelectedImage = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbXML.Size = new System.Drawing.Size(245, 32);
            this.nbbXML.TabIndex = 5;
            this.nbbXML.ToolTipText = "NavigateBarButton";
            // 
            // nbbSQLite
            // 
            this.nbbSQLite.Caption = "SQLite";
            this.nbbSQLite.CaptionDescription = "SQLite";
            this.nbbSQLite.Cursor = System.Windows.Forms.Cursors.Default;
            this.nbbSQLite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nbbSQLite.Image = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbSQLite.IsSelected = false;
            this.nbbSQLite.IsShowCollapseScreenCaption = false;
            this.nbbSQLite.Key = "3C73C8F6469E48C493F2C77783329DAB";
            this.nbbSQLite.Location = new System.Drawing.Point(0, 243);
            this.nbbSQLite.MinimumSize = new System.Drawing.Size(22, 20);
            this.nbbSQLite.MouseOverImage = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbSQLite.Name = "nbbSQLite";
            this.nbbSQLite.SelectedImage = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbSQLite.Size = new System.Drawing.Size(245, 32);
            this.nbbSQLite.TabIndex = 6;
            this.nbbSQLite.ToolTipText = "NavigateBarButton";
            // 
            // nbbPracticas
            // 
            this.nbbPracticas.Caption = "PARCIAL 1";
            this.nbbPracticas.CaptionDescription = "PRACTICAS";
            this.nbbPracticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nbbPracticas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nbbPracticas.Image = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbPracticas.IsSelected = false;
            this.nbbPracticas.IsShowCollapseScreenCaption = false;
            this.nbbPracticas.Key = "BCEA9F40374D4474862003AC28B52A6C";
            this.nbbPracticas.Location = new System.Drawing.Point(0, 275);
            this.nbbPracticas.MinimumSize = new System.Drawing.Size(22, 20);
            this.nbbPracticas.MouseOverImage = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbPracticas.Name = "nbbPracticas";
            this.nbbPracticas.SelectedImage = global::UTM.SI.Properties.Resources.Herramientas;
            this.nbbPracticas.Size = new System.Drawing.Size(245, 32);
            this.nbbPracticas.TabIndex = 7;
            this.nbbPracticas.ToolTipText = "PARCIAL 1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 490);
            this.Controls.Add(this.nbPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.nbPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspClose;
        private System.Windows.Forms.ToolStripButton tspCollapse;
        private System.Windows.Forms.ToolStripButton tsphepl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private MT.WindowsUI.NavigationPane.NavigateBar nbPrincipal;
        private MT.WindowsUI.NavigationPane.NavigateBarButton nbbArchivo;
        private MT.WindowsUI.NavigationPane.NavigateBarButton nbbXML;
        private MT.WindowsUI.NavigationPane.NavigateBarButton nbbSQLite;
        private MT.WindowsUI.NavigationPane.NavigateBarButton nbbPracticas;
    }
}