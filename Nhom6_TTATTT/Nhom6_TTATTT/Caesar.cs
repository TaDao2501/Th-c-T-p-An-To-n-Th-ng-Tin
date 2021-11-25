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
    public partial class Caesar : Form
    {
        public Caesar()
        {
            InitializeComponent();
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            string a = txtInputE.Text;
            int x = Convert.ToInt32(txtKhoaE.Text);
            txtOutputE.Text = ceasear.cEncrypt(a, x);
        }
        
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }

        private void txtKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }

        private void txtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }

        private void txtInputD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }
        private void txtKhoaD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }

        private void txtOutputD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }
        public class ceasear
        {
            public static string cEncrypt(string text, int key)
            {
                string result = "";

                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsUpper(text[i]))
                    {
                        result += Convert.ToChar(Convert.ToInt32(text[i] + key - 65) % 26 + 65);
                    }
                    else
                    {
                        result += Convert.ToChar(Convert.ToInt32(text[i] + key - 97) % 26 + 97);
                    }
                }
                return result;
            }

            public static string cDecrypt(string text, int key)
            {
                string result = "";

                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsUpper(text[i]))
                    {
                        result += Convert.ToChar(Convert.ToInt32(text[i] + 26 - key - 65) % 26 + 65);
                    }
                    else
                    {
                        result += Convert.ToChar(Convert.ToInt32(text[i] + 26 - key - 97) % 26 + 97);
                    }
                }
                return result;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            string a = txtInputD.Text;
            int x = Convert.ToInt32(txtKhoaD.Text);
            txtOutputD.Text = ceasear.cDecrypt(a, x);
        }
    }
}
