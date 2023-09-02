using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Evaluatebtn_Click(object sender, EventArgs e)
        {
            int a = int.Parse(atxt.Text);
            int b = int.Parse(btxt.Text);
            int m = int.Parse(mtxt.Text);
            int c = int.Parse(ctxt.Text);
            int d = int.Parse(dtxt.Text);
            int n = int.Parse(ntxt.Text);
            int y = ((m * c - n * a) / (c * b - a * d));
            int x = ((d * m - b * n) / (a * d - b * c));
            mLbl.Text = "X=" + x.ToString();
            nLbl.Text = "Y=" + y.ToString();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            atxt.Clear();
            btxt.Clear();
            mtxt.Clear();
            ctxt.Clear();
            dtxt.Clear();
            ntxt.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


          