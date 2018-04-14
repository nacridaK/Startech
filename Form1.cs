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
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace Harita_Denemesi
{
    public partial class Form1 : Form
    {
        GMapOverlay kaplama;
        public Form1()
        {
            InitializeComponent();
            kaplama = new GMapOverlay();
            comboBox_sağlayıcılar.DataSource = GMapProviders.List;
            comboBox_sağlayıcılar.SelectedIndex = 1;
            comboBox_mod.SelectedIndex = 1;
            kaplama.Markers.Add(new GMarkerGoogle(new PointLatLng(41.026699, 28.888663), GMarkerGoogleType.arrow));
            kaplama.Markers.Add(new GMarkerGoogle(new PointLatLng(41.02609, 28.88806), GMarkerGoogleType.arrow));
            gMapControl1.ShowCenter = false;
            kaplama.Markers[0].ToolTipText = "Aquila";
            kaplama.Markers[1].ToolTipText = "Orion";
            gMapControl1.Overlays.Add(kaplama);
            gMapControl1.SetPositionByKeywords("Yıldız Teknik Üniversitesi Davutpaşa İstanbul");
            for (int i = 0; i < kaplama.Markers.Count; i++)
            {
                listBox_işaretler.Items.Add("İşaret " + i);
            }
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
        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            textBox_latitude.Text = item.Position.Lat.ToString();
            textBox_longitude.Text = item.Position.Lng.ToString();
        }
        private void listBox_işaretler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_işaretler.SelectedIndex != -1)
                gMapControl1.Position = kaplama.Markers[listBox_işaretler.SelectedIndex].Position;
        }
        private void gMapControl1_OnMarkerEnter(GMapMarker item)
        {
            gMapControl1.ContextMenuStrip = contextMenuStrip_işaret;
        }
        private void gMapControl1_OnMarkerLeave(GMapMarker item)
        {
            gMapControl1.ContextMenuStrip = contextMenuStrip1;
        }
    }
}