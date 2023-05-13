namespace OnlineSatisPlatformu.Forms
{
    partial class frmSepet
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKargoAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKargoTipi = new System.Windows.Forms.Label();
            this.pnlSatis = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(528, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 37);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Sonraki";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(528, 52);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(99, 37);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Önceki";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lblKargoAd);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.lblKargoTipi);
            this.flowLayoutPanel1.Controls.Add(this.pnlSatis);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(236, 352);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kargo Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKargoAd
            // 
            this.lblKargoAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKargoAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKargoAd.Location = new System.Drawing.Point(3, 33);
            this.lblKargoAd.Name = "lblKargoAd";
            this.lblKargoAd.Size = new System.Drawing.Size(229, 33);
            this.lblKargoAd.TabIndex = 1;
            this.lblKargoAd.Text = "Kargo Adı:";
            this.lblKargoAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kargo Tipi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKargoTipi
            // 
            this.lblKargoTipi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKargoTipi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKargoTipi.Location = new System.Drawing.Point(3, 99);
            this.lblKargoTipi.Name = "lblKargoTipi";
            this.lblKargoTipi.Size = new System.Drawing.Size(226, 33);
            this.lblKargoTipi.TabIndex = 3;
            this.lblKargoTipi.Text = "tip";
            this.lblKargoTipi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSatis
            // 
            this.pnlSatis.Location = new System.Drawing.Point(3, 135);
            this.pnlSatis.Name = "pnlSatis";
            this.pnlSatis.Size = new System.Drawing.Size(227, 210);
            this.pnlSatis.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtName);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtSurname);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.txtAdres);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(269, 15);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(247, 347);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alıcı Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(3, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 29);
            this.txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyadı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSurname.Location = new System.Drawing.Point(3, 104);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(244, 29);
            this.txtSurname.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adresi:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdres.Location = new System.Drawing.Point(3, 172);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(244, 88);
            this.txtAdres.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(528, 108);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 37);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Sepetten Çıkar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // frmSepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 379);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Name = "frmSepet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SEPET";
            this.Load += new System.EventHandler(this.frmSepet_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNext;
        private Button btnPrev;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label lblKargoAd;
        private Label lblKargoTipi;
        private Panel pnlSatis;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button btnRemove;
        public TextBox txtName;
        public TextBox txtSurname;
        public TextBox txtAdres;
    }
}