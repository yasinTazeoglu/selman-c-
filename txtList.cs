using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace kelimeAyir
{
    public partial class txtList : Form
    {
        bool kntrl = true;
        public txtList()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Both;
            listboxAdd();
            

        }
        private void text_box1_Enter(object sender, EventArgs e)
        {
           label2.Focus();
        }

        private void txtList_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (kntrl) {
                Form1 anasayfa = (Form1)Application.OpenForms["Form1"];
                anasayfa.Close();
            }
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string yol = File.ReadAllText(@"e:masaüstü\notlar\ing\" + listBox1.SelectedItem.ToString());
                label4.Text= File.ReadLines(@"e:masaüstü\notlar\ing\" + listBox1.SelectedItem.ToString()).Count().ToString();
                textBox1.Text = yol;
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Process.Start(@"e:masaüstü\notlar\ing\" + listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapın", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string silinenF = listBox1.SelectedItem.ToString();
                File.Delete(@"e:masaüstü\notlar\ing\" + listBox1.SelectedItem.ToString());
                listBox1.Items.Clear();
                listboxAdd();
                textBox1.Text = "";
                MessageBox.Show(silinenF+" dosyasi silindi", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapın", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void listboxAdd() {
            string yol = @"e:masaüstü\notlar\ing";
            string[] txtDosya = Directory.GetFiles(yol);
            foreach (string i in txtDosya)
            {
                string metin = i.Split('\\').Last();
                listBox1.Items.Add(metin);
            }
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
    }
}
