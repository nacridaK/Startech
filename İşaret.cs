using System.Collections.Generic;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Harita_Denemesi
{
    class İşaret
    {
        private GMarkerGoogle işaret;
        private static List<İşaret> liste = new List<İşaret>(0);
        internal static List<İşaret> Liste
        {
            get => liste;
            set => liste = value;
        }
        private static GMapOverlay kaplama = new GMapOverlay();
        public static GMapOverlay Kaplama => kaplama;
        public string Ad
        {
            get => işaret.ToolTipText;
            set => işaret.ToolTipText = value;
        }
        public double Enlem
        {
            get => işaret.Position.Lat;
        }
        public double Boylam
        {
            get => işaret.Position.Lng;
        }
        public bool Görünürlük
        {
            get => işaret.IsVisible;
            set => işaret.IsVisible = value;
        }
        public İşaret(string Ad, PointLatLng konum, GMarkerGoogleType tip)
        {
            işaret = new GMarkerGoogle(konum, tip);
            this.Ad = Ad;
        }
        public void HaritayaEkle()
        {
            kaplama.Markers.Add(this.işaret);
            liste.Add(this);
        }
        public void HaritadanSil()
        {
            int i = liste.IndexOf(this);
            HaritadanYokEt(i);
        }
        public static void HaritayaKoy(string Ad, PointLatLng konum, GMarkerGoogleType tip)
        {
            new İşaret(Ad, konum, tip).HaritayaEkle();
        }
        public static void HaritadanYokEt(int i)
        {
            kaplama.Markers.RemoveAt(i);
            liste.RemoveAt(i);
        }
    }
}