﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitOtomasyon
{
    public partial class FrmOgrListcs : Form
    {
        public FrmOgrListcs()
        {
            InitializeComponent();
        }

        private void FrmOgrListcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet19.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter1.Fill(this.yurtOtomasyonuDataSet19.Ogrenci);
        

        }

 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            this.Hide();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr. ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString() ;
            fr.dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.ogrkayittarih = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.veliadsoyad = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.velitel = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            fr.adres = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            fr.Show();
            this.ogrenciTableAdapter1.Fill(this.yurtOtomasyonuDataSet19.Ogrenci);



        }

    }
}
