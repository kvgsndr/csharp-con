
namespace uzemanyagGUI_11ainfism2
{
    partial class uzemanyagGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDatum = new System.Windows.Forms.TextBox();
            this.txbBenzin = new System.Windows.Forms.TextBox();
            this.txbGazolaj = new System.Windows.Forms.TextBox();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbFileName = new System.Windows.Forms.TextBox();
            this.btHozzaad = new System.Windows.Forms.Button();
            this.btMent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dátum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Benzin ár (Ft)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gázolaj ár (Ft)";
            // 
            // txbDatum
            // 
            this.txbDatum.Location = new System.Drawing.Point(127, 32);
            this.txbDatum.Name = "txbDatum";
            this.txbDatum.Size = new System.Drawing.Size(184, 23);
            this.txbDatum.TabIndex = 3;
            // 
            // txbBenzin
            // 
            this.txbBenzin.Location = new System.Drawing.Point(127, 73);
            this.txbBenzin.Name = "txbBenzin";
            this.txbBenzin.Size = new System.Drawing.Size(184, 23);
            this.txbBenzin.TabIndex = 4;
            // 
            // txbGazolaj
            // 
            this.txbGazolaj.Location = new System.Drawing.Point(127, 109);
            this.txbGazolaj.Name = "txbGazolaj";
            this.txbGazolaj.Size = new System.Drawing.Size(184, 23);
            this.txbGazolaj.TabIndex = 5;
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.ItemHeight = 15;
            this.lbxLista.Location = new System.Drawing.Point(13, 185);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(299, 199);
            this.lbxLista.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "File neve:";
            // 
            // txbFileName
            // 
            this.txbFileName.Location = new System.Drawing.Point(84, 405);
            this.txbFileName.Name = "txbFileName";
            this.txbFileName.Size = new System.Drawing.Size(107, 23);
            this.txbFileName.TabIndex = 8;
            this.txbFileName.Text = "adatok.txt";
            // 
            // btHozzaad
            // 
            this.btHozzaad.Location = new System.Drawing.Point(236, 141);
            this.btHozzaad.Name = "btHozzaad";
            this.btHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btHozzaad.TabIndex = 9;
            this.btHozzaad.Text = "Hozzáad";
            this.btHozzaad.UseVisualStyleBackColor = true;
            this.btHozzaad.Click += new System.EventHandler(this.btHozzaad_Click);
            // 
            // btMent
            // 
            this.btMent.Location = new System.Drawing.Point(236, 405);
            this.btMent.Name = "btMent";
            this.btMent.Size = new System.Drawing.Size(75, 29);
            this.btMent.TabIndex = 10;
            this.btMent.Text = "Mentés";
            this.btMent.UseVisualStyleBackColor = true;
            this.btMent.Click += new System.EventHandler(this.btMent_Click);
            // 
            // uzemanyagGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btMent);
            this.Controls.Add(this.btHozzaad);
            this.Controls.Add(this.txbFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.txbGazolaj);
            this.Controls.Add(this.txbBenzin);
            this.Controls.Add(this.txbDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uzemanyagGUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ÜzemanyagGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDatum;
        private System.Windows.Forms.TextBox txbBenzin;
        private System.Windows.Forms.TextBox txbGazolaj;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbFileName;
        private System.Windows.Forms.Button btHozzaad;
        private System.Windows.Forms.Button btMent;
    }
}

