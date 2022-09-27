
namespace formosapp11ainfism2
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
            this.btOKE = new System.Windows.Forms.Button();
            this.lbFelirat = new System.Windows.Forms.Label();
            this.txbSzoveg = new System.Windows.Forms.TextBox();
            this.txbTartalom = new System.Windows.Forms.TextBox();
            this.lbxTartalom = new System.Windows.Forms.ListBox();
            this.cbxTartalom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btHozaad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOKE
            // 
            this.btOKE.Location = new System.Drawing.Point(256, 22);
            this.btOKE.Name = "btOKE";
            this.btOKE.Size = new System.Drawing.Size(75, 23);
            this.btOKE.TabIndex = 0;
            this.btOKE.Text = "OKÉ";
            this.btOKE.UseVisualStyleBackColor = true;
            this.btOKE.Click += new System.EventHandler(this.btOKE_Click);
            // 
            // lbFelirat
            // 
            this.lbFelirat.AutoSize = true;
            this.lbFelirat.Location = new System.Drawing.Point(12, 22);
            this.lbFelirat.Name = "lbFelirat";
            this.lbFelirat.Size = new System.Drawing.Size(56, 15);
            this.lbFelirat.TabIndex = 1;
            this.lbFelirat.Text = "File neve:";
            // 
            // txbSzoveg
            // 
            this.txbSzoveg.Location = new System.Drawing.Point(77, 22);
            this.txbSzoveg.Name = "txbSzoveg";
            this.txbSzoveg.Size = new System.Drawing.Size(162, 23);
            this.txbSzoveg.TabIndex = 2;
            this.txbSzoveg.Text = "adatok.txt";
            // 
            // txbTartalom
            // 
            this.txbTartalom.Location = new System.Drawing.Point(12, 73);
            this.txbTartalom.Multiline = true;
            this.txbTartalom.Name = "txbTartalom";
            this.txbTartalom.Size = new System.Drawing.Size(227, 73);
            this.txbTartalom.TabIndex = 3;
            // 
            // lbxTartalom
            // 
            this.lbxTartalom.FormattingEnabled = true;
            this.lbxTartalom.ItemHeight = 15;
            this.lbxTartalom.Location = new System.Drawing.Point(12, 154);
            this.lbxTartalom.Name = "lbxTartalom";
            this.lbxTartalom.Size = new System.Drawing.Size(227, 304);
            this.lbxTartalom.TabIndex = 4;
            this.lbxTartalom.SelectedIndexChanged += new System.EventHandler(this.lbxTartalom_SelectedIndexChanged);
            // 
            // cbxTartalom
            // 
            this.cbxTartalom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxTartalom.FormattingEnabled = true;
            this.cbxTartalom.Location = new System.Drawing.Point(346, 73);
            this.cbxTartalom.Name = "cbxTartalom";
            this.cbxTartalom.Size = new System.Drawing.Size(134, 383);
            this.cbxTartalom.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "--->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btHozaad
            // 
            this.btHozaad.Location = new System.Drawing.Point(256, 73);
            this.btHozaad.Name = "btHozaad";
            this.btHozaad.Size = new System.Drawing.Size(75, 23);
            this.btHozaad.TabIndex = 7;
            this.btHozaad.Text = "Hozzáad";
            this.btHozaad.UseVisualStyleBackColor = true;
            this.btHozaad.Click += new System.EventHandler(this.btHozaad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 474);
            this.Controls.Add(this.btHozaad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxTartalom);
            this.Controls.Add(this.lbxTartalom);
            this.Controls.Add(this.txbTartalom);
            this.Controls.Add(this.txbSzoveg);
            this.Controls.Add(this.lbFelirat);
            this.Controls.Add(this.btOKE);
            this.Name = "Form1";
            this.Text = "File beolvas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOKE;
        private System.Windows.Forms.Label lbFelirat;
        private System.Windows.Forms.TextBox txbSzoveg;
        private System.Windows.Forms.TextBox txbTartalom;
        private System.Windows.Forms.ListBox lbxTartalom;
        private System.Windows.Forms.ComboBox cbxTartalom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btHozaad;
    }
}

