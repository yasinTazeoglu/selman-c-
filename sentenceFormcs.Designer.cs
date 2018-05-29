namespace kelimeAyir
{
    partial class sentenceFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sentenceFormcs));
            this.button1 = new System.Windows.Forms.Button();
            this.sentenceWord = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sentenceList = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Anasayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sentenceWord
            // 
            this.sentenceWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sentenceWord.Location = new System.Drawing.Point(322, 35);
            this.sentenceWord.Name = "sentenceWord";
            this.sentenceWord.Size = new System.Drawing.Size(170, 26);
            this.sentenceWord.TabIndex = 1;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(368, 67);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(87, 32);
            this.search.TabIndex = 2;
            this.search.Text = "Cümle Ara";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "kelimeleri aralarina virgül koyarak yaziniz";
            // 
            // sentenceList
            // 
            this.sentenceList.Enabled = false;
            this.sentenceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sentenceList.Location = new System.Drawing.Point(12, 126);
            this.sentenceList.Multiline = true;
            this.sentenceList.Name = "sentenceList";
            this.sentenceList.Size = new System.Drawing.Size(787, 435);
            this.sentenceList.TabIndex = 4;
            this.sentenceList.TextChanged += new System.EventHandler(this.sentenceList_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(718, 31);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(97, 36);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Cumle Ekle";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // sentenceFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(811, 573);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.sentenceList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.sentenceWord);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 620);
            this.MinimumSize = new System.Drawing.Size(829, 620);
            this.Name = "sentenceFormcs";
            this.Text = "sentenceFormcs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.sentenceFormcs_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sentenceWord;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sentenceList;
        private System.Windows.Forms.Button addBtn;
    }
}