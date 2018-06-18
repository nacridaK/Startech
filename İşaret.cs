using System.Collections.Generic;
using System.Drawing;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Harita_Denemesi
{
    class İşaret
    {
        private GMarkerGoogle işaret;
        private static List<İşaret> liste = new List<İşaret>();
        internal static List<İşaret> Liste
        {
            get => liste;
            set => liste = value;
        }
        private static GMapOverlay katman = new GMapOverlay();
        public static GMapOverlay Katman => katman;
        public string Ad
        {
            get => işaret.ToolTipText;
            set => işaret.ToolTipText = value;
        }
        public İşaret()
        {
            işaret = new GMarkerGoogle(PointLatLng.Empty, GMarkerGoogleType.arrow);
            Ad = " ";
            HaritayaEkle();
        }
        public İşaret(string Ad, PointLatLng konum, GMarkerGoogleType tip)
        {
            işaret = new GMarkerGoogle(konum, tip);
            this.Ad = Ad;
        }
        public double Enlem
        {
            get => işaret.Position.Lat;
            set => işaret.Position = new PointLatLng(value, Boylam);
        }
        public double Boylam
        {
            get => işaret.Position.Lng;
            set => işaret.Position = new PointLatLng(Enlem, value);
        }
        public bool Görünürlük
        {
            get => işaret.IsVisible;
            set => işaret.IsVisible = value;
        }
        public void HaritayaEkle()
        {
            işaret.ToolTip.Font = new Font("Microsoft Serif Sans", 11, FontStyle.Bold);
            işaret.ToolTip.Foreground = Brushes.Teal;
            işaret.ToolTip.Stroke = Pens.Navy;
            işaret.ToolTip.TextPadding = new Size(10, 2);
            katman.Markers.Add(işaret);
            liste.Add(this);
        }
        public void HaritadanSil()
        {
            int i = liste.IndexOf(this);
            HaritadanYokEt(i);
        }
        public static string AdıGetir(int i)
        {
            return katman.Markers[i].ToolTipText;
        }
        public static int NumarayıGetir(GMapMarker işaretçi)
        {
            return katman.Markers.IndexOf(işaretçi);
        }
        public static PointLatLng PozisyonuGetir(int i)
        {
            return katman.Markers[i].Position;
        }
        public static void HaritayaKoy(string Ad, PointLatLng konum, GMarkerGoogleType tip)
        {
            new İşaret(Ad, konum, tip).HaritayaEkle();
        }
        public static void HaritadanYokEt(int i)
        {
            katman.Markers.RemoveAt(i);
            liste.RemoveAt(i);
        }
        public static void HaritadanYokEt(GMapMarker işaretçi)
        {
            int i = NumarayıGetir(işaretçi);
            HaritadanYokEt(i);
        }
    }
}