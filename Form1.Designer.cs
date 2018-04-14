namespace Harita_Denemesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.contextMenuStrip_işaret = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_işaret = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_harita = new System.Windows.Forms.GroupBox();
            this.label_enlem = new System.Windows.Forms.Label();
            this.label_boylam = new System.Windows.Forms.Label();
            this.textBox_latitude = new System.Windows.Forms.TextBox();
            this.textBox_longitude = new System.Windows.Forms.TextBox();
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.label_ara = new System.Windows.Forms.Label();
            this.button_bul = new System.Windows.Forms.Button();
            this.comboBox_sağlayıcılar = new System.Windows.Forms.ComboBox();
            this.label_sağlayıcı = new System.Windows.Forms.Label();
            this.groupBox_coordinates = new System.Windows.Forms.GroupBox();
            this.label_mod = new System.Windows.Forms.Label();
            this.comboBox_mod = new System.Windows.Forms.ComboBox();
            this.groupBox_ayarlar = new System.Windows.Forms.GroupBox();
            this.pictureBox_ytu = new System.Windows.Forms.PictureBox();
            this.listBox_işaretler = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_işaret.SuspendLayout();
            this.groupBox_harita.SuspendLayout();
            this.groupBox_coordinates.SuspendLayout();
            this.groupBox_ayarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ytu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3, 16);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(565, 443);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 18D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.gMapControl1_OnMarkerEnter);
            this.gMapControl1.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.gMapControl1_OnMarkerLeave);
            // 
            // contextMenuStrip_işaret
            // 
            this.contextMenuStrip_işaret.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_işaret});
            this.contextMenuStrip_işaret.Name = "contextMenuStrip_işaret";
            this.contextMenuStrip_işaret.Size = new System.Drawing.Size(202, 26);
            // 
            // toolStripMenuItem_işaret
            // 
            this.toolStripMenuItem_işaret.Name = "toolStripMenuItem_işaret";
            this.toolStripMenuItem_işaret.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem_işaret.Text = "İşaret ContextMenuStrip";
            // 
            // groupBox_harita
            // 
            this.groupBox_harita.Controls.Add(this.gMapControl1);
            this.groupBox_harita.Location = new System.Drawing.Point(12, 12);
            this.groupBox_harita.Name = "groupBox_harita";
            this.groupBox_harita.Size = new System.Drawing.Size(571, 462);
            this.groupBox_harita.TabIndex = 1;
            this.groupBox_harita.TabStop = false;
            this.groupBox_harita.Text = "gMapController1";
            // 
            // label_enlem
            // 
            this.label_enlem.AutoSize = true;
            this.label_enlem.Location = new System.Drawing.Point(109, 22);
            this.label_enlem.Name = "label_enlem";
            this.label_enlem.Size = new System.Drawing.Size(35, 13);
            this.label_enlem.TabIndex = 2;
            this.label_enlem.Text = "enlem";
            // 
            // label_boylam
            // 
            this.label_boylam.AutoSize = true;
            this.label_boylam.Location = new System.Drawing.Point(109, 49);
            this.label_boylam.Name = "label_boylam";
            this.label_boylam.Size = new System.Drawing.Size(40, 13);
            this.label_boylam.TabIndex = 3;
            this.label_boylam.Text = "boylam";
            // 
            // textBox_latitude
            // 
            this.textBox_latitude.Location = new System.Drawing.Point(6, 15);
            this.textBox_latitude.Name = "textBox_latitude";
            this.textBox_latitude.Size = new System.Drawing.Size(100, 20);
            this.textBox_latitude.TabIndex = 4;
            // 
            // textBox_longitude
            // 
            this.textBox_longitude.Location = new System.Drawing.Point(6, 42);
            this.textBox_longitude.Name = "textBox_longitude";
            this.textBox_longitude.Size = new System.Drawing.Size(100, 20);
            this.textBox_longitude.TabIndex = 5;
            // 
            // textBox_keyword
            // 
            this.textBox_keyword.Location = new System.Drawing.Point(6, 68);
            this.textBox_keyword.Name = "textBox_keyword";
            this.textBox_keyword.Size = new System.Drawing.Size(100, 20);
            this.textBox_keyword.TabIndex = 7;
            // 
            // label_ara
            // 
            this.label_ara.AutoSize = true;
            this.label_ara.Location = new System.Drawing.Point(109, 75);
            this.label_ara.Name = "label_ara";
            this.label_ara.Size = new System.Drawing.Size(22, 13);
            this.label_ara.TabIndex = 6;
            this.label_ara.Text = "ara";
            // 
            // button_bul
            // 
            this.button_bul.Location = new System.Drawing.Point(17, 93);
            this.button_bul.Name = "button_bul";
            this.button_bul.Size = new System.Drawing.Size(75, 23);
            this.button_bul.TabIndex = 8;
            this.button_bul.Text = "Bul";
            this.button_bul.UseVisualStyleBackColor = true;
            this.button_bul.Click += new System.EventHandler(this.button_bul_Click);
            // 
            // comboBox_sağlayıcılar
            // 
            this.comboBox_sağlayıcılar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sağlayıcılar.FormattingEnabled = true;
            this.comboBox_sağlayıcılar.Location = new System.Drawing.Point(6, 16);
            this.comboBox_sağlayıcılar.Name = "comboBox_sağlayıcılar";
            this.comboBox_sağlayıcılar.Size = new System.Drawing.Size(108, 21);
            this.comboBox_sağlayıcılar.TabIndex = 9;
            this.comboBox_sağlayıcılar.SelectedIndexChanged += new System.EventHandler(this.comboBox_sağlayıcılar_SelectedIndexChanged);
            // 
            // label_sağlayıcı
            // 
            this.label_sağlayıcı.AutoSize = true;
            this.label_sağlayıcı.Location = new System.Drawing.Point(117, 24);
            this.label_sağlayıcı.Name = "label_sağlayıcı";
            this.label_sağlayıcı.Size = new System.Drawing.Size(47, 13);
            this.label_sağlayıcı.TabIndex = 10;
            this.label_sağlayıcı.Text = "sağlayıcı";
            // 
            // groupBox_coordinates
            // 
            this.groupBox_coordinates.Controls.Add(this.textBox_keyword);
            this.groupBox_coordinates.Controls.Add(this.label_enlem);
            this.groupBox_coordinates.Controls.Add(this.label_boylam);
            this.groupBox_coordinates.Controls.Add(this.button_bul);
            this.groupBox_coordinates.Controls.Add(this.textBox_latitude);
            this.groupBox_coordinates.Controls.Add(this.textBox_longitude);
            this.groupBox_coordinates.Controls.Add(this.label_ara);
            this.groupBox_coordinates.Location = new System.Drawing.Point(589, 12);
            this.groupBox_coordinates.Name = "groupBox_coordinates";
            this.groupBox_coordinates.Size = new System.Drawing.Size(166, 120);
            this.groupBox_coordinates.TabIndex = 11;
            this.groupBox_coordinates.TabStop = false;
            this.groupBox_coordinates.Text = "Coordinates";
            // 
            // label_mod
            // 
            this.label_mod.AutoSize = true;
            this.label_mod.Location = new System.Drawing.Point(117, 51);
            this.label_mod.Name = "label_mod";
            this.label_mod.Size = new System.Drawing.Size(27, 13);
            this.label_mod.TabIndex = 13;
            this.label_mod.Text = "mod";
            // 
            // comboBox_mod
            // 
            this.comboBox_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mod.FormattingEnabled = true;
            this.comboBox_mod.Items.AddRange(new object[] {
            "ServerOnly",
            "ServerAndCache",
            "CacheOnly"});
            this.comboBox_mod.Location = new System.Drawing.Point(6, 43);
            this.comboBox_mod.Name = "comboBox_mod";
            this.comboBox_mod.Size = new System.Drawing.Size(108, 21);
            this.comboBox_mod.TabIndex = 12;
            this.comboBox_mod.SelectedIndexChanged += new System.EventHandler(this.comboBox_mod_SelectedIndexChanged);
            // 
            // groupBox_ayarlar
            // 
            this.groupBox_ayarlar.Controls.Add(this.comboBox_sağlayıcılar);
            this.groupBox_ayarlar.Controls.Add(this.label_mod);
            this.groupBox_ayarlar.Controls.Add(this.label_sağlayıcı);
            this.groupBox_ayarlar.Controls.Add(this.comboBox_mod);
            this.groupBox_ayarlar.Location = new System.Drawing.Point(589, 138);
            this.groupBox_ayarlar.Name = "groupBox_ayarlar";
            this.groupBox_ayarlar.Size = new System.Drawing.Size(166, 70);
            this.groupBox_ayarlar.TabIndex = 14;
            this.groupBox_ayarlar.TabStop = false;
            this.groupBox_ayarlar.Text = "Ayarlar";
            // 
            // pictureBox_ytu
            // 
            this.pictureBox_ytu.Image = global::Harita_Denemesi.Properties.Resources.ytü;
            this.pictureBox_ytu.Location = new System.Drawing.Point(606, 214);
            this.pictureBox_ytu.Name = "pictureBox_ytu";
            this.pictureBox_ytu.Size = new System.Drawing.Size(133, 143);
            this.pictureBox_ytu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ytu.TabIndex = 15;
            this.pictureBox_ytu.TabStop = false;
            // 
            // listBox_işaretler
            // 
            this.listBox_işaretler.FormattingEnabled = true;
            this.listBox_işaretler.Location = new System.Drawing.Point(606, 363);
            this.listBox_işaretler.Name = "listBox_işaretler";
            this.listBox_işaretler.Size = new System.Drawing.Size(120, 95);
            this.listBox_işaretler.TabIndex = 16;
            this.listBox_işaretler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_işaretler_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem1.Text = "ContextMenuStrip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 486);
            this.Controls.Add(this.listBox_işaretler);
            this.Controls.Add(this.pictureBox_ytu);
            this.Controls.Add(this.groupBox_ayarlar);
            this.Controls.Add(this.groupBox_coordinates);
            this.Controls.Add(this.groupBox_harita);
            this.Name = "Form1";
            this.Text = "Harita Denemesi";
            this.contextMenuStrip_işaret.ResumeLayout(false);
            this.groupBox_harita.ResumeLayout(false);
            this.groupBox_coordinates.ResumeLayout(false);
            this.groupBox_coordinates.PerformLayout();
            this.groupBox_ayarlar.ResumeLayout(false);
            this.groupBox_ayarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ytu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.GroupBox groupBox_harita;
        private System.Windows.Forms.Label label_enlem;
        private System.Windows.Forms.Label label_boylam;
        private System.Windows.Forms.TextBox textBox_latitude;
        private System.Windows.Forms.TextBox textBox_longitude;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.Label label_ara;
        private System.Windows.Forms.Button button_bul;
        private System.Windows.Forms.ComboBox comboBox_sağlayıcılar;
        private System.Windows.Forms.Label label_sağlayıcı;
        private System.Windows.Forms.GroupBox groupBox_coordinates;
        private System.Windows.Forms.Label label_mod;
        private System.Windows.Forms.ComboBox comboBox_mod;
        private System.Windows.Forms.GroupBox groupBox_ayarlar;
        private System.Windows.Forms.PictureBox pictureBox_ytu;
        private System.Windows.Forms.ListBox listBox_işaretler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_işaret;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_işaret;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

