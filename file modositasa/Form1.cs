using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace file_modositasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           string[] sorok=File.ReadAllLines("fob2016.txt");
            foreach (var sor in sorok)
                lbxAdatok.Items.Add(sor);
        }


        

       

        private void txbPontok_TextChanged(object sender, EventArgs e)
        {
            lbPontokSzama.Text = String.Format(" {0} db ", txbPontok.Text.Split(' ').Length);
        }
    }
}
