using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void btnCalc_Click(object sender, EventArgs e)
        {
            
            double P = 0f;
            double F = 0f;
            double r = 0f;
            double n = 0f;

            F = double.Parse(txtF.Text);
            r = double.Parse(txtr.Text);
            n = double.Parse(txtn.Text);

            P = F * (r / (Math.Pow(1 + r, n) - 1)) * (1 / (1 + r));
            txtP.Text = P.ToString();
        }
    }
}
