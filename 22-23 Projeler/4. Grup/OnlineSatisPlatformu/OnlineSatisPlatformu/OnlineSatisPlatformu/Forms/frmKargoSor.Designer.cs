namespace OnlineSatisPlatformu.Forms
{
    partial class frmKargoSor
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKtip = new System.Windows.Forms.ComboBox();
            this.cmbKad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "KARGO TİPİ:";
            // 
            // cmbKtip
            // 
            this.cmbKtip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKtip.FormattingEnabled = true;
            this.cmbKtip.Items.AddRange(new object[] {
            "ÇOK ACİL",
            "ACİL",
            "NORMAL"});
            this.cmbKtip.Location = new System.Drawing.Point(168, 33);
            this.cmbKtip.Name = "cmbKtip";
            this.cmbKtip.Size = new System.Drawing.Size(192, 29);
            this.cmbKtip.TabIndex = 1;
            this.cmbKtip.Text = "NORMAL";
            // 
            // cmbKad
            // 
            this.cmbKad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKad.FormattingEnabled = true;
            this.cmbKad.Items.AddRange(new object[] {
            "YURTİÇİ",
            "MNG",
            "PTT"});
            this.cmbKad.Location = new System.Drawing.Point(168, 68);
            this.cmbKad.Name = "cmbKad";
            this.cmbKad.Size = new System.Drawing.Size(192, 29);
            this.cmbKad.TabIndex = 3;
            this.cmbKad.Text = "YURTİÇİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "KARGO FİRMASI:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(394, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 42);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "TAMAM";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(394, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "İPTAL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmKargoSor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 121);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbKad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKtip);
            this.Controls.Add(this.label1);
            this.Name = "frmKargoSor";
            this.Text = "frmKargoSor";
            this.Load += new System.EventHandler(this.frmKargoSor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbKtip;
        private ComboBox cmbKad;
        private Label label2;
        private Button btnOK;
        private Button btnCancel;
    }
}