namespace TurOtomasyonu.UI
{
    partial class MainForm
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
            this.lstTours = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.cmbSubCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpTourDate = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuatity = new System.Windows.Forms.NumericUpDown();
            this.grpbPaymentMethod = new System.Windows.Forms.GroupBox();
            this.rdbCredit = new System.Windows.Forms.RadioButton();
            this.rdbCash = new System.Windows.Forms.RadioButton();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblDetail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bttnLogInOut = new System.Windows.Forms.Button();
            this.grpCategory.SuspendLayout();
            this.grpTourDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuatity)).BeginInit();
            this.grpbPaymentMethod.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTours
            // 
            this.lstTours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstTours.FullRowSelect = true;
            this.lstTours.GridLines = true;
            this.lstTours.Location = new System.Drawing.Point(4, 213);
            this.lstTours.Name = "lstTours";
            this.lstTours.Size = new System.Drawing.Size(603, 196);
            this.lstTours.TabIndex = 0;
            this.lstTours.UseCompatibleStateImageBehavior = false;
            this.lstTours.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tur Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kişi Sayısı";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(86, 29);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 1;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(361, 29);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtEndDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç T.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş T.";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(106, 24);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(138, 21);
            this.cmbCategories.TabIndex = 3;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori Seçimi :";
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.cmbSubCategories);
            this.grpCategory.Controls.Add(this.cmbCategories);
            this.grpCategory.Controls.Add(this.label4);
            this.grpCategory.Controls.Add(this.label3);
            this.grpCategory.Location = new System.Drawing.Point(12, 83);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(595, 58);
            this.grpCategory.TabIndex = 4;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Turlar";
            this.grpCategory.Enter += new System.EventHandler(this.grpCategory_Enter);
            // 
            // cmbSubCategories
            // 
            this.cmbSubCategories.FormattingEnabled = true;
            this.cmbSubCategories.Location = new System.Drawing.Point(402, 19);
            this.cmbSubCategories.Name = "cmbSubCategories";
            this.cmbSubCategories.Size = new System.Drawing.Size(138, 21);
            this.cmbSubCategories.TabIndex = 3;
            this.cmbSubCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tur Çeşitleri :";
            // 
            // grpTourDate
            // 
            this.grpTourDate.Controls.Add(this.dtEndDate);
            this.grpTourDate.Controls.Add(this.dtStartDate);
            this.grpTourDate.Controls.Add(this.label2);
            this.grpTourDate.Controls.Add(this.label1);
            this.grpTourDate.Location = new System.Drawing.Point(12, 147);
            this.grpTourDate.Name = "grpTourDate";
            this.grpTourDate.Size = new System.Drawing.Size(595, 60);
            this.grpTourDate.TabIndex = 5;
            this.grpTourDate.TabStop = false;
            this.grpTourDate.Text = "Size uygun bir tarih seçin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.nudQuatity);
            this.groupBox1.Controls.Add(this.grpbPaymentMethod);
            this.groupBox1.Controls.Add(this.btnBuy);
            this.groupBox1.Controls.Add(this.lblDetail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(4, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(191, 114);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(39, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Miktar:";
            // 
            // nudQuatity
            // 
            this.nudQuatity.Location = new System.Drawing.Point(236, 112);
            this.nudQuatity.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudQuatity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuatity.Name = "nudQuatity";
            this.nudQuatity.Size = new System.Drawing.Size(41, 20);
            this.nudQuatity.TabIndex = 1;
            this.nudQuatity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpbPaymentMethod
            // 
            this.grpbPaymentMethod.Controls.Add(this.rdbCredit);
            this.grpbPaymentMethod.Controls.Add(this.rdbCash);
            this.grpbPaymentMethod.Location = new System.Drawing.Point(300, 103);
            this.grpbPaymentMethod.Name = "grpbPaymentMethod";
            this.grpbPaymentMethod.Size = new System.Drawing.Size(151, 34);
            this.grpbPaymentMethod.TabIndex = 2;
            this.grpbPaymentMethod.TabStop = false;
            this.grpbPaymentMethod.Text = "Ödeme Şekli";
            // 
            // rdbCredit
            // 
            this.rdbCredit.AutoSize = true;
            this.rdbCredit.Location = new System.Drawing.Point(62, 14);
            this.rdbCredit.Name = "rdbCredit";
            this.rdbCredit.Size = new System.Drawing.Size(73, 17);
            this.rdbCredit.TabIndex = 0;
            this.rdbCredit.TabStop = true;
            this.rdbCredit.Text = "Kredi Kartı";
            this.rdbCredit.UseVisualStyleBackColor = true;
            // 
            // rdbCash
            // 
            this.rdbCash.AutoSize = true;
            this.rdbCash.Location = new System.Drawing.Point(6, 14);
            this.rdbCash.Name = "rdbCash";
            this.rdbCash.Size = new System.Drawing.Size(50, 17);
            this.rdbCash.TabIndex = 0;
            this.rdbCash.TabStop = true;
            this.rdbCash.Text = "Nakit";
            this.rdbCash.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuy.Location = new System.Drawing.Point(462, 103);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(135, 35);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Satın Al";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblDetail
            // 
            this.lblDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDetail.Location = new System.Drawing.Point(72, 16);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(525, 84);
            this.lblDetail.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Detay :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttnLogInOut);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 58);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı İşlemleri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(17, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Kullanıcı Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Parola:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 1;
            // 
            // bttnLogInOut
            // 
            this.bttnLogInOut.Location = new System.Drawing.Point(486, 16);
            this.bttnLogInOut.Name = "bttnLogInOut";
            this.bttnLogInOut.Size = new System.Drawing.Size(75, 23);
            this.bttnLogInOut.TabIndex = 2;
            this.bttnLogInOut.Text = "Giriş Yap";
            this.bttnLogInOut.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTourDate);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.lstTours);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.grpTourDate.ResumeLayout(false);
            this.grpTourDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuatity)).EndInit();
            this.grpbPaymentMethod.ResumeLayout(false);
            this.grpbPaymentMethod.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstTours;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.GroupBox grpTourDate;
        private System.Windows.Forms.ComboBox cmbSubCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.GroupBox grpbPaymentMethod;
        private System.Windows.Forms.RadioButton rdbCash;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuatity;
        private System.Windows.Forms.RadioButton rdbCredit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button bttnLogInOut;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}