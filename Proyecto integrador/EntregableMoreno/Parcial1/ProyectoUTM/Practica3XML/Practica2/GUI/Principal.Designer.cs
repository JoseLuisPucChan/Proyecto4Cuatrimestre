namespace Practica2
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtISBN = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditorial = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.dgListado = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Autor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editorial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnNuevo = new MetroFramework.Controls.MetroTile();
            this.btnBuscar = new MetroFramework.Controls.MetroTile();
            this.btnLimpiar = new MetroFramework.Controls.MetroTile();
            this.btnImprimir = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(43, 91);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(98, 23);
            this.txtISBN.TabIndex = 1;
            this.txtISBN.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(370, 91);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(217, 23);
            this.txtAutor.TabIndex = 5;
            this.txtAutor.UseStyleColors = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(593, 91);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(137, 23);
            this.txtEditorial.TabIndex = 7;
            this.txtEditorial.Text = " ";
            this.txtEditorial.UseStyleColors = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(736, 91);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(78, 23);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.Text = " ";
            this.txtPrecio.UseStyleColors = true;
            // 
            // dgListado
            // 
            this.dgListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgListado.Location = new System.Drawing.Point(20, 196);
            this.dgListado.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.HotTrack;
            this.dgListado.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgListado.MainView = this.gridView1;
            this.dgListado.Name = "dgListado";
            this.dgListado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.dgListado.Size = new System.Drawing.Size(801, 225);
            this.dgListado.TabIndex = 11;
            this.dgListado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ISBN,
            this.Nombre,
            this.Autor,
            this.Editorial,
            this.Precio,
            this.Editar});
            this.gridView1.GridControl = this.dgListado;
            this.gridView1.Name = "gridView1";
            // 
            // ISBN
            // 
            this.ISBN.Caption = "ISBN";
            this.ISBN.FieldName = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Visible = true;
            this.ISBN.VisibleIndex = 0;
            this.ISBN.Width = 130;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            this.Nombre.Width = 130;
            // 
            // Autor
            // 
            this.Autor.Caption = "Autor";
            this.Autor.FieldName = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.Visible = true;
            this.Autor.VisibleIndex = 2;
            this.Autor.Width = 130;
            // 
            // Editorial
            // 
            this.Editorial.Caption = "Editorial";
            this.Editorial.FieldName = "Editorial";
            this.Editorial.Name = "Editorial";
            this.Editorial.Visible = true;
            this.Editorial.VisibleIndex = 3;
            this.Editorial.Width = 130;
            // 
            // Precio
            // 
            this.Precio.Caption = "Precio";
            this.Precio.FieldName = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Visible = true;
            this.Precio.VisibleIndex = 4;
            this.Precio.Width = 222;
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.repositoryItemButtonEdit1;
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 5;
            this.Editar.Width = 41;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(43, 147);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 31);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(167, 147);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 31);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(289, 147);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 31);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(408, 147);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 31);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 441);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgListado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtISBN);
            this.Name = "Principal";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtAutor;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtEditorial;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private DevExpress.XtraGrid.GridControl dgListado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MetroFramework.Controls.MetroTile btnNuevo;
        private MetroFramework.Controls.MetroTile btnBuscar;
        private MetroFramework.Controls.MetroTile btnLimpiar;
        private MetroFramework.Controls.MetroTile btnImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn ISBN;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Autor;
        private DevExpress.XtraGrid.Columns.GridColumn Editorial;
        private DevExpress.XtraGrid.Columns.GridColumn Precio;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}