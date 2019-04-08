using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using ÇekilişProgramıv6._5;
using System.Drawing.Imaging;

namespace ÇekilişProgramıv5._5
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_EditValueChanged(object sender, EventArgs e)
        {
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string secili = listView1.SelectedItems[0].Text;
                int sayi = 0;
                ArrayList veriler = new ArrayList();
                int count = listView1.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    veriler.Add(listView1.Items[i].ToString());
                }

                foreach (string veri in veriler)
                {
                    if (veri == secili)
                    {
                        sayi++;
                    }
                }
                if (sayi != 0)
                {
                    float yuzde = (sayi / (float)count) * 100;
                    labelControl1.Text = "%" + yuzde.ToString();
                }
                else
                {
                    MessageBox.Show("Hesaplama yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Veri", 258);
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "" && Convert.ToInt16(textBox1.Text) < listView1.Items.Count && textBox1.Text != "0")
                {
                    if (radioGroup1.Text == "Tekli")
                    {
                        int count = listView1.Items.Count;

                        ArrayList veriler = new ArrayList();

                        for (int i = 0; i < count; i++)
                        {
                            veriler.Add(listView1.Items[i].ToString());
                        }

                        Random rastgele = new Random();
                        richTextBox1.Visible = true;
                        label2.Visible = true;
                        richTextBox1.Text = "";
                        for (int i = 1; i <= Convert.ToInt16(textBox1.Text); i++)
                        {
                            int uretilen = rastgele.Next(0, veriler.Count);

                            if (richTextBox1.Text != "")
                            {
                                richTextBox1.Text = richTextBox1.Text + "\n" + veriler[uretilen];
                                veriler.RemoveAt(uretilen);
                            }
                            else
                            {
                                richTextBox1.Text = richTextBox1.Text + veriler[uretilen];
                                veriler.RemoveAt(uretilen);
                            }
                        }
                    }
                    else if (radioGroup1.Text == "Takımlı")
                    {
                        int count = listView1.Items.Count;
                        int kCount = count;
                        kCount++;
                        if ((Convert.ToInt32(textBox1.Text) * 2) <= kCount)
                        {
                            ArrayList veriler2 = new ArrayList();
                            for (int i = 0; i < count; i++)
                            {
                                veriler2.Add(listView1.Items[i].ToString());
                            }

                            Random rastgele = new Random();
                            richTextBox1.Visible = true;
                            label2.Visible = true;
                            this.Height = 530;
                            richTextBox1.Text = "";
                            int sayi = Convert.ToInt32(textBox1.Text);
                            for (int i = 1; i <= sayi; i++)
                            {
                                int uretilen = rastgele.Next(0, veriler2.Count);

                                if (richTextBox1.Text != "")
                                {
                                    richTextBox1.Text = richTextBox1.Text + "\n" + veriler2[uretilen];
                                    veriler2.RemoveAt(uretilen);
                                }
                                else
                                {
                                    richTextBox1.Text = richTextBox1.Text + veriler2[uretilen];
                                    veriler2.RemoveAt(uretilen);
                                }

                                if (veriler2.Count > 0)
                                {
                                    int uretilen2 = rastgele.Next(0, veriler2.Count);
                                    if (richTextBox1.Text != "")
                                    {
                                        richTextBox1.Text = richTextBox1.Text + "   -   " + veriler2[uretilen2];
                                        veriler2.RemoveAt(uretilen2);
                                    }
                                    else
                                    {
                                        richTextBox1.Text = richTextBox1.Text + "   -   " + veriler2[uretilen2];
                                        veriler2.RemoveAt(uretilen2);
                                    }
                                }
                                else
                                {
                                    richTextBox1.Text = richTextBox1.Text + "   BAY";
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Çekiliş Yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Çekiliş yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() != "")
                {
                    if (radioGroup1.Text == "Tekli")
                    {
                        int sayi = Convert.ToInt32(textBox1.Text);
                        if (sayi != 0)
                        {
                            if (sayi >= listView1.Items.Count)
                            {
                            simpleButton7.Enabled = false;
                            }
                            else
                            {
                            simpleButton7.Enabled = true;
                            }
                        }
                    }
                    else if (radioGroup1.Text == "Takımlı") 
                    {
                        int sayi = Convert.ToInt32(textBox1.Text);
                        if (sayi != 0)
                        {
                        sayi--;
                            if (sayi * 2 > listView1.Items.Count)
                            {
                            simpleButton7.Enabled = false;
                            }
                            else
                            {
                            simpleButton7.Enabled = true;
                            }
                        }
                    }

                    int veri = 0;
                    int count = listView1.Items.Count;
                    if (count > 1)
                    {
                        if (count % 2 == 0)
                        {
                            veri = count / 2;
                        }
                        else
                        {
                            veri = (count + 1) / 2;
                        }

                        if (int.Parse(textBox1.Text) == veri)
                        {
                            labelControl3.Visible = false;
                        }
                        else
                        {
                            labelControl3.Visible = true;
                        }
                    }
                }
                else
                {
                    labelControl3.Visible = true;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.Text != " ")
                {
                    string secili = listView1.SelectedItems[0].Text;
                    int sayi = 0;
                    ArrayList veriler = new ArrayList();
                    int count = listView1.Items.Count;
                    for (int i = 0; i < count; i++)
                    {
                        veriler.Add(listView1.Items[i].ToString());
                    }

                    foreach (string veri in veriler)
                    {
                        if (veri == secili)
                        {
                            sayi++;
                        }
                    }
                    if (sayi != 0)
                    {
                        float yuzde = (sayi / (float)count) * 100;
                        if (yuzde > 0 && yuzde <= 20)
                        {
                            labelControl2.ForeColor = Color.Gray;
                        }
                        else if (yuzde > 20 && yuzde <= 40)
                        {
                            labelControl2.ForeColor = Color.Red;
                        }
                        else if (yuzde > 40 && yuzde <= 60)
                        {
                            labelControl2.ForeColor = Color.Orange;
                        }
                        else if (yuzde > 60 && yuzde <= 80)
                        {
                            labelControl2.ForeColor = Color.Green;
                        }
                        else if (yuzde > 80 && yuzde <= 100)
                        {
                            labelControl2.ForeColor = Color.Blue;
                        }
                        labelControl2.Text = "%" + yuzde.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Hesaplama yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string secili = listView1.Items[1].ToString();
                    int sayi = 0;
                    ArrayList veriler = new ArrayList();
                    int count = listView1.Items.Count;
                    for (int i = 0; i < count; i++)
                    {
                        veriler.Add(listView1.Items[i].ToString());
                    }

                    foreach (string veri in veriler)
                    {
                        if (veri == secili)
                        {
                            sayi++;
                        }
                    }
                    if (sayi != 0)
                    {
                        float yuzde = (sayi / (float)count) * 100;
                        if (yuzde == 100)
                        {
                            MessageBox.Show("Verilerinizin çıkma ihtimali %100'dür.\nBu durumda çekiliş yapmanız mantıklı olmaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hesaplama yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (textBox1.Text != "" && Convert.ToInt16(textBox1.Text) < listView1.Items.Count && textBox1.Text != "0")
                    {
                        if (radioGroup1.Text == "Tekli")
                        {
                            int nCount = listView1.Items.Count;

                            ArrayList nVeriler = new ArrayList();

                            for (int i = 0; i < nCount; i++)
                            {
                                nVeriler.Add(listView1.Items[i].ToString());
                            }

                            Random rastgele = new Random();
                            richTextBox1.Visible = true;
                            label2.Visible = true;
                            richTextBox1.Text = "";
                            for (int i = 1; i <= Convert.ToInt16(textBox1.Text); i++)
                            {
                                int uretilen = rastgele.Next(0, nVeriler.Count);

                                if (richTextBox1.Text != "")
                                {
                                    richTextBox1.Text = richTextBox1.Text + "\n" + nVeriler[uretilen];
                                    nVeriler.RemoveAt(uretilen);
                                }
                                else
                                {
                                    richTextBox1.Text = richTextBox1.Text + nVeriler[uretilen];
                                    nVeriler.RemoveAt(uretilen);
                                }
                            }
                        }
                        else if (radioGroup1.Text == "Takımlı")
                        {
                            int nCount = listView1.Items.Count;
                            int kCount = nCount;
                            kCount++;
                            if ((Convert.ToInt32(textBox1.Text) * 2) <= kCount)
                            {
                                ArrayList veriler2 = new ArrayList();
                                for (int i = 0; i < nCount; i++)
                                {
                                    veriler2.Add(listView1.Items[i].ToString());
                                }

                                Random rastgele = new Random();
                                richTextBox1.Visible = true;
                                label2.Visible = true;
                                this.Height = 530;
                                richTextBox1.Text = "";
                                int nSayi = Convert.ToInt32(textBox1.Text);
                                for (int i = 1; i <= nSayi; i++)
                                {
                                    int uretilen = rastgele.Next(0, veriler2.Count);

                                    if (richTextBox1.Text != "")
                                    {
                                        richTextBox1.Text = richTextBox1.Text + "\n" + veriler2[uretilen];
                                        veriler2.RemoveAt(uretilen);
                                    }
                                    else
                                    {
                                        richTextBox1.Text = richTextBox1.Text + veriler2[uretilen];
                                        veriler2.RemoveAt(uretilen);
                                    }

                                    if (veriler2.Count > 0)
                                    {
                                        int uretilen2 = rastgele.Next(0, veriler2.Count);
                                        if (richTextBox1.Text != "")
                                        {
                                            richTextBox1.Text = richTextBox1.Text + "   -   " + veriler2[uretilen2];
                                            veriler2.RemoveAt(uretilen2);
                                        }
                                        else
                                        {
                                            richTextBox1.Text = richTextBox1.Text + "   -   " + veriler2[uretilen2];
                                            veriler2.RemoveAt(uretilen2);
                                        }
                                    }
                                    else
                                    {
                                        richTextBox1.Text = richTextBox1.Text + "   BAY";
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kazanacak sayısında bir hata olduğundan dolayı çekiliş yapılamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şunlardan biriniz yapmanızdan dolayı çekiliş yapılamadı:\nKazanacak sayısı, katılımcı sayısından fazla veya eşit.\nKazanacak sayısı boş.\nKazanacak sayısı 0", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "*.txt";
                openFileDialog1.Filter = "Metin Dosyası (*.txt)|*.txt";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Title = "Okunacak Veriyi Seçiniz:";
                openFileDialog1.ShowDialog();
                StreamReader dosyaokuma = new StreamReader(openFileDialog1.FileName);
                listView1.Items.Clear();
                string yazi = dosyaokuma.ReadLine();
                while (yazi != null)
                {
                    listView1.Items.Add(yazi);
                    yazi = dosyaokuma.ReadLine();
                }
                dosyaokuma.Close();
                int count = listView1.Items.Count;
                label3.Text = "Toplamda " + count + " veri bulunmaktadır.";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (textBox1.Text.Trim() != "")
                {
                    if (radioGroup1.Text == "Tekli")
                    {
                        int sayi = Convert.ToInt32(textBox1.Text);
                        if (sayi != 0)
                        {
                            if (sayi >= listView1.Items.Count)
                            {
                                simpleButton7.Enabled = false;
                            }
                            else
                            {
                                simpleButton7.Enabled = true;
                            }
                        }
                    }
                    else if (radioGroup1.Text == "Takımlı")
                    {
                        int sayi = Convert.ToInt32(textBox1.Text);
                        if (sayi != 0)
                        {
                            sayi--;
                            if (sayi * 2 > listView1.Items.Count)
                            {
                                simpleButton7.Enabled = false;
                            }
                            else
                            {
                                simpleButton7.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0)
                {
                    saveFileDialog1.FileName = "*";
                    saveFileDialog1.Filter = "Metin Dosyası (*.txt)|*.txt";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Title = "Kayıt Edilecek Yeri Seçiniz:";
                    saveFileDialog1.ShowDialog();

                    StreamWriter dosyayazma = new StreamWriter(saveFileDialog1.FileName);

                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        dosyayazma.WriteLine(listView1.Items[i].Text);
                    }
                    dosyayazma.Close();
                }
                else
                {
                    MessageBox.Show("Kaydetmek için en az 1 veri bulunması gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çekiliş V7.00\n\nhttp://www.kodevreni.com\n\nKullanımı ve paylaşımı tamamen ücretsizdir!", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string veri = Microsoft.VisualBasic.Interaction.InputBox("Lütfen eklenecek veriyi giriniz:", "Ekle", "", 50, 50);
            if (veri.Trim() != "")
            {
                listView1.Items.Add(veri.Trim());
                string count = listView1.Items.Count.ToString();
                label3.Text = "Toplamda " + count + " veri bulunmaktadır.";
            }
            else
            {
                veri = veri.Trim();
                MessageBox.Show("Veri eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (textBox1.Text.Trim() != "")
                {
                    if (radioGroup1.Text == "Tekli")
                    {
                        int sayi = Convert.ToInt32(textBox1.Text);
                        if (sayi != 0)
                        {
                            if (sayi >= listView1.Items.Count)
                            {
                                simpleButton7.Enabled = false;
                            }
                            else
                            {
                                simpleButton7.Enabled = true;
                            }
                        }
                    }
                    else if (radioGroup1.Text == "Takımlı")
                    {
                        int sayi = Convert.ToInt32(textBox1.Text);
                        if (sayi != 0)
                        {
                            sayi--;
                            if (sayi * 2 > listView1.Items.Count)
                            {
                                simpleButton7.Enabled = false;
                            }
                            else
                            {
                                simpleButton7.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string metin = Microsoft.VisualBasic.Interaction.InputBox("Lütfen \"" + listView1.SelectedItems[0].Text + "\" adlı verinin yeni değerini giriniz:", "Düzenle", listView1.SelectedItems[0].Text, 50, 50);
                if (metin.Trim() != "")
                {
                    listView1.SelectedItems[0].Text = metin.Trim();
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz veriyi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (textBox1.Text.Trim() != "")
                {
                    if (radioGroup1.Text == "Tekli")
                    {
                        int sayi = Convert.ToInt32(textBox1.Text);
                        if (sayi != 0)
                        {
                            if (sayi >= listView1.Items.Count)
                            {
                                simpleButton7.Enabled = false;
                            }
                            else
                            {
                                simpleButton7.Enabled = true;
                            }
                        }
                    }
                    else if (radioGroup1.Text == "Takımlı")
                    {
                        int sayi = Convert.ToInt32(textBox1.Text);
                        if (sayi != 0)
                        {
                            sayi--;
                            if (sayi * 2 > listView1.Items.Count)
                            {
                                simpleButton7.Enabled = false;
                            }
                            else
                            {
                                simpleButton7.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    DialogResult soru = MessageBox.Show("Veriyi silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (soru == DialogResult.Yes)
                    {
                        foreach (ListViewItem item in listView1.SelectedItems)
                        {
                            listView1.Items.RemoveAt(item.Index);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz veriyi seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textBox1.Text.Trim() != "")
                {
                    if (radioGroup1.Text == "Tekli")
                    {
                        int sayi = Convert.ToInt32(textBox1.Text);
                        if (sayi != 0)
                        {
                            if (sayi >= listView1.Items.Count)
                            {
                                simpleButton7.Enabled = false;
                            }
                            else
                            {
                                simpleButton7.Enabled = true;
                            }
                        }
                    }
                    else if (radioGroup1.Text == "Takımlı")
                    {
                        int sayi = Convert.ToInt32(textBox1.Text);
                        if (sayi != 0)
                        {
                            sayi--;
                            if (sayi * 2 > listView1.Items.Count)
                            {
                                simpleButton7.Enabled = false;
                            }
                            else
                            {
                                simpleButton7.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tümünüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count;
            if (count > 0)
            {
                DialogResult soru = MessageBox.Show(count + " adet veri mevcuttur.\nHepsini silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    listView1.Items.Clear();
                    label3.Text = "Toplamda 0 veri bulunmaktadır.";
                }
            }
            else
            {
                MessageBox.Show("Tüm verileri temizlemeniz için bir veri bulunması gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void çekilişV600YardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çekiliş V7.00 Kullanımı:\n\nKatılımcı Ekleme: Katılımcıların bulunduğu bölüme sağ tıklayarak Ekle bölümüne tıklayarak.\n\nKatılımcı Silme: Silmek istediğiniz katılımcı(ları) katılımcıların listelendiği bölümden seçtikten sonra sağ tıklayıp Sil bölümüne tıklayarak.\n\nKatılımcı Düzenleme: Düzenlemek istediğiniz katılımcıyı katılımcıların listelendiği bölümde seçtikten sonra sağ tıklayıp Düzenle bölümüne tıklayarak açılan pencerede yeni ismini vererek Tamam tuşuna basarak.\n\nTüm Katılımcıları Silme: Herhangi bir alana sağ tıklayıp Tümünü Sil bölümüne tıkladıktan sonra gelen soruyu evet olarak cevaplayarak.\n\nTekli ve Takımlı Çekilişler: Tekli çekiliş, sadece belirlediğiniz sayıda tek kişiyi satır satır gösterir. Takımlı çekiliş, belirlediğiniz sayıda 2'li takımlar halinde satır satır gösterir\n\nÇekiliş Açmak ve Çekiliş Kaydetmek: Çekiliş kaydetmek için, yukarıda bulunan Dosya menüsünden Kaydet seçeneği seçilir. Kayıt edilecek yer seçildikten sonra kaydedilir. Çekiliş açmak için, yukarıda bulunan Dosya menüsünden Aç seçeneği seçilir. Açılacak .txt uzantılı dosya seçildikten sonra açılır.\n\nKazanları Temizleme: Çekiliş yaptıktan sonra kazanan katılımcıları temizlemek için, kazananların bulunduğu metin kutusuna sağ tıklayıp Temizle tuşuna basarak.\n\nKazananları Kaydetme: Kazanan katılımcıları kaydetmek için; kazanan katılımcıların bulunduğu metin kutusuna sağ tıklayarak Kaydet tuşuna basıp, kayıt edeceğiniz yeri seçip.\n\nResim Alma: Kazanan katılımcıların ve programın resmini almak için, kazanan katılımcıların bulunduğu metin kutusuna sağ tıklayıp Resim Al tuşuna basıp kaydedeceğiniz yeri seçerek(Resimi kaydedebileceğiniz uzantılar: bmp, jpg, png, ico, gif).\n\nResim alma işlevinin amacı: Çok önemli çekilişler yaparken kanıt olarak göstermek için fazladan bir programa ihtiyaç duymadan resim almanız için bu işlev eklenmiştir.\n\nTamamını takım olarak eşleştir nedir?\nTamamını takım olarak eşleştirme işlevi, takımlı çekiliş için bir kolaylık sağlar! Katılımcıların hepsini takım olarak eşleştirmek için gerekli sayıyı kazanacak sayısı metin kutusuna girer.\n\nUEFA Avrupa Ligi ve Şampiyonlar Ligi Grup Kuraları Çekme: Anasayfada iken üst menülerden Çekiliş/Eğlence sekmesine tıklayın. Açılan pencerede kuralarını çekmek istediğiniz takımı seçin ve Kurayı Çek düğmesi ile grup kuralarını çekin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.Text != " ")
                {
                    string secili = listView1.SelectedItems[0].Text;
                    int sayi = 0;
                    ArrayList veriler = new ArrayList();
                    int count = listView1.Items.Count;
                    for (int i = 0; i < count; i++)
                    {
                        veriler.Add(listView1.Items[i].Text);
                    }
                    foreach (string veri in veriler)
                    {
                        if (veri == secili)
                        {
                            sayi++;
                        }
                    }
                    if (sayi != 0)
                    {
                        float yuzde = (sayi / (float)count) * 100;
                        if (yuzde > 0 && yuzde <= 20)
                        {
                            labelControl2.ForeColor = Color.Gray;
                        }
                        else if (yuzde > 20 && yuzde <= 40)
                        {
                            labelControl2.ForeColor = Color.Red;
                        }
                        else if (yuzde > 40 && yuzde <= 60)
                        {
                            labelControl2.ForeColor = Color.Orange;
                        }
                        else if (yuzde > 60 && yuzde <= 80)
                        {
                            labelControl2.ForeColor = Color.Green;
                        }
                        else if (yuzde > 80 && yuzde <= 100)
                        {
                            labelControl2.ForeColor = Color.Blue;
                        }
                        labelControl2.Text = "%" + yuzde.ToString();
                    }
                    else
                    {
                        
                    }
                }
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                string secili = listView1.Items[0].Text;
                int sayi = 0;
                ArrayList veriler = new ArrayList();
                int count = listView1.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    veriler.Add(listView1.Items[i].Text);
                }
                foreach (string veri in veriler)
                {
                    if (veri == secili)
                    {
                        sayi++;
                    }
                }
                if (sayi != 0)
                {
                    float yuzde = (sayi / (float)count) * 100;
                    if (yuzde > 0 && yuzde <= 20)
                    {
                        labelControl2.ForeColor = Color.Gray;
                    }
                    else if (yuzde > 20 && yuzde <= 40)
                    {
                        labelControl2.ForeColor = Color.Red;
                    }
                    else if (yuzde > 40 && yuzde <= 60)
                    {
                        labelControl2.ForeColor = Color.Orange;
                    }
                    else if (yuzde > 60 && yuzde <= 80)
                    {
                        labelControl2.ForeColor = Color.Green;
                    }
                    else if (yuzde > 80 && yuzde <= 100)
                    {
                        labelControl2.ForeColor = Color.Blue;
                    }

                    if (yuzde == 100)
                    {
                        MessageBox.Show("Verilerin çıkma ihtimali %100. Bu durumda çekiliş yapmak mantıksız olacaktır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Yüzde hesaplaması yapılamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (textBox1.Text != "" && Convert.ToInt16(textBox1.Text) < listView1.Items.Count && textBox1.Text != "0")
                {
                    if (radioGroup1.Text == "Tekli")
                    {
                        int nCount = listView1.Items.Count;

                        ArrayList nVeriler = new ArrayList();

                        for (int i = 0; i < nCount; i++)
                        {
                            nVeriler.Add(listView1.Items[i].Text);
                        }

                        Random rastgele = new Random();
                        richTextBox1.Visible = true;
                        label2.Visible = true;
                        richTextBox1.Text = "";
                        for (int i = 1; i <= Convert.ToInt16(textBox1.Text); i++)
                        {
                            int uretilen = rastgele.Next(0, nVeriler.Count);

                            if (richTextBox1.Text != "")
                            {
                                richTextBox1.Text = richTextBox1.Text + "\n" + nVeriler[uretilen];
                                nVeriler.RemoveAt(uretilen);
                            }
                            else
                            {
                                richTextBox1.Text = richTextBox1.Text + nVeriler[uretilen];
                                nVeriler.RemoveAt(uretilen);
                            }
                        }
                    }
                    else if (radioGroup1.Text == "Takımlı")
                    {
                        int nCount = listView1.Items.Count;
                        int kCount = nCount;
                        kCount++;
                        if ((Convert.ToInt32(textBox1.Text) * 2) <= kCount)
                        {
                            ArrayList veriler2 = new ArrayList();
                            for (int i = 0; i < nCount; i++)
                            {
                                veriler2.Add(listView1.Items[i].Text);
                            }

                            Random rastgele = new Random();
                            richTextBox1.Visible = true;
                            label2.Visible = true;
                            richTextBox1.Text = "";
                            int nSayi = Convert.ToInt32(textBox1.Text);
                            for (int i = 1; i <= nSayi; i++)
                            {
                                int uretilen = rastgele.Next(0, veriler2.Count);

                                if (richTextBox1.Text != "")
                                {
                                    richTextBox1.Text = richTextBox1.Text + "\n" + veriler2[uretilen];
                                    veriler2.RemoveAt(uretilen);
                                }
                                else
                                {
                                    richTextBox1.Text = richTextBox1.Text + veriler2[uretilen];
                                    veriler2.RemoveAt(uretilen);
                                }

                                if (veriler2.Count > 0)
                                {
                                    int uretilen2 = rastgele.Next(0, veriler2.Count);
                                    if (richTextBox1.Text != "")
                                    {
                                        richTextBox1.Text = richTextBox1.Text + "   -   " + veriler2[uretilen2];
                                        veriler2.RemoveAt(uretilen2);
                                    }
                                    else
                                    {
                                        richTextBox1.Text = richTextBox1.Text + "   -   " + veriler2[uretilen2];
                                        veriler2.RemoveAt(uretilen2);
                                    }
                                }
                                else
                                {
                                    richTextBox1.Text = richTextBox1.Text + "   BAY";
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kazanacak katılımcı sayısında hata mevcut olduğundan çekiliş yapılamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kazanacak sayısında hata mevcut olduğundan çekiliş yapılamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void kaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0)
                {
                    saveFileDialog1.FileName = "*";
                    saveFileDialog1.Filter = "Metin Dosyası (*.txt)|*.txt";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Title = "Kayıt Edilecek Yeri Seçiniz:";
                    saveFileDialog1.ShowDialog();

                    StreamWriter dosyayazma = new StreamWriter(saveFileDialog1.FileName);

                    int satir = 0;

                    foreach (string veri in richTextBox1.Lines)
                    {
                        satir++;
                    }

                    for (int i = 0; i < satir; i++)
                    {
                        dosyayazma.WriteLine(richTextBox1.Lines[i]);
                    }
                    dosyayazma.Close();
                }
                else
                {
                    MessageBox.Show("Kaydetmek için en az 1 veri bulunması gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }

                saveFileDialog1.Title = "Kaydedeceğiniz yeri seçiniz:";
                saveFileDialog1.Filter = "Jpeg Resim Dosyası (*.jpg)|*.jpg|Gif Resim Dosyası (*.gif)|*.gif|Png Resim Dosyası (*.png)|*.png|Bmp Resim Dosyası (*.bmp)|*.bmp|Ikon Resim Dosyası (*.ico)|*.ico|Tüm Dosyalar (*.*)|*.*";
                saveFileDialog1.DefaultExt = "png";
                ImageFormat resimturu = ImageFormat.Png;
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (Path.GetExtension(saveFileDialog1.FileName) == "jpg")
                    {
                        resimturu = ImageFormat.Jpeg;
                    }
                    else if (Path.GetExtension(saveFileDialog1.FileName) == "png")
                    {
                        resimturu = ImageFormat.Png;
                    }
                    else if (Path.GetExtension(saveFileDialog1.FileName) == "gif")
                    {
                        resimturu = ImageFormat.Gif;
                    }
                    else if (Path.GetExtension(saveFileDialog1.FileName) == "ico")
                    {
                        resimturu = ImageFormat.Icon;
                    }
                    else if (Path.GetExtension(saveFileDialog1.FileName) == "bmp")
                    {
                        resimturu = ImageFormat.Bmp;
                    }
                    bitmap.Save(saveFileDialog1.FileName, resimturu);
                }
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            int sayi = 0;
            radioGroup1.SelectedIndex = 1;
            int count = listView1.Items.Count;
            if (count > 1)
            {
                if (count % 2 == 0)
                {
                    sayi = count / 2;
                }
                else
                {
                    sayi = (count + 1) / 2;
                    mesaj = "1 veri BAY olarak geçecektir.";
                }
                textBox1.Text = sayi.ToString();
                labelControl3.Visible = false;
                if (mesaj != "")
                {
                    MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkEdit1_Click(object sender, EventArgs e)
        {
            
        }

        string veri = "";

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                listView1.Visible = false;
                richTextBox2.Visible = true;
                veri = "";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (veri == "")
                    {
                        veri = listView1.Items[i].Text;
                    }
                    else
                    {
                        veri += "\n" + listView1.Items[i].Text;
                    }
                }
                richTextBox2.Text = veri;
            }
            else if (checkEdit1.Checked == false)
            {
                listView1.Visible = true;
                richTextBox2.Visible = false;
                listView1.Items.Clear();
                foreach (string item in richTextBox2.Lines)
                {
                    if (item != "")
                    {
                        listView1.Items.Add(item);
                    }
                }
                label3.Text = "Şuanda " + listView1.Items.Count + " adet veri bulunmaktadır.";
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (string item in richTextBox2.Lines)
            {
                if (item != "")
                {
                    listView1.Items.Add(item);
                }
            }
            label3.Text = "Şuanda " + listView1.Items.Count + " adet veri bulunmaktadır.";
        }

        private void eğlenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
