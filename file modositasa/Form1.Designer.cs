
namespace file_modositasa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxAdatok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPontok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbPontokSzama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxAdatok
            // 
            this.lbxAdatok.FormattingEnabled = true;
            this.lbxAdatok.ItemHeight = 15;
            this.lbxAdatok.Location = new System.Drawing.Point(22, 38);
            this.lbxAdatok.Name = "lbxAdatok";
            this.lbxAdatok.Size = new System.Drawing.Size(266, 364);
            this.lbxAdatok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(403, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 23);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Egyesület";
            // 
            // txbPontok
            // 
            this.txbPontok.Location = new System.Drawing.Point(403, 111);
            this.txbPontok.Name = "txbPontok";
            this.txbPontok.Size = new System.Drawing.Size(174, 23);
            this.txbPontok.TabIndex = 7;
            this.txbPontok.TextChanged += new System.EventHandler(this.txbPontok_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pontok";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(419, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 19);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nő";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(511, 156);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 19);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Férfi";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lbPontokSzama
            // 
            this.lbPontokSzama.AutoSize = true;
            this.lbPontokSzama.Location = new System.Drawing.Point(603, 118);
            this.lbPontokSzama.Name = "lbPontokSzama";
            this.lbPontokSzama.Size = new System.Drawing.Size(38, 15);
            this.lbPontokSzama.TabIndex = 10;
            this.lbPontokSzama.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.lbPontokSzama);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txbPontok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxAdatok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAdatok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPontok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbPontokSzama;
    }
}

