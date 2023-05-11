namespace RecapDemo1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hosgeldiniz = new System.Windows.Forms.Label();
            this.giris_yap = new System.Windows.Forms.Label();
            this.tc_kimlik = new System.Windows.Forms.Label();
            this.tc_kimlik_textbox = new System.Windows.Forms.TextBox();
            this.isim_textbox = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.Label();
            this.soyisim_textbox = new System.Windows.Forms.TextBox();
            this.soyisim = new System.Windows.Forms.Label();
            this.cinsiyet = new System.Windows.Forms.Label();
            this.erkek_checkbox = new System.Windows.Forms.CheckBox();
            this.kadin_checkbox = new System.Windows.Forms.CheckBox();
            this.yas = new System.Windows.Forms.Label();
            this.yas_numupdown = new System.Windows.Forms.NumericUpDown();
            this.giris_button = new System.Windows.Forms.Button();
            this.nereye = new System.Windows.Forms.Label();
            this.nereden = new System.Windows.Forms.Label();
            this.bilet_olustur = new System.Windows.Forms.Label();
            this.nereden_combobox = new System.Windows.Forms.ComboBox();
            this.nereye_combobox = new System.Windows.Forms.ComboBox();
            this.sefer_combobox = new System.Windows.Forms.ComboBox();
            this.mevcut_seferler = new System.Windows.Forms.Label();
            this.koltuk_numarasi = new System.Windows.Forms.Label();
            this.koltuk_numarasi_numupdown = new System.Windows.Forms.NumericUpDown();
            this.bilet_sec_combobox = new System.Windows.Forms.ComboBox();
            this.bilet_sec = new System.Windows.Forms.Label();
            this.bilet_sil = new System.Windows.Forms.Label();
            this.bileti_sil_button = new System.Windows.Forms.Button();
            this.bilet_olustur_button = new System.Windows.Forms.Button();
            this.tc_uyari = new System.Windows.Forms.Label();
            this.isim_uyari = new System.Windows.Forms.Label();
            this.soyisim_uyari = new System.Windows.Forms.Label();
            this.cinsiyet_uyari = new System.Windows.Forms.Label();
            this.yas_uyari = new System.Windows.Forms.Label();
            this.tcbos_uyari = new System.Windows.Forms.Label();
            this.zaman_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gun_ve_saat = new System.Windows.Forms.Label();
            this.nereden_uyari = new System.Windows.Forms.Label();
            this.nereye_uyari = new System.Windows.Forms.Label();
            this.gun_ve_saat_uyari = new System.Windows.Forms.Label();
            this.sefer_uyari = new System.Windows.Forms.Label();
            this.koltukno_uyari = new System.Windows.Forms.Label();
            this.biletsil_uyari = new System.Windows.Forms.Label();
            this.tc11rakam_uyari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yas_numupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koltuk_numarasi_numupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // hosgeldiniz
            // 
            this.hosgeldiniz.AutoSize = true;
            this.hosgeldiniz.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.hosgeldiniz.Location = new System.Drawing.Point(327, 22);
            this.hosgeldiniz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hosgeldiniz.Name = "hosgeldiniz";
            this.hosgeldiniz.Size = new System.Drawing.Size(409, 26);
            this.hosgeldiniz.TabIndex = 0;
            this.hosgeldiniz.Text = "Otobüs Yönetim Sistemine Hoşgeldiniz!";
            // 
            // giris_yap
            // 
            this.giris_yap.AutoSize = true;
            this.giris_yap.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.giris_yap.Location = new System.Drawing.Point(148, 84);
            this.giris_yap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.giris_yap.Name = "giris_yap";
            this.giris_yap.Size = new System.Drawing.Size(102, 26);
            this.giris_yap.TabIndex = 1;
            this.giris_yap.Text = "Giriş Yap";
            // 
            // tc_kimlik
            // 
            this.tc_kimlik.AutoSize = true;
            this.tc_kimlik.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.tc_kimlik.Location = new System.Drawing.Point(44, 145);
            this.tc_kimlik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tc_kimlik.Name = "tc_kimlik";
            this.tc_kimlik.Size = new System.Drawing.Size(112, 18);
            this.tc_kimlik.TabIndex = 2;
            this.tc_kimlik.Text = "T.C Kimlik No: ";
            // 
            // tc_kimlik_textbox
            // 
            this.tc_kimlik_textbox.Location = new System.Drawing.Point(163, 143);
            this.tc_kimlik_textbox.Name = "tc_kimlik_textbox";
            this.tc_kimlik_textbox.Size = new System.Drawing.Size(196, 21);
            this.tc_kimlik_textbox.TabIndex = 3;
            this.tc_kimlik_textbox.TextChanged += new System.EventHandler(this.tc_kimlik_textbox_TextChanged);
            this.tc_kimlik_textbox.VisibleChanged += new System.EventHandler(this.tcbos_uyari_VisibleChanged);
            this.tc_kimlik_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tc_kimlik_textbox_KeyDown);
            this.tc_kimlik_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_kimlik_textbox_KeyPress);
            // 
            // isim_textbox
            // 
            this.isim_textbox.Location = new System.Drawing.Point(162, 198);
            this.isim_textbox.Name = "isim_textbox";
            this.isim_textbox.Size = new System.Drawing.Size(197, 21);
            this.isim_textbox.TabIndex = 5;
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.isim.Location = new System.Drawing.Point(43, 198);
            this.isim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(48, 18);
            this.isim.TabIndex = 4;
            this.isim.Text = "İsim: ";
            // 
            // soyisim_textbox
            // 
            this.soyisim_textbox.Location = new System.Drawing.Point(162, 252);
            this.soyisim_textbox.Name = "soyisim_textbox";
            this.soyisim_textbox.Size = new System.Drawing.Size(197, 21);
            this.soyisim_textbox.TabIndex = 7;
            // 
            // soyisim
            // 
            this.soyisim.AutoSize = true;
            this.soyisim.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.soyisim.Location = new System.Drawing.Point(43, 252);
            this.soyisim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(73, 18);
            this.soyisim.TabIndex = 6;
            this.soyisim.Text = "Soyisim: ";
            // 
            // cinsiyet
            // 
            this.cinsiyet.AutoSize = true;
            this.cinsiyet.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.cinsiyet.Location = new System.Drawing.Point(44, 312);
            this.cinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(74, 18);
            this.cinsiyet.TabIndex = 8;
            this.cinsiyet.Text = "Cinsiyet: ";
            // 
            // erkek_checkbox
            // 
            this.erkek_checkbox.AutoSize = true;
            this.erkek_checkbox.Location = new System.Drawing.Point(163, 313);
            this.erkek_checkbox.Name = "erkek_checkbox";
            this.erkek_checkbox.Size = new System.Drawing.Size(59, 19);
            this.erkek_checkbox.TabIndex = 9;
            this.erkek_checkbox.Text = "Erkek";
            this.erkek_checkbox.UseVisualStyleBackColor = true;
            // 
            // kadin_checkbox
            // 
            this.kadin_checkbox.AutoSize = true;
            this.kadin_checkbox.Location = new System.Drawing.Point(281, 311);
            this.kadin_checkbox.Name = "kadin_checkbox";
            this.kadin_checkbox.Size = new System.Drawing.Size(58, 19);
            this.kadin_checkbox.TabIndex = 10;
            this.kadin_checkbox.Text = "Kadın";
            this.kadin_checkbox.UseVisualStyleBackColor = true;
            // 
            // yas
            // 
            this.yas.AutoSize = true;
            this.yas.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.yas.Location = new System.Drawing.Point(45, 367);
            this.yas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(44, 18);
            this.yas.TabIndex = 11;
            this.yas.Text = "Yaş: ";
            // 
            // yas_numupdown
            // 
            this.yas_numupdown.Location = new System.Drawing.Point(281, 364);
            this.yas_numupdown.Name = "yas_numupdown";
            this.yas_numupdown.Size = new System.Drawing.Size(73, 21);
            this.yas_numupdown.TabIndex = 12;
            // 
            // giris_button
            // 
            this.giris_button.Location = new System.Drawing.Point(260, 432);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(94, 23);
            this.giris_button.TabIndex = 13;
            this.giris_button.Text = "Giriş";
            this.giris_button.UseVisualStyleBackColor = true;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click_1);
            // 
            // nereye
            // 
            this.nereye.AutoSize = true;
            this.nereye.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.nereye.Location = new System.Drawing.Point(397, 196);
            this.nereye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nereye.Name = "nereye";
            this.nereye.Size = new System.Drawing.Size(67, 18);
            this.nereye.TabIndex = 17;
            this.nereye.Text = "Nereye: ";
            // 
            // nereden
            // 
            this.nereden.AutoSize = true;
            this.nereden.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.nereden.Location = new System.Drawing.Point(398, 143);
            this.nereden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nereden.Name = "nereden";
            this.nereden.Size = new System.Drawing.Size(77, 18);
            this.nereden.TabIndex = 15;
            this.nereden.Text = "Nereden: ";
            // 
            // bilet_olustur
            // 
            this.bilet_olustur.AutoSize = true;
            this.bilet_olustur.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.bilet_olustur.Location = new System.Drawing.Point(458, 84);
            this.bilet_olustur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bilet_olustur.Name = "bilet_olustur";
            this.bilet_olustur.Size = new System.Drawing.Size(140, 26);
            this.bilet_olustur.TabIndex = 14;
            this.bilet_olustur.Text = "Bilet Oluştur";
            // 
            // nereden_combobox
            // 
            this.nereden_combobox.FormattingEnabled = true;
            this.nereden_combobox.Items.AddRange(new object[] {
            "(Boş)",
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.nereden_combobox.Location = new System.Drawing.Point(516, 138);
            this.nereden_combobox.Name = "nereden_combobox";
            this.nereden_combobox.Size = new System.Drawing.Size(131, 23);
            this.nereden_combobox.TabIndex = 20;
            this.nereden_combobox.Text = "Seçiniz";
            this.nereden_combobox.SelectedIndexChanged += new System.EventHandler(this.nereden_combobox_SelectedIndexChanged);
            // 
            // nereye_combobox
            // 
            this.nereye_combobox.DisplayMember = "(none)";
            this.nereye_combobox.FormattingEnabled = true;
            this.nereye_combobox.Items.AddRange(new object[] {
            "(Boş)",
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.nereye_combobox.Location = new System.Drawing.Point(515, 194);
            this.nereye_combobox.Name = "nereye_combobox";
            this.nereye_combobox.Size = new System.Drawing.Size(131, 23);
            this.nereye_combobox.TabIndex = 21;
            this.nereye_combobox.Tag = "";
            this.nereye_combobox.Text = "Seçiniz";
            // 
            // sefer_combobox
            // 
            this.sefer_combobox.FormattingEnabled = true;
            this.sefer_combobox.Location = new System.Drawing.Point(400, 362);
            this.sefer_combobox.Name = "sefer_combobox";
            this.sefer_combobox.Size = new System.Drawing.Size(246, 23);
            this.sefer_combobox.TabIndex = 23;
            this.sefer_combobox.Text = "Seçiniz";
            this.sefer_combobox.SelectedIndexChanged += new System.EventHandler(this.sefer_combobox_SelectedIndexChanged);
            // 
            // mevcut_seferler
            // 
            this.mevcut_seferler.AutoSize = true;
            this.mevcut_seferler.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.mevcut_seferler.Location = new System.Drawing.Point(398, 340);
            this.mevcut_seferler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mevcut_seferler.Name = "mevcut_seferler";
            this.mevcut_seferler.Size = new System.Drawing.Size(127, 18);
            this.mevcut_seferler.TabIndex = 22;
            this.mevcut_seferler.Text = "Mevcut Seferler: ";
            this.mevcut_seferler.Click += new System.EventHandler(this.label4_Click);
            // 
            // koltuk_numarasi
            // 
            this.koltuk_numarasi.AutoSize = true;
            this.koltuk_numarasi.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.koltuk_numarasi.Location = new System.Drawing.Point(396, 427);
            this.koltuk_numarasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.koltuk_numarasi.Name = "koltuk_numarasi";
            this.koltuk_numarasi.Size = new System.Drawing.Size(129, 18);
            this.koltuk_numarasi.TabIndex = 24;
            this.koltuk_numarasi.Text = "Koltuk Numarası:";
            this.koltuk_numarasi.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // koltuk_numarasi_numupdown
            // 
            this.koltuk_numarasi_numupdown.Location = new System.Drawing.Point(573, 427);
            this.koltuk_numarasi_numupdown.Name = "koltuk_numarasi_numupdown";
            this.koltuk_numarasi_numupdown.Size = new System.Drawing.Size(73, 21);
            this.koltuk_numarasi_numupdown.TabIndex = 25;
            this.koltuk_numarasi_numupdown.Tag = "";
            // 
            // bilet_sec_combobox
            // 
            this.bilet_sec_combobox.FormattingEnabled = true;
            this.bilet_sec_combobox.Location = new System.Drawing.Point(759, 169);
            this.bilet_sec_combobox.Name = "bilet_sec_combobox";
            this.bilet_sec_combobox.Size = new System.Drawing.Size(246, 23);
            this.bilet_sec_combobox.TabIndex = 28;
            this.bilet_sec_combobox.Text = "Seçiniz";
            // 
            // bilet_sec
            // 
            this.bilet_sec.AutoSize = true;
            this.bilet_sec.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.bilet_sec.Location = new System.Drawing.Point(756, 137);
            this.bilet_sec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bilet_sec.Name = "bilet_sec";
            this.bilet_sec.Size = new System.Drawing.Size(72, 18);
            this.bilet_sec.TabIndex = 27;
            this.bilet_sec.Text = "Bilet seç:";
            // 
            // bilet_sil
            // 
            this.bilet_sil.AutoSize = true;
            this.bilet_sil.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.bilet_sil.Location = new System.Drawing.Point(829, 83);
            this.bilet_sil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bilet_sil.Name = "bilet_sil";
            this.bilet_sil.Size = new System.Drawing.Size(91, 26);
            this.bilet_sil.TabIndex = 26;
            this.bilet_sil.Text = "Bilet Sil";
            // 
            // bileti_sil_button
            // 
            this.bileti_sil_button.Location = new System.Drawing.Point(911, 223);
            this.bileti_sil_button.Name = "bileti_sil_button";
            this.bileti_sil_button.Size = new System.Drawing.Size(94, 23);
            this.bileti_sil_button.TabIndex = 29;
            this.bileti_sil_button.Text = "Bileti Sil";
            this.bileti_sil_button.UseVisualStyleBackColor = true;
            // 
            // bilet_olustur_button
            // 
            this.bilet_olustur_button.Location = new System.Drawing.Point(553, 486);
            this.bilet_olustur_button.Name = "bilet_olustur_button";
            this.bilet_olustur_button.Size = new System.Drawing.Size(94, 23);
            this.bilet_olustur_button.TabIndex = 30;
            this.bilet_olustur_button.Text = "Bilet Oluştur";
            this.bilet_olustur_button.UseVisualStyleBackColor = true;
            // 
            // tc_uyari
            // 
            this.tc_uyari.AutoSize = true;
            this.tc_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_uyari.ForeColor = System.Drawing.Color.Red;
            this.tc_uyari.Location = new System.Drawing.Point(43, 172);
            this.tc_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tc_uyari.Name = "tc_uyari";
            this.tc_uyari.Size = new System.Drawing.Size(174, 15);
            this.tc_uyari.TabIndex = 31;
            this.tc_uyari.Text = "* Geçersiz kimlik numarası ! ";
            this.tc_uyari.Visible = false;
            // 
            // isim_uyari
            // 
            this.isim_uyari.AutoSize = true;
            this.isim_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim_uyari.ForeColor = System.Drawing.Color.Red;
            this.isim_uyari.Location = new System.Drawing.Point(43, 227);
            this.isim_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isim_uyari.Name = "isim_uyari";
            this.isim_uyari.Size = new System.Drawing.Size(207, 15);
            this.isim_uyari.TabIndex = 32;
            this.isim_uyari.Text = "* Lütfen bu alanı boş bırakmayınız!";
            this.isim_uyari.Visible = false;
            // 
            // soyisim_uyari
            // 
            this.soyisim_uyari.AutoSize = true;
            this.soyisim_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisim_uyari.ForeColor = System.Drawing.Color.Red;
            this.soyisim_uyari.Location = new System.Drawing.Point(45, 284);
            this.soyisim_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soyisim_uyari.Name = "soyisim_uyari";
            this.soyisim_uyari.Size = new System.Drawing.Size(207, 15);
            this.soyisim_uyari.TabIndex = 33;
            this.soyisim_uyari.Text = "* Lütfen bu alanı boş bırakmayınız!";
            this.soyisim_uyari.Visible = false;
            // 
            // cinsiyet_uyari
            // 
            this.cinsiyet_uyari.AutoSize = true;
            this.cinsiyet_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cinsiyet_uyari.ForeColor = System.Drawing.Color.Red;
            this.cinsiyet_uyari.Location = new System.Drawing.Point(43, 343);
            this.cinsiyet_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cinsiyet_uyari.Name = "cinsiyet_uyari";
            this.cinsiyet_uyari.Size = new System.Drawing.Size(178, 15);
            this.cinsiyet_uyari.TabIndex = 34;
            this.cinsiyet_uyari.Text = "* Lütfen cinsiyetinizi belirtiniz!";
            this.cinsiyet_uyari.Visible = false;
            // 
            // yas_uyari
            // 
            this.yas_uyari.AutoSize = true;
            this.yas_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yas_uyari.ForeColor = System.Drawing.Color.Red;
            this.yas_uyari.Location = new System.Drawing.Point(45, 399);
            this.yas_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yas_uyari.Name = "yas_uyari";
            this.yas_uyari.Size = new System.Drawing.Size(155, 15);
            this.yas_uyari.TabIndex = 35;
            this.yas_uyari.Text = "* Lütfen yaşınızı belirtiniz!";
            this.yas_uyari.Visible = false;
            // 
            // tcbos_uyari
            // 
            this.tcbos_uyari.AutoSize = true;
            this.tcbos_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcbos_uyari.ForeColor = System.Drawing.Color.Red;
            this.tcbos_uyari.Location = new System.Drawing.Point(45, 172);
            this.tcbos_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcbos_uyari.Name = "tcbos_uyari";
            this.tcbos_uyari.Size = new System.Drawing.Size(207, 15);
            this.tcbos_uyari.TabIndex = 36;
            this.tcbos_uyari.Text = "* Lütfen bu alanı boş bırakmayınız!";
            this.tcbos_uyari.Visible = false;
            // 
            // zaman_dateTimePicker
            // 
            this.zaman_dateTimePicker.Location = new System.Drawing.Point(402, 278);
            this.zaman_dateTimePicker.Name = "zaman_dateTimePicker";
            this.zaman_dateTimePicker.Size = new System.Drawing.Size(245, 21);
            this.zaman_dateTimePicker.TabIndex = 37;
            // 
            // gun_ve_saat
            // 
            this.gun_ve_saat.AutoSize = true;
            this.gun_ve_saat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gun_ve_saat.Location = new System.Drawing.Point(398, 254);
            this.gun_ve_saat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gun_ve_saat.Name = "gun_ve_saat";
            this.gun_ve_saat.Size = new System.Drawing.Size(100, 16);
            this.gun_ve_saat.TabIndex = 38;
            this.gun_ve_saat.Text = "Gün ve Saat: ";
            this.gun_ve_saat.Click += new System.EventHandler(this.label1_Click);
            // 
            // nereden_uyari
            // 
            this.nereden_uyari.AutoSize = true;
            this.nereden_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nereden_uyari.ForeColor = System.Drawing.Color.Red;
            this.nereden_uyari.Location = new System.Drawing.Point(398, 169);
            this.nereden_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nereden_uyari.Name = "nereden_uyari";
            this.nereden_uyari.Size = new System.Drawing.Size(220, 15);
            this.nereden_uyari.TabIndex = 39;
            this.nereden_uyari.Text = "* Lütfen kalkış yapacağınız ili seçiniz!";
            this.nereden_uyari.Visible = false;
            // 
            // nereye_uyari
            // 
            this.nereye_uyari.AutoSize = true;
            this.nereye_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nereye_uyari.ForeColor = System.Drawing.Color.Red;
            this.nereye_uyari.Location = new System.Drawing.Point(398, 227);
            this.nereye_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nereye_uyari.Name = "nereye_uyari";
            this.nereye_uyari.Size = new System.Drawing.Size(179, 15);
            this.nereye_uyari.TabIndex = 40;
            this.nereye_uyari.Text = "* Lütfen gideceğiniz ili seçiniz!";
            this.nereye_uyari.Visible = false;
            // 
            // gun_ve_saat_uyari
            // 
            this.gun_ve_saat_uyari.AutoSize = true;
            this.gun_ve_saat_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gun_ve_saat_uyari.ForeColor = System.Drawing.Color.Red;
            this.gun_ve_saat_uyari.Location = new System.Drawing.Point(398, 311);
            this.gun_ve_saat_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gun_ve_saat_uyari.Name = "gun_ve_saat_uyari";
            this.gun_ve_saat_uyari.Size = new System.Drawing.Size(189, 15);
            this.gun_ve_saat_uyari.TabIndex = 41;
            this.gun_ve_saat_uyari.Text = "* Lütfen kalkış tarihini belirtiniz!";
            this.gun_ve_saat_uyari.Visible = false;
            // 
            // sefer_uyari
            // 
            this.sefer_uyari.AutoSize = true;
            this.sefer_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sefer_uyari.ForeColor = System.Drawing.Color.Red;
            this.sefer_uyari.Location = new System.Drawing.Point(397, 399);
            this.sefer_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sefer_uyari.Name = "sefer_uyari";
            this.sefer_uyari.Size = new System.Drawing.Size(151, 15);
            this.sefer_uyari.TabIndex = 42;
            this.sefer_uyari.Text = "* Lütfen bir sefer seçiniz!";
            this.sefer_uyari.Visible = false;
            // 
            // koltukno_uyari
            // 
            this.koltukno_uyari.AutoSize = true;
            this.koltukno_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.koltukno_uyari.ForeColor = System.Drawing.Color.Red;
            this.koltukno_uyari.Location = new System.Drawing.Point(397, 451);
            this.koltukno_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.koltukno_uyari.Name = "koltukno_uyari";
            this.koltukno_uyari.Size = new System.Drawing.Size(207, 15);
            this.koltukno_uyari.TabIndex = 43;
            this.koltukno_uyari.Text = "* Lütfen bu alanı boş bırakmayınız!";
            this.koltukno_uyari.Visible = false;
            // 
            // biletsil_uyari
            // 
            this.biletsil_uyari.AutoSize = true;
            this.biletsil_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletsil_uyari.ForeColor = System.Drawing.Color.Red;
            this.biletsil_uyari.Location = new System.Drawing.Point(756, 201);
            this.biletsil_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.biletsil_uyari.Name = "biletsil_uyari";
            this.biletsil_uyari.Size = new System.Drawing.Size(231, 15);
            this.biletsil_uyari.TabIndex = 44;
            this.biletsil_uyari.Text = "* Lütfen silmek istediğiniz bileti seçiniz!";
            this.biletsil_uyari.Visible = false;
            // 
            // tc11rakam_uyari
            // 
            this.tc11rakam_uyari.AutoSize = true;
            this.tc11rakam_uyari.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc11rakam_uyari.ForeColor = System.Drawing.Color.Red;
            this.tc11rakam_uyari.Location = new System.Drawing.Point(45, 172);
            this.tc11rakam_uyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tc11rakam_uyari.Name = "tc11rakam_uyari";
            this.tc11rakam_uyari.Size = new System.Drawing.Size(265, 15);
            this.tc11rakam_uyari.TabIndex = 45;
            this.tc11rakam_uyari.Text = "* Lütfen 11 rakamlı kimlik numaranızı giriniz!";
            this.tc11rakam_uyari.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1080, 542);
            this.Controls.Add(this.tc11rakam_uyari);
            this.Controls.Add(this.biletsil_uyari);
            this.Controls.Add(this.koltukno_uyari);
            this.Controls.Add(this.sefer_uyari);
            this.Controls.Add(this.gun_ve_saat_uyari);
            this.Controls.Add(this.nereye_uyari);
            this.Controls.Add(this.nereden_uyari);
            this.Controls.Add(this.gun_ve_saat);
            this.Controls.Add(this.zaman_dateTimePicker);
            this.Controls.Add(this.tcbos_uyari);
            this.Controls.Add(this.yas_uyari);
            this.Controls.Add(this.cinsiyet_uyari);
            this.Controls.Add(this.soyisim_uyari);
            this.Controls.Add(this.isim_uyari);
            this.Controls.Add(this.tc_uyari);
            this.Controls.Add(this.bilet_olustur_button);
            this.Controls.Add(this.bileti_sil_button);
            this.Controls.Add(this.bilet_sec_combobox);
            this.Controls.Add(this.bilet_sec);
            this.Controls.Add(this.bilet_sil);
            this.Controls.Add(this.koltuk_numarasi_numupdown);
            this.Controls.Add(this.koltuk_numarasi);
            this.Controls.Add(this.sefer_combobox);
            this.Controls.Add(this.mevcut_seferler);
            this.Controls.Add(this.nereye_combobox);
            this.Controls.Add(this.nereden_combobox);
            this.Controls.Add(this.nereye);
            this.Controls.Add(this.nereden);
            this.Controls.Add(this.bilet_olustur);
            this.Controls.Add(this.giris_button);
            this.Controls.Add(this.yas_numupdown);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.kadin_checkbox);
            this.Controls.Add(this.erkek_checkbox);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.soyisim_textbox);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim_textbox);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.tc_kimlik_textbox);
            this.Controls.Add(this.tc_kimlik);
            this.Controls.Add(this.giris_yap);
            this.Controls.Add(this.hosgeldiniz);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şirket Adı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yas_numupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koltuk_numarasi_numupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hosgeldiniz;
        private System.Windows.Forms.Label giris_yap;
        private System.Windows.Forms.Label tc_kimlik;
        private System.Windows.Forms.TextBox tc_kimlik_textbox;
        private System.Windows.Forms.TextBox isim_textbox;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.TextBox soyisim_textbox;
        private System.Windows.Forms.Label soyisim;
        private System.Windows.Forms.Label cinsiyet;
        private System.Windows.Forms.CheckBox erkek_checkbox;
        private System.Windows.Forms.CheckBox kadin_checkbox;
        private System.Windows.Forms.Label yas;
        private System.Windows.Forms.NumericUpDown yas_numupdown;
        private System.Windows.Forms.Button giris_button;
        private System.Windows.Forms.Label nereye;
        private System.Windows.Forms.Label nereden;
        private System.Windows.Forms.Label bilet_olustur;
        private System.Windows.Forms.ComboBox nereden_combobox;
        private System.Windows.Forms.ComboBox nereye_combobox;
        private System.Windows.Forms.ComboBox sefer_combobox;
        private System.Windows.Forms.Label mevcut_seferler;
        private System.Windows.Forms.Label koltuk_numarasi;
        private System.Windows.Forms.NumericUpDown koltuk_numarasi_numupdown;
        private System.Windows.Forms.ComboBox bilet_sec_combobox;
        private System.Windows.Forms.Label bilet_sec;
        private System.Windows.Forms.Label bilet_sil;
        private System.Windows.Forms.Button bileti_sil_button;
        private System.Windows.Forms.Button bilet_olustur_button;
        private System.Windows.Forms.Label tc_uyari;
        private System.Windows.Forms.Label isim_uyari;
        private System.Windows.Forms.Label soyisim_uyari;
        private System.Windows.Forms.Label cinsiyet_uyari;
        private System.Windows.Forms.Label yas_uyari;
        private System.Windows.Forms.Label tcbos_uyari;
        private System.Windows.Forms.DateTimePicker zaman_dateTimePicker;
        private System.Windows.Forms.Label gun_ve_saat;
        private System.Windows.Forms.Label nereden_uyari;
        private System.Windows.Forms.Label nereye_uyari;
        private System.Windows.Forms.Label gun_ve_saat_uyari;
        private System.Windows.Forms.Label sefer_uyari;
        private System.Windows.Forms.Label koltukno_uyari;
        private System.Windows.Forms.Label biletsil_uyari;
        private System.Windows.Forms.Label tc11rakam_uyari;
    }
}

