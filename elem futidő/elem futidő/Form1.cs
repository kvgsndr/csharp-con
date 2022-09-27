using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elem_futidő
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label lab1 = new Label();
            lab1.Text = "Futási időben";
            lab1.Width = 300;
            lab1.Height = 200;
            lab1.Left = 10;
            lab1.Height = 20;
            lab1.Name = "Lab1";
            this.Controls.Add(lab1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
