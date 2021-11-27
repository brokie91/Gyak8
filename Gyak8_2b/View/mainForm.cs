using Gyak8_2b.Model;
using Gyak8_2b.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak8_2b
{
    public partial class mainForm : Form
    {
        private DiakStorage diakStorage = new DiakStorage();
        private List<DiakControl> diakControls = new List<DiakControl>();
        public mainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void InitUI()
        {
            //listBoxDiakok inicializálása
            listBoxDiakok.Items.Clear();

            //ListBox feltöltése
            for(int i = 0; i < diakStorage.Count; i++)
            {
                listBoxDiakok.Items.Add(diakStorage[i].RovidToString());
            }

            //Születési évek meghatározása
            List<int> szuletesiEvek = new List<int>();
            for(int i = 0; i < diakStorage.Count; i++)
            {
                if (!szuletesiEvek.Contains(diakStorage[i].SzuletesiEv))
                {
                    szuletesiEvek.Add(diakStorage[i].SzuletesiEv);
                }
            }

            //Gombok megjelenítése
            int gombokSzama = szuletesiEvek.Count;
            int gombokKozottiHely = 10;
            //Születési évek listájának növekvő sorba rendezése
            szuletesiEvek.Sort((a,b) => a.CompareTo(b));
            for(int i = 0; i < gombokSzama; i++)
            {               
                diakControls.Add(new DiakControl(panelEvek, gombokKozottiHely, i, szuletesiEvek[i], listBoxEredmeny, diakStorage));
            }
        }

        private bool FileBeolvas()
        {
            try
            {
                DialogResult selected = openFileDialog1.ShowDialog();
                if (selected == DialogResult.OK)
                {
                    diakStorage.FilebolOlvas(openFileDialog1.FileName, new DiakListParser());

                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fájl olvasási hiba!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {

            if (FileBeolvas())
            {
                InitUI();
            }
        }

        private void listBoxDiakok_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxDiakok.SelectedIndex;
            lbDiakAdatok.Text = diakStorage[index].ToString();
        }
    }
}
