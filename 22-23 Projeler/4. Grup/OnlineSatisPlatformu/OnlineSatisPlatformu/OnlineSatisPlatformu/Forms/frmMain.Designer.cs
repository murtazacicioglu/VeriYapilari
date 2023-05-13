namespace OnlineSatisPlatformu
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSepet = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.tabKargolar = new System.Windows.Forms.TabPage();
            this.flpKargolar = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYrtTemizle = new System.Windows.Forms.Button();
            this.flpYurtici = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMngTemizle = new System.Windows.Forms.Button();
            this.flpMNG = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPttTemizle = new System.Windows.Forms.Button();
            this.flpPTT = new System.Windows.Forms.FlowLayoutPanel();
            this.bthAbout = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabKargolar.SuspendLayout();
            this.flpKargolar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(124, 62);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "ÜRÜN EKLE";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAddProduct);
            this.flowLayoutPanel2.Controls.Add(this.btnSepet);
            this.flowLayoutPanel2.Controls.Add(this.bthAbout);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1760, 15);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(132, 216);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // btnSepet
            // 
            this.btnSepet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSepet.Location = new System.Drawing.Point(3, 71);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(124, 62);
            this.btnSepet.TabIndex = 8;
            this.btnSepet.Text = "SEPET";
            this.btnSepet.UseVisualStyleBackColor = true;
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabKargolar);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 40);
            this.tabControl1.Location = new System.Drawing.Point(12, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1742, 943);
            this.tabControl1.TabIndex = 7;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.flowLayoutPanel3);
            this.tabProducts.Controls.Add(this.flpProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 44);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(1734, 895);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "ÜRÜNLER";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.cmbKat);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.cmbSort);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.txtSearch);
            this.flowLayoutPanel3.Controls.Add(this.btnSearch);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 9);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1017, 40);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbKat
            // 
            this.cmbKat.FormattingEnabled = true;
            this.cmbKat.Items.AddRange(new object[] {
            "HEPSİ",
            "TV",
            "BUZDOLABI",
            "ÇAMAŞIR MAK."});
            this.cmbKat.Location = new System.Drawing.Point(88, 3);
            this.cmbKat.Name = "cmbKat";
            this.cmbKat.Size = new System.Drawing.Size(181, 29);
            this.cmbKat.TabIndex = 1;
            this.cmbKat.Text = "HEPSİ";
            this.cmbKat.SelectedIndexChanged += new System.EventHandler(this.cmbKat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(275, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sırala:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Fiyata göre artan",
            "Fiyata göre azalan",
            "En ucuz",
            "En pahalı"});
            this.cmbSort.Location = new System.Drawing.Point(360, 3);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(181, 29);
            this.cmbSort.TabIndex = 3;
            this.cmbSort.Text = "Fiyata göre artan";
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(547, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ara:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(632, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 29);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(830, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Filtrele";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flpProducts
            // 
            this.flpProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flpProducts.Location = new System.Drawing.Point(3, 52);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(1728, 840);
            this.flpProducts.TabIndex = 0;
            // 
            // tabKargolar
            // 
            this.tabKargolar.Controls.Add(this.flpKargolar);
            this.tabKargolar.Location = new System.Drawing.Point(4, 44);
            this.tabKargolar.Name = "tabKargolar";
            this.tabKargolar.Padding = new System.Windows.Forms.Padding(3);
            this.tabKargolar.Size = new System.Drawing.Size(1734, 895);
            this.tabKargolar.TabIndex = 1;
            this.tabKargolar.Text = "KARGOLAR";
            this.tabKargolar.UseVisualStyleBackColor = true;
            // 
            // flpKargolar
            // 
            this.flpKargolar.Controls.Add(this.label4);
            this.flpKargolar.Controls.Add(this.btnYrtTemizle);
            this.flpKargolar.Controls.Add(this.flpYurtici);
            this.flpKargolar.Controls.Add(this.label5);
            this.flpKargolar.Controls.Add(this.btnMngTemizle);
            this.flpKargolar.Controls.Add(this.flpMNG);
            this.flpKargolar.Controls.Add(this.label6);
            this.flpKargolar.Controls.Add(this.btnPttTemizle);
            this.flpKargolar.Controls.Add(this.flpPTT);
            this.flpKargolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKargolar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flpKargolar.Location = new System.Drawing.Point(3, 3);
            this.flpKargolar.Name = "flpKargolar";
            this.flpKargolar.Size = new System.Drawing.Size(1728, 889);
            this.flpKargolar.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "YURTİÇİ";
            // 
            // btnYrtTemizle
            // 
            this.btnYrtTemizle.Location = new System.Drawing.Point(99, 3);
            this.btnYrtTemizle.Name = "btnYrtTemizle";
            this.btnYrtTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnYrtTemizle.TabIndex = 7;
            this.btnYrtTemizle.Text = "Gönder";
            this.btnYrtTemizle.UseVisualStyleBackColor = true;
            this.btnYrtTemizle.Click += new System.EventHandler(this.btnYrtTemizle_Click);
            // 
            // flpYurtici
            // 
            this.flpYurtici.Location = new System.Drawing.Point(3, 33);
            this.flpYurtici.Name = "flpYurtici";
            this.flpYurtici.Size = new System.Drawing.Size(1722, 213);
            this.flpYurtici.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "MNG";
            // 
            // btnMngTemizle
            // 
            this.btnMngTemizle.Location = new System.Drawing.Point(73, 252);
            this.btnMngTemizle.Name = "btnMngTemizle";
            this.btnMngTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnMngTemizle.TabIndex = 8;
            this.btnMngTemizle.Text = "Gönder";
            this.btnMngTemizle.UseVisualStyleBackColor = true;
            this.btnMngTemizle.Click += new System.EventHandler(this.btnMngTemizle_Click);
            // 
            // flpMNG
            // 
            this.flpMNG.Location = new System.Drawing.Point(3, 282);
            this.flpMNG.Name = "flpMNG";
            this.flpMNG.Size = new System.Drawing.Size(1722, 213);
            this.flpMNG.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "PTT";
            // 
            // btnPttTemizle
            // 
            this.btnPttTemizle.Location = new System.Drawing.Point(58, 501);
            this.btnPttTemizle.Name = "btnPttTemizle";
            this.btnPttTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnPttTemizle.TabIndex = 8;
            this.btnPttTemizle.Text = "Gönder";
            this.btnPttTemizle.UseVisualStyleBackColor = true;
            this.btnPttTemizle.Click += new System.EventHandler(this.btnPttTemizle_Click);
            // 
            // flpPTT
            // 
            this.flpPTT.Location = new System.Drawing.Point(3, 531);
            this.flpPTT.Name = "flpPTT";
            this.flpPTT.Size = new System.Drawing.Size(1722, 213);
            this.flpPTT.TabIndex = 5;
            // 
            // bthAbout
            // 
            this.bthAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bthAbout.Location = new System.Drawing.Point(3, 139);
            this.bthAbout.Name = "bthAbout";
            this.bthAbout.Size = new System.Drawing.Size(124, 62);
            this.bthAbout.TabIndex = 9;
            this.bthAbout.Text = "HAKKINDA";
            this.bthAbout.UseVisualStyleBackColor = true;
            this.bthAbout.Click += new System.EventHandler(this.bthAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "frmMain";
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tabKargolar.ResumeLayout(false);
            this.flpKargolar.ResumeLayout(false);
            this.flpKargolar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddProduct;
        private FlowLayoutPanel flowLayoutPanel2;
        private TabControl tabControl1;
        private TabPage tabProducts;
        private TabPage tabKargolar;
        private FlowLayoutPanel flpProducts;
        private Label label1;
        private ComboBox cmbKat;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private ComboBox cmbSort;
        private Label label3;
        private TextBox txtSearch;
        private Button btnSearch;
        private FlowLayoutPanel flpKargolar;
        private Button btnSepet;
        private Label label4;
        private FlowLayoutPanel flpYurtici;
        private Label label5;
        private FlowLayoutPanel flpMNG;
        private Label label6;
        private FlowLayoutPanel flpPTT;
        private Button btnYrtTemizle;
        private Button btnMngTemizle;
        private Button btnPttTemizle;
        private Button bthAbout;
    }
}