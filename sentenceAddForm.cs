using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace kelimeAyir
{
    public partial class sentenceAddForm : Form
    {
        bool kntrl = true;
        int sentenceCount = 0;
        public sentenceAddForm()
        {
            InitializeComponent();
            sentenceTxt.ScrollBars = ScrollBars.Both;
        }
        private void anasayfa_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = (Form1)Application.OpenForms["Form1"];
            anasayfa.StartPosition = FormStartPosition.Manual;
            anasayfa.Left = this.Left;
            anasayfa.Top = this.Top;
            anasayfa.Show();
            kntrl = false;
            this.Close();
        }

        private void sentenceAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (kntrl)
            {
                Form1 anasayfa = (Form1)Application.OpenForms["Form1"];
                anasayfa.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sentenceTxt.Text.Trim() == "") {
                MessageBox.Show("Lütfen metin girin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sentenceTxt.Text = "";
            }
            else {
                string metin = sentenceTxt.Text.Trim().ToLower();
                string[] wordArray = metin.Split('.');
                //txtSave(metin);
                txtSaveTwo(metin);
                sentenceTxt.Text = "";
                MessageBox.Show(sentenceCount+" adet cümle veri tabanina eklendi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sentenceCount = 0;
            }
        }

        private void sentenceOpen_Click(object sender, EventArgs e)
        {
            Process.Start(@"sentence.txt");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kntrl = false;
            sentenceFormcs dosyaListele = new sentenceFormcs();
            dosyaListele.StartPosition = FormStartPosition.Manual;
            dosyaListele.Left = this.Left;
            dosyaListele.Top = this.Top;
            dosyaListele.Show();
            this.Close();
        }
        void txtSave(string metin)
        {
            string[] wordArray = metin.Split('.');
            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] != "")
                {
                    string[] old = File.ReadAllLines(@"sentence.txt");
                    for (int a = 0; a < old.Length; a++)
                    {
                        if (wordArray[i] == old[a]) { goto disdongu; }
                    }
                    TextWriter tw = new StreamWriter(@"sentence.txt", true);
                    tw.WriteLine(wordArray[i].Trim());
                    sentenceCount++;
                    tw.Close();
                    disdongu:;
                }

            }
        }
        void txtSaveTwo(string s3)
        {
            Regex r = new Regex(@"\s+");
            string metin = r.Replace(s3, @" ");
            string[] wordArray = metin.Split('.');
            List<string> temizMetin = new List<string>();
            foreach (string i in wordArray)
            {
                string a = i.Trim();
                if (a != "")
                {
                    temizMetin.Add(a);
                }
            }
            sentenceTxt.Text = "";
            for (int i = 0; i < temizMetin.Count; i++)
            {
                if (temizMetin[i] != "")
                {
                    string[] old = File.ReadAllLines(@"sentence.txt");
                    for (int a = 0; a < old.Length; a++)
                    {
                        if (temizMetin[i] == old[a]) { goto disdongu; }
                    }
                    string temizCumle = "";
                    if(temizMetin[i].IndexOf("-") == 0) { temizCumle = temizMetin[i].Substring(1);}
                    else
                    {
                        temizCumle = temizMetin[i];
                    }
                    int kelimeC = temizCumle.Split(' ').Length;
                    if (temizCumle.IndexOf(": -") == -1&&kelimeC>3&&kelimeC<15&&temizCumle.IndexOf("-")==-1) {
                        TextWriter tw = new StreamWriter(@"sentence.txt", true);
                        tw.WriteLine(temizCumle);
                        sentenceCount++;
                        tw.Close();
                    }
                    disdongu:;
                }

            }
        }
    }
}
