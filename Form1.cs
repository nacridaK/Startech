using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO.Ports;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace Harita_Denemesi
{
    public partial class Form1 : Form
    {
        Queue<byte[]> s_enlem = new Queue<byte[]>();
        Queue<byte[]> s_boylam = new Queue<byte[]>();
        PointLatLng imleç_konum;
        GMapMarker işaretçi;
        public Form1()
        {
            InitializeComponent();
            Text += " v" + Application.ProductVersion;
            comboBox_sağlayıcılar.DataSource = GMapProviders.List;
            comboBox_sağlayıcılar.SelectedIndex = 1;
            comboBox_mod.SelectedIndex = 1;
            toolStripComboBox_simge.SelectedIndex = 1;
            gMapControl1.DragButton = MouseButtons.Middle;
            gMapControl1.Overlays.Add(İşaret.Katman);
            İşaret.HaritayaKoy("Orion", new PointLatLng(41.029198242468411, 28.889928460121155), GMarkerGoogleType.arrow);
            İşaret.HaritayaKoy("Aquila", new PointLatLng(41.029275131313071, 28.889638781547546), GMarkerGoogleType.arrow);
            işaretBindingSource.DataSource = İşaret.Liste;
            gMapControl1.SetPositionByKeywords(textBox_arama.Text);
            Console.WriteLine(gMapControl1.CacheLocation);
            seriport.Open();
        }
        private void my_DataGridViewGüncelle()
        {
            işaretBindingSource.DataSource = null;
            işaretBindingSource.DataSource = İşaret.Liste;
            my_DurumGüncelle("DataGridView güncellendi.");
        }
        private void my_DurumGüncelle(string durum)
        {
            toolStripStatusLabel_durum.Text = durum;
        }
        private void button_bul_Click(object sender, EventArgs e)
        {
            if (textBox_enlem.Text != String.Empty && textBox_boylam.Text != String.Empty)
            {
                gMapControl1.Position = new PointLatLng(Double.Parse(textBox_enlem.Text), Double.Parse(textBox_boylam.Text));
                my_DurumGüncelle("Girilen koordinat bulundu.");
            }
            if (textBox_arama.Text != String.Empty)
            {
                gMapControl1.SetPositionByKeywords(textBox_arama.Text);
                my_DurumGüncelle("Kelimeyle koordinat bulundu.");
            }
        }
        private void comboBox_sağlayıcılar_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = comboBox_sağlayıcılar.SelectedItem as GMapProvider;
            my_DurumGüncelle("Harita sağlayıcısı değiştirildi.");
        }
        private void comboBox_mod_SelectedIndexChanged(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = (AccessMode)comboBox_mod.SelectedIndex;
            my_DurumGüncelle("Harita modu değiştirildi.");
        }
        private void gMapControl1_OnMarkerEnter(GMapMarker item)
        {
            işaretçi = item;
            gMapControl1.ContextMenuStrip = contextMenuStrip_işaret;
        }
        private void gMapControl1_OnMarkerLeave(GMapMarker item)
        {
            gMapControl1.ContextMenuStrip = contextMenuStrip_harita;
        }
        private void ToolStripMenuItem_işarethızlıekle_Click(object sender, EventArgs e)
        {
            İşaret.HaritayaKoy("İşaret " + (İşaret.Liste.Count + 1), imleç_konum, GMarkerGoogleType.black_small);
            my_DataGridViewGüncelle();
            my_DurumGüncelle("Hızlı işaret eklendi.");
            contextMenuStrip_harita.Close();
        }
        private void toolStripMenuItem_işaretekle_Click(object sender, EventArgs e)
        {
            string ad = Interaction.InputBox("İşaret Adı:", "İşaret Ekle", "İşaret " + (İşaret.Liste.Count + 1));
            if (ad != "")
            {
                İşaret.HaritayaKoy(ad, imleç_konum, (GMarkerGoogleType)(toolStripComboBox_simge.SelectedIndex + 1));
                my_DataGridViewGüncelle();
                my_DurumGüncelle("İşaret eklendi.");
            }
        }
        private void gMapControl1_MouseMove(object sender, MouseEventArgs e)
        {
            imleç_konum = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            toolStripStatusLabel_imleç.Text = "İmleçin Konumu: " + imleç_konum.ToString();
        }
        private void contextMenuStrip_işaret_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                İşaretSil();
                contextMenuStrip_işaret.Close();
            }
        }
        private void contextMenuStrip_işaret_Opening(object sender, CancelEventArgs e)
        {
            toolStripMenuItem_işaret_başlık.Text = işaretçi.ToolTipText + " Ayarları";
        }
        private void İşaretSil()
        {
            İşaret.HaritadanYokEt(işaretçi);
            my_DataGridViewGüncelle();
            my_DurumGüncelle(işaretçi.ToolTipText + " işareti silindi.");
            gMapControl1.ContextMenuStrip = contextMenuStrip_harita;
        }
        private void toolStripMenuItem_işaretsil_Click(object sender, EventArgs e)
        {
            İşaretSil();
        }
        private void dataGridView_işaretler_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gMapControl1.Position = İşaret.PozisyonuGetir(e.RowIndex);
            gMapControl1.Zoom = 19;
            my_DurumGüncelle(İşaret.AdıGetir(e.RowIndex) + " işareti merkezlendi.");
        }
        private void dataGridView_işaretler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                switch (e.ColumnIndex)
                {
                    case 4:
                        İşaret.HaritadanYokEt(e.RowIndex);
                        my_DataGridViewGüncelle();
                        my_DurumGüncelle(e.RowIndex + " numaralı işaret silindi.");
                        break;
                }
        }
        private void gMapControl1_OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e)
        {
            gMapControl1.Position = item.Position;
            gMapControl1.Zoom = 19;
            my_DurumGüncelle(item.ToolTipText + " işareti merkezlendi.");
        }
        private void seriport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] enlem = new byte[8];
            byte[] boylam = new byte[8];
            seriport.Read(enlem, 0, 8);
            seriport.Read(boylam, 0, 8);
            s_enlem.Enqueue(enlem);
            s_boylam.Enqueue(boylam);
            backgroundWorker_işaretler.RunWorkerAsync();
            //Console.WriteLine(enl + " " + byl);
            //İşaret.HaritayaKoy("Yasin", new PointLatLng(enl, byl), GMarkerGoogleType.arrow);
        }
        private void backgroundWorker_işaretler_DoWork(object sender, DoWorkEventArgs e)
        {
            double[] koordinatlar = { BitConverter.ToDouble(s_enlem.Dequeue(), 0), BitConverter.ToDouble(s_boylam.Dequeue(), 0) };
            Console.WriteLine(koordinatlar[0] + " " + koordinatlar[1]);
            //İşaret.HaritayaKoy("Yasin", new PointLatLng(enlem, boylam), GMarkerGoogleType.arrow);
        }
    }
}