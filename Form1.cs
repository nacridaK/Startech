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
        List<GMapMarker> markers = new List<GMapMarker>();
        public Form1()
        {
            InitializeComponent();
            GMapOverlay overlay = new GMapOverlay("overlay");
            markers.Add(new GMarkerGoogle(new PointLatLng(48.8617774, 2.349272), GMarkerGoogleType.arrow));
            comboBox_providers.DataSource = GMapProviders.List;
            gMapControl1.ShowCenter = false;
            markers[0].ToolTipText = "Test";
            overlay.Markers.Add(markers[0]);
            gMapControl1.Overlays.Add(overlay);
            gMapControl1.SetPositionByKeywords("Yıldız Teknik Üniversitesi Davutpaşa İstanbul");
        }
        private void button_find_Click(object sender, EventArgs e)
        {
            if (textBox_latitude.Text != String.Empty && textBox_longitude.Text != String.Empty)
                gMapControl1.Position = new PointLatLng(Double.Parse(textBox_latitude.Text), Double.Parse(textBox_latitude.Text));
            if (textBox_keyword.Text != String.Empty)
                gMapControl1.SetPositionByKeywords(textBox_keyword.Text);
        }
        private void comboBox_providers_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = comboBox_providers.SelectedItem as GMapProvider;
        }
        private void comboBox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = (AccessMode)comboBox_mode.SelectedIndex;
        }
    }
}