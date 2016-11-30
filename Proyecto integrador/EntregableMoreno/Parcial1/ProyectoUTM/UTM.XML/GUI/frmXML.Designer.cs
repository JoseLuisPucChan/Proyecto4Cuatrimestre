namespace UTM.XML.GUI
{
    partial class frmXML
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
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInicio
            // 
            this.pnlInicio.Controls.Add(this.btnEliminar);
            this.pnlInicio.Controls.Add(this.lblEdad);
            this.pnlInicio.Controls.Add(this.lblAM);
            this.pnlInicio.Controls.Add(this.lblAP);
            this.pnlInicio.Controls.Add(this.lblNombre);
            this.pnlInicio.Controls.Add(this.lblClave);
            this.pnlInicio.Controls.Add(this.btnModificar);
            this.pnlInicio.Controls.Add(this.btnInsertar);
            this.pnlInicio.Controls.Add(this.btnListar);
            this.pnlInicio.Controls.Add(this.btnBuscar);
            this.pnlInicio.Controls.Add(this.txtAM);
            this.pnlInicio.Controls.Add(this.txtAP);
            this.pnlInicio.Controls.Add(this.txtEdad);
            this.pnlInicio.Controls.Add(this.txtNombre);
            this.pnlInicio.Controls.Add(this.txtClave);
            this.pnlInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInicio.Location = new System.Drawing.Point(0, 0);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(924, 102);
            this.pnlInicio.TabIndex = 0;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(371, 9);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Location = new System.Drawing.Point(371, 51);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(29, 13);
            this.lblAM.TabIndex = 2;
            this.lblAM.Text = "A.M:";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Location = new System.Drawing.Point(249, 51);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(27, 13);
            this.lblAP.TabIndex = 2;
            this.lblAP.Text = "A.P:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(20, 9);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(754, 22);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 56);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(679, 22);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 56);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(604, 22);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 56);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(528, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 56);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtAM
            // 
            this.txtAM.Location = new System.Drawing.Point(374, 67);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(131, 20);
            this.txtAM.TabIndex = 0;
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(252, 67);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(121, 20);
            this.txtAP.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(374, 25);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(131, 20);
            this.txtEdad.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(23, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(23, 25);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(350, 20);
            this.txtClave.TabIndex = 0;
            // 
            // dgResultado
            // 
            this.dgResultado.AllowUserToAddRows = false;
            this.dgResultado.AllowUserToDeleteRows = false;
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResultado.Location = new System.Drawing.Point(0, 102);
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.ReadOnly = true;
            this.dgResultado.Size = new System.Drawing.Size(924, 326);
            this.dgResultado.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(829, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 56);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 428);
            this.Controls.Add(this.dgResultado);
            this.Controls.Add(this.pnlInicio);
            this.Name = "frmXML";
            this.Text = "frmXML";
            this.Load += new System.EventHandler(this.frmXML_Load);
            this.pnlInicio.ResumeLayout(false);
            this.pnlInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.Button btnEliminar;
    }
}