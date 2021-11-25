using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diffie_Hellman
{
    
    public partial class Form1 : Form
    {
      
        private bool ktsonto(BigInteger q)
        {
            for (BigInteger i = 2; i <= q / 2; i++)
                if (q % i == 0)
                    return false;
            return true;
        }
        private BigInteger pow(BigInteger num, BigInteger somu)
        {
            BigInteger kq = 1;
            for (BigInteger i = 1; i <= somu; i++)
                kq *= num;
            return kq;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtq.Text = "";
            txtXa.Text = "";
            txtXb.Text = "";
            txtYa.Text = "";
            txtYb.Text = "";
            txtK.Text = "";
            txtK1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            BigInteger q = BigInteger.Parse(txtq.Text);
            BigInteger a = BigInteger.Parse(txta.Text);
            

            BigInteger Ya, Yb, K,K1;
            if (ktsonto(q))
            {
                if (txtXa.Text != "")
                {
                    BigInteger Xa = BigInteger.Parse(txtXa.Text);
                    if (txtXb.Text != "")
                    {
                        BigInteger Xb = BigInteger.Parse(txtXb.Text);
                        Ya = pow(a, Xa) % q;
                        Yb = pow(a, Xb) % q;
                        K = pow(Ya, Xb) % q;
                        K1 = pow(Yb, Xa) % q;
                        txtYa.Text = Ya.ToString();
                        txtYb.Text = Yb.ToString();
                        txtK.Text = K.ToString();
                        txtK1.Text = K1.ToString();
                    }
                    else
                        MessageBox.Show("Nhập Lại Xb", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Nhập lại Xa hoặc Xb", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("q phải là số nguyên tố", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtYa.ReadOnly = true;
            txtYb.ReadOnly = true;
            txtK.ReadOnly = true;
            txtK1.ReadOnly = true;
        }
    }
}
