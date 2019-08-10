namespace Araba_Yarışı
{
    partial class bahis
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
            this.radioCar1 = new System.Windows.Forms.RadioButton();
            this.radioCar3 = new System.Windows.Forms.RadioButton();
            this.radioCar2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HANGİ ARABAYA BAHİS OYNAMAK İSTİYORSUN?";
            // 
            // radioCar1
            // 
            this.radioCar1.AutoSize = true;
            this.radioCar1.Location = new System.Drawing.Point(163, 110);
            this.radioCar1.Name = "radioCar1";
            this.radioCar1.Size = new System.Drawing.Size(187, 21);
            this.radioCar1.TabIndex = 1;
            this.radioCar1.TabStop = true;
            this.radioCar1.Text = "1 NUMARA MAVİ (Kartal)";
            this.radioCar1.UseVisualStyleBackColor = true;
            // 
            // radioCar3
            // 
            this.radioCar3.AutoSize = true;
            this.radioCar3.Location = new System.Drawing.Point(163, 183);
            this.radioCar3.Name = "radioCar3";
            this.radioCar3.Size = new System.Drawing.Size(176, 21);
            this.radioCar3.TabIndex = 1;
            this.radioCar3.TabStop = true;
            this.radioCar3.Text = "3 NUMARA SARI (Altın)";
            this.radioCar3.UseVisualStyleBackColor = true;
            // 
            // radioCar2
            // 
            this.radioCar2.AutoSize = true;
            this.radioCar2.Location = new System.Drawing.Point(163, 147);
            this.radioCar2.Name = "radioCar2";
            this.radioCar2.Size = new System.Drawing.Size(198, 21);
            this.radioCar2.TabIndex = 1;
            this.radioCar2.TabStop = true;
            this.radioCar2.Text = "2 NUMARA KIRMIZI (Anka)";
            this.radioCar2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(266, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bahis Oyna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(609, 9);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 17);
            this.lblBakiye.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(612, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bakiye Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(612, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(12, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "ÇIKIŞ YAP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bahis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Araba_Yarışı.Properties.Resources.auto_racing_betting_feature;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 387);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioCar2);
            this.Controls.Add(this.radioCar3);
            this.Controls.Add(this.radioCar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "bahis";
            this.Text = "BAHİS OYNA";
            this.Load += new System.EventHandler(this.bahis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCar1;
        private System.Windows.Forms.RadioButton radioCar3;
        private System.Windows.Forms.RadioButton radioCar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}