using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.ObjectModel;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using Microsoft.VisualBasic;

namespace Harita_Denemesi
{
    public partial class Form1 : Form
    {
        GMapOverlay kaplama;
        PointLatLng imleç_konum;
        GMapMarker işaret;
        public Form1()
        {            
            InitializeComponent();
            kaplama = new GMapOverlay();
            comboBox_sağlayıcılar.DataSource = GMapProviders.List;
            comboBox_sağlayıcılar.SelectedIndex = 1;
            comboBox_mod.SelectedIndex = 1;
            kaplama.Markers.Add(new GMarkerGoogle(new PointLatLng(41.026699, 28.888663), GMarkerGoogleType.arrow));
            kaplama.Markers.Add(new GMarkerGoogle(new PointLatLng(41.02609, 28.88806), GMarkerGoogleType.arrow));
            gMapControl1.DragButton = MouseButtons.Middle;
            kaplama.Markers[0].ToolTipText = "Aquila";
            kaplama.Markers[1].ToolTipText = "Orion";
            gMapControl1.Overlays.Add(kaplama);
            gMapControl1.SetPositionByKeywords("Yıldız Teknik Üniversitesi Davutpaşa İstanbul");
            foreach (GMapMarker işaret in kaplama.Markers)
                listBox_işaretler.Items.Add(işaret.ToolTipText + " " + işaret.Position.ToString());
        }
        private void button_bul_Click(object sender, EventArgs e)
        {
            if (textBox_latitude.Text != String.Empty && textBox_longitude.Text != String.Empty)
                gMapControl1.Position = new PointLatLng(Double.Parse(textBox_latitude.Text), Double.Parse(textBox_longitude.Text));
            if (textBox_keyword.Text != String.Empty)
                gMapControl1.SetPositionByKeywords(textBox_keyword.Text);
        }
        private void comboBox_sağlayıcılar_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = comboBox_sağlayıcılar.SelectedItem as GMapProvider;
        }
        private void comboBox_mod_SelectedIndexChanged(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = (AccessMode)comboBox_mod.SelectedIndex;
        }
        private void listBox_işaretler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_işaretler.SelectedIndex != -1)
                gMapControl1.Position = kaplama.Markers[listBox_işaretler.SelectedIndex].Position;
        }
        private void gMapControl1_OnMarkerEnter(GMapMarker item)
        {
            işaret = item;
            gMapControl1.ContextMenuStrip = contextMenuStrip_işaret;
        }
        private void gMapControl1_OnMarkerLeave(GMapMarker item)
        {
            gMapControl1.ContextMenuStrip = contextMenuStrip_harita;
        }
        private void ToolStripMenuItem_işarethızlıekle_Click(object sender, EventArgs e)
        {
            string ad = "İşaret " + (kaplama.Markers.Count + 1);
            kaplama.Markers.Add(new GMarkerGoogle(imleç_konum, GMarkerGoogleType.black_small));
            kaplama.Markers[kaplama.Markers.Count - 1].ToolTipText = ad;
            listBox_işaretler.Items.Add(ad + " " + kaplama.Markers[kaplama.Markers.Count - 1].Position.ToString());
            contextMenuStrip_harita.Close();
        }
        private void toolStripMenuItem_işaretekle_Click(object sender, EventArgs e)
        {
            string ad = Interaction.InputBox("İşaret Adı:", "İşaret Ekle", "İşaret " + (kaplama.Markers.Count + 1));
            if (ad != "")
            {
                kaplama.Markers.Add(new GMarkerGoogle(imleç_konum, (GMarkerGoogleType)toolStripComboBox_simge.SelectedIndex));
                kaplama.Markers[kaplama.Markers.Count - 1].ToolTipText = ad;
                listBox_işaretler.Items.Add(ad + " " + kaplama.Markers[kaplama.Markers.Count - 1].Position.ToString());
            }
        }
        private void gMapControl1_MouseMove(object sender, MouseEventArgs e)
        {
            imleç_konum = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            toolStripStatusLabel_imleç.Text = "İmleçin Konumu: " + imleç_konum.ToString();
        }
        private void contextMenuStrip_işaret_Opening(object sender, CancelEventArgs e)
        {
            toolStripMenuItem_işaret_başlık.Text = işaret.ToolTipText + " Ayarları";
        }
        private void toolStripMenuItem_işaretsil_Click(object sender, EventArgs e)
        {
            int i = kaplama.Markers.IndexOf(işaret);
            kaplama.Markers.Remove(işaret);
            listBox_işaretler.Items.RemoveAt(i);
            gMapControl1.ContextMenuStrip = contextMenuStrip_harita;
        }
    }
}