namespace logowanie
{
    partial class czyszczenie
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
            this.txbTXT = new System.Windows.Forms.TextBox();
            this.btnCzysc = new System.Windows.Forms.Button();
            this.txbKtoraLinijka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbTXT
            // 
            this.txbTXT.Location = new System.Drawing.Point(12, 32);
            this.txbTXT.Multiline = true;
            this.txbTXT.Name = "txbTXT";
            this.txbTXT.Size = new System.Drawing.Size(429, 323);
            this.txbTXT.TabIndex = 0;
            // 
            // btnCzysc
            // 
            this.btnCzysc.Location = new System.Drawing.Point(456, 163);
            this.btnCzysc.Name = "btnCzysc";
            this.btnCzysc.Size = new System.Drawing.Size(308, 81);
            this.btnCzysc.TabIndex = 1;
            this.btnCzysc.Text = "Wyczysc";
            this.btnCzysc.UseVisualStyleBackColor = true;
            this.btnCzysc.Click += new System.EventHandler(this.btnCzysc_Click);
            // 
            // txbKtoraLinijka
            // 
            this.txbKtoraLinijka.Location = new System.Drawing.Point(493, 74);
            this.txbKtoraLinijka.Name = "txbKtoraLinijka";
            this.txbKtoraLinijka.Size = new System.Drawing.Size(216, 23);
            this.txbKtoraLinijka.TabIndex = 2;
            this.txbKtoraLinijka.TextChanged += new System.EventHandler(this.txbKtoraLinijka_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "TXT plik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz linijke";
            // 
            // czyszczenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbKtoraLinijka);
            this.Controls.Add(this.btnCzysc);
            this.Controls.Add(this.txbTXT);
            this.Name = "czyszczenie";
            this.Text = "czyszczenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbTXT;
        private Button btnCzysc;
        private TextBox txbKtoraLinijka;
        private Label label1;
        private Label label2;
    }
}