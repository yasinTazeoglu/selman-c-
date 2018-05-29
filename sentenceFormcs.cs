using System;
using System.IO;
using System.Windows.Forms;

namespace kelimeAyir
{
    public partial class sentenceFormcs : Form
    {
        bool kntrl = true;
        bool writeK = false;
        bool acilisK = true;
        int sayac = 0;
        int satirSayisi = 0;
        string wordS = "";
        public sentenceFormcs()
        {
            InitializeComponent();
            sentenceList.ScrollBars = ScrollBars.Both;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = (Form1)Application.OpenForms["Form1"];
            anasayfa.StartPosition = FormStartPosition.Manual;
            anasayfa.Left = this.Left;
            anasayfa.Top = this.Top;
            anasayfa.Show();
            kntrl = false;
            this.Close();
        }

        private void sentenceFormcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (kntrl)
            {
                Form1 anasayfa = (Form1)Application.OpenForms["Form1"];
                anasayfa.Close();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (sentenceWord.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen kelime yaziniz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                wordS = sentenceWord.Text;
                writeK = false;
                acilisK = true;
                sentenceRead();
            }
        }

        private void sentenceList_TextChanged(object sender, EventArgs e)
        {
            if (writeK) {
                writeK = false;
                sentenceRead();
                MessageBox.Show("Malesef cümleler üzerinde degisiklik yapamazsiziniz kopyalamayi deneyin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        void sentenceRead()
        {

            string[] kelimeler = wordS.Split(','); 
            sentenceList.Clear();
            string[] yol = File.ReadAllLines(@"sentence.txt");
            sentenceList.Enabled = true;
             for (int i = 0; i < yol.Length; i++)
             {
                string[] satir = yol[i].Split(' ');
                for (int a = 0; a < kelimeler.Length; a++)
                    {
                    for (int s = 0; s < satir.Length; s++)
                    {
                        if (satir[s].IndexOf(kelimeler[a]) == 0)
                        {
                            sayac++;
                            goto disdongu;

                        }
                    }
                    disdongu:;
                }
                if (kelimeler.Length == sayac) {
                    satirSayisi++;
                    sentenceList.AppendText(satirSayisi+".) "+yol[i]);
                    sentenceList.AppendText("\n--------------------------------------------" +
               "---------------------------------------------------------------------\n");
                }
                sayac = 0;

             }
            if (sentenceList.Text.Length > 0)
            {
                if(acilisK)
                    MessageBox.Show(satirSayisi + " adet cumle bulundu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                satirSayisi = 0;
                acilisK = false;
                writeK = true;
            }
             else
                MessageBox.Show("Uygun cümle yok", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            kntrl = false;
            sentenceAddForm dosyaListele = new sentenceAddForm();
            dosyaListele.StartPosition = FormStartPosition.Manual;
            dosyaListele.Left = this.Left;
            dosyaListele.Top = this.Top;
            dosyaListele.Show();
            this.Close();
        }
    }
}
