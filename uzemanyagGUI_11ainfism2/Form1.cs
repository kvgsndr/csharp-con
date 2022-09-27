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

namespace uzemanyagGUI_11ainfism2
{
    public partial class uzemanyagGUI : Form
    {
        public uzemanyagGUI()
        {
            InitializeComponent();
        }

        private void btHozzaad_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDateTime(txbDatum.Text);
            }
            catch (Exception kiv)
            {

                MessageBox.Show(kiv.Message);
            }


            
            var elemek=txbDatum.Text.Split('.');
            if( elemek.Length != 3)
            {
                MessageBox.Show("Hibás Dátum", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ev = int.Parse(elemek[0]);
            int ho = int.Parse(elemek[1]);
            int nap = int.Parse(elemek[2]);

            if (ev > 2016 || ev < 2011)
            {
                MessageBox.Show("Hibás évszám", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ho > 12 || ho < 1)
            {
                MessageBox.Show("Hibás hónap", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (nap > 31 || nap < 1)
            { 
                MessageBox.Show("Hibás nap", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txbDatum.Focus();
            txbDatum.SelectAll();
            if (int.Parse(txbBenzin.Text) < 0)
            { 
                MessageBox.Show($"Rossz benzinár!! ");
                txbBenzin.Focus();
                txbBenzin.SelectAll();
                return;
            }

            if (int.Parse(txbGazolaj.Text) < 0)
            {
                MessageBox.Show($"Rossz gázolajár!! ");
                txbGazolaj.Focus();
                txbGazolaj.SelectAll();
                return;
            }


            lbxLista.Items.Add( $"{txbDatum.Text};{txbBenzin.Text};{txbGazolaj.Text}" );

            txbBenzin.Clear();
            txbDatum.Clear();
            txbGazolaj.Clear();

        }

        private void btMent_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter fki = new StreamWriter(txbFileName.Text);
                foreach (var item in lbxLista.Items)
                {
                    fki.WriteLine(item);
                }
                fki.Close();
                MessageBox.Show("A mentés sikeres", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba történt a file megnyitásánál!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
    }
}
