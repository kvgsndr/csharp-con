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

namespace formosapp11ainfism2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOKE_Click(object sender, EventArgs e)
        {
            if (File.Exists(txbSzoveg.Text))
            {
                try
                {
                    StreamReader fbe = new StreamReader(txbSzoveg.Text);
                    //txbTartalom.Text = fbe.ReadToEnd();
                    while (!fbe.EndOfStream)
                    {   string st = fbe.ReadLine();
                        lbxTartalom.Items.Add(st);
                        cbxTartalom.Items.Add(st);
                    }

                    fbe.Close();


                }
                catch (Exception kiv)
                {

                    MessageBox.Show($"Hiba!!! {kiv.Message}");
                }

            }
            else
                MessageBox.Show($"A {txbSzoveg} fájl nem létezik!!!");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbxTartalom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbTartalom.Text = lbxTartalom.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxTartalom.Text = txbTartalom.Text;
        }

        private void btHozaad_Click(object sender, EventArgs e)
        {
            cbxTartalom.Items.Add(cbxTartalom.Text);
        }
    }
}
