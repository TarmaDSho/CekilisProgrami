using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ÇekilişProgramıv5._5;
using System.IO;
using System.Collections;
using Microsoft.VisualBasic;

namespace ÇekilişProgramıv6._5
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.Text == "UEFA Şampiyonlar Ligi Kuralar")
            {
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                int count4 = 0;
                listView1.Items.Clear();
                listView2.Items.Clear();
                listView3.Items.Clear();
                listView4.Items.Clear();

                StreamReader dosyaokuyucu = new StreamReader("şampiyonlar ligi torbalar.txt", Encoding.Default);
                ArrayList ilktorba = new ArrayList();
                ArrayList ikincitorba = new ArrayList();
                ArrayList ucuncutorba = new ArrayList();
                ArrayList dorduncutorba = new ArrayList();
                ArrayList torbalar = new ArrayList();
                int sayi = 0;
                int durum = 0;
                string satir = dosyaokuyucu.ReadLine();
                while (satir != null)
                {
                    torbalar.Add(satir);
                    sayi++;
                    satir = dosyaokuyucu.ReadLine();
                }

                if (sayi == 32)
                {
                    for (int i = 0; i < torbalar.Count; i++)
                    {
                        if (i >= 0 && i <= 7)
                        {
                            ilktorba.Add(torbalar[i]);
                        }
                        else if (i >= 8 && i <= 15)
                        {
                            ikincitorba.Add(torbalar[i]);
                        }
                        else if (i >= 16 && i <= 23)
                        {
                            ucuncutorba.Add(torbalar[i]);
                        }
                        else if (i >= 24 && i <= 31)
                        {
                            dorduncutorba.Add(torbalar[i]);
                        }
                    }

                    foreach (string item in ilktorba)
                    {
                        listView1.Items.Add(item);
                    }

                    foreach (string item2 in ikincitorba)
                    {
                        listView2.Items.Add(item2);
                    }

                    foreach (string item3 in ucuncutorba)
                    {
                        listView3.Items.Add(item3);
                    }

                    foreach (string item4 in dorduncutorba)
                    {
                        listView4.Items.Add(item4);
                    }
                }
                else if (sayi == 48)
                {
                    for (int i = 0; i < torbalar.Count; i++)
                    {
                        if (i >= 0 && i <= 11)
                        {
                            ilktorba.Add(torbalar[i]);
                        }
                        else if (i >= 12 && i <= 23)
                        {
                            ikincitorba.Add(torbalar[i]);
                        }
                        else if (i >= 24 && i <= 35)
                        {
                            ucuncutorba.Add(torbalar[i]);
                        }
                        else if (i >= 36 && i <= 47)
                        {
                            dorduncutorba.Add(torbalar[i]);
                        }
                    }

                    foreach (string item in ilktorba)
                    {
                        listView1.Items.Add(item);
                    }

                    foreach (string item2 in ikincitorba)
                    {
                        listView2.Items.Add(item2);
                    }

                    foreach (string item3 in ucuncutorba)
                    {
                        listView3.Items.Add(item3);
                    }

                    foreach (string item4 in dorduncutorba)
                    {
                        listView4.Items.Add(item4);
                    }
                }

                if (ilktorba.Count == 8 && ilktorba.Count == 8 && ilktorba.Count == 8 && ilktorba.Count == 8)
                {
                    comboBoxEdit1.SelectedIndex = 0;
                }
                else if (ilktorba.Count == 12 && ilktorba.Count == 12 && ilktorba.Count == 12 && ilktorba.Count == 12)
                {
                    comboBoxEdit1.SelectedIndex = 1;
                }
                else
                {
                    listView1.Items.Clear();
                    listView2.Items.Clear();
                    listView3.Items.Clear();
                    listView4.Items.Clear();
                    MessageBox.Show("UEFA Şampiyonlar Ligi için her torba 8 takım, UEFA Avrupa ligi için her torba 12 takım olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.Text == "UEFA Avrupa Ligi Kuralar")
            {
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                int count4 = 0;
                listView1.Items.Clear();
                listView2.Items.Clear();
                listView3.Items.Clear();
                listView4.Items.Clear();

                StreamReader dosyaokuyucu = new StreamReader("avrupa ligi torbalar.txt", Encoding.Default);
                ArrayList ilktorba = new ArrayList();
                ArrayList ikincitorba = new ArrayList();
                ArrayList ucuncutorba = new ArrayList();
                ArrayList dorduncutorba = new ArrayList();
                ArrayList torbalar = new ArrayList();
                int sayi = 0;
                int durum = 0;
                string satir = dosyaokuyucu.ReadLine();
                while (satir != null)
                {
                    torbalar.Add(satir);
                    sayi++;
                    satir = dosyaokuyucu.ReadLine();
                }

                if (sayi == 32)
                {
                    for (int i = 0; i < torbalar.Count; i++)
                    {
                        if (i >= 0 && i <= 7)
                        {
                            ilktorba.Add(torbalar[i]);
                        }
                        else if (i >= 8 && i <= 15)
                        {
                            ikincitorba.Add(torbalar[i]);
                        }
                        else if (i >= 16 && i <= 23)
                        {
                            ucuncutorba.Add(torbalar[i]);
                        }
                        else if (i >= 24 && i <= 31)
                        {
                            dorduncutorba.Add(torbalar[i]);
                        }
                    }

                    foreach (string item in ilktorba)
                    {
                        listView1.Items.Add(item);
                    }

                    foreach (string item2 in ikincitorba)
                    {
                        listView2.Items.Add(item2);
                    }

                    foreach (string item3 in ucuncutorba)
                    {
                        listView3.Items.Add(item3);
                    }

                    foreach (string item4 in dorduncutorba)
                    {
                        listView4.Items.Add(item4);
                    }
                }
                else if (sayi == 48)
                {
                    for (int i = 0; i < torbalar.Count; i++)
                    {
                        if (i >= 0 && i <= 11)
                        {
                            ilktorba.Add(torbalar[i]);
                        }
                        else if (i >= 12 && i <= 23)
                        {
                            ikincitorba.Add(torbalar[i]);
                        }
                        else if (i >= 24 && i <= 35)
                        {
                            ucuncutorba.Add(torbalar[i]);
                        }
                        else if (i >= 36 && i <= 47)
                        {
                            dorduncutorba.Add(torbalar[i]);
                        }
                    }

                    foreach (string item in ilktorba)
                    {
                        listView1.Items.Add(item);
                    }

                    foreach (string item2 in ikincitorba)
                    {
                        listView2.Items.Add(item2);
                    }

                    foreach (string item3 in ucuncutorba)
                    {
                        listView3.Items.Add(item3);
                    }

                    foreach (string item4 in dorduncutorba)
                    {
                        listView4.Items.Add(item4);
                    }
                }

                if (ilktorba.Count == 8 && ilktorba.Count == 8 && ilktorba.Count == 8 && ilktorba.Count == 8)
                {
                    comboBoxEdit1.SelectedIndex = 0;
                }
                else if (ilktorba.Count == 12 && ilktorba.Count == 12 && ilktorba.Count == 12 && ilktorba.Count == 12)
                {
                    comboBoxEdit1.SelectedIndex = 1;
                }
                else
                {
                    listView1.Items.Clear();
                    listView2.Items.Clear();
                    listView3.Items.Clear();
                    listView4.Items.Clear();
                    MessageBox.Show("UEFA Şampiyonlar Ligi için her torba 8 takım, UEFA Avrupa ligi için her torba 12 takım olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                torbalar.Clear();
                ilktorba.Clear();
                ikincitorba.Clear();
                ucuncutorba.Clear();
                dorduncutorba.Clear();
            }
        }

        private void çekilişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                contextMenuStrip1.Items[1].Enabled = true;
                contextMenuStrip1.Items[2].Enabled = true;
            }
            else if (listView1.SelectedItems.Count > 0)
            {
                contextMenuStrip1.Items[1].Enabled = true;
                contextMenuStrip1.Items[2].Enabled = false;
            }
            else
            {
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Takım");
            listView2.Columns.Add("Takım");
            listView3.Columns.Add("Takım");
            listView4.Columns.Add("Takım");
            listView5.Columns.Add("Sayı");
            listView5.Columns.Add("Takım");
            listView6.Columns.Add("Sayı");
            listView6.Columns.Add("Takım");
            listView7.Columns.Add("Sayı");
            listView7.Columns.Add("Takım");
            listView8.Columns.Add("Sayı");
            listView8.Columns.Add("Takım");
            listView9.Columns.Add("Sayı");
            listView9.Columns.Add("Takım");
            listView10.Columns.Add("Sayı");
            listView10.Columns.Add("Takım");
            listView11.Columns.Add("Sayı");
            listView11.Columns.Add("Takım");
            listView12.Columns.Add("Sayı");
            listView12.Columns.Add("Takım");
            listView13.Columns.Add("Sayı");
            listView13.Columns.Add("Takım");
            listView14.Columns.Add("Sayı");
            listView14.Columns.Add("Takım");
            listView15.Columns.Add("Sayı");
            listView15.Columns.Add("Takım");
            listView16.Columns.Add("Sayı");
            listView16.Columns.Add("Takım");
        }

        private void kaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "*.txt";
            saveFileDialog1.Filter = "Metin Dosyası (*.txt)|*.txt";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "Kayıt Edilecek Yeri Seçiniz:";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter dosyayazma = new StreamWriter(saveFileDialog1.FileName);
                ArrayList yazilacak = new ArrayList();
                foreach (ListViewItem item1 in listView1.Items)
                {
                    yazilacak.Add(item1.Text);
                }

                foreach (ListViewItem item2 in listView2.Items)
                {
                    yazilacak.Add(item2.Text);
                }

                foreach (ListViewItem item3 in listView3.Items)
                {
                    yazilacak.Add(item3.Text);
                }

                foreach (ListViewItem item4 in listView4.Items)
                {
                    yazilacak.Add(item4.Text);
                }

                foreach (string veri in yazilacak)
                {
                    dosyayazma.WriteLine(veri);
                }
                dosyayazma.Close();
            }
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Metin Dosyası (*.txt)|*.txt";
            openFileDialog1.FileName = "*.txt";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Title = "Okunacak veriyi seçiniz:";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    int count1 = 0;
                    int count2 = 0;
                    int count3 = 0;
                    int count4 = 0;
                    listView1.Items.Clear();
                    listView2.Items.Clear();
                    listView3.Items.Clear();
                    listView4.Items.Clear();

                    StreamReader dosyaokuyucu = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                    ArrayList ilktorba = new ArrayList();
                    ArrayList ikincitorba = new ArrayList();
                    ArrayList ucuncutorba = new ArrayList();
                    ArrayList dorduncutorba = new ArrayList();
                    ArrayList torbalar = new ArrayList();
                    int sayi = 0;
                    int durum = 0;
                    string satir = dosyaokuyucu.ReadLine();
                    while (satir != null)
                    {
                        torbalar.Add(satir);
                        sayi++;
                        satir = dosyaokuyucu.ReadLine();
                    }

                    if (sayi == 32)
                    {
                        for (int i = 0; i < torbalar.Count; i++)
                        {
                            if (i >= 0 && i <= 7)
                            {
                                ilktorba.Add(torbalar[i]);
                            }
                            else if (i >= 8 && i <= 15)
                            {
                                ikincitorba.Add(torbalar[i]);
                            }
                            else if (i >= 16 && i <= 23)
                            {
                                ucuncutorba.Add(torbalar[i]);
                            }
                            else if (i >= 24 && i <= 31)
                            {
                                dorduncutorba.Add(torbalar[i]);
                            }
                        }

                        foreach (string item in ilktorba)
                        {
                            listView1.Items.Add(item);
                        }

                        foreach (string item2 in ikincitorba)
                        {
                            listView2.Items.Add(item2);
                        }

                        foreach (string item3 in ucuncutorba)
                        {
                            listView3.Items.Add(item3);
                        }

                        foreach (string item4 in dorduncutorba)
                        {
                            listView4.Items.Add(item4);
                        }
                    }
                    else if (sayi == 48)
                    {
                        for (int i = 0; i < torbalar.Count; i++)
                        {
                            if (i >= 0 && i <= 11)
                            {
                                ilktorba.Add(torbalar[i]);
                            }
                            else if (i >= 12 && i <= 23)
                            {
                                ikincitorba.Add(torbalar[i]);
                            }
                            else if (i >= 24 && i <= 35)
                            {
                                ucuncutorba.Add(torbalar[i]);
                            }
                            else if (i >= 36 && i <= 47)
                            {
                                dorduncutorba.Add(torbalar[i]);
                            }
                        }

                        foreach (string item in ilktorba)
                        {
                            listView1.Items.Add(item);
                        }

                        foreach (string item2 in ikincitorba)
                        {
                            listView2.Items.Add(item2);
                        }

                        foreach (string item3 in ucuncutorba)
                        {
                            listView3.Items.Add(item3);
                        }

                        foreach (string item4 in dorduncutorba)
                        {
                            listView4.Items.Add(item4);
                        }
                    }

                    if (ilktorba.Count == 8 && ilktorba.Count == 8 && ilktorba.Count == 8 && ilktorba.Count == 8)
                    {
                        comboBoxEdit1.SelectedIndex = 0;
                    }
                    else if (ilktorba.Count == 12 && ilktorba.Count == 12 && ilktorba.Count == 12 && ilktorba.Count == 12)
                    {
                        comboBoxEdit1.SelectedIndex = 1;
                    }
                    else
                    {
                        listView1.Items.Clear();
                        listView2.Items.Clear();
                        listView3.Items.Clear();
                        listView4.Items.Clear();
                        MessageBox.Show("UEFA Şampiyonlar Ligi için her torba 8 takım, UEFA Avrupa ligi için her torba 12 takım olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView5.Items.Clear();
            listView6.Items.Clear();
            listView7.Items.Clear();
            listView8.Items.Clear();
            listView9.Items.Clear();
            listView10.Items.Clear();
            listView11.Items.Clear();
            listView12.Items.Clear();
            listView13.Items.Clear();
            listView14.Items.Clear();
            listView15.Items.Clear();
            listView16.Items.Clear();
            ArrayList torba1 = new ArrayList();
            ArrayList torba2 = new ArrayList();
            ArrayList torba3 = new ArrayList();
            ArrayList torba4 = new ArrayList();
            if (comboBoxEdit1.SelectedIndex == 0 && listView1.Items.Count == 8 && listView2.Items.Count == 8 && listView3.Items.Count == 8 && listView4.Items.Count == 8)
            {
                ArrayList gruplar = new ArrayList();
                gruplar.Add("A");
                gruplar.Add("B");
                gruplar.Add("C");
                gruplar.Add("D");
                gruplar.Add("E");
                gruplar.Add("F");
                gruplar.Add("G");
                gruplar.Add("H");
                foreach (ListViewItem item1 in listView1.Items)
                {
                    torba1.Add(item1.Text);
                }

                foreach (ListViewItem item2 in listView2.Items)
                {
                    torba2.Add(item2.Text);
                }

                foreach (ListViewItem item3 in listView3.Items)
                {
                    torba3.Add(item3.Text);
                }

                foreach (ListViewItem item4 in listView4.Items)
                {
                    torba4.Add(item4.Text);
                }

                Random rastgele = new Random();
                int sayi = 0;
                for (int i = 0; i <= torba1.Count + 6; i++)
                {
                    int uretilen = rastgele.Next(0, torba1.Count);
                    int grupuretilen = rastgele.Next(0, gruplar.Count);
                    string takim = torba1[uretilen].ToString();
                    string grup = gruplar[grupuretilen].ToString();
                    torba1.RemoveAt(uretilen);
                    gruplar.RemoveAt(grupuretilen);
                    if (grup == "A")
                    {
                        int count = listView8.Items.Count;
                        listView8.Items.Add((listView8.Items.Count + 1).ToString());
                        listView8.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "B")
                    {
                        int count = listView7.Items.Count;
                        listView7.Items.Add((listView7.Items.Count + 1).ToString());
                        listView7.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "C")
                    {
                        int count = listView6.Items.Count;
                        listView6.Items.Add((listView6.Items.Count + 1).ToString());
                        listView6.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "D")
                    {
                        int count = listView5.Items.Count;
                        listView5.Items.Add((listView5.Items.Count + 1).ToString());
                        listView5.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "E")
                    {
                        int count = listView12.Items.Count;
                        listView12.Items.Add((listView12.Items.Count + 1).ToString());
                        listView12.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "F")
                    {
                        int count = listView11.Items.Count;
                        listView11.Items.Add((listView11.Items.Count + 1).ToString());
                        listView11.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "G")
                    {
                        int count = listView10.Items.Count;
                        listView10.Items.Add((listView10.Items.Count + 1).ToString());
                        listView10.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "H")
                    {
                        int count = listView9.Items.Count;
                        listView9.Items.Add((listView9.Items.Count + 1).ToString());
                        listView9.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "I")
                    {
                        int count = listView13.Items.Count;
                        listView13.Items.Add((listView13.Items.Count + 1).ToString());
                        listView13.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "J")
                    {
                        int count = listView14.Items.Count;
                        listView14.Items.Add((listView14.Items.Count + 1).ToString());
                        listView14.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "K")
                    {
                        int count = listView15.Items.Count;
                        listView15.Items.Add((listView15.Items.Count + 1).ToString());
                        listView15.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "L")
                    {
                        int count = listView16.Items.Count;
                        listView16.Items.Add((listView16.Items.Count + 1).ToString());
                        listView16.Items[count].SubItems.Add(takim);
                    }
                }
                sayi = 0;
                gruplar.Add("A");
                gruplar.Add("B");
                gruplar.Add("C");
                gruplar.Add("D");
                gruplar.Add("E");
                gruplar.Add("F");
                gruplar.Add("G");
                gruplar.Add("H");
                for (int c = 0; c <= torba2.Count + 6; c++)
                {
                    sayi++;
                    int uretilen = rastgele.Next(0, torba2.Count);
                    int grupuretilen = rastgele.Next(0, gruplar.Count);
                    string takim = torba2[uretilen].ToString();
                    string grup = gruplar[grupuretilen].ToString();
                    torba2.RemoveAt(uretilen);
                    gruplar.RemoveAt(grupuretilen);
                    if (grup == "A")
                    {
                        int count = listView8.Items.Count;
                        listView8.Items.Add((listView8.Items.Count + 1).ToString());
                        listView8.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "B")
                    {
                        int count = listView7.Items.Count;
                        listView7.Items.Add((listView7.Items.Count + 1).ToString());
                        listView7.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "C")
                    {
                        int count = listView6.Items.Count;
                        listView6.Items.Add((listView6.Items.Count + 1).ToString());
                        listView6.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "D")
                    {
                        int count = listView5.Items.Count;
                        listView5.Items.Add((listView5.Items.Count + 1).ToString());
                        listView5.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "E")
                    {
                        int count = listView12.Items.Count;
                        listView12.Items.Add((listView12.Items.Count + 1).ToString());
                        listView12.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "F")
                    {
                        int count = listView11.Items.Count;
                        listView11.Items.Add((listView11.Items.Count + 1).ToString());
                        listView11.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "G")
                    {
                        int count = listView10.Items.Count;
                        listView10.Items.Add((listView10.Items.Count + 1).ToString());
                        listView10.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "H")
                    {
                        int count = listView9.Items.Count;
                        listView9.Items.Add((listView9.Items.Count + 1).ToString());
                        listView9.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "I")
                    {
                        int count = listView13.Items.Count;
                        listView13.Items.Add((listView13.Items.Count + 1).ToString());
                        listView13.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "J")
                    {
                        int count = listView14.Items.Count;
                        listView14.Items.Add((listView14.Items.Count + 1).ToString());
                        listView14.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "K")
                    {
                        int count = listView15.Items.Count;
                        listView15.Items.Add((listView15.Items.Count + 1).ToString());
                        listView15.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "L")
                    {
                        int count = listView16.Items.Count;
                        listView16.Items.Add((listView16.Items.Count + 1).ToString());
                        listView16.Items[count].SubItems.Add(takim);
                    }
                }
                sayi = 0;
                gruplar.Add("A");
                gruplar.Add("B");
                gruplar.Add("C");
                gruplar.Add("D");
                gruplar.Add("E");
                gruplar.Add("F");
                gruplar.Add("G");
                gruplar.Add("H");
                for (int x = 0; x <= torba3.Count + 6; x++)
                {
                    sayi++;
                    int uretilen = rastgele.Next(0, torba3.Count);
                    int grupuretilen = rastgele.Next(0, gruplar.Count);
                    string takim = torba3[uretilen].ToString();
                    string grup = gruplar[grupuretilen].ToString();
                    torba3.RemoveAt(uretilen);
                    gruplar.RemoveAt(grupuretilen);
                    if (grup == "A")
                    {
                        int count = listView8.Items.Count;
                        listView8.Items.Add((listView8.Items.Count + 1).ToString());
                        listView8.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "B")
                    {
                        int count = listView7.Items.Count;
                        listView7.Items.Add((listView7.Items.Count + 1).ToString());
                        listView7.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "C")
                    {
                        int count = listView6.Items.Count;
                        listView6.Items.Add((listView6.Items.Count + 1).ToString());
                        listView6.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "D")
                    {
                        int count = listView5.Items.Count;
                        listView5.Items.Add((listView5.Items.Count + 1).ToString());
                        listView5.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "E")
                    {
                        int count = listView12.Items.Count;
                        listView12.Items.Add((listView12.Items.Count + 1).ToString());
                        listView12.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "F")
                    {
                        int count = listView11.Items.Count;
                        listView11.Items.Add((listView11.Items.Count + 1).ToString());
                        listView11.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "G")
                    {
                        int count = listView10.Items.Count;
                        listView10.Items.Add((listView10.Items.Count + 1).ToString());
                        listView10.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "H")
                    {
                        int count = listView9.Items.Count;
                        listView9.Items.Add((listView9.Items.Count + 1).ToString());
                        listView9.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "I")
                    {
                        int count = listView13.Items.Count;
                        listView13.Items.Add((listView13.Items.Count + 1).ToString());
                        listView13.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "J")
                    {
                        int count = listView14.Items.Count;
                        listView14.Items.Add((listView14.Items.Count + 1).ToString());
                        listView14.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "K")
                    {
                        int count = listView15.Items.Count;
                        listView15.Items.Add((listView15.Items.Count + 1).ToString());
                        listView15.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "L")
                    {
                        int count = listView16.Items.Count;
                        listView16.Items.Add((listView16.Items.Count + 1).ToString());
                        listView16.Items[count].SubItems.Add(takim);
                    }
                }
                sayi = 0;
                gruplar.Add("A");
                gruplar.Add("B");
                gruplar.Add("C");
                gruplar.Add("D");
                gruplar.Add("E");
                gruplar.Add("F");
                gruplar.Add("G");
                gruplar.Add("H");
                for (int m = 0; m <= torba4.Count + 6; m++)
                {
                    sayi++;
                    int uretilen = rastgele.Next(0, torba4.Count);
                    int grupuretilen = rastgele.Next(0, gruplar.Count);
                    string takim = torba4[uretilen].ToString();
                    string grup = gruplar[grupuretilen].ToString();
                    torba4.RemoveAt(uretilen);
                    gruplar.RemoveAt(grupuretilen);
                    if (grup == "A")
                    {
                        int count = listView8.Items.Count;
                        listView8.Items.Add((listView8.Items.Count + 1).ToString());
                        listView8.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "B")
                    {
                        int count = listView7.Items.Count;
                        listView7.Items.Add((listView7.Items.Count + 1).ToString());
                        listView7.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "C")
                    {
                        int count = listView6.Items.Count;
                        listView6.Items.Add((listView6.Items.Count + 1).ToString());
                        listView6.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "D")
                    {
                        int count = listView5.Items.Count;
                        listView5.Items.Add((listView5.Items.Count + 1).ToString());
                        listView5.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "E")
                    {
                        int count = listView12.Items.Count;
                        listView12.Items.Add((listView12.Items.Count + 1).ToString());
                        listView12.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "F")
                    {
                        int count = listView11.Items.Count;
                        listView11.Items.Add((listView11.Items.Count + 1).ToString());
                        listView11.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "G")
                    {
                        int count = listView10.Items.Count;
                        listView10.Items.Add((listView10.Items.Count + 1).ToString());
                        listView10.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "H")
                    {
                        int count = listView9.Items.Count;
                        listView9.Items.Add((listView9.Items.Count + 1).ToString());
                        listView9.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "I")
                    {
                        int count = listView13.Items.Count;
                        listView13.Items.Add((listView13.Items.Count + 1).ToString());
                        listView13.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "J")
                    {
                        int count = listView14.Items.Count;
                        listView14.Items.Add((listView14.Items.Count + 1).ToString());
                        listView14.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "K")
                    {
                        int count = listView15.Items.Count;
                        listView15.Items.Add((listView15.Items.Count + 1).ToString());
                        listView15.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "L")
                    {
                        int count = listView16.Items.Count;
                        listView16.Items.Add((listView16.Items.Count + 1).ToString());
                        listView16.Items[count].SubItems.Add(takim);
                    }
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 1 && listView1.Items.Count == 12 && listView2.Items.Count == 12 && listView3.Items.Count == 12 && listView4.Items.Count == 12)
            {
                ArrayList gruplar = new ArrayList();
                gruplar.Add("A");
                gruplar.Add("B");
                gruplar.Add("C");
                gruplar.Add("D");
                gruplar.Add("E");
                gruplar.Add("F");
                gruplar.Add("G");
                gruplar.Add("H");
                gruplar.Add("I");
                gruplar.Add("J");
                gruplar.Add("K");
                gruplar.Add("L");
                foreach (ListViewItem item1 in listView1.Items)
                {
                    torba1.Add(item1.Text);
                }

                foreach (ListViewItem item2 in listView2.Items)
                {
                    torba2.Add(item2.Text);
                }

                foreach (ListViewItem item3 in listView3.Items)
                {
                    torba3.Add(item3.Text);
                }

                foreach (ListViewItem item4 in listView4.Items)
                {
                    torba4.Add(item4.Text);
                }

                Random rastgele = new Random();
                int sayi = 0;
                for (int i = 0; i <= torba1.Count + 10; i++)
                {
                    int uretilen = rastgele.Next(0, torba1.Count);
                    int grupuretilen = rastgele.Next(0, gruplar.Count);
                    string takim = torba1[uretilen].ToString();
                    string grup = gruplar[grupuretilen].ToString();
                    torba1.RemoveAt(uretilen);
                    gruplar.RemoveAt(grupuretilen);
                    if (grup == "A")
                    {
                        int count = listView8.Items.Count;
                        listView8.Items.Add((listView8.Items.Count + 1).ToString());
                        listView8.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "B")
                    {
                        int count = listView7.Items.Count;
                        listView7.Items.Add((listView7.Items.Count + 1).ToString());
                        listView7.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "C")
                    {
                        int count = listView6.Items.Count;
                        listView6.Items.Add((listView6.Items.Count + 1).ToString());
                        listView6.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "D")
                    {
                        int count = listView5.Items.Count;
                        listView5.Items.Add((listView5.Items.Count + 1).ToString());
                        listView5.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "E")
                    {
                        int count = listView12.Items.Count;
                        listView12.Items.Add((listView12.Items.Count + 1).ToString());
                        listView12.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "F")
                    {
                        int count = listView11.Items.Count;
                        listView11.Items.Add((listView11.Items.Count + 1).ToString());
                        listView11.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "G")
                    {
                        int count = listView10.Items.Count;
                        listView10.Items.Add((listView10.Items.Count + 1).ToString());
                        listView10.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "H")
                    {
                        int count = listView9.Items.Count;
                        listView9.Items.Add((listView9.Items.Count + 1).ToString());
                        listView9.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "I")
                    {
                        int count = listView13.Items.Count;
                        listView13.Items.Add((listView13.Items.Count + 1).ToString());
                        listView13.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "J")
                    {
                        int count = listView14.Items.Count;
                        listView14.Items.Add((listView14.Items.Count + 1).ToString());
                        listView14.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "K")
                    {
                        int count = listView15.Items.Count;
                        listView15.Items.Add((listView15.Items.Count + 1).ToString());
                        listView15.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "L")
                    {
                        int count = listView16.Items.Count;
                        listView16.Items.Add((listView16.Items.Count + 1).ToString());
                        listView16.Items[count].SubItems.Add(takim);
                    }
                }
                sayi = 0;
                gruplar.Add("A");
                gruplar.Add("B");
                gruplar.Add("C");
                gruplar.Add("D");
                gruplar.Add("E");
                gruplar.Add("F");
                gruplar.Add("G");
                gruplar.Add("H");
                gruplar.Add("I");
                gruplar.Add("J");
                gruplar.Add("K");
                gruplar.Add("L");
                for (int c = 0; c <= torba2.Count + 10; c++)
                {
                    sayi++;
                    int uretilen = rastgele.Next(0, torba2.Count);
                    int grupuretilen = rastgele.Next(0, gruplar.Count);
                    string takim = torba2[uretilen].ToString();
                    string grup = gruplar[grupuretilen].ToString();
                    torba2.RemoveAt(uretilen);
                    gruplar.RemoveAt(grupuretilen);
                    if (grup == "A")
                    {
                        int count = listView8.Items.Count;
                        listView8.Items.Add((listView8.Items.Count + 1).ToString());
                        listView8.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "B")
                    {
                        int count = listView7.Items.Count;
                        listView7.Items.Add((listView7.Items.Count + 1).ToString());
                        listView7.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "C")
                    {
                        int count = listView6.Items.Count;
                        listView6.Items.Add((listView6.Items.Count + 1).ToString());
                        listView6.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "D")
                    {
                        int count = listView5.Items.Count;
                        listView5.Items.Add((listView5.Items.Count + 1).ToString());
                        listView5.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "E")
                    {
                        int count = listView12.Items.Count;
                        listView12.Items.Add((listView12.Items.Count + 1).ToString());
                        listView12.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "F")
                    {
                        int count = listView11.Items.Count;
                        listView11.Items.Add((listView11.Items.Count + 1).ToString());
                        listView11.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "G")
                    {
                        int count = listView10.Items.Count;
                        listView10.Items.Add((listView10.Items.Count + 1).ToString());
                        listView10.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "H")
                    {
                        int count = listView9.Items.Count;
                        listView9.Items.Add((listView9.Items.Count + 1).ToString());
                        listView9.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "I")
                    {
                        int count = listView13.Items.Count;
                        listView13.Items.Add((listView13.Items.Count + 1).ToString());
                        listView13.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "J")
                    {
                        int count = listView14.Items.Count;
                        listView14.Items.Add((listView14.Items.Count + 1).ToString());
                        listView14.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "K")
                    {
                        int count = listView15.Items.Count;
                        listView15.Items.Add((listView15.Items.Count + 1).ToString());
                        listView15.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "L")
                    {
                        int count = listView16.Items.Count;
                        listView16.Items.Add((listView16.Items.Count + 1).ToString());
                        listView16.Items[count].SubItems.Add(takim);
                    }
                }
                sayi = 0;
                gruplar.Add("A");
                gruplar.Add("B");
                gruplar.Add("C");
                gruplar.Add("D");
                gruplar.Add("E");
                gruplar.Add("F");
                gruplar.Add("G");
                gruplar.Add("H");
                gruplar.Add("I");
                gruplar.Add("J");
                gruplar.Add("K");
                gruplar.Add("L");
                for (int x = 0; x <= torba3.Count + 10; x++)
                {
                    sayi++;
                    int uretilen = rastgele.Next(0, torba3.Count);
                    int grupuretilen = rastgele.Next(0, gruplar.Count);
                    string takim = torba3[uretilen].ToString();
                    string grup = gruplar[grupuretilen].ToString();
                    torba3.RemoveAt(uretilen);
                    gruplar.RemoveAt(grupuretilen);
                    if (grup == "A")
                    {
                        int count = listView8.Items.Count;
                        listView8.Items.Add((listView8.Items.Count + 1).ToString());
                        listView8.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "B")
                    {
                        int count = listView7.Items.Count;
                        listView7.Items.Add((listView7.Items.Count + 1).ToString());
                        listView7.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "C")
                    {
                        int count = listView6.Items.Count;
                        listView6.Items.Add((listView6.Items.Count + 1).ToString());
                        listView6.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "D")
                    {
                        int count = listView5.Items.Count;
                        listView5.Items.Add((listView5.Items.Count + 1).ToString());
                        listView5.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "E")
                    {
                        int count = listView12.Items.Count;
                        listView12.Items.Add((listView12.Items.Count + 1).ToString());
                        listView12.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "F")
                    {
                        int count = listView11.Items.Count;
                        listView11.Items.Add((listView11.Items.Count + 1).ToString());
                        listView11.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "G")
                    {
                        int count = listView10.Items.Count;
                        listView10.Items.Add((listView10.Items.Count + 1).ToString());
                        listView10.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "H")
                    {
                        int count = listView9.Items.Count;
                        listView9.Items.Add((listView9.Items.Count + 1).ToString());
                        listView9.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "I")
                    {
                        int count = listView13.Items.Count;
                        listView13.Items.Add((listView13.Items.Count + 1).ToString());
                        listView13.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "J")
                    {
                        int count = listView14.Items.Count;
                        listView14.Items.Add((listView14.Items.Count + 1).ToString());
                        listView14.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "K")
                    {
                        int count = listView15.Items.Count;
                        listView15.Items.Add((listView15.Items.Count + 1).ToString());
                        listView15.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "L")
                    {
                        int count = listView16.Items.Count;
                        listView16.Items.Add((listView16.Items.Count + 1).ToString());
                        listView16.Items[count].SubItems.Add(takim);
                    }
                }
                sayi = 0;
                gruplar.Add("A");
                gruplar.Add("B");
                gruplar.Add("C");
                gruplar.Add("D");
                gruplar.Add("E");
                gruplar.Add("F");
                gruplar.Add("G");
                gruplar.Add("H");
                gruplar.Add("I");
                gruplar.Add("J");
                gruplar.Add("K");
                gruplar.Add("L");
                for (int m = 0; m <= torba4.Count + 10; m++)
                {
                    sayi++;
                    int uretilen = rastgele.Next(0, torba4.Count);
                    int grupuretilen = rastgele.Next(0, gruplar.Count);
                    string takim = torba4[uretilen].ToString();
                    string grup = gruplar[grupuretilen].ToString();
                    torba4.RemoveAt(uretilen);
                    gruplar.RemoveAt(grupuretilen);
                    if (grup == "A")
                    {
                        int count = listView8.Items.Count;
                        listView8.Items.Add((listView8.Items.Count + 1).ToString());
                        listView8.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "B")
                    {
                        int count = listView7.Items.Count;
                        listView7.Items.Add((listView7.Items.Count + 1).ToString());
                        listView7.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "C")
                    {
                        int count = listView6.Items.Count;
                        listView6.Items.Add((listView6.Items.Count + 1).ToString());
                        listView6.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "D")
                    {
                        int count = listView5.Items.Count;
                        listView5.Items.Add((listView5.Items.Count + 1).ToString());
                        listView5.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "E")
                    {
                        int count = listView12.Items.Count;
                        listView12.Items.Add((listView12.Items.Count + 1).ToString());
                        listView12.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "F")
                    {
                        int count = listView11.Items.Count;
                        listView11.Items.Add((listView11.Items.Count + 1).ToString());
                        listView11.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "G")
                    {
                        int count = listView10.Items.Count;
                        listView10.Items.Add((listView10.Items.Count + 1).ToString());
                        listView10.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "H")
                    {
                        int count = listView9.Items.Count;
                        listView9.Items.Add((listView9.Items.Count + 1).ToString());
                        listView9.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "I")
                    {
                        int count = listView13.Items.Count;
                        listView13.Items.Add((listView13.Items.Count + 1).ToString());
                        listView13.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "J")
                    {
                        int count = listView14.Items.Count;
                        listView14.Items.Add((listView14.Items.Count + 1).ToString());
                        listView14.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "K")
                    {
                        int count = listView15.Items.Count;
                        listView15.Items.Add((listView15.Items.Count + 1).ToString());
                        listView15.Items[count].SubItems.Add(takim);
                    }
                    else if (grup == "L")
                    {
                        int count = listView16.Items.Count;
                        listView16.Items.Add((listView16.Items.Count + 1).ToString());
                        listView16.Items[count].SubItems.Add(takim);
                    }
                }
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0 && listView1.Items.Count < 8 || comboBoxEdit1.SelectedIndex == 1 && listView1.Items.Count < 12)
            {
                string veri = Microsoft.VisualBasic.Interaction.InputBox("Eklenecek veriyi giriniz:", "Ekle", "", 50, 50);
                if (veri.Trim() != "")
                {
                    listView1.Items.Add(veri.Trim());
                }
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (listView2.SelectedItems.Count == 1)
            {
                contextMenuStrip2.Items[1].Enabled = true;
                contextMenuStrip2.Items[2].Enabled = true;
            }
            else if (listView2.SelectedItems.Count > 0)
            {
                contextMenuStrip2.Items[1].Enabled = true;
                contextMenuStrip2.Items[2].Enabled = false;
            }
            else
            {
                contextMenuStrip2.Items[1].Enabled = false;
                contextMenuStrip2.Items[2].Enabled = false;
            }
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            if (listView3.SelectedItems.Count == 1)
            {
                contextMenuStrip3.Items[1].Enabled = true;
                contextMenuStrip3.Items[2].Enabled = true;
            }
            else if (listView2.SelectedItems.Count > 0)
            {
                contextMenuStrip3.Items[1].Enabled = true;
                contextMenuStrip3.Items[2].Enabled = false;
            }
            else
            {
                contextMenuStrip3.Items[1].Enabled = false;
                contextMenuStrip3.Items[2].Enabled = false;
            }
        }

        private void contextMenuStrip4_Opening(object sender, CancelEventArgs e)
        {
            if (listView4.SelectedItems.Count == 1)
            {
                contextMenuStrip4.Items[1].Enabled = true;
                contextMenuStrip4.Items[2].Enabled = true;
            }
            else if (listView4.SelectedItems.Count > 0)
            {
                contextMenuStrip4.Items[1].Enabled = true;
                contextMenuStrip4.Items[2].Enabled = false;
            }
            else
            {
                contextMenuStrip4.Items[1].Enabled = false;
                contextMenuStrip4.Items[2].Enabled = false;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    foreach (ListViewItem veri in listView1.SelectedItems)
                    {
                        listView1.Items.RemoveAt(veri.Index);
                    }
                }
                else
                {
                    string veriler = "";
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        if (veriler == "")
                        {
                            veriler = item.Text.Trim();
                        }
                        else
                        {
                            veriler += "\n" + item.Text.Trim();
                        }
                    }
                    DialogResult sonuc = MessageBox.Show(veriler + "\nYukarıdaki verilerin tamamını silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == System.Windows.Forms.DialogResult.Yes)
                    {
                        foreach (ListViewItem item in listView1.SelectedItems)
                        {
                            listView1.Items.RemoveAt(item.Index);
                        }
                    }
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string veri = Microsoft.VisualBasic.Interaction.InputBox("Yeni veriyi giriniz:", "Düzenle", listView1.SelectedItems[0].Text, 50, 50);
                if (veri.Trim() != "")
                {
                    listView1.Items[listView1.SelectedItems[0].Index].Text = veri.Trim();
                }
            }
        }

        private void tümünüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                DialogResult sonuc = MessageBox.Show(listView1.Items.Count + " adet verinin tümünü silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == System.Windows.Forms.DialogResult.Yes)
                {
                    listView1.Items.Clear();
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0 && listView2.Items.Count < 8 || comboBoxEdit1.SelectedIndex == 1 && listView2.Items.Count < 12)
            {
                string veri = Microsoft.VisualBasic.Interaction.InputBox("Eklenecek veriyi giriniz:", "Ekle", "", 50, 50);
                if (veri.Trim() != "")
                {
                    listView2.Items.Add(veri.Trim());
                }
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0 && listView3.Items.Count < 8 || comboBoxEdit1.SelectedIndex == 1 && listView3.Items.Count < 12)
            {
                string veri = Microsoft.VisualBasic.Interaction.InputBox("Eklenecek veriyi giriniz:", "Ekle", "", 50, 50);
                if (veri.Trim() != "")
                {
                    listView3.Items.Add(veri.Trim());
                }
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0 && listView4.Items.Count < 8 || comboBoxEdit1.SelectedIndex == 1 && listView4.Items.Count < 12)
            {
                string veri = Microsoft.VisualBasic.Interaction.InputBox("Eklenecek veriyi giriniz:", "Ekle", "", 50, 50);
                if (veri.Trim() != "")
                {
                    listView4.Items.Add(veri.Trim());
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (listView2.SelectedItems.Count == 1)
                {
                    foreach (ListViewItem veri in listView2.SelectedItems)
                    {
                        listView2.Items.RemoveAt(veri.Index);
                    }
                }
                else
                {
                    string veriler = "";
                    foreach (ListViewItem item in listView2.SelectedItems)
                    {
                        if (veriler == "")
                        {
                            veriler = item.Text.Trim();
                        }
                        else
                        {
                            veriler += "\n" + item.Text.Trim();
                        }
                    }
                    DialogResult sonuc = MessageBox.Show(veriler + "\nYukarıdaki verilerin tamamını silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == System.Windows.Forms.DialogResult.Yes)
                    {
                        foreach (ListViewItem item in listView2.SelectedItems)
                        {
                            listView2.Items.RemoveAt(item.Index);
                        }
                    }
                }
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                if (listView3.SelectedItems.Count == 1)
                {
                    foreach (ListViewItem veri in listView3.SelectedItems)
                    {
                        listView3.Items.RemoveAt(veri.Index);
                    }
                }
                else
                {
                    string veriler = "";
                    foreach (ListViewItem item in listView3.SelectedItems)
                    {
                        if (veriler == "")
                        {
                            veriler = item.Text.Trim();
                        }
                        else
                        {
                            veriler += "\n" + item.Text.Trim();
                        }
                    }
                    DialogResult sonuc = MessageBox.Show(veriler + "\nYukarıdaki verilerin tamamını silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == System.Windows.Forms.DialogResult.Yes)
                    {
                        foreach (ListViewItem item in listView3.SelectedItems)
                        {
                            listView3.Items.RemoveAt(item.Index);
                        }
                    }
                }
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count > 0)
            {
                if (listView4.SelectedItems.Count == 1)
                {
                    foreach (ListViewItem veri in listView4.SelectedItems)
                    {
                        listView4.Items.RemoveAt(veri.Index);
                    }
                }
                else
                {
                    string veriler = "";
                    foreach (ListViewItem item in listView4.SelectedItems)
                    {
                        if (veriler == "")
                        {
                            veriler = item.Text.Trim();
                        }
                        else
                        {
                            veriler += "\n" + item.Text.Trim();
                        }
                    }
                    DialogResult sonuc = MessageBox.Show(veriler + "\nYukarıdaki verilerin tamamını silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == System.Windows.Forms.DialogResult.Yes)
                    {
                        foreach (ListViewItem item in listView1.SelectedItems)
                        {
                            listView4.Items.RemoveAt(item.Index);
                        }
                    }
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 1)
            {
                string veri = Microsoft.VisualBasic.Interaction.InputBox("Yeni veriyi giriniz:", "Düzenle", listView2.SelectedItems[0].Text, 50, 50);
                if (veri.Trim() != "")
                {
                    listView2.Items[listView2.SelectedItems[0].Index].Text = veri.Trim();
                }
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 1)
            {
                string veri = Microsoft.VisualBasic.Interaction.InputBox("Yeni veriyi giriniz:", "Düzenle", listView3.SelectedItems[0].Text, 50, 50);
                if (veri.Trim() != "")
                {
                    listView3.Items[listView3.SelectedItems[0].Index].Text = veri.Trim();
                }
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count == 1)
            {
                string veri = Microsoft.VisualBasic.Interaction.InputBox("Yeni veriyi giriniz:", "Düzenle", listView4.SelectedItems[0].Text, 50, 50);
                if (veri.Trim() != "")
                {
                    listView4.Items[listView4.SelectedItems[0].Index].Text = veri.Trim();
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count > 0)
            {
                DialogResult sonuc = MessageBox.Show(listView2.Items.Count + " adet verinin tümünü silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == System.Windows.Forms.DialogResult.Yes)
                {
                    listView2.Items.Clear();
                }
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (listView3.Items.Count > 0)
            {
                DialogResult sonuc = MessageBox.Show(listView3.Items.Count + " adet verinin tümünü silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == System.Windows.Forms.DialogResult.Yes)
                {
                    listView3.Items.Clear();
                }
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (listView4.Items.Count > 0)
            {
                DialogResult sonuc = MessageBox.Show(listView4.Items.Count + " adet verinin tümünü silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == System.Windows.Forms.DialogResult.Yes)
                {
                    listView4.Items.Clear();
                }
            }
        }
    }
}