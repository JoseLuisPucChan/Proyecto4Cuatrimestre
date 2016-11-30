namespace Mensajeria.GUI
{
    partial class frmMenu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nbc1 = new DevExpress.XtraNavBar.NavBarControl();
            this.CerrarSesion = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.Mensajes = new DevExpress.XtraNavBar.NavBarGroup();
            this.Nuevo = new DevExpress.XtraNavBar.NavBarItem();
            this.Recibidos = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbc1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.nbc1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Size = new System.Drawing.Size(1066, 397);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 0;
            // 
            // nbc1
            // 
            this.nbc1.ActiveGroup = this.CerrarSesion;
            this.nbc1.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbc1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.Mensajes,
            this.navBarGroup1,
            this.CerrarSesion});
            this.nbc1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.Nuevo,
            this.Recibidos,
            this.navBarItem2,
            this.navBarItem3});
            this.nbc1.Location = new System.Drawing.Point(0, 0);
            this.nbc1.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.Highlight;
            this.nbc1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.nbc1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.nbc1.Name = "nbc1";
            this.nbc1.OptionsNavPane.ExpandedWidth = 216;
            this.nbc1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.SideBar;
            this.nbc1.Size = new System.Drawing.Size(216, 397);
            this.nbc1.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.Buttons;
            this.nbc1.TabIndex = 0;
            this.nbc1.Text = "Mensajes";
            this.nbc1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Visual Studio 2013 Blue");
            this.nbc1.Click += new System.EventHandler(this.nbc1_Click);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Caption = "Cerrar sesión";
            this.CerrarSesion.Expanded = true;
            this.CerrarSesion.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.CerrarSesion.Name = "CerrarSesion";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Cerrar sesión";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // Mensajes
            // 
            this.Mensajes.Caption = "Mensajes";
            this.Mensajes.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.Nuevo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Recibidos)});
            this.Mensajes.Name = "Mensajes";
            // 
            // Nuevo
            // 
            this.Nuevo.Caption = "Nuevo";
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Nuevo_LinkClicked);
            // 
            // Recibidos
            // 
            this.Recibidos.Caption = "Recibidos";
            this.Recibidos.Name = "Recibidos";
            this.Recibidos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Recibidos_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Gestion";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Administración de usuarios";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "navBarItem1";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 477);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbc1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraNavBar.NavBarControl nbc1;
        private DevExpress.XtraNavBar.NavBarGroup Mensajes;
        private DevExpress.XtraNavBar.NavBarItem Nuevo;
        private DevExpress.XtraNavBar.NavBarItem Recibidos;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarGroup CerrarSesion;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
    }
}