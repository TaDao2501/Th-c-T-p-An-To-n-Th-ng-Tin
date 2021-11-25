namespace Diffie_Hellman
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtXa = new System.Windows.Forms.TextBox();
            this.txtYa = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtK1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "q";
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(75, 18);
            this.txtq.Multiline = true;
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(100, 22);
            this.txtq.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thực Hiện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "α";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xa";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ya";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "K";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(324, 19);
            this.txta.Multiline = true;
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 22);
            this.txta.TabIndex = 7;
            // 
            // txtXa
            // 
            this.txtXa.Location = new System.Drawing.Point(80, 19);
            this.txtXa.Multiline = true;
            this.txtXa.Name = "txtXa";
            this.txtXa.Size = new System.Drawing.Size(100, 22);
            this.txtXa.TabIndex = 8;
            // 
            // txtYa
            // 
            this.txtYa.Location = new System.Drawing.Point(80, 57);
            this.txtYa.Multiline = true;
            this.txtYa.Name = "txtYa";
            this.txtYa.Size = new System.Drawing.Size(100, 22);
            this.txtYa.TabIndex = 9;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(80, 94);
            this.txtK.Multiline = true;
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 22);
            this.txtK.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtXa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtYb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtK1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtXb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(256, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 130);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bob";
            // 
            // txtYb
            // 
            this.txtYb.Location = new System.Drawing.Point(80, 57);
            this.txtYb.Multiline = true;
            this.txtYb.Name = "txtYb";
            this.txtYb.Size = new System.Drawing.Size(100, 22);
            this.txtYb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yb";
            // 
            // txtK1
            // 
            this.txtK1.Location = new System.Drawing.Point(80, 94);
            this.txtK1.Multiline = true;
            this.txtK1.Name = "txtK1";
            this.txtK1.Size = new System.Drawing.Size(100, 22);
            this.txtK1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Xb";
            // 
            // txtXb
            // 
            this.txtXb.Location = new System.Drawing.Point(80, 19);
            this.txtXb.Multiline = true;
            this.txtXb.Name = "txtXb";
            this.txtXb.Size = new System.Drawing.Size(100, 22);
            this.txtXb.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "K";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 255);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtXa;
        private System.Windows.Forms.TextBox txtYa;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtK1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtXb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
    }
}

