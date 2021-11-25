namespace WindowsFormsApplication2
{
    partial class RSA_LuongThiThuongThuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnSinhPQ = new System.Windows.Forms.Button();
			this.txtP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPri = new System.Windows.Forms.Button();
			this.btnPub = new System.Windows.Forms.Button();
			this.btnMa = new System.Windows.Forms.Button();
			this.txtN = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtE = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBanMa = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBanRo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.txtD = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_N = new System.Windows.Forms.TextBox();
			this.bntGiaiMa = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtC = new System.Windows.Forms.TextBox();
			this.txtP1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtq = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtS = new System.Windows.Forms.TextBox();
			this.txtP2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSinhPQ
			// 
			this.btnSinhPQ.Location = new System.Drawing.Point(16, 15);
			this.btnSinhPQ.Margin = new System.Windows.Forms.Padding(4);
			this.btnSinhPQ.Name = "btnSinhPQ";
			this.btnSinhPQ.Size = new System.Drawing.Size(201, 31);
			this.btnSinhPQ.TabIndex = 0;
			this.btnSinhPQ.Text = "Sinh cặp khóa bất đối xứng";
			this.btnSinhPQ.UseVisualStyleBackColor = true;
			this.btnSinhPQ.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtP
			// 
			this.txtP.Location = new System.Drawing.Point(29, 201);
			this.txtP.Margin = new System.Windows.Forms.Padding(4);
			this.txtP.Name = "txtP";
			this.txtP.Size = new System.Drawing.Size(529, 22);
			this.txtP.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 169);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nhập văn bản cần mã hóa";
			// 
			// btnPri
			// 
			this.btnPri.Location = new System.Drawing.Point(573, 367);
			this.btnPri.Margin = new System.Windows.Forms.Padding(4);
			this.btnPri.Name = "btnPri";
			this.btnPri.Size = new System.Drawing.Size(151, 28);
			this.btnPri.TabIndex = 3;
			this.btnPri.Text = "Tạo khóa riêng";
			this.btnPri.UseVisualStyleBackColor = true;
			this.btnPri.Click += new System.EventHandler(this.btnPri_Click);
			// 
			// btnPub
			// 
			this.btnPub.Location = new System.Drawing.Point(573, 124);
			this.btnPub.Margin = new System.Windows.Forms.Padding(4);
			this.btnPub.Name = "btnPub";
			this.btnPub.Size = new System.Drawing.Size(151, 30);
			this.btnPub.TabIndex = 4;
			this.btnPub.Text = "Tạo khóa công khai";
			this.btnPub.UseVisualStyleBackColor = true;
			this.btnPub.Click += new System.EventHandler(this.btnPub_Click);
			// 
			// btnMa
			// 
			this.btnMa.Location = new System.Drawing.Point(573, 201);
			this.btnMa.Margin = new System.Windows.Forms.Padding(4);
			this.btnMa.Name = "btnMa";
			this.btnMa.Size = new System.Drawing.Size(77, 28);
			this.btnMa.TabIndex = 5;
			this.btnMa.Text = "Mã hóa";
			this.btnMa.UseVisualStyleBackColor = true;
			this.btnMa.Click += new System.EventHandler(this.btnMa_Click);
			// 
			// txtN
			// 
			this.txtN.Location = new System.Drawing.Point(72, 89);
			this.txtN.Margin = new System.Windows.Forms.Padding(4);
			this.txtN.Name = "txtN";
			this.txtN.Size = new System.Drawing.Size(487, 22);
			this.txtN.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 64);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Nhập khóa công khai";
			// 
			// txtE
			// 
			this.txtE.Location = new System.Drawing.Point(72, 129);
			this.txtE.Margin = new System.Windows.Forms.Padding(4);
			this.txtE.Name = "txtE";
			this.txtE.Size = new System.Drawing.Size(487, 22);
			this.txtE.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 97);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Số n";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 133);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "Số e";
			// 
			// txtBanMa
			// 
			this.txtBanMa.Location = new System.Drawing.Point(29, 254);
			this.txtBanMa.Margin = new System.Windows.Forms.Padding(4);
			this.txtBanMa.Name = "txtBanMa";
			this.txtBanMa.Size = new System.Drawing.Size(529, 22);
			this.txtBanMa.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 234);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Kết quả";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(29, 480);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 17);
			this.label6.TabIndex = 23;
			this.label6.Text = "Kết quả";
			// 
			// txtBanRo
			// 
			this.txtBanRo.Location = new System.Drawing.Point(33, 500);
			this.txtBanRo.Margin = new System.Windows.Forms.Padding(4);
			this.txtBanRo.Name = "txtBanRo";
			this.txtBanRo.Size = new System.Drawing.Size(525, 22);
			this.txtBanRo.TabIndex = 22;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(29, 379);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 17);
			this.label7.TabIndex = 21;
			this.label7.Text = "Số d";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(29, 343);
			this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(37, 17);
			this.label.TabIndex = 20;
			this.label.Text = "Số n";
			this.label.Click += new System.EventHandler(this.txtN1_Click);
			// 
			// txtD
			// 
			this.txtD.Location = new System.Drawing.Point(76, 375);
			this.txtD.Margin = new System.Windows.Forms.Padding(4);
			this.txtD.Name = "txtD";
			this.txtD.Size = new System.Drawing.Size(483, 22);
			this.txtD.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(25, 315);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(119, 17);
			this.label9.TabIndex = 18;
			this.label9.Text = "Nhập khóa bí mật";
			// 
			// txt_N
			// 
			this.txt_N.Location = new System.Drawing.Point(76, 335);
			this.txt_N.Margin = new System.Windows.Forms.Padding(4);
			this.txt_N.Name = "txt_N";
			this.txt_N.Size = new System.Drawing.Size(483, 22);
			this.txt_N.TabIndex = 17;
			// 
			// bntGiaiMa
			// 
			this.bntGiaiMa.Location = new System.Drawing.Point(573, 443);
			this.bntGiaiMa.Margin = new System.Windows.Forms.Padding(4);
			this.bntGiaiMa.Name = "bntGiaiMa";
			this.bntGiaiMa.Size = new System.Drawing.Size(77, 28);
			this.bntGiaiMa.TabIndex = 16;
			this.bntGiaiMa.Text = "Giải mã";
			this.bntGiaiMa.UseVisualStyleBackColor = true;
			this.bntGiaiMa.Click += new System.EventHandler(this.bntGiaiMa_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(29, 415);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(173, 17);
			this.label10.TabIndex = 14;
			this.label10.Text = "Nhập văn bản cần giải mã";
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(33, 447);
			this.txtC.Margin = new System.Windows.Forms.Padding(4);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(525, 22);
			this.txtC.TabIndex = 13;
			// 
			// txtP1
			// 
			this.txtP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtP1.Location = new System.Drawing.Point(274, 19);
			this.txtP1.Name = "txtP1";
			this.txtP1.Size = new System.Drawing.Size(80, 22);
			this.txtP1.TabIndex = 25;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(243, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 17);
			this.label8.TabIndex = 24;
			this.label8.Text = "p";
			// 
			// txtq
			// 
			this.txtq.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtq.Location = new System.Drawing.Point(274, 59);
			this.txtq.Name = "txtq";
			this.txtq.Size = new System.Drawing.Size(80, 22);
			this.txtq.TabIndex = 27;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(243, 62);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(16, 17);
			this.label11.TabIndex = 26;
			this.label11.Text = "q";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(575, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 23);
			this.button1.TabIndex = 28;
			this.button1.Text = "Tính khóa";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(573, 59);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 23);
			this.button2.TabIndex = 29;
			this.button2.Text = "Xác thực";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtS
			// 
			this.txtS.Location = new System.Drawing.Point(405, 19);
			this.txtS.Name = "txtS";
			this.txtS.Size = new System.Drawing.Size(100, 22);
			this.txtS.TabIndex = 30;
			// 
			// txtP2
			// 
			this.txtP2.Location = new System.Drawing.Point(405, 59);
			this.txtP2.Name = "txtP2";
			this.txtP2.Size = new System.Drawing.Size(100, 22);
			this.txtP2.TabIndex = 31;
			// 
			// RSA_LuongThiThuongThuong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 556);
			this.Controls.Add(this.txtP2);
			this.Controls.Add(this.txtS);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtq);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtP1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtBanRo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label);
			this.Controls.Add(this.txtD);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txt_N);
			this.Controls.Add(this.bntGiaiMa);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtBanMa);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtE);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtN);
			this.Controls.Add(this.btnMa);
			this.Controls.Add(this.btnPub);
			this.Controls.Add(this.btnPri);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtP);
			this.Controls.Add(this.btnSinhPQ);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "RSA_LuongThiThuongThuong";
			this.Text = "RSA";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinhPQ;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPri;
        private System.Windows.Forms.Button btnPub;
        private System.Windows.Forms.Button btnMa;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBanMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBanRo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_N;
        private System.Windows.Forms.Button bntGiaiMa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtP1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtq;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtS;
		private System.Windows.Forms.TextBox txtP2;
	}
}

