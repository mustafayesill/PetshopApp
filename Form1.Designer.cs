
namespace PetshopApp
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_balik = new System.Windows.Forms.RadioButton();
            this.rd_kus = new System.Windows.Forms.RadioButton();
            this.rd_kopek = new System.Windows.Forms.RadioButton();
            this.rd_kedi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_hayvanYas = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_mama = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HayvanAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TelNo = new System.Windows.Forms.TextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_disi = new System.Windows.Forms.RadioButton();
            this.rd_erkek = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "ARA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 279);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(858, 150);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Orange;
            this.groupBox3.Controls.Add(this.rd_balik);
            this.groupBox3.Controls.Add(this.rd_kus);
            this.groupBox3.Controls.Add(this.rd_kopek);
            this.groupBox3.Controls.Add(this.rd_kedi);
            this.groupBox3.Location = new System.Drawing.Point(300, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 107);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hayvan Türü";
            // 
            // rd_balik
            // 
            this.rd_balik.AutoSize = true;
            this.rd_balik.Location = new System.Drawing.Point(3, 75);
            this.rd_balik.Name = "rd_balik";
            this.rd_balik.Size = new System.Drawing.Size(48, 17);
            this.rd_balik.TabIndex = 3;
            this.rd_balik.TabStop = true;
            this.rd_balik.Text = "Balık";
            this.rd_balik.UseVisualStyleBackColor = true;
            // 
            // rd_kus
            // 
            this.rd_kus.AutoSize = true;
            this.rd_kus.Location = new System.Drawing.Point(3, 55);
            this.rd_kus.Name = "rd_kus";
            this.rd_kus.Size = new System.Drawing.Size(43, 17);
            this.rd_kus.TabIndex = 2;
            this.rd_kus.TabStop = true;
            this.rd_kus.Text = "Kuş";
            this.rd_kus.UseVisualStyleBackColor = true;
            // 
            // rd_kopek
            // 
            this.rd_kopek.AutoSize = true;
            this.rd_kopek.Location = new System.Drawing.Point(3, 36);
            this.rd_kopek.Name = "rd_kopek";
            this.rd_kopek.Size = new System.Drawing.Size(56, 17);
            this.rd_kopek.TabIndex = 1;
            this.rd_kopek.TabStop = true;
            this.rd_kopek.Text = "Köpek";
            this.rd_kopek.UseVisualStyleBackColor = true;
            // 
            // rd_kedi
            // 
            this.rd_kedi.AutoSize = true;
            this.rd_kedi.Location = new System.Drawing.Point(3, 16);
            this.rd_kedi.Name = "rd_kedi";
            this.rd_kedi.Size = new System.Drawing.Size(46, 17);
            this.rd_kedi.TabIndex = 0;
            this.rd_kedi.TabStop = true;
            this.rd_kedi.Text = "Kedi";
            this.rd_kedi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orange;
            this.groupBox2.Controls.Add(this.cmb_hayvanYas);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_mama);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_HayvanAd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_TelNo);
            this.groupBox2.Controls.Add(this.txt_AdSoyad);
            this.groupBox2.Location = new System.Drawing.Point(13, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 244);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgiler";
            // 
            // cmb_hayvanYas
            // 
            this.cmb_hayvanYas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hayvanYas.FormattingEnabled = true;
            this.cmb_hayvanYas.Items.AddRange(new object[] {
            "Kitten",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmb_hayvanYas.Location = new System.Drawing.Point(98, 132);
            this.cmb_hayvanYas.Name = "cmb_hayvanYas";
            this.cmb_hayvanYas.Size = new System.Drawing.Size(121, 21);
            this.cmb_hayvanYas.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hayvan Yaşı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon no :";
            // 
            // cmb_mama
            // 
            this.cmb_mama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mama.FormattingEnabled = true;
            this.cmb_mama.Items.AddRange(new object[] {
            "Seçiniz...",
            "Proplan",
            "Royal Canin",
            "Royal Canin Sterilized",
            "Mystic Kitten",
            "Mystic Adult",
            "Mystic Sterilized"});
            this.cmb_mama.Location = new System.Drawing.Point(98, 161);
            this.cmb_mama.Name = "cmb_mama";
            this.cmb_mama.Size = new System.Drawing.Size(121, 21);
            this.cmb_mama.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hayvan ismi :";
            // 
            // txt_HayvanAd
            // 
            this.txt_HayvanAd.Location = new System.Drawing.Point(98, 100);
            this.txt_HayvanAd.Name = "txt_HayvanAd";
            this.txt_HayvanAd.Size = new System.Drawing.Size(100, 20);
            this.txt_HayvanAd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mama :";
            // 
            // txt_TelNo
            // 
            this.txt_TelNo.Location = new System.Drawing.Point(98, 67);
            this.txt_TelNo.Name = "txt_TelNo";
            this.txt_TelNo.Size = new System.Drawing.Size(100, 20);
            this.txt_TelNo.TabIndex = 5;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(98, 36);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_AdSoyad.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.rd_disi);
            this.groupBox1.Controls.Add(this.rd_erkek);
            this.groupBox1.Location = new System.Drawing.Point(416, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 74);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // rd_disi
            // 
            this.rd_disi.AutoSize = true;
            this.rd_disi.Location = new System.Drawing.Point(1, 39);
            this.rd_disi.Name = "rd_disi";
            this.rd_disi.Size = new System.Drawing.Size(42, 17);
            this.rd_disi.TabIndex = 3;
            this.rd_disi.TabStop = true;
            this.rd_disi.Text = "Dişi";
            this.rd_disi.UseVisualStyleBackColor = true;
            // 
            // rd_erkek
            // 
            this.rd_erkek.AutoSize = true;
            this.rd_erkek.Location = new System.Drawing.Point(1, 19);
            this.rd_erkek.Name = "rd_erkek";
            this.rd_erkek.Size = new System.Drawing.Size(53, 17);
            this.rd_erkek.TabIndex = 2;
            this.rd_erkek.TabStop = true;
            this.rd_erkek.Text = "Erkek";
            this.rd_erkek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_balik;
        private System.Windows.Forms.RadioButton rd_kus;
        private System.Windows.Forms.RadioButton rd_kopek;
        private System.Windows.Forms.RadioButton rd_kedi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_hayvanYas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_mama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HayvanAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TelNo;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_disi;
        private System.Windows.Forms.RadioButton rd_erkek;
    }
}

