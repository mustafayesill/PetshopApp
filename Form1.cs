using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetshopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Müşteri Adı", 100);
            listView1.Columns.Add("Tel No", 100);
            listView1.Columns.Add("Cinsiyet", 100);
            listView1.Columns.Add("Hayvan Türü", 100);
            listView1.Columns.Add("Hayvan Adı", 100);
            listView1.Columns.Add("Hayvan Yaşı", 100);
            listView1.Columns.Add("Mama Adı", 125);
            listView1.Columns.Add("Tarih", 125);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AdSoyad = "", hayvanAd = "", Mama = "", hayvanYas = "", hayvanTuru = "", hayvanCinsiyet = "", telNo = "", tarih = "";
            hayvanYas = cmb_hayvanYas.Text; tarih = dateTimePicker1.Text;
            Mama = cmb_mama.Text;
            AdSoyad = txt_AdSoyad.Text;
            hayvanAd = txt_HayvanAd.Text;
            hayvanTuru = "";
            hayvanCinsiyet = "";
            telNo = txt_TelNo.Text;

            if (rd_erkek.Checked == true)
            {
                hayvanCinsiyet = rd_erkek.Text;
            }
            else if (rd_disi.Checked == true)
            {
                hayvanCinsiyet = rd_disi.Text;
            }
            if (rd_kedi.Checked == true)
            {
                hayvanTuru = rd_kedi.Text;
            }
            else if (rd_kopek.Checked == true)
            {
                hayvanTuru = rd_kopek.Text;
            }
            else if (rd_kus.Checked == true)
            {
                hayvanTuru = rd_kus.Text;
            }
            else if (rd_balik.Checked == true)
            {
                hayvanTuru = rd_balik.Text;
            }
            string[] bilgiler = { AdSoyad, telNo, hayvanCinsiyet, hayvanTuru, hayvanAd, hayvanYas, Mama, tarih };
            ListViewItem lst = new ListViewItem(bilgiler);
            listView1.Items.Add(lst);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilensayisi = listView1.CheckedItems.Count;
            foreach (ListViewItem secilikayitbilgisi in listView1.CheckedItems)
            {
                secilikayitbilgisi.Remove();
                MessageBox.Show("Kayıt Silindi !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool aranankayitkontrolu = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text == txt_TelNo.Text)
                {
                    aranankayitkontrolu = true;
                    txt_AdSoyad.Text = listView1.Items[i].SubItems[0].Text;
                    txt_HayvanAd.Text = listView1.Items[i].SubItems[4].Text;
                    cmb_hayvanYas.Text = listView1.Items[i].SubItems[5].Text;
                    cmb_mama.Text = listView1.Items[i].SubItems[6].Text;
                    if (listView1.Items[i].SubItems[2].Text == rd_erkek.Text)
                    {
                        rd_erkek.Checked = true;
                    }
                    else if (listView1.Items[i].SubItems[2].Text == rd_disi.Text)
                    {
                        rd_disi.Checked = true;

                    }
                    if (listView1.Items[i].SubItems[3].Text == rd_kedi.Text)
                    {
                        rd_kedi.Checked = true;
                    }
                    else if (listView1.Items[i].SubItems[3].Text == rd_kopek.Text)
                    {
                        rd_kopek.Checked = true;
                    }
                    else if (listView1.Items[i].SubItems[3].Text == rd_kus.Text)
                    {
                        rd_kus.Checked = true;
                    }
                    else if (listView1.Items[i].SubItems[3].Text == rd_balik.Text)
                    {
                        rd_balik.Checked = true;
                    }
                    dateTimePicker1.Text = listView1.Items[i].SubItems[7].Text;
                    //groupBox1.Enabled = false; groupBox2.Enabled = false; groupBox3.Enabled = false;
                }
            }
            if (aranankayitkontrolu == false)
                MessageBox.Show(txt_TelNo.Text + " Telefon numarası ile kayıt mevcut değildir !");
        }
    }
}
