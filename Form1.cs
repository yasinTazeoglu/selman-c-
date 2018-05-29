using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kelimeAyir
{
    public partial class Form1 : Form
    {
        string eskiM="1";
        int saveTxtV = 0;
        string saveM = "0";
        Char[] ayraclar = { '/','\n','#', '.', ',', '(', ')', ';', '?', ' ', ':', '*', '—', '[', ']', '%', '&', '<', '>', '"', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '_', '+' };
        public Form1()
        {
            InitializeComponent();
            wordL.Items.Add("KELİMELER BURADA GÖRÜNECEK");
            txtT.ScrollBars = ScrollBars.Both;

        }

        private void bol_Click(object sender, EventArgs e)
        {
            kelimeAyir(txtT.Text != "METNİ BURAYA GİRİNİZ",saveM+" "+txtT.Text);
             }
        private void txtT_ENTER(object sender, EventArgs e)
        {
            if(txtT.Text== "METNİ BURAYA GİRİNİZ")
            {
                txtT.Text = "";
                txtT.ForeColor = Color.Black;
            }
        }
        private void txtT_LEAVE(object sender, EventArgs e)
        {
            if (txtT.Text=="")
            {
                txtT.Text = "METNİ BURAYA GİRİNİZ";
                txtT.ForeColor = Color.Silver;
            }
        }
        private void txtC_ENTER(object sender, EventArgs e)
        {
            if (txtC.Text == "DOSYA İSMİ")
            {
                txtC.Text = "";
                txtC.ForeColor = Color.Black;
            }
        }
        private void txtC_LEAVE(object sender, EventArgs e)
        {
            if (txtC.Text == "")
            {
                txtC.Text = "DOSYA İSMİ";
                txtC.ForeColor = Color.Silver;
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (txtT.Text != "METNİ BURAYA GİRİNİZ")
            {
                wordL.Items.Clear();
                wordL.Items.Add("KELİMELER BURADA GÖRÜNECEK");
                wordL.ForeColor = Color.Silver;
                saveTxtV++;
                saveTxt.Text = saveTxtV.ToString();
                countw.Text = "0";
                if (saveM != "0")
                    saveM = saveM + " " + txtT.Text;
                else
                    saveM = txtT.Text;
                txtT.ForeColor = Color.Silver;
                txtT.Text = "METNİ BURAYA GİRİNİZ";
            }
            else
            {
                if (eskiM != "1")
                {
                    MessageBox.Show("METİN GİRMEDİGİNİZ İCİN BİR ONCEKİ METİN YUKLENECEK", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtT.Text = eskiM;
                    txtT.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("LÜTFEN METİN GİRİNİZ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void sifirla_Click(object sender, EventArgs e)
        {
            eskiM = "1";
            saveM = "0";
            countw.Text = "0";
            saveTxt.Text = "0";
            txtT.Text = "METNİ BURAYA GİRİNİZ";
            txtT.ForeColor = Color.Silver;
            wordL.Items.Clear();
            wordL.Items.Add("KELİMELER BURADA GÖRÜNECEK");
            wordL.ForeColor = Color.Silver;
            txtC.Text = "";


        }
        private void wordD_Click(object sender, EventArgs e)
        {
            if(wordL.Items[0].ToString()!= "KELİMELER BURADA GÖRÜNECEK")
            {
                wordL.Items.Clear();
                wordL.Items.Add("KELİMELER BURADA GÖRÜNECEK");
                wordL.ForeColor = Color.Silver;
                countw.Text = "0";
            }
            else
            {
                MessageBox.Show("Silinecek Kelime Bulunamadi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void txtCB_Click(object sender, EventArgs e)
        {
            if (txtC.Text != ""&&wordL.Items[0].ToString()!= "KELİMELER BURADA GÖRÜNECEK")
            {
                try {
                    string path = @"e:masaüstü\notlar\ing\" + txtC.Text + ".txt";
                    if (File.Exists(path))
                    { MessageBox.Show("Bu dosya ismi daha önce kullanilmiş", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        StreamWriter belge = new StreamWriter(@"e:masaüstü\notlar\ing\" + txtC.Text + ".txt");
                        for (int i = 0; i < wordL.Items.Count; i++)
                        {
                            belge.WriteLine(wordL.Items[i].ToString());
                        }
                        belge.Close();
                        MessageBox.Show("Kelimeler " + txtC.Text + " dosyasina yazildi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtC.Text = "DOSYA İSMİ";
                        txtC.ForeColor = Color.Silver;
                    }
                }
                catch(Exception a)
                {
                    MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
               

            }
            else
            {
                MessageBox.Show("bir hata var", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void folderList_Click(object sender, EventArgs e)
        {
                this.Hide();
                txtList dosyaListele = new txtList();
                dosyaListele.StartPosition = FormStartPosition.Manual;
                dosyaListele.Left = this.Left;
                dosyaListele.Top = this.Top;
                dosyaListele.Show();
                
        }
        Boolean CogulW(string[] wordArray, int i)
        {
            int WL = wordArray[i].Length - 1;
            bool a = false;
            for (int j = 0; j < wordArray.Length; j++)
            {
                if (j != i&&WL>2)
                {
                     if (wordArray[i].Substring(WL - 2) == "oes"|| wordArray[i].Substring(WL - 2) == "xes")
                     {
                        string wordWL = wordArray[i].Substring(0,WL-1);
                         if (wordWL == wordArray[j]) { a = true; goto cikis; }
                     }else if(wordArray[i].Substring(WL - 3) == "ches"|| wordArray[i].Substring(WL - 3) == "shes")
                    {
                        string wordWL = wordArray[i].Substring(0, WL - 1);
                        if (wordWL == wordArray[j]) { a = true; goto cikis; }
                    }else if (wordArray[i].Substring(WL - 2) == "ies") {
                        string wordWL = wordArray[i].Substring(0, WL - 2)+"y";
                        if (wordWL == wordArray[j]) { a = true; goto cikis; }
                    }else if (wordArray[i].Substring(WL) == "s")
                    {
                        string wordWL = wordArray[i].Substring(0,WL);
                        if (wordWL == wordArray[j]) { a = true; }

                    }
                }

            }
            cikis:
            return a;
        }
        void kelimeAyir(bool a, string metin)
        {
            if (a)
            {
                wordL.Items.Clear();
                wordL.ForeColor = Color.Black;
                string[] wordArray = metin.Split(ayraclar);
                for (int i = 0; i < wordArray.Length; i++)
                {
                    Boolean kontrol = wordArray[i].Length != 1 && wordArray[i].Length != 0 && wordArray[i].Length !=
                        2 && wordArray[i] != "the" && wordArray[i] != "are" && wordArray[i] != "was" && wordArray[i] != "the";
                    if (kontrol)
                    {
                        for (int k = 0; k < i; k++)
                        {
                            if (wordArray[i] == wordArray[k]) { goto disdongu; }
                        }
                        if (CogulW(wordArray, i)) { goto disdongu; }
                        wordL.Items.Add(wordArray[i].ToLower().Trim());


                    }
                    disdongu:;
                }
                eskiM = txtT.Text;
                if (saveM != "0")
                {
                    txtT.Text = saveM + " " + txtT.Text;
                    txtT.ForeColor = Color.Black;
                    saveTxtV = 0;
                    saveTxt.Text = "0";
                    saveM = "0";
                }

                countw.Text = wordL.Items.Count.ToString();

            }
            else
            {
                if (saveM == "0")
                {
                    if (eskiM != "1")
                    {
                        MessageBox.Show("METİN GİRMEDİGİNİZ İCİN BİR ONCEKİ METİN YUKLENECEK", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtT.Text = eskiM;
                        txtT.ForeColor = Color.Black;

                    }
                    else
                    {
                        MessageBox.Show("LÜTFEN METİN GİRİN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    txtT.Text = saveM.Substring(saveM.Length-1/2);
                    txtT.ForeColor = Color.Black;
                    kelimeAyir(true, saveM);
                    saveTxtV = 0;
                    saveTxt.Text = "0";
                }

            }
        }

        private void sentence_Click(object sender, EventArgs e)
        {
            sentenceFormcs dosyaListele = new sentenceFormcs();
            dosyaListele.StartPosition = FormStartPosition.Manual;
            dosyaListele.Left = this.Left;
            dosyaListele.Top = this.Top;
            dosyaListele.Show();
            this.Hide();
        }
    }
}
