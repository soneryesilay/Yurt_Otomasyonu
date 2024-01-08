﻿using System.Drawing;
using System.Windows.Forms;
using System;

namespace YurtKayitOtomasyon
{
    partial class FrmOgrKayit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbbolum = new System.Windows.Forms.ComboBox();
            this.mskkayittarih = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.OgrID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbolum);
            this.groupBox1.Controls.Add(this.mskkayittarih);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.CmbOdaNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MskDogum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MskOgrTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MskTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtOgrSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtOgrAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(56, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 352);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİ";
            // 
            // cmbbolum
            // 
            this.cmbbolum.Font = new System.Drawing.Font("Georgia", 12F);
            this.cmbbolum.FormattingEnabled = true;
            this.cmbbolum.Location = new System.Drawing.Point(161, 205);
            this.cmbbolum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Size = new System.Drawing.Size(294, 32);
            this.cmbbolum.TabIndex = 7;
            // 
            // mskkayittarih
            // 
            this.mskkayittarih.Font = new System.Drawing.Font("Georgia", 12F);
            this.mskkayittarih.Location = new System.Drawing.Point(161, 307);
            this.mskkayittarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskkayittarih.Mask = "00/00/0000";
            this.mskkayittarih.Name = "mskkayittarih";
            this.mskkayittarih.Size = new System.Drawing.Size(294, 30);
            this.mskkayittarih.TabIndex = 44;
            this.mskkayittarih.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 21);
            this.label12.TabIndex = 43;
            this.label12.Text = "Kayıt Tarihi : ";
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.Font = new System.Drawing.Font("Georgia", 12F);
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(161, 271);
            this.CmbOdaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(294, 32);
            this.CmbOdaNo.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11F);
            this.label8.Location = new System.Drawing.Point(74, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Oda No:";
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtMail.Location = new System.Drawing.Point(161, 240);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(294, 30);
            this.TxtMail.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11F);
            this.label7.Location = new System.Drawing.Point(100, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11F);
            this.label6.Location = new System.Drawing.Point(15, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Öğrenci Bölüm:";
            // 
            // MskDogum
            // 
            this.MskDogum.Font = new System.Drawing.Font("Georgia", 12F);
            this.MskDogum.Location = new System.Drawing.Point(161, 171);
            this.MskDogum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(294, 30);
            this.MskDogum.TabIndex = 6;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11F);
            this.label5.Location = new System.Drawing.Point(22, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // MskOgrTelefon
            // 
            this.MskOgrTelefon.Font = new System.Drawing.Font("Georgia", 12F);
            this.MskOgrTelefon.Location = new System.Drawing.Point(161, 136);
            this.MskOgrTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MskOgrTelefon.Mask = "(999) 000-0000";
            this.MskOgrTelefon.Name = "MskOgrTelefon";
            this.MskOgrTelefon.Size = new System.Drawing.Size(294, 30);
            this.MskOgrTelefon.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11F);
            this.label4.Location = new System.Drawing.Point(80, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Telefon:";
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Georgia", 12F);
            this.MskTC.Location = new System.Drawing.Point(161, 100);
            this.MskTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(294, 30);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F);
            this.label3.Location = new System.Drawing.Point(118, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "TC:";
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtOgrSoyad.Location = new System.Drawing.Point(161, 65);
            this.TxtOgrSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(294, 30);
            this.TxtOgrSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F);
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtOgrAd.Location = new System.Drawing.Point(161, 28);
            this.TxtOgrAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(294, 30);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F);
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RchAdres);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.MskVeliTelefon);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxtVeliAdSoyad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(56, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 249);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VELİ";
            // 
            // RchAdres
            // 
            this.RchAdres.Font = new System.Drawing.Font("Georgia", 12F);
            this.RchAdres.Location = new System.Drawing.Point(161, 115);
            this.RchAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(294, 116);
            this.RchAdres.TabIndex = 12;
            this.RchAdres.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 11F);
            this.label11.Location = new System.Drawing.Point(90, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Adres:";
            // 
            // MskVeliTelefon
            // 
            this.MskVeliTelefon.Font = new System.Drawing.Font("Georgia", 12F);
            this.MskVeliTelefon.Location = new System.Drawing.Point(161, 59);
            this.MskVeliTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MskVeliTelefon.Mask = "(999) 000-0000";
            this.MskVeliTelefon.Name = "MskVeliTelefon";
            this.MskVeliTelefon.Size = new System.Drawing.Size(294, 30);
            this.MskVeliTelefon.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 11F);
            this.label10.Location = new System.Drawing.Point(39, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Veli Telefon:";
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(161, 25);
            this.TxtVeliAdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(294, 30);
            this.TxtVeliAdSoyad.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 11F);
            this.label9.Location = new System.Drawing.Point(22, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Veli Ad Soyad:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Lavender;
            this.BtnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnKaydet.Location = new System.Drawing.Point(119, 670);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(392, 65);
            this.BtnKaydet.TabIndex = 14;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // OgrID
            // 
            this.OgrID.AutoSize = true;
            this.OgrID.Location = new System.Drawing.Point(116, 380);
            this.OgrID.Name = "OgrID";
            this.OgrID.Size = new System.Drawing.Size(42, 16);
            this.OgrID.TabIndex = 44;
            this.OgrID.Text = "OgrID";
            this.OgrID.Visible = false;
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 781);
            this.Controls.Add(this.OgrID);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Label label8;
        private TextBox TxtMail;
        private Label label7;
        private Label label6;
        private MaskedTextBox MskDogum;
        private Label label5;
        private MaskedTextBox MskOgrTelefon;
        private Label label4;
        private MaskedTextBox MskTC;
        private Label label3;
        private TextBox TxtOgrSoyad;
        private Label label2;
        private TextBox TxtOgrAd;
        private Label label1;
        private GroupBox groupBox3;
        private Button BtnKaydet;
        private RichTextBox RchAdres;
        private Label label11;
        private MaskedTextBox MskVeliTelefon;
        private Label label10;
        private TextBox TxtVeliAdSoyad;
        private Label label9;
        private Label label12;
        private MaskedTextBox mskkayittarih;
        private Label OgrID;
        private ComboBox CmbOdaNo;
        private ComboBox cmbbolum;
    }
}