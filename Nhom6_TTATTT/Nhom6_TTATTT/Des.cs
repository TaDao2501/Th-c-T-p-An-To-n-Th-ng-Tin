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
using System.Data.OleDb;

namespace Nhom6_TTATTT
{
    public partial class Des : Form
    { public string[] stringArr_NhiPhan(string key)
        {
           
            string[] keyBinaryArray = DES1.HexToBin4bit(key);
            return keyBinaryArray;
        }

        public void Key_Binary()
        { 
            string temp = "";
            foreach (var item in stringArr_NhiPhan(txtKhoa.Text))
            {
                temp += (item + " ");
            }
            txtKetQua.AppendText("  K nhị phân: "+temp+ Environment.NewLine);
        }

        public void tim_K_table(string[] matranPC02_Array)
        {

            string[] key_Array = new string[48];
            for (int i = 0; i < 16; i++)
            {

                key_Array = new string[56];
                for (int j = 0; j < 48; j++)
                {
                    int temp = int.Parse(matranPC02_Array[j]) - 1;
                    for (int k = 0; k < 56; k++)
                    {
                        if (temp == k)
                        {
                            key_Array[j] = DES1.listCnDn[i][k];
                        }
                    }
                }
                DES1.key_List.Add(key_Array);
            }

            for (int k = 0; k < 16; k++)
            {
                txtKetQua.AppendText("  K"+(k+1)+" :");
                if(k < 9) txtKetQua.AppendText("  ");
                for (int j = 0; j < 48; j++)
                {
                    txtKetQua.AppendText(DES1.key_List[k][j].ToString() + " ");

                }
                txtKetQua.AppendText(Environment.NewLine);
            }
        }

        public void HoanViKey()
        {
            string[] binaryStr64 = DES1.Convert_16unit4bit_To_64unit1bit(stringArr_NhiPhan(txtKhoa.Text));
            string[] strArray = DES1.hoanVi(DES1.MT_PC1, binaryStr64, 56);
            string temp = "";
          
            for (int i = 0; i < strArray.Length; i++)
            {
                temp += strArray[i];
                if ((i+1) % 4 == 0) temp += " ";
            }
          
            txtKetQua.AppendText("  K hoán vị  : " + temp + Environment.NewLine);
        }

        public void CnDnTable()
        {
            string[] binaryStr64 = DES1.Convert_16unit4bit_To_64unit1bit(stringArr_NhiPhan(txtKhoa.Text));
            string[] keyHoanVi = DES1.hoanVi(DES1.MT_PC1, binaryStr64, 56);
            DES1.CnDnTable(DES1.Dich_CnDn, keyHoanVi);
           
            txtKetQua.AppendText(Environment.NewLine);
            for (int i = 0; i <= 16; i++)
            {
               
                txtKetQua.AppendText("  C" + i + ": ");
                if (i <= 9) txtKetQua.AppendText("  ");
                for (int j = 0; j < 28; j++)
                {
                    
                    txtKetQua.AppendText((DES1.listCn[i][j] + " "));
                }
                txtKetQua.AppendText("|D" + i + ": ");
                if (i <= 9) txtKetQua.AppendText("  ");
                for (int j = 0; j < 28; j++)
                {
                    
                    txtKetQua.AppendText((DES1.listDn[i][j] + " "));

                }
                txtKetQua.AppendText(Environment.NewLine);
            }
        }
        public void TimLnRn(string plainText)
        {
            tim_K_table(DES1.MT_PC2);
            for (int i = 0; i < 16; i++)
            {
                //moi vong co SiBi

                //tinh R tiep theo de gan cho L
                //muon tim dc R1 thi phai lat L0 XOR f(ER0,K1). L0 co, R0 co, K1 co. 
                //b1.Phai tim f(ER0,K1). 
                //b2: f chia thanh 8 nhom 6 bit,
                //b3:moix nhom 6bit hoan vi qua bang sbox tuong ung
                //b3.1: tim x,y;
                //b3.2: tim x,y tuong ung trong Sbox => hoan thanh 1 Si(Bi), lap lai 8 lan;
                //Thuc hien b1:tim f(ER0,K1)

                //listLn[1] = listRn[0];

                DES1.L0R0(stringArr_NhiPhan(plainText));
                string[] f = DES1.KeyXorER(DES1.key_List[i], DES1.listRn[i]);//xong b1;

                string[] Bn_array = DES1.Bn(f);//xong b2;
                DES1.listSboxOut.Add(Bn_array);
                //thuc hien buoc 3;
                //ket qua ra S1(B1) -> S8(B8)
                DES1.timXY(Bn_array);
                DES1.hoanViFquaSBox(Bn_array);
                string[] tempSnBn = DES1.DecimalToBin4bit(DES1.SnBnArray);
                DES1.listSnBnArray.Add(tempSnBn);
                //hoan vi cua f(R0,K1) ;
                string[] binaryStr = DES1.Convert_8unit4bit_To_32unit1bit(tempSnBn);
                string[] F_RK = DES1.hoanVi(DES1.MT_P, binaryStr, 32);
                DES1.listFRK.Add(F_RK);
                string[] temp = DES1.listRn[i];
                DES1.listLn.Insert(i + 1, temp);

                string[] temp2 = DES1.L_Xor_F_RK(DES1.listLn[i], F_RK);
                DES1.listRn.Insert(i + 1, temp2);

            }
        }
        public Des()
        {
            InitializeComponent();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                sw.WriteLine("Bản rõ M: " + txtBanRo.Text);
                sw.WriteLine("Khóa K: " + txtKhoa.Text);
                sw.WriteLine("Bản mã hóa: " + txtBanMaHoa.Text);
                sw.WriteLine("-----------------Chi tiết--------------------------");
                sw.WriteLine(txtKetQua.Text);
                sw.Close();
            }
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if (txtKhoa.Text.Length != 16)
            {
                MessageBox.Show("  Độ dài K phải = 16!", "Thông báo");
                return;
            }
            string cypherText = "";
            string plainText = txtBanRo.Text;
            while (plainText.Length % 16 != 0)
            {
                plainText += "F";
            }
            txtBanRo.Text = plainText;
            string[] plainTextArray = new string[plainText.Length / 16];
            int index = 0;
            for (int i = 0; i < plainTextArray.Length; i++)
            {
                plainTextArray[i] = plainText.Substring(index, 16);
                index += 16;
            }

            txtKetQua.AppendText("  Bản rõ chia thành các đoạn: ");
            txtKetQua.AppendText(Environment.NewLine);
            for (int i = 0; i < plainTextArray.Length; i++)
            {
                txtKetQua.AppendText("  Đoạn " + (i + 1) + ": ");
                txtKetQua.AppendText(plainTextArray[i]);
                txtKetQua.AppendText(Environment.NewLine);
            }
            for (int k = 0; k < plainTextArray.Length; k++)
            {

                txtKetQua.AppendText(Environment.NewLine);
                txtKetQua.AppendText("  Đoạn rõ " + (k + 1) + ": " + plainTextArray[k]); txtKetQua.AppendText(Environment.NewLine);
                plainText = plainTextArray[k];
                //bien doi key - > nhi phan
                Key_Binary();

                //hoan vi khoa 56 bit
                HoanViKey();

                //bang dich theo key theo bang CnDn
                CnDnTable();

                //bang key tu 1->16

                txtKetQua.AppendText(Environment.NewLine);
                //DES.LnRn(stringArr_NhiPhan(txtBanRo.Text));

                TimLnRn(plainText);
                // 16 vong DES
                txtKetQua.AppendText(Environment.NewLine);
                txtKetQua.AppendText("  L0:" + string.Join("", DES1.listLn[0]));
                txtKetQua.AppendText("  R0:" + string.Join("", DES1.listRn[0]));
                for (int i = 1; i <= 16; i++)
                {
                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("----------------------------------------------------------------------Vòng " + i + "---------------------------------------------------------------");
                    txtKetQua.AppendText(Environment.NewLine);

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  L" + i + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                    for (int j = 0; j < DES1.listLn[i].Length; j++)
                        txtKetQua.AppendText(DES1.listLn[i][j]);

                    txtKetQua.AppendText(Environment.NewLine);

                    txtKetQua.AppendText("  E(R" + (i - 1) + ") :"); if (i <= 9) txtKetQua.AppendText("  ");
                    txtKetQua.AppendText(string.Join(" ", DES1.listE_R[i - 1]));
                    txtKetQua.AppendText(Environment.NewLine);

                    txtKetQua.AppendText("  K" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                    txtKetQua.AppendText(string.Join(" ", DES1.key_List[i - 1]));
                    txtKetQua.AppendText(Environment.NewLine);

                    txtKetQua.AppendText("  ER" + (i - 1) + " XOR K" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                    txtKetQua.AppendText(string.Join(" ", DES1.listERXorK[i - 1]));
                    txtKetQua.AppendText(Environment.NewLine);

                    txtKetQua.AppendText("  SBox_Out " + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                    txtKetQua.AppendText(string.Join(" ", DES1.listSboxOut[i - 1]));
                    txtKetQua.AppendText(Environment.NewLine);

                    txtKetQua.AppendText("  S" + (i) + "  B" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                    txtKetQua.AppendText(string.Join(" ", DES1.listSnBnArray[i - 1]));
                    txtKetQua.AppendText(Environment.NewLine);

                    txtKetQua.AppendText("  F(R" + (i - 1) + "K" + (i) + "):"); if (i <= 9) txtKetQua.AppendText("  ");
                    txtKetQua.AppendText(string.Join(" ", DES1.listFRK[i - 1]));

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  L" + (i - 1) + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                    for (int j = 0; j < DES1.listLn[i - 1].Length; j++)
                        txtKetQua.AppendText(DES1.listLn[i][j] + " ");
                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  R" + i + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                    for (int j = 0; j < DES1.listRn[i].Length; j++)
                        txtKetQua.AppendText(DES1.listRn[i][j] + " ");

                }
                string[] R16L16 = DES1.listRn[16].Concat(DES1.listLn[16]).ToArray();
                string[] hoanviIpNegative1 = DES1.hoanVi(DES1.MT_IP_negative1, R16L16, 64);

                txtKetQua.AppendText(Environment.NewLine);
                txtKetQua.AppendText(Environment.NewLine);
                string hoanviIpNegative1Str = string.Join("", hoanviIpNegative1);
                txtKetQua.AppendText("  IP-1:" + hoanviIpNegative1Str);
                cypherText += DES1.binary4bitToHexDecimal(hoanviIpNegative1Str); txtKetQua.AppendText(Environment.NewLine);
                txtKetQua.AppendText("  Bản mã của đoạn: " + DES1.binary4bitToHexDecimal(hoanviIpNegative1Str)); txtKetQua.AppendText(Environment.NewLine);
                txtKetQua.AppendText("______________________________________________________________________________________________________________________"); txtKetQua.AppendText(Environment.NewLine);
                DES1.DisposeAll();
            }
            txtBanMaHoa.Text = cypherText;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBanMaHoa.Clear();
            txtBanRo.Clear();
            txtKetQua.Clear();
            txtKhoa.Clear();
            txtBanRo.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
