
namespace Gyak8
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
            this.lbKivalasztottak = new System.Windows.Forms.Label();
            this.panelDiakok = new System.Windows.Forms.Panel();
            this.lbLegidosebbek = new System.Windows.Forms.Label();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.btnKivalasztas = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listLegidosebbek = new System.Windows.Forms.ListView();
            this.lbLegidosebb = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbDiakok
            // 
            this.lbDiakok.AutoSize = true;
            this.lbDiakok.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDiakok.ForeColor = System.Drawing.Color.Firebrick;
            this.lbDiakok.Location = new System.Drawing.Point(85, 9);
            this.lbDiakok.Name = "lbDiakok";
            this.lbDiakok.Size = new System.Drawing.Size(72, 27);
            this.lbDiakok.TabIndex = 0;
            this.lbDiakok.Text = "Diákok";
            // 
            // lbKivalasztottak
            // 
            this.lbKivalasztottak.AutoSize = true;
            this.lbKivalasztottak.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKivalasztottak.ForeColor = System.Drawing.Color.Firebrick;
            this.lbKivalasztottak.Location = new System.Drawing.Point(306, 9);
            this.lbKivalasztottak.Name = "lbKivalasztottak";
            this.lbKivalasztottak.Size = new System.Drawing.Size(131, 27);
            this.lbKivalasztottak.TabIndex = 1;
            this.lbKivalasztottak.Text = "Kiválasztottak";
            // 
            // panelDiakok
            // 
            this.panelDiakok.AutoScroll = true;
            this.panelDiakok.BackColor = System.Drawing.Color.Bisque;
            this.panelDiakok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDiakok.Location = new System.Drawing.Point(23, 39);
            this.panelDiakok.Name = "panelDiakok";
            this.panelDiakok.Size = new System.Drawing.Size(200, 267);
            this.panelDiakok.TabIndex = 2;
            // 
            // lbLegidosebbek
            // 
            this.lbLegidosebbek.AutoSize = true;
            this.lbLegidosebbek.Location = new System.Drawing.Point(264, 197);
            this.lbLegidosebbek.Name = "lbLegidosebbek";
            this.lbLegidosebbek.Size = new System.Drawing.Size(77, 13);
            this.lbLegidosebbek.TabIndex = 4;
            this.lbLegidosebbek.Text = "Legidősebbek:";
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(23, 324);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 6;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // btnKivalasztas
            // 
            this.btnKivalasztas.Location = new System.Drawing.Point(148, 324);
            this.btnKivalasztas.Name = "btnKivalasztas";
            this.btnKivalasztas.Size = new System.Drawing.Size(75, 23);
            this.btnKivalasztas.TabIndex = 7;
            this.btnKivalasztas.Text = "Kiválasztás";
            this.btnKivalasztas.UseVisualStyleBackColor = true;
            this.btnKivalasztas.Click += new System.EventHandler(this.btnKivalasztas_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listLegidosebbek
            // 
            this.listLegidosebbek.HideSelection = false;
            this.listLegidosebbek.Location = new System.Drawing.Point(267, 213);
            this.listLegidosebbek.Name = "listLegidosebbek";
            this.listLegidosebbek.Size = new System.Drawing.Size(222, 93);
            this.listLegidosebbek.TabIndex = 9;
            this.listLegidosebbek.UseCompatibleStateImageBehavior = false;
            this.listLegidosebbek.View = System.Windows.Forms.View.List;
            // 
            // lbLegidosebb
            // 
            this.lbLegidosebb.AutoSize = true;
            this.lbLegidosebb.Location = new System.Drawing.Point(267, 324);
            this.lbLegidosebb.Name = "lbLegidosebb";
            this.lbLegidosebb.Size = new System.Drawing.Size(35, 13);
            this.lbLegidosebb.TabIndex = 10;
            this.lbLegidosebb.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(267, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 134);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(508, 369);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbLegidosebb);
            this.Controls.Add(this.listLegidosebbek);
            this.Controls.Add(this.btnKivalasztas);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.lbLegidosebbek);
            this.Controls.Add(this.panelDiakok);
            this.Controls.Add(this.lbKivalasztottak);
            this.Controls.Add(this.lbDiakok);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDiakok;
        private System.Windows.Forms.Label lbKivalasztottak;
        private System.Windows.Forms.Panel panelDiakok;
        private System.Windows.Forms.Label lbLegidosebbek;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Button btnKivalasztas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listLegidosebbek;
        private System.Windows.Forms.Label lbLegidosebb;
        private System.Windows.Forms.ListBox listBox1;
    }
}

