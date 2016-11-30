namespace Mensajeria.GUI
{
    partial class Nuevo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPara = new MetroFramework.Controls.MetroTextBox();
            this.txtDe = new MetroFramework.Controls.MetroTextBox();
            this.txtAsunto = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(236, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 27);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "De:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(23, 141);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(583, 202);
            this.txtMensaje.TabIndex = 4;
            this.txtMensaje.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(236, 52);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(80, 26);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Asunto";
            // 
            // txtPara
            // 
            // 
            // 
            // 
            this.txtPara.CustomButton.Image = null;
            this.txtPara.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtPara.CustomButton.Name = "";
            this.txtPara.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPara.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPara.CustomButton.TabIndex = 1;
            this.txtPara.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPara.CustomButton.UseSelectable = true;
            this.txtPara.CustomButton.Visible = false;
            this.txtPara.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPara.Lines = new string[0];
            this.txtPara.Location = new System.Drawing.Point(72, 14);
            this.txtPara.MaxLength = 32767;
            this.txtPara.Multiline = true;
            this.txtPara.Name = "txtPara";
            this.txtPara.PasswordChar = '\0';
            this.txtPara.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPara.SelectedText = "";
            this.txtPara.SelectionLength = 0;
            this.txtPara.SelectionStart = 0;
            this.txtPara.ShortcutsEnabled = true;
            this.txtPara.Size = new System.Drawing.Size(158, 27);
            this.txtPara.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPara.TabIndex = 15;
            this.txtPara.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPara.UseSelectable = true;
            this.txtPara.UseStyleColors = true;
            this.txtPara.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPara.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDe
            // 
            // 
            // 
            // 
            this.txtDe.CustomButton.Image = null;
            this.txtDe.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtDe.CustomButton.Name = "";
            this.txtDe.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDe.CustomButton.TabIndex = 1;
            this.txtDe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDe.CustomButton.UseSelectable = true;
            this.txtDe.CustomButton.Visible = false;
            this.txtDe.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDe.Lines = new string[0];
            this.txtDe.Location = new System.Drawing.Point(72, 52);
            this.txtDe.MaxLength = 32767;
            this.txtDe.Multiline = true;
            this.txtDe.Name = "txtDe";
            this.txtDe.PasswordChar = '\0';
            this.txtDe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDe.SelectedText = "";
            this.txtDe.SelectionLength = 0;
            this.txtDe.SelectionStart = 0;
            this.txtDe.ShortcutsEnabled = true;
            this.txtDe.Size = new System.Drawing.Size(158, 27);
            this.txtDe.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDe.TabIndex = 16;
            this.txtDe.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDe.UseSelectable = true;
            this.txtDe.UseStyleColors = true;
            this.txtDe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAsunto
            // 
            // 
            // 
            // 
            this.txtAsunto.CustomButton.Image = null;
            this.txtAsunto.CustomButton.Location = new System.Drawing.Point(508, 1);
            this.txtAsunto.CustomButton.Name = "";
            this.txtAsunto.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAsunto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAsunto.CustomButton.TabIndex = 1;
            this.txtAsunto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAsunto.CustomButton.UseSelectable = true;
            this.txtAsunto.CustomButton.Visible = false;
            this.txtAsunto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAsunto.Lines = new string[0];
            this.txtAsunto.Location = new System.Drawing.Point(72, 89);
            this.txtAsunto.MaxLength = 32767;
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.PasswordChar = '\0';
            this.txtAsunto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAsunto.SelectedText = "";
            this.txtAsunto.SelectionLength = 0;
            this.txtAsunto.SelectionStart = 0;
            this.txtAsunto.ShortcutsEnabled = true;
            this.txtAsunto.Size = new System.Drawing.Size(534, 27);
            this.txtAsunto.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAsunto.TabIndex = 17;
            this.txtAsunto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAsunto.UseSelectable = true;
            this.txtAsunto.UseStyleColors = true;
            this.txtAsunto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAsunto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 379);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Nuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtPara;
        private MetroFramework.Controls.MetroTextBox txtDe;
        private MetroFramework.Controls.MetroTextBox txtAsunto;
    }
}