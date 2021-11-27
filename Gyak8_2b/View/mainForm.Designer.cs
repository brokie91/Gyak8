namespace Gyak8_2b
{
    partial class mainForm
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
            this.listBoxDiakok = new System.Windows.Forms.ListBox();
            this.lbDiakok = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEvek = new System.Windows.Forms.Panel();
            this.listBoxEredmeny = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbDiakAdatok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDiakok
            // 
            this.listBoxDiakok.FormattingEnabled = true;
            this.listBoxDiakok.Location = new System.Drawing.Point(12, 40);
            this.listBoxDiakok.Name = "listBoxDiakok";
            this.listBoxDiakok.Size = new System.Drawing.Size(194, 264);
            this.listBoxDiakok.TabIndex = 0;
            this.listBoxDiakok.SelectedIndexChanged += new System.EventHandler(this.listBoxDiakok_SelectedIndexChanged);
            // 
            // lbDiakok
            // 
            this.lbDiakok.AutoSize = true;
            this.lbDiakok.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDiakok.ForeColor = System.Drawing.Color.Firebrick;
            this.lbDiakok.Location = new System.Drawing.Point(66, 10);
            this.lbDiakok.Name = "lbDiakok";
            this.lbDiakok.Size = new System.Drawing.Size(72, 27);
            this.lbDiakok.TabIndex = 1;
            this.lbDiakok.Text = "Diákok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Születési év";
            // 
            // panelEvek
            // 
            this.panelEvek.AutoScroll = true;
            this.panelEvek.BackColor = System.Drawing.Color.Bisque;
            this.panelEvek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEvek.Location = new System.Drawing.Point(239, 40);
            this.panelEvek.Name = "panelEvek";
            this.panelEvek.Size = new System.Drawing.Size(359, 72);
            this.panelEvek.TabIndex = 3;
            // 
            // listBoxEredmeny
            // 
            this.listBoxEredmeny.FormattingEnabled = true;
            this.listBoxEredmeny.Location = new System.Drawing.Point(239, 131);
            this.listBoxEredmeny.Name = "listBoxEredmeny";
            this.listBoxEredmeny.Size = new System.Drawing.Size(362, 173);
            this.listBoxEredmeny.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "A keresés eredménye:";
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(63, 323);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 6;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbDiakAdatok
            // 
            this.lbDiakAdatok.AutoSize = true;
            this.lbDiakAdatok.Location = new System.Drawing.Point(236, 323);
            this.lbDiakAdatok.Name = "lbDiakAdatok";
            this.lbDiakAdatok.Size = new System.Drawing.Size(0, 13);
            this.lbDiakAdatok.TabIndex = 7;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(613, 357);
            this.Controls.Add(this.lbDiakAdatok);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxEredmeny);
            this.Controls.Add(this.panelEvek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDiakok);
            this.Controls.Add(this.listBoxDiakok);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDiakok;
        private System.Windows.Forms.Label lbDiakok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEvek;
        private System.Windows.Forms.ListBox listBoxEredmeny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbDiakAdatok;
    }
}

