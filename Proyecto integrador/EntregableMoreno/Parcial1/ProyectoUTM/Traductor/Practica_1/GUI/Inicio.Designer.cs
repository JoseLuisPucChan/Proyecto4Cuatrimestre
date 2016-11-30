namespace Practica_1.GUI
{
    partial class Inicio
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
            this.cboTraducir1 = new System.Windows.Forms.ComboBox();
            this.cboTraducir2 = new System.Windows.Forms.ComboBox();
            this.txtTraducir1 = new System.Windows.Forms.TextBox();
            this.btnTraducir = new System.Windows.Forms.Button();
            this.txtTraducir2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbImagen2 = new System.Windows.Forms.PictureBox();
            this.pcbImagen1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTraducir1
            // 
            this.cboTraducir1.FormattingEnabled = true;
            this.cboTraducir1.Items.AddRange(new object[] {
            "ESPAÑOL",
            "INGLES",
            "MAYA"});
            this.cboTraducir1.Location = new System.Drawing.Point(98, 135);
            this.cboTraducir1.Name = "cboTraducir1";
            this.cboTraducir1.Size = new System.Drawing.Size(192, 21);
            this.cboTraducir1.TabIndex = 0;
            this.cboTraducir1.SelectedIndexChanged += new System.EventHandler(this.cboTraducir1_SelectedIndexChanged);
            // 
            // cboTraducir2
            // 
            this.cboTraducir2.FormattingEnabled = true;
            this.cboTraducir2.Items.AddRange(new object[] {
            "ESPAÑOL",
            "INGLES",
            "MAYA"});
            this.cboTraducir2.Location = new System.Drawing.Point(360, 135);
            this.cboTraducir2.Name = "cboTraducir2";
            this.cboTraducir2.Size = new System.Drawing.Size(192, 21);
            this.cboTraducir2.TabIndex = 1;
            this.cboTraducir2.SelectedIndexChanged += new System.EventHandler(this.cboTraducir2_SelectedIndexChanged);
            // 
            // txtTraducir1
            // 
            this.txtTraducir1.BackColor = System.Drawing.Color.White;
            this.txtTraducir1.Location = new System.Drawing.Point(98, 179);
            this.txtTraducir1.Multiline = true;
            this.txtTraducir1.Name = "txtTraducir1";
            this.txtTraducir1.Size = new System.Drawing.Size(192, 47);
            this.txtTraducir1.TabIndex = 2;
            // 
            // btnTraducir
            // 
            this.btnTraducir.BackColor = System.Drawing.Color.White;
            this.btnTraducir.Location = new System.Drawing.Point(197, 255);
            this.btnTraducir.Name = "btnTraducir";
            this.btnTraducir.Size = new System.Drawing.Size(239, 39);
            this.btnTraducir.TabIndex = 3;
            this.btnTraducir.Text = "Traducir";
            this.btnTraducir.UseVisualStyleBackColor = false;
            this.btnTraducir.Click += new System.EventHandler(this.btnTraducir_Click);
            // 
            // txtTraducir2
            // 
            this.txtTraducir2.Location = new System.Drawing.Point(360, 179);
            this.txtTraducir2.Multiline = true;
            this.txtTraducir2.Name = "txtTraducir2";
            this.txtTraducir2.Size = new System.Drawing.Size(192, 47);
            this.txtTraducir2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Practica_1.Properties.Resources.Titulo;
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pcbImagen2
            // 
            this.pcbImagen2.Image = global::Practica_1.Properties.Resources.Ingles1;
            this.pcbImagen2.Location = new System.Drawing.Point(495, 232);
            this.pcbImagen2.Name = "pcbImagen2";
            this.pcbImagen2.Size = new System.Drawing.Size(57, 50);
            this.pcbImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen2.TabIndex = 9;
            this.pcbImagen2.TabStop = false;
            // 
            // pcbImagen1
            // 
            this.pcbImagen1.Image = global::Practica_1.Properties.Resources.españa;
            this.pcbImagen1.Location = new System.Drawing.Point(98, 232);
            this.pcbImagen1.Name = "pcbImagen1";
            this.pcbImagen1.Size = new System.Drawing.Size(57, 50);
            this.pcbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen1.TabIndex = 9;
            this.pcbImagen1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica_1.Properties.Resources.idiomas;
            this.pictureBox1.Location = new System.Drawing.Point(332, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::Practica_1.Properties.Resources.arrow_11_24;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(307, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 21);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(644, 330);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pcbImagen2);
            this.Controls.Add(this.pcbImagen1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTraducir2);
            this.Controls.Add(this.btnTraducir);
            this.Controls.Add(this.txtTraducir1);
            this.Controls.Add(this.cboTraducir2);
            this.Controls.Add(this.cboTraducir1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTraducir1;
        private System.Windows.Forms.ComboBox cboTraducir2;
        private System.Windows.Forms.TextBox txtTraducir1;
        private System.Windows.Forms.Button btnTraducir;
        private System.Windows.Forms.TextBox txtTraducir2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbImagen1;
        private System.Windows.Forms.PictureBox pcbImagen2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}