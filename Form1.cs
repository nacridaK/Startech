using System;
using System.ComponentModel;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using Microsoft.VisualBasic;

namespace Harita_Denemesi
{
    public partial class Form1 : Form
    {
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
            gMapControl1.Overlays.Add(İşaret.Kaplama);
            İşaret.HaritayaKoy("Orion", new PointLatLng(41.029198242468411, 28.889928460121155), GMarkerGoogleType.arrow);
            İşaret.HaritayaKoy("Aquila", new PointLatLng(41.029275131313071, 28.889638781547546), GMarkerGoogleType.arrow);
            işaretBindingSource.DataSource = İşaret.Liste;
            gMapControl1.SetPositionByKeywords(textBox_arama.Text);
        }
        private void DataGridViewGüncelle()
        {
            işaretBindingSource.DataSource = null;
            işaretBindingSource.DataSource = İşaret.Liste;
        }
        private void button_bul_Click(object sender, EventArgs e)
        {
            if (textBox_enlem.Text != String.Empty && textBox_boylam.Text != String.Empty)
                gMapControl1.Position = new PointLatLng(Double.Parse(textBox_enlem.Text), Double.Parse(textBox_boylam.Text));
            if (textBox_arama.Text != String.Empty)
                gMapControl1.SetPositionByKeywords(textBox_arama.Text);
        }
        private void comboBox_sağlayıcılar_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = comboBox_sağlayıcılar.SelectedItem as GMapProvider;
        }
        private void comboBox_mod_SelectedIndexChanged(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = (AccessMode)comboBox_mod.SelectedIndex;
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
            DataGridViewGüncelle();
            contextMenuStrip_harita.Close();
        }
        private void toolStripMenuItem_işaretekle_Click(object sender, EventArgs e)
        {
            string ad = Interaction.InputBox("İşaret Adı:", "İşaret Ekle", "İşaret " + (İşaret.Liste.Count + 1));
            if (ad != "")
            {
                İşaret.HaritayaKoy(ad, imleç_konum, (GMarkerGoogleType)toolStripComboBox_simge.SelectedIndex);
                DataGridViewGüncelle();
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
                DataGridViewGüncelle();
                contextMenuStrip_işaret.Close();
            }
        }
        private void contextMenuStrip_işaret_Opening(object sender, CancelEventArgs e)
        {
            toolStripMenuItem_işaret_başlık.Text = işaretçi.ToolTipText + " Ayarları";
        }
        private void İşaretSil()
        {
            İşaret.HaritadanYokEt(İşaret.Kaplama.Markers.IndexOf(işaretçi));
            DataGridViewGüncelle();
            gMapControl1.ContextMenuStrip = contextMenuStrip_harita;
        }
        private void toolStripMenuItem_işaretsil_Click(object sender, EventArgs e)
        {
            İşaretSil();
            DataGridViewGüncelle();
        }
        private void dataGridView_işaretler_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gMapControl1.Position = İşaret.Kaplama.Markers[e.RowIndex].Position;
        }
    }
}