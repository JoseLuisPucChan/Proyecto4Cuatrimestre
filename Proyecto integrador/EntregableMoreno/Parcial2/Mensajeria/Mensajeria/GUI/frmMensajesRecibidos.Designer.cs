namespace Mensajeria.GUI
{
    partial class frmMensajesRecibidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtgMensajes = new System.Windows.Forms.DataGridView();
            this.grbMensaje = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensajes)).BeginInit();
            this.grbMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BackgroundImage = global::Mensajeria.Properties.Resources.no_tiene;
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic1.Location = new System.Drawing.Point(466, 92);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(117, 82);
            this.pic1.TabIndex = 18;
            this.pic1.TabStop = false;
            this.pic1.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtgMensajes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.grbMensaje);
            this.splitContainer1.Size = new System.Drawing.Size(787, 427);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 19;
            // 
            // dtgMensajes
            // 
            this.dtgMensajes.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgMensajes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgMensajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMensajes.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgMensajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgMensajes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgMensajes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMensajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMensajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgMensajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMensajes.Location = new System.Drawing.Point(0, 0);
            this.dtgMensajes.Name = "dtgMensajes";
            this.dtgMensajes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMensajes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgMensajes.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgMensajes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgMensajes.Size = new System.Drawing.Size(145, 427);
            this.dtgMensajes.TabIndex = 18;
            this.dtgMensajes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMensajes_CellMouseClick);
            // 
            // grbMensaje
            // 
            this.grbMensaje.Controls.Add(this.lblMensaje);
            this.grbMensaje.Controls.Add(this.lblAsunto);
            this.grbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMensaje.Location = new System.Drawing.Point(36, 45);
            this.grbMensaje.Name = "grbMensaje";
            this.grbMensaje.Size = new System.Drawing.Size(549, 302);
            this.grbMensaje.TabIndex = 1;
            this.grbMensaje.TabStop = false;
            this.grbMensaje.Text = "De:";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(23, 76);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(11, 16);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "l";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(23, 31);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(12, 16);
            this.lblAsunto.TabIndex = 0;
            this.lblAsunto.Text = "l";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bandeja de entrada";
            // 
            // frmMensajesRecibidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 427);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pic1);
            this.Name = "frmMensajesRecibidos";
            this.Text = "frmMensajesRecibidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMensajesRecibidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensajes)).EndInit();
            this.grbMensaje.ResumeLayout(false);
            this.grbMensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgMensajes;
        private System.Windows.Forms.GroupBox grbMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label label1;
    }
}