namespace Gyak8_2c
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
            this.lbDiakok = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDiakok = new System.Windows.Forms.ListBox();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.btnZhIras = new System.Windows.Forms.Button();
            this.panelPonthatarok = new System.Windows.Forms.Panel();
            this.panelSzulEv = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxEredmeny = new System.Windows.Forms.ListBox();
            this.btnKereses = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbReszletek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDiakok
            // 
            this.lbDiakok.AutoSize = true;
            this.lbDiakok.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDiakok.ForeColor = System.Drawing.Color.Firebrick;
            this.lbDiakok.Location = new System.Drawing.Point(41, 21);
            this.lbDiakok.Name = "lbDiakok";
            this.lbDiakok.Size = new System.Drawing.Size(72, 27);
            this.lbDiakok.TabIndex = 2;
            this.lbDiakok.Text = "Diákok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(464, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Születési év";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(243, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ponthatárok";
            // 
            // listBoxDiakok
            // 
            this.listBoxDiakok.FormattingEnabled = true;
            this.listBoxDiakok.Location = new System.Drawing.Point(12, 51);
            this.listBoxDiakok.Name = "listBoxDiakok";
            this.listBoxDiakok.Size = new System.Drawing.Size(170, 290);
            this.listBoxDiakok.TabIndex = 5;
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(12, 357);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 6;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // btnZhIras
            // 
            this.btnZhIras.Location = new System.Drawing.Point(107, 357);
            this.btnZhIras.Name = "btnZhIras";
            this.btnZhIras.Size = new System.Drawing.Size(75, 23);
            this.btnZhIras.TabIndex = 7;
            this.btnZhIras.Text = "Zh írás";
            this.btnZhIras.UseVisualStyleBackColor = true;
            this.btnZhIras.Click += new System.EventHandler(this.btnZhIras_Click);
            // 
            // panelPonthatarok
            // 
            this.panelPonthatarok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPonthatarok.Location = new System.Drawing.Point(212, 51);
            this.panelPonthatarok.Name = "panelPonthatarok";
            this.panelPonthatarok.Size = new System.Drawing.Size(179, 290);
            this.panelPonthatarok.TabIndex = 8;
            // 
            // panelSzulEv
            // 
            this.panelSzulEv.AutoScroll = true;
            this.panelSzulEv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSzulEv.Location = new System.Drawing.Point(427, 51);
            this.panelSzulEv.Name = "panelSzulEv";
            this.panelSzulEv.Size = new System.Drawing.Size(179, 68);
            this.panelSzulEv.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "A keresés eredménye:";
            // 
            // listBoxEredmeny
            // 
            this.listBoxEredmeny.FormattingEnabled = true;
            this.listBoxEredmeny.Location = new System.Drawing.Point(427, 168);
            this.listBoxEredmeny.Name = "listBoxEredmeny";
            this.listBoxEredmeny.Size = new System.Drawing.Size(179, 173);
            this.listBoxEredmeny.TabIndex = 11;
            this.listBoxEredmeny.SelectedIndexChanged += new System.EventHandler(this.listBoxEredmeny_SelectedIndexChanged);
            // 
            // btnKereses
            // 
            this.btnKereses.Location = new System.Drawing.Point(259, 357);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(75, 23);
            this.btnKereses.TabIndex = 12;
            this.btnKereses.Text = "Keresés";
            this.btnKereses.UseVisualStyleBackColor = true;
            this.btnKereses.Click += new System.EventHandler(this.btnKereses_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbReszletek
            // 
            this.lbReszletek.AutoSize = true;
            this.lbReszletek.Location = new System.Drawing.Point(427, 357);
            this.lbReszletek.Name = "lbReszletek";
            this.lbReszletek.Size = new System.Drawing.Size(0, 13);
            this.lbReszletek.TabIndex = 13;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(621, 394);
            this.Controls.Add(this.lbReszletek);
            this.Controls.Add(this.btnKereses);
            this.Controls.Add(this.listBoxEredmeny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelSzulEv);
            this.Controls.Add(this.panelPonthatarok);
            this.Controls.Add(this.btnZhIras);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.listBoxDiakok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDiakok);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDiakok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDiakok;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Button btnZhIras;
        private System.Windows.Forms.Panel panelPonthatarok;
        private System.Windows.Forms.Panel panelSzulEv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxEredmeny;
        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbReszletek;
    }
}

