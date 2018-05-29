namespace kelimeAyir
{
    partial class sentenceAddForm
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
            this.sentenceTxt = new System.Windows.Forms.TextBox();
            this.anasayfa = new System.Windows.Forms.Button();
            this.sentenceAddbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sentenceOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sentenceTxt
            // 
            this.sentenceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sentenceTxt.Location = new System.Drawing.Point(12, 54);
            this.sentenceTxt.Multiline = true;
            this.sentenceTxt.Name = "sentenceTxt";
            this.sentenceTxt.Size = new System.Drawing.Size(787, 507);
            this.sentenceTxt.TabIndex = 0;
            // 
            // anasayfa
            // 
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.Location = new System.Drawing.Point(714, 6);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(85, 36);
            this.anasayfa.TabIndex = 1;
            this.anasayfa.Text = "Anasayfa";
            this.anasayfa.UseVisualStyleBackColor = true;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // sentenceAddbtn
            // 
            this.sentenceAddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sentenceAddbtn.Location = new System.Drawing.Point(392, 6);
            this.sentenceAddbtn.Name = "sentenceAddbtn";
            this.sentenceAddbtn.Size = new System.Drawing.Size(100, 36);
            this.sentenceAddbtn.TabIndex = 2;
            this.sentenceAddbtn.Text = "Cumle Ekle";
            this.sentenceAddbtn.UseVisualStyleBackColor = true;
            this.sentenceAddbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cümleleriniz nokta işaretine göre ayrılacaktır";
            // 
            // sentenceOpen
            // 
            this.sentenceOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sentenceOpen.Location = new System.Drawing.Point(498, 6);
            this.sentenceOpen.Name = "sentenceOpen";
            this.sentenceOpen.Size = new System.Drawing.Size(112, 36);
            this.sentenceOpen.TabIndex = 4;
            this.sentenceOpen.Text = "Cumleleri Ac";
            this.sentenceOpen.UseVisualStyleBackColor = true;
            this.sentenceOpen.Click += new System.EventHandler(this.sentenceOpen_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(616, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cumle Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sentenceAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(811, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sentenceOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sentenceAddbtn);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.sentenceTxt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(829, 620);
            this.MinimumSize = new System.Drawing.Size(829, 620);
            this.Name = "sentenceAddForm";
            this.Text = "sentenceAddForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.sentenceAddForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sentenceTxt;
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.Button sentenceAddbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sentenceOpen;
        private System.Windows.Forms.Button button1;
    }
}