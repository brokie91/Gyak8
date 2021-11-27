using Gyak8.Model;
using Gyak8.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace Gyak8
{
    
    public partial class mainForm : Form
    {
        private DiakStorage diakStorage = new DiakStorage();
        private List<DiakControl> diakControls = new List<DiakControl>();

        private const int yKulonbseg = 25;

        public mainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnKivalasztas.Enabled = false;

        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            if (FileBeolvas())
            {
                btnAdatbevitel.Enabled = false;
                btnKivalasztas.Enabled = true;
                InitUI();
                //Kell vajon ResetUI-hoz hasonló metódus?
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
                MessageBox.Show("Fájl olvasási hiba!","Figyelem!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return false;
        }

        private void InitUI()
        {
            int sorokSzama = 0;
            panelDiakok.Controls.Clear();
            for(int i = 0; i < diakStorage.Count; i++)
            {
                diakControls.Add(
                    new DiakControl(
                        panelDiakok,
                        sorokSzama * yKulonbseg,
                        diakStorage[i]
                    )
                );

                sorokSzama++;
            }
        }

        private void btnKivalasztas_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Diak> kivalasztottak = new List<Diak>();
            int pipakSzama = 0;
            foreach(DiakControl ctrl in diakControls)
            {
                if (ctrl.isChecked())
                {
                    kivalasztottak.Add(ctrl.getDiak());
                    listBox1.Items.Add(ctrl.getData());
                    pipakSzama++;
                }
            }
            if (pipakSzama == 0)
            {
                MessageBox.Show("Válasszon ki valakit!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            legidosebb(kivalasztottak);
        }

        private void legidosebb(List<Diak> kivalasztottak)
        {
            //Legidősebb megtalálása
            int min = 0;
            for(int i = 0; i < kivalasztottak.Count; i++)
            {
                if (kivalasztottak[min].SzuletesiEv > kivalasztottak[i].SzuletesiEv)
                {
                    min = i;
                }
            }
            //Mindenkit kiírok a listába, aki ezzel a születési évvel rendelkezik
            for(int i = 0; i < kivalasztottak.Count; i++)
            {
                if (kivalasztottak[min].SzuletesiEv == kivalasztottak[i].SzuletesiEv)
                {
                    listLegidosebbek.Clear();
                    listLegidosebbek.Items.Add(kivalasztottak[i].RovidToString());
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Megkeresem a listában, a kiválasztott elem adatai alapján a megfelelő diákot
            String valami = (string)listBox1.SelectedItem;

            String[] splitArray = valami.Split('('); //MCJZT9.PTE)
            String[] splitArray2 = splitArray[1].Split('.');
            string neptunkod = splitArray2[0];

            for (int i = 0; i < diakStorage.Count; i++)
            {
                if (diakStorage[i].Neptun.Equals(neptunkod))
                {
                    lbLegidosebb.Text = diakStorage[i].ToString();
                }
            }
        }
    }
}
