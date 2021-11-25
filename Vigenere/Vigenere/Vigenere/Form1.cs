using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Mahoa(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = (char)(s[i] + key[j] - 'A');
                    if (s[i] > 'Z') s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }
        public void GiaiMa(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) 
                s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = s[i] >= key[j] ?
                              (char)(s[i] - key[j] + 'A') :
                              (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(textBox1.Text);
            string key = textBox2.Text;
            Mahoa(ref s, key);
            textBox3.Text = Convert.ToString(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(textBox3.Text);
            string key = textBox2.Text;
            GiaiMa(ref s, key);
            textBox1.Text = Convert.ToString(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
