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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox_map = new System.Windows.Forms.GroupBox();
            this.label_latitude = new System.Windows.Forms.Label();
            this.label_longitude = new System.Windows.Forms.Label();
            this.textBox_latitude = new System.Windows.Forms.TextBox();
            this.textBox_longitude = new System.Windows.Forms.TextBox();
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.label_keyword = new System.Windows.Forms.Label();
            this.button_find = new System.Windows.Forms.Button();
            this.comboBox_providers = new System.Windows.Forms.ComboBox();
            this.label_provider = new System.Windows.Forms.Label();
            this.groupBox_coordinates = new System.Windows.Forms.GroupBox();
            this.label_mode = new System.Windows.Forms.Label();
            this.comboBox_mode = new System.Windows.Forms.ComboBox();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_map.SuspendLayout();
            this.groupBox_coordinates.SuspendLayout();
            this.groupBox_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
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
            // 
            // groupBox_map
            // 
            this.groupBox_map.Controls.Add(this.gMapControl1);
            this.groupBox_map.Location = new System.Drawing.Point(12, 12);
            this.groupBox_map.Name = "groupBox_map";
            this.groupBox_map.Size = new System.Drawing.Size(571, 462);
            this.groupBox_map.TabIndex = 1;
            this.groupBox_map.TabStop = false;
            this.groupBox_map.Text = "gMapController1";
            // 
            // label_latitude
            // 
            this.label_latitude.AutoSize = true;
            this.label_latitude.Location = new System.Drawing.Point(109, 22);
            this.label_latitude.Name = "label_latitude";
            this.label_latitude.Size = new System.Drawing.Size(41, 13);
            this.label_latitude.TabIndex = 2;
            this.label_latitude.Text = "latitude";
            // 
            // label_longitude
            // 
            this.label_longitude.AutoSize = true;
            this.label_longitude.Location = new System.Drawing.Point(109, 49);
            this.label_longitude.Name = "label_longitude";
            this.label_longitude.Size = new System.Drawing.Size(50, 13);
            this.label_longitude.TabIndex = 3;
            this.label_longitude.Text = "longitude";
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
            // label_keyword
            // 
            this.label_keyword.AutoSize = true;
            this.label_keyword.Location = new System.Drawing.Point(109, 75);
            this.label_keyword.Name = "label_keyword";
            this.label_keyword.Size = new System.Drawing.Size(47, 13);
            this.label_keyword.TabIndex = 6;
            this.label_keyword.Text = "keyword";
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(17, 93);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(75, 23);
            this.button_find.TabIndex = 8;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // comboBox_providers
            // 
            this.comboBox_providers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_providers.FormattingEnabled = true;
            this.comboBox_providers.Location = new System.Drawing.Point(6, 16);
            this.comboBox_providers.Name = "comboBox_providers";
            this.comboBox_providers.Size = new System.Drawing.Size(108, 21);
            this.comboBox_providers.TabIndex = 9;
            this.comboBox_providers.SelectedIndexChanged += new System.EventHandler(this.comboBox_providers_SelectedIndexChanged);
            // 
            // label_provider
            // 
            this.label_provider.AutoSize = true;
            this.label_provider.Location = new System.Drawing.Point(117, 24);
            this.label_provider.Name = "label_provider";
            this.label_provider.Size = new System.Drawing.Size(45, 13);
            this.label_provider.TabIndex = 10;
            this.label_provider.Text = "provider";
            // 
            // groupBox_coordinates
            // 
            this.groupBox_coordinates.Controls.Add(this.textBox_keyword);
            this.groupBox_coordinates.Controls.Add(this.label_latitude);
            this.groupBox_coordinates.Controls.Add(this.label_longitude);
            this.groupBox_coordinates.Controls.Add(this.button_find);
            this.groupBox_coordinates.Controls.Add(this.textBox_latitude);
            this.groupBox_coordinates.Controls.Add(this.textBox_longitude);
            this.groupBox_coordinates.Controls.Add(this.label_keyword);
            this.groupBox_coordinates.Location = new System.Drawing.Point(589, 12);
            this.groupBox_coordinates.Name = "groupBox_coordinates";
            this.groupBox_coordinates.Size = new System.Drawing.Size(166, 120);
            this.groupBox_coordinates.TabIndex = 11;
            this.groupBox_coordinates.TabStop = false;
            this.groupBox_coordinates.Text = "Coordinates";
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.Location = new System.Drawing.Point(117, 51);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(33, 13);
            this.label_mode.TabIndex = 13;
            this.label_mode.Text = "mode";
            // 
            // comboBox_mode
            // 
            this.comboBox_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mode.FormattingEnabled = true;
            this.comboBox_mode.Items.AddRange(new object[] {
            "ServerOnly",
            "ServerAndCache",
            "CacheOnly"});
            this.comboBox_mode.Location = new System.Drawing.Point(6, 43);
            this.comboBox_mode.Name = "comboBox_mode";
            this.comboBox_mode.Size = new System.Drawing.Size(108, 21);
            this.comboBox_mode.TabIndex = 12;
            this.comboBox_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_mode_SelectedIndexChanged);
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.comboBox_providers);
            this.groupBox_settings.Controls.Add(this.label_mode);
            this.groupBox_settings.Controls.Add(this.label_provider);
            this.groupBox_settings.Controls.Add(this.comboBox_mode);
            this.groupBox_settings.Location = new System.Drawing.Point(589, 138);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(166, 70);
            this.groupBox_settings.TabIndex = 14;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Harita_Denemesi.Properties.Resources.ytü;
            this.pictureBox1.Location = new System.Drawing.Point(606, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_settings);
            this.Controls.Add(this.groupBox_coordinates);
            this.Controls.Add(this.groupBox_map);
            this.Name = "Form1";
            this.Text = "Harita Denemesi";
            this.groupBox_map.ResumeLayout(false);
            this.groupBox_coordinates.ResumeLayout(false);
            this.groupBox_coordinates.PerformLayout();
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.GroupBox groupBox_map;
        private System.Windows.Forms.Label label_latitude;
        private System.Windows.Forms.Label label_longitude;
        private System.Windows.Forms.TextBox textBox_latitude;
        private System.Windows.Forms.TextBox textBox_longitude;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.Label label_keyword;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.ComboBox comboBox_providers;
        private System.Windows.Forms.Label label_provider;
        private System.Windows.Forms.GroupBox groupBox_coordinates;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.ComboBox comboBox_mode;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

