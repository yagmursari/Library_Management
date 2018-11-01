namespace Library_Management3
{
    partial class MainForm
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
            this.grpSiniflar = new System.Windows.Forms.GroupBox();
            this.cmSiniflar = new System.Windows.Forms.ComboBox();
            this.grpislem = new System.Windows.Forms.GroupBox();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpListele = new System.Windows.Forms.GroupBox();
            this.grpSiniflar.SuspendLayout();
            this.grpislem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSiniflar
            // 
            this.grpSiniflar.Controls.Add(this.cmSiniflar);
            this.grpSiniflar.Location = new System.Drawing.Point(0, 0);
            this.grpSiniflar.Name = "grpSiniflar";
            this.grpSiniflar.Size = new System.Drawing.Size(258, 120);
            this.grpSiniflar.TabIndex = 0;
            this.grpSiniflar.TabStop = false;
            this.grpSiniflar.Text = "SINIFLAR";
           
            // 
            // cmSiniflar
            // 
            this.cmSiniflar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmSiniflar.FormattingEnabled = true;
            this.cmSiniflar.Location = new System.Drawing.Point(41, 50);
            this.cmSiniflar.Name = "cmSiniflar";
            this.cmSiniflar.Size = new System.Drawing.Size(171, 21);
            this.cmSiniflar.TabIndex = 0;
            this.cmSiniflar.SelectedIndexChanged += new System.EventHandler(this.cmSiniflar_SelectedIndexChanged);
            // 
            // grpislem
            // 
            this.grpislem.Controls.Add(this.btnduzenle);
            this.grpislem.Controls.Add(this.btnSil);
            this.grpislem.Controls.Add(this.btnEkle);
            this.grpislem.Location = new System.Drawing.Point(390, 0);
            this.grpislem.Name = "grpislem";
            this.grpislem.Size = new System.Drawing.Size(361, 120);
            this.grpislem.TabIndex = 1;
            this.grpislem.TabStop = false;
            this.grpislem.Text = "İŞLEMLER";
            // 
            // btnduzenle
            // 
            this.btnduzenle.Location = new System.Drawing.Point(232, 37);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(94, 48);
            this.btnduzenle.TabIndex = 2;
            this.btnduzenle.Text = "DÜZENLE";
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(140, 37);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 48);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(18, 37);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 48);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpListele
            // 
            this.grpListele.Location = new System.Drawing.Point(12, 126);
            this.grpListele.Name = "grpListele";
            this.grpListele.Size = new System.Drawing.Size(679, 149);
            this.grpListele.TabIndex = 0;
            this.grpListele.TabStop = false;
            this.grpListele.Text = "LİSTELE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 287);
            this.Controls.Add(this.grpListele);
            this.Controls.Add(this.grpislem);
            this.Controls.Add(this.grpSiniflar);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpSiniflar.ResumeLayout(false);
            this.grpislem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSiniflar;
        private System.Windows.Forms.ComboBox cmSiniflar;
        private System.Windows.Forms.GroupBox grpislem;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox grpListele;
    }
}

