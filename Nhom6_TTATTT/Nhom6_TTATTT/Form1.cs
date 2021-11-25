using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom6_TTATTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void caesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caesar frm = new Caesar();
            frm.Show();
            this.Show();
        }

        private void playFairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Fair frm = new Play_Fair();
       
            frm.Show();
            this.Show();
        }

        private void vigenereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vigenere frm = new Vigenere();
            frm.Show();
            this.Show();
        }

        private void desToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Des frm = new Des();
            frm.Show();
            this.Show();
        }

        private void railsFenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rails_Fence frm = new Rails_Fence();
            
            frm.Show();
            this.Show();
        }

        private void mãHóaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHHang frm = new MHHang();
            frm.Show();
            this.Show();
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSA_N6 frm = new RSA_N6();
            frm.Show();
            this.Show();
        }

        private void diffieHellmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diffie_Hellman frm = new Diffie_Hellman();
            
            frm.Show();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
