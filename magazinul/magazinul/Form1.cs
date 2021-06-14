using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magazinul
{
    public partial class Form1 : Form
    {
        int total;
        public Form1()
        {
            InitializeComponent();
        }

        private void lstProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTricou_Click(object sender, EventArgs e)
        {
            lstProduse.Items.Add("Tricou-200 lei");
            total =total +200;
            lblPret.Text = total.ToString();
        }

        private void btnAdidas_Click(object sender, EventArgs e)
        {
            lstProduse.Items.Add("Adidasi-400 lei");
            total = total + 400;
            lblPret.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = true;
            lstProdus.Visible = false;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            foreach(string s in lstProduse.SelectedItems.OfType<string>().ToList())
            {
                lstProduse.Items.Remove(s);
            }
            if(lstProduse.SelectedItem.ToString() == "Adidasi-400 lei")
            {
                total = total - 400;
                lblPret.Text = total.ToString();
            }
            if(lstProduse.SelectedItem.ToString() == "Tricou-200 lei")
            {
                total = total - 200;
                lblPret.Text = total.ToString();
            }
        }

        private void btnGoleste_Click(object sender, EventArgs e)
        {
            lstProduse.Items.Clear();
            lblPret.Text = " ";
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            lstProdus.Visible = true;
            panel2.Visible = true;
            lstProdus.Size = new Size(604,474);
            lstProdus.Location = new Point(0, 0);
            btnCos.Visible = false;
        }
    }
}
