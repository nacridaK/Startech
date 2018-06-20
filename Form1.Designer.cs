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
            this.contextMenuStrip_harita = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_harita_başlık = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_ayıraç1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_işarethızlıekle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_işaretekle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_simge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_simge = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip_işaret = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_işaret_başlık = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_ayıraç2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_işaretsil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_işaretler = new System.Windows.Forms.GroupBox();
            this.propertyGrid_seriport = new System.Windows.Forms.PropertyGrid();
            this.seriport = new System.IO.Ports.SerialPort(this.components);
            this.dataGridView_işaretler = new System.Windows.Forms.DataGridView();
            this.silDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox_ayarlar = new System.Windows.Forms.GroupBox();
            this.comboBox_sağlayıcılar = new System.Windows.Forms.ComboBox();
            this.label_mod = new System.Windows.Forms.Label();
            this.label_sağlayıcı = new System.Windows.Forms.Label();
            this.comboBox_mod = new System.Windows.Forms.ComboBox();
            this.groupBox_koordinatlar = new System.Windows.Forms.GroupBox();
            this.textBox_arama = new System.Windows.Forms.TextBox();
            this.label_enlem = new System.Windows.Forms.Label();
            this.label_boylam = new System.Windows.Forms.Label();
            this.button_bul = new System.Windows.Forms.Button();
            this.textBox_enlem = new System.Windows.Forms.TextBox();
            this.textBox_boylam = new System.Windows.Forms.TextBox();
            this.label_ara = new System.Windows.Forms.Label();
            this.groupBox_harita = new System.Windows.Forms.GroupBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.statusStrip_durum = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_durum = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_harita = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_imleç = new System.Windows.Forms.ToolStripStatusLabel();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enlemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boylamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görünürlükDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.işaretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip_harita.SuspendLayout();
            this.contextMenuStrip_işaret.SuspendLayout();
            this.groupBox_işaretler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_işaretler)).BeginInit();
            this.groupBox_ayarlar.SuspendLayout();
            this.groupBox_koordinatlar.SuspendLayout();
            this.groupBox_harita.SuspendLayout();
            this.statusStrip_durum.SuspendLayout();
            this.statusStrip_harita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.işaretBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip_harita
            // 
            this.contextMenuStrip_harita.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_harita_başlık,
            this.toolStripSeparator_ayıraç1,
            this.toolStripMenuItem_işarethızlıekle});
            this.contextMenuStrip_harita.Name = "contextMenuStrip1";
            this.contextMenuStrip_harita.ShowImageMargin = false;
            this.contextMenuStrip_harita.Size = new System.Drawing.Size(128, 54);
            // 
            // toolStripMenuItem_harita_başlık
            // 
            this.toolStripMenuItem_harita_başlık.Enabled = false;
            this.toolStripMenuItem_harita_başlık.Name = "toolStripMenuItem_harita_başlık";
            this.toolStripMenuItem_harita_başlık.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItem_harita_başlık.Text = "Harita Menüsü";
            // 
            // toolStripSeparator_ayıraç1
            // 
            this.toolStripSeparator_ayıraç1.Name = "toolStripSeparator_ayıraç1";
            this.toolStripSeparator_ayıraç1.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripMenuItem_işarethızlıekle
            // 
            this.toolStripMenuItem_işarethızlıekle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_işaretekle,
            this.toolStripMenuItem_simge,
            this.toolStripComboBox_simge});
            this.toolStripMenuItem_işarethızlıekle.Name = "toolStripMenuItem_işarethızlıekle";
            this.toolStripMenuItem_işarethızlıekle.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItem_işarethızlıekle.Text = "Hızlı İşaret Ekle";
            this.toolStripMenuItem_işarethızlıekle.Click += new System.EventHandler(this.ToolStripMenuItem_işarethızlıekle_Click);
            // 
            // toolStripMenuItem_işaretekle
            // 
            this.toolStripMenuItem_işaretekle.Name = "toolStripMenuItem_işaretekle";
            this.toolStripMenuItem_işaretekle.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem_işaretekle.Text = "İşaret Ekle";
            this.toolStripMenuItem_işaretekle.Click += new System.EventHandler(this.toolStripMenuItem_işaretekle_Click);
            // 
            // toolStripMenuItem_simge
            // 
            this.toolStripMenuItem_simge.Enabled = false;
            this.toolStripMenuItem_simge.Name = "toolStripMenuItem_simge";
            this.toolStripMenuItem_simge.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem_simge.Text = "Simge :";
            // 
            // toolStripComboBox_simge
            // 
            this.toolStripComboBox_simge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_simge.Items.AddRange(new object[] {
            "arrow",
            "blue",
            "blue_small",
            "blue_dot",
            "blue_pushpin",
            "brown_small",
            "gray_small",
            "green",
            "green_small",
            "green_dot",
            "green_pushpin",
            "green_big_go",
            "yellow",
            "yellow_small",
            "yellow_dot",
            "yellow_big_pause",
            "yellow_pushpin",
            "lightblue",
            "lightblue_dot",
            "lightblue_pushpin",
            "orange",
            "orange_small",
            "orange_dot",
            "pink",
            "pink_dot",
            "pink_pushpin",
            "purple",
            "purple_small",
            "purple_dot",
            "purple_pushpin",
            "red ",
            "red_small",
            "red_dot",
            "red_pushpin",
            "red_big_stop",
            "black_small",
            "white_small"});
            this.toolStripComboBox_simge.Name = "toolStripComboBox_simge";
            this.toolStripComboBox_simge.Size = new System.Drawing.Size(121, 23);
            // 
            // contextMenuStrip_işaret
            // 
            this.contextMenuStrip_işaret.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_işaret_başlık,
            this.toolStripSeparator_ayıraç2,
            this.toolStripMenuItem_işaretsil});
            this.contextMenuStrip_işaret.Name = "contextMenuStrip_işaret";
            this.contextMenuStrip_işaret.ShowImageMargin = false;
            this.contextMenuStrip_işaret.Size = new System.Drawing.Size(96, 54);
            this.contextMenuStrip_işaret.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_işaret_Opening);
            this.contextMenuStrip_işaret.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip_işaret_MouseClick);
            // 
            // toolStripMenuItem_işaret_başlık
            // 
            this.toolStripMenuItem_işaret_başlık.Enabled = false;
            this.toolStripMenuItem_işaret_başlık.Name = "toolStripMenuItem_işaret_başlık";
            this.toolStripMenuItem_işaret_başlık.Size = new System.Drawing.Size(95, 22);
            this.toolStripMenuItem_işaret_başlık.Text = " Ayarları";
            // 
            // toolStripSeparator_ayıraç2
            // 
            this.toolStripSeparator_ayıraç2.Name = "toolStripSeparator_ayıraç2";
            this.toolStripSeparator_ayıraç2.Size = new System.Drawing.Size(92, 6);
            // 
            // toolStripMenuItem_işaretsil
            // 
            this.toolStripMenuItem_işaretsil.Name = "toolStripMenuItem_işaretsil";
            this.toolStripMenuItem_işaretsil.Size = new System.Drawing.Size(95, 22);
            this.toolStripMenuItem_işaretsil.Text = "İşareti Sil";
            this.toolStripMenuItem_işaretsil.Click += new System.EventHandler(this.toolStripMenuItem_işaretsil_Click);
            // 
            // groupBox_işaretler
            // 
            this.groupBox_işaretler.Controls.Add(this.propertyGrid_seriport);
            this.groupBox_işaretler.Controls.Add(this.dataGridView_işaretler);
            this.groupBox_işaretler.Location = new System.Drawing.Point(589, 138);
            this.groupBox_işaretler.Name = "groupBox_işaretler";
            this.groupBox_işaretler.Size = new System.Drawing.Size(583, 285);
            this.groupBox_işaretler.TabIndex = 23;
            this.groupBox_işaretler.TabStop = false;
            this.groupBox_işaretler.Text = "İşaretler";
            // 
            // propertyGrid_seriport
            // 
            this.propertyGrid_seriport.Location = new System.Drawing.Point(6, 90);
            this.propertyGrid_seriport.Name = "propertyGrid_seriport";
            this.propertyGrid_seriport.SelectedObject = this.seriport;
            this.propertyGrid_seriport.Size = new System.Drawing.Size(310, 189);
            this.propertyGrid_seriport.TabIndex = 26;
            this.propertyGrid_seriport.ToolbarVisible = false;
            // 
            // seriport
            // 
            this.seriport.DtrEnable = true;
            this.seriport.PortName = "COM8";
            this.seriport.ReceivedBytesThreshold = 8;
            this.seriport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.seriport_DataReceived);
            // 
            // dataGridView_işaretler
            // 
            this.dataGridView_işaretler.AutoGenerateColumns = false;
            this.dataGridView_işaretler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_işaretler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.enlemDataGridViewTextBoxColumn,
            this.boylamDataGridViewTextBoxColumn,
            this.görünürlükDataGridViewCheckBoxColumn,
            this.silDataGridViewButtonColumn});
            this.dataGridView_işaretler.DataSource = this.işaretBindingSource;
            this.dataGridView_işaretler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_işaretler.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_işaretler.Name = "dataGridView_işaretler";
            this.dataGridView_işaretler.Size = new System.Drawing.Size(577, 266);
            this.dataGridView_işaretler.TabIndex = 26;
            this.dataGridView_işaretler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_işaretler_CellContentClick);
            this.dataGridView_işaretler.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_işaretler_RowHeaderMouseDoubleClick);
            // 
            // silDataGridViewButtonColumn
            // 
            this.silDataGridViewButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.silDataGridViewButtonColumn.HeaderText = "Sil";
            this.silDataGridViewButtonColumn.Name = "silDataGridViewButtonColumn";
            this.silDataGridViewButtonColumn.Text = "İşaret Sil";
            this.silDataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            this.silDataGridViewButtonColumn.Width = 24;
            // 
            // groupBox_ayarlar
            // 
            this.groupBox_ayarlar.Controls.Add(this.comboBox_sağlayıcılar);
            this.groupBox_ayarlar.Controls.Add(this.label_mod);
            this.groupBox_ayarlar.Controls.Add(this.label_sağlayıcı);
            this.groupBox_ayarlar.Controls.Add(this.comboBox_mod);
            this.groupBox_ayarlar.Location = new System.Drawing.Point(761, 12);
            this.groupBox_ayarlar.Name = "groupBox_ayarlar";
            this.groupBox_ayarlar.Size = new System.Drawing.Size(166, 72);
            this.groupBox_ayarlar.TabIndex = 22;
            this.groupBox_ayarlar.TabStop = false;
            this.groupBox_ayarlar.Text = "Ayarlar";
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
            // label_mod
            // 
            this.label_mod.AutoSize = true;
            this.label_mod.Location = new System.Drawing.Point(117, 51);
            this.label_mod.Name = "label_mod";
            this.label_mod.Size = new System.Drawing.Size(27, 13);
            this.label_mod.TabIndex = 13;
            this.label_mod.Text = "mod";
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
            // groupBox_koordinatlar
            // 
            this.groupBox_koordinatlar.Controls.Add(this.textBox_arama);
            this.groupBox_koordinatlar.Controls.Add(this.label_enlem);
            this.groupBox_koordinatlar.Controls.Add(this.label_boylam);
            this.groupBox_koordinatlar.Controls.Add(this.button_bul);
            this.groupBox_koordinatlar.Controls.Add(this.textBox_enlem);
            this.groupBox_koordinatlar.Controls.Add(this.textBox_boylam);
            this.groupBox_koordinatlar.Controls.Add(this.label_ara);
            this.groupBox_koordinatlar.Location = new System.Drawing.Point(589, 12);
            this.groupBox_koordinatlar.Name = "groupBox_koordinatlar";
            this.groupBox_koordinatlar.Size = new System.Drawing.Size(166, 120);
            this.groupBox_koordinatlar.TabIndex = 21;
            this.groupBox_koordinatlar.TabStop = false;
            this.groupBox_koordinatlar.Text = "Koordinatlar";
            // 
            // textBox_arama
            // 
            this.textBox_arama.Location = new System.Drawing.Point(6, 68);
            this.textBox_arama.Name = "textBox_arama";
            this.textBox_arama.Size = new System.Drawing.Size(111, 20);
            this.textBox_arama.TabIndex = 7;
            this.textBox_arama.Text = "Kontrol ve Otomasyon";
            // 
            // label_enlem
            // 
            this.label_enlem.AutoSize = true;
            this.label_enlem.Location = new System.Drawing.Point(123, 22);
            this.label_enlem.Name = "label_enlem";
            this.label_enlem.Size = new System.Drawing.Size(35, 13);
            this.label_enlem.TabIndex = 2;
            this.label_enlem.Text = "enlem";
            // 
            // label_boylam
            // 
            this.label_boylam.AutoSize = true;
            this.label_boylam.Location = new System.Drawing.Point(123, 49);
            this.label_boylam.Name = "label_boylam";
            this.label_boylam.Size = new System.Drawing.Size(40, 13);
            this.label_boylam.TabIndex = 3;
            this.label_boylam.Text = "boylam";
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
            // textBox_enlem
            // 
            this.textBox_enlem.Location = new System.Drawing.Point(6, 15);
            this.textBox_enlem.Name = "textBox_enlem";
            this.textBox_enlem.Size = new System.Drawing.Size(111, 20);
            this.textBox_enlem.TabIndex = 4;
            // 
            // textBox_boylam
            // 
            this.textBox_boylam.Location = new System.Drawing.Point(6, 42);
            this.textBox_boylam.Name = "textBox_boylam";
            this.textBox_boylam.Size = new System.Drawing.Size(111, 20);
            this.textBox_boylam.TabIndex = 5;
            // 
            // label_ara
            // 
            this.label_ara.AutoSize = true;
            this.label_ara.Location = new System.Drawing.Point(123, 75);
            this.label_ara.Name = "label_ara";
            this.label_ara.Size = new System.Drawing.Size(22, 13);
            this.label_ara.TabIndex = 6;
            this.label_ara.Text = "ara";
            // 
            // groupBox_harita
            // 
            this.groupBox_harita.Controls.Add(this.gMapControl1);
            this.groupBox_harita.Location = new System.Drawing.Point(12, 12);
            this.groupBox_harita.Name = "groupBox_harita";
            this.groupBox_harita.Size = new System.Drawing.Size(571, 411);
            this.groupBox_harita.TabIndex = 20;
            this.groupBox_harita.TabStop = false;
            this.groupBox_harita.Text = "gMapControl1";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.ContextMenuStrip = this.contextMenuStrip_harita;
            this.gMapControl1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3, 16);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 19;
            this.gMapControl1.MinZoom = 1;
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
            this.gMapControl1.Size = new System.Drawing.Size(565, 392);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 19D;
            this.gMapControl1.OnMarkerDoubleClick += new GMap.NET.WindowsForms.MarkerDoubleClick(this.gMapControl1_OnMarkerDoubleClick);
            this.gMapControl1.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.gMapControl1_OnMarkerEnter);
            this.gMapControl1.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.gMapControl1_OnMarkerLeave);
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseMove);
            // 
            // statusStrip_durum
            // 
            this.statusStrip_durum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_durum});
            this.statusStrip_durum.Location = new System.Drawing.Point(0, 505);
            this.statusStrip_durum.Name = "statusStrip_durum";
            this.statusStrip_durum.Size = new System.Drawing.Size(1185, 22);
            this.statusStrip_durum.TabIndex = 24;
            // 
            // toolStripStatusLabel_durum
            // 
            this.toolStripStatusLabel_durum.Name = "toolStripStatusLabel_durum";
            this.toolStripStatusLabel_durum.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel_durum.Text = "Hazır.";
            // 
            // statusStrip_harita
            // 
            this.statusStrip_harita.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_imleç});
            this.statusStrip_harita.Location = new System.Drawing.Point(0, 483);
            this.statusStrip_harita.Name = "statusStrip_harita";
            this.statusStrip_harita.Size = new System.Drawing.Size(1185, 22);
            this.statusStrip_harita.SizingGrip = false;
            this.statusStrip_harita.TabIndex = 25;
            // 
            // toolStripStatusLabel_imleç
            // 
            this.toolStripStatusLabel_imleç.Name = "toolStripStatusLabel_imleç";
            this.toolStripStatusLabel_imleç.Size = new System.Drawing.Size(101, 17);
            this.toolStripStatusLabel_imleç.Text = "İmleçin Konumu: ";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 45;
            // 
            // enlemDataGridViewTextBoxColumn
            // 
            this.enlemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.enlemDataGridViewTextBoxColumn.DataPropertyName = "Enlem";
            this.enlemDataGridViewTextBoxColumn.HeaderText = "Enlem";
            this.enlemDataGridViewTextBoxColumn.Name = "enlemDataGridViewTextBoxColumn";
            this.enlemDataGridViewTextBoxColumn.Width = 61;
            // 
            // boylamDataGridViewTextBoxColumn
            // 
            this.boylamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.boylamDataGridViewTextBoxColumn.DataPropertyName = "Boylam";
            this.boylamDataGridViewTextBoxColumn.HeaderText = "Boylam";
            this.boylamDataGridViewTextBoxColumn.Name = "boylamDataGridViewTextBoxColumn";
            this.boylamDataGridViewTextBoxColumn.Width = 66;
            // 
            // görünürlükDataGridViewCheckBoxColumn
            // 
            this.görünürlükDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.görünürlükDataGridViewCheckBoxColumn.DataPropertyName = "Görünürlük";
            this.görünürlükDataGridViewCheckBoxColumn.HeaderText = "Görünürlük";
            this.görünürlükDataGridViewCheckBoxColumn.Name = "görünürlükDataGridViewCheckBoxColumn";
            this.görünürlükDataGridViewCheckBoxColumn.Width = 65;
            // 
            // işaretBindingSource
            // 
            this.işaretBindingSource.AllowNew = true;
            this.işaretBindingSource.DataSource = typeof(Harita_Denemesi.İşaret);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 527);
            this.Controls.Add(this.statusStrip_harita);
            this.Controls.Add(this.statusStrip_durum);
            this.Controls.Add(this.groupBox_işaretler);
            this.Controls.Add(this.groupBox_ayarlar);
            this.Controls.Add(this.groupBox_koordinatlar);
            this.Controls.Add(this.groupBox_harita);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harita Denemesi";
            this.contextMenuStrip_harita.ResumeLayout(false);
            this.contextMenuStrip_işaret.ResumeLayout(false);
            this.groupBox_işaretler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_işaretler)).EndInit();
            this.groupBox_ayarlar.ResumeLayout(false);
            this.groupBox_ayarlar.PerformLayout();
            this.groupBox_koordinatlar.ResumeLayout(false);
            this.groupBox_koordinatlar.PerformLayout();
            this.groupBox_harita.ResumeLayout(false);
            this.statusStrip_durum.ResumeLayout(false);
            this.statusStrip_durum.PerformLayout();
            this.statusStrip_harita.ResumeLayout(false);
            this.statusStrip_harita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.işaretBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_işaret;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_işaret_başlık;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_harita;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_işarethızlıekle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_işaretekle;
        private System.Windows.Forms.GroupBox groupBox_işaretler;
        private System.Windows.Forms.GroupBox groupBox_ayarlar;
        private System.Windows.Forms.ComboBox comboBox_sağlayıcılar;
        private System.Windows.Forms.Label label_mod;
        private System.Windows.Forms.Label label_sağlayıcı;
        private System.Windows.Forms.ComboBox comboBox_mod;
        private System.Windows.Forms.GroupBox groupBox_koordinatlar;
        private System.Windows.Forms.TextBox textBox_arama;
        private System.Windows.Forms.Label label_enlem;
        private System.Windows.Forms.Label label_boylam;
        private System.Windows.Forms.Button button_bul;
        private System.Windows.Forms.TextBox textBox_enlem;
        private System.Windows.Forms.TextBox textBox_boylam;
        private System.Windows.Forms.Label label_ara;
        private System.Windows.Forms.GroupBox groupBox_harita;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.StatusStrip statusStrip_durum;
        private System.Windows.Forms.StatusStrip statusStrip_harita;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_durum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_imleç;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_harita_başlık;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_ayıraç1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_ayıraç2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_işaretsil;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_simge;
        private System.Windows.Forms.DataGridView dataGridView_işaretler;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_simge;
        private System.Windows.Forms.BindingSource işaretBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enlemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boylamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn görünürlükDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn silDataGridViewButtonColumn;
        private System.IO.Ports.SerialPort seriport;
        private System.Windows.Forms.PropertyGrid propertyGrid_seriport;
    }
}

