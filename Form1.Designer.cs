namespace kelimeAyir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtT = new System.Windows.Forms.TextBox();
            this.bol = new System.Windows.Forms.Button();
            this.kelime = new System.Windows.Forms.Label();
            this.metin = new System.Windows.Forms.Label();
            this.wordL = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countw = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.sifila = new System.Windows.Forms.Button();
            this.wordD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveTxt = new System.Windows.Forms.Label();
            this.txtCB = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.folderList = new System.Windows.Forms.Button();
            this.sentence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtT
            // 
            this.txtT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtT.ForeColor = System.Drawing.Color.Silver;
            this.txtT.Location = new System.Drawing.Point(12, 36);
            this.txtT.Multiline = true;
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(787, 219);
            this.txtT.TabIndex = 0;
            this.txtT.Text = "METNİ BURAYA GİRİNİZ";
            this.txtT.Enter += new System.EventHandler(this.txtT_ENTER);
            this.txtT.Leave += new System.EventHandler(this.txtT_LEAVE);
            // 
            // bol
            // 
            this.bol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bol.ForeColor = System.Drawing.Color.Black;
            this.bol.Location = new System.Drawing.Point(177, 261);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(127, 35);
            this.bol.TabIndex = 1;
            this.bol.Text = "Parçala";
            this.bol.UseVisualStyleBackColor = false;
            this.bol.Click += new System.EventHandler(this.bol_Click);
            // 
            // kelime
            // 
            this.kelime.AutoSize = true;
            this.kelime.ForeColor = System.Drawing.Color.White;
            this.kelime.Location = new System.Drawing.Point(12, 282);
            this.kelime.Name = "kelime";
            this.kelime.Size = new System.Drawing.Size(64, 17);
            this.kelime.TabIndex = 3;
            this.kelime.Text = "kelimeler";
            // 
            // metin
            // 
            this.metin.AutoSize = true;
            this.metin.BackColor = System.Drawing.Color.Black;
            this.metin.ForeColor = System.Drawing.Color.White;
            this.metin.Location = new System.Drawing.Point(9, 16);
            this.metin.Name = "metin";
            this.metin.Size = new System.Drawing.Size(42, 17);
            this.metin.TabIndex = 4;
            this.metin.Text = "metin";
            // 
            // wordL
            // 
            this.wordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordL.ForeColor = System.Drawing.Color.Silver;
            this.wordL.FormattingEnabled = true;
            this.wordL.ItemHeight = 22;
            this.wordL.Location = new System.Drawing.Point(12, 302);
            this.wordL.Name = "wordL";
            this.wordL.Size = new System.Drawing.Size(425, 268);
            this.wordL.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(648, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kelime Sayısı:";
            // 
            // countw
            // 
            this.countw.AutoSize = true;
            this.countw.ForeColor = System.Drawing.Color.White;
            this.countw.Location = new System.Drawing.Point(749, 282);
            this.countw.Name = "countw";
            this.countw.Size = new System.Drawing.Size(16, 17);
            this.countw.TabIndex = 7;
            this.countw.Text = "0";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(708, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(91, 25);
            this.save.TabIndex = 8;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // sifila
            // 
            this.sifila.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sifila.ForeColor = System.Drawing.Color.Black;
            this.sifila.Location = new System.Drawing.Point(611, 5);
            this.sifila.Name = "sifila";
            this.sifila.Size = new System.Drawing.Size(91, 25);
            this.sifila.TabIndex = 9;
            this.sifila.Text = "Sıfırla";
            this.sifila.UseVisualStyleBackColor = false;
            this.sifila.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // wordD
            // 
            this.wordD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.wordD.ForeColor = System.Drawing.Color.Black;
            this.wordD.Location = new System.Drawing.Point(310, 261);
            this.wordD.Name = "wordD";
            this.wordD.Size = new System.Drawing.Size(127, 35);
            this.wordD.TabIndex = 10;
            this.wordD.Text = "Kelimeliri Sil";
            this.wordD.UseVisualStyleBackColor = false;
            this.wordD.Click += new System.EventHandler(this.wordD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(582, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kaydedilen Metin Sayısı:";
            // 
            // saveTxt
            // 
            this.saveTxt.AutoSize = true;
            this.saveTxt.ForeColor = System.Drawing.Color.White;
            this.saveTxt.Location = new System.Drawing.Point(749, 258);
            this.saveTxt.Name = "saveTxt";
            this.saveTxt.Size = new System.Drawing.Size(16, 17);
            this.saveTxt.TabIndex = 12;
            this.saveTxt.Text = "0";
            // 
            // txtCB
            // 
            this.txtCB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCB.ForeColor = System.Drawing.Color.Black;
            this.txtCB.Location = new System.Drawing.Point(532, 421);
            this.txtCB.Name = "txtCB";
            this.txtCB.Size = new System.Drawing.Size(151, 26);
            this.txtCB.TabIndex = 13;
            this.txtCB.Text = "txt Oluştur ve yaz";
            this.txtCB.UseVisualStyleBackColor = false;
            this.txtCB.Click += new System.EventHandler(this.txtCB_Click);
            // 
            // txtC
            // 
            this.txtC.ForeColor = System.Drawing.Color.Silver;
            this.txtC.Location = new System.Drawing.Point(532, 381);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(151, 22);
            this.txtC.TabIndex = 14;
            this.txtC.Text = "DOSYA İSMİ";
            this.txtC.Enter += new System.EventHandler(this.txtC_ENTER);
            this.txtC.Leave += new System.EventHandler(this.txtC_LEAVE);
            // 
            // folderList
            // 
            this.folderList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.folderList.ForeColor = System.Drawing.Color.Black;
            this.folderList.Location = new System.Drawing.Point(532, 453);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(151, 26);
            this.folderList.TabIndex = 15;
            this.folderList.Text = "Dosyalari Listele";
            this.folderList.UseVisualStyleBackColor = false;
            this.folderList.Click += new System.EventHandler(this.folderList_Click);
            // 
            // sentence
            // 
            this.sentence.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sentence.ForeColor = System.Drawing.Color.Black;
            this.sentence.Location = new System.Drawing.Point(532, 485);
            this.sentence.Name = "sentence";
            this.sentence.Size = new System.Drawing.Size(151, 26);
            this.sentence.TabIndex = 16;
            this.sentence.Text = "Cümle Bul";
            this.sentence.UseVisualStyleBackColor = false;
            this.sentence.Click += new System.EventHandler(this.sentence_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(811, 573);
            this.Controls.Add(this.sentence);
            this.Controls.Add(this.folderList);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtCB);
            this.Controls.Add(this.saveTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordD);
            this.Controls.Add(this.sifila);
            this.Controls.Add(this.save);
            this.Controls.Add(this.countw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordL);
            this.Controls.Add(this.metin);
            this.Controls.Add(this.kelime);
            this.Controls.Add(this.bol);
            this.Controls.Add(this.txtT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(829, 620);
            this.MinimumSize = new System.Drawing.Size(829, 620);
            this.Name = "Form1";
            this.Text = "Kelime Ayirma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Button bol;
        private System.Windows.Forms.Label kelime;
        private System.Windows.Forms.Label metin;
        private System.Windows.Forms.ListBox wordL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countw;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button sifila;
        private System.Windows.Forms.Button wordD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label saveTxt;
        private System.Windows.Forms.Button txtCB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button folderList;
        private System.Windows.Forms.Button sentence;
    }
}

