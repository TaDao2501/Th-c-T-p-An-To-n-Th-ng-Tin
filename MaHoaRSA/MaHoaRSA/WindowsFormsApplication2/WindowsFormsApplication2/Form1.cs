using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApplication2
{
    public partial class RSA_LuongThiThuongThuong : Form
    {
        Random rnd = new Random();
        KhoaCongKhai a = new KhoaCongKhai();
        KhoaBiMat b = new KhoaBiMat();
        public RSA_LuongThiThuongThuong()
        {
            InitializeComponent();
        }
        //BigInteger RANDBIG()
        //{
        //    string result="";
        //    for (int i = 0; i < 30; i++)
        //    {
        //        BigInteger rand = rnd.Next(0,9);
        //        result= String.Concat(result, rand.ToString());
        //    }
        //    BigInteger a = BigInteger.Parse(result);
        //    return a;
        //}
        BigInteger gcd_extend(BigInteger a, BigInteger b, ref BigInteger x , ref BigInteger y)
        {
            if (b == 0)
            {
                x = 1;
                y = 0;
                return a;
            }
            BigInteger x1=0, y1=0;
            BigInteger gcd = gcd_extend(b, a % b, ref x1,  ref y1);
            x = y1;
            y = x1 - (a / b) * y1;
            return gcd;
        }
        BigInteger modulo_inverse_euclidean(BigInteger n, BigInteger m)
        {
            BigInteger x = 0, y =0;
            if (gcd_extend(n, m, ref x,  ref y) != 1) return -1;
            return (x % m + m) % m; 
        }
        int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //RabinMiBigIntegerer rabin = new RabinMiBigIntegerer();
            //bool Flag = false;
            //BigInteger p = 0, q = 0;
            //while (Flag == false)
            //{
            //    BigInteger k = RANDBIG();
            //    if (rabin.miller(k) == true)
            //    {
            //        p = k;
            //        Flag = true;
            //    }
            //}
            //Flag = false;
            //while (Flag == false)
            //{
            //    BigInteger t = RANDBIG();
            //    if (rabin.miller(t) == true)
            //    {
            //        q = t;
            //        Flag = true;
            //    }
            //}
            //Flag = false;
            //MessageBox.Show("Số p: " + p + "\n" + "Số q: " + q);
            //txtP1.Text = p.ToString();
            //txtq.Text = q.ToString();
            //BigInteger phi_n,n;
            //BigInteger rsa_e=2;
            //while(Flag==false)
            //{
            //    BigInteger t = rnd.Next(2,999999);
            //    if (rabin.miller(t) == true)
            //    {
            //        rsa_e = t;
            //        Flag = true;
            //    }
            //}
            //phi_n = (p - 1) * (q - 1);
            //n = p * q;
            //BigInteger d = modulo_inverse_euclidean(rsa_e, phi_n);
            //txtN.Text = txt_N.Text = n.ToString();
            //txtE.Text = rsa_e.ToString();
            //txtD.Text = d.ToString();
        }

        private void btnPub_Click(object sender, EventArgs e)
        {
            a.n = BigInteger.Parse(txtN.Text.Trim());
            a.e = BigInteger.Parse(txtE.Text.Trim());
            MessageBox.Show("Tạo thành công!!!");
        }

        private void btnPri_Click(object sender, EventArgs e)
        {
            b.n = BigInteger.Parse(txt_N.Text.Trim());
            b.d = BigInteger.Parse(txtD.Text.Trim());
            MessageBox.Show("Tạo thành công!!!");
        }

        private void btnMa_Click(object sender, EventArgs e)
        {
            RSA RSA = new RSA();
            BigInteger P = BigInteger.Parse(txtP.Text.Trim());
            BigInteger C = RSA.MaHoaRSA(P, a);
            txtBanMa.Text = C.ToString();
        }

        private void bntGiaiMa_Click(object sender, EventArgs e)
        {
            RSA_LuongThiThuongThuong RSA = new RSA_LuongThiThuongThuong();
            BigInteger C = BigInteger.Parse(txtC.Text);
            BigInteger D = BigInteger.Parse(txtD.Text);
            BigInteger n = BigInteger.Parse(txtN.Text);
            BigInteger P;
            P = pow(C, D) % n;
            txtBanRo.Text = P.ToString();
        }

        private void txtN1_Click(object sender, EventArgs e)
        {

        }
		//public int N(int a, int b)
		//{
		//    int kq = 0;
		//    kq = a * b;
		//    return kq;
		//}
		//public int FiN(int a, int b)
		//{
		//    int kq = 0;
		//    kq = (a - 1) * (b - 1);
		//    return kq;
		//}

		public BigInteger d(BigInteger p, BigInteger q, BigInteger e)
		{
            BigInteger i;
            BigInteger n;
			n = p * q;
			for (i = 1; i <= n; i++)
			{
				if ((i * e) % ((p-1)*(q-1)) == 1)
				{
					return i;
				}
			}
			return i;

		}
		private void button1_Click_1(object sender, EventArgs e)
		{
            BigInteger p = int.Parse(txtP1.Text);
            BigInteger q = int.Parse(txtq.Text);
            BigInteger E = int.Parse(txtE.Text);
            BigInteger n = 0;
            n=p * q;
            txt_N.Text = n.ToString();
            txtN.Text = n.ToString();
            BigInteger kq = d(p, q, E);
            txtD.Text = kq.ToString();

        }
        public BigInteger pow(BigInteger num, BigInteger somu)
		{
            BigInteger kq = 1;
            for (BigInteger i = 1; i <= somu; i++)
                kq *= num;
            return kq;
		}
		private void button2_Click(object sender, EventArgs e)
		{
            BigInteger p = BigInteger.Parse(txtP.Text);
            BigInteger q = BigInteger.Parse(txtq.Text);
            BigInteger E = BigInteger.Parse(txtE.Text);
            BigInteger d = BigInteger.Parse(txtD.Text);
            BigInteger n = BigInteger.Parse(txtN.Text);
            BigInteger s;
            s = pow(p, d) % n;
            BigInteger p1;
            p1 = pow(s, E) % n;
            txtS.Text ="S= "+ s.ToString();
            txtP2.Text ="P= "+ p1.ToString();
            if (p1 == p)
            {
                MessageBox.Show("Chữ kí đúng");

            }
            else
                MessageBox.Show("Chữ kí sai");

		}
	}
}
