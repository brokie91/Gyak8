using Gyak8_2c.Model;
using Gyak8_2c.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak8_2c
{
    public partial class mainForm : Form
    {
        private DiakStorage diakStorage = new DiakStorage();
        private List<int> pontHatarStorage = new List<int>();
        private List<PontHatarControl> pontHatarControls = new List<PontHatarControl>();
        private List<SzulEvControl> szulEvControls = new List<SzulEvControl>();

        int[,] pontHatarok = new int[6, 2];
        public mainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            btnAdatbevitel.Enabled = true;
            btnKereses.Enabled = false;
            btnZhIras.Enabled = false;

            //Ponthatárok megjelenítése
            PontBeolvas();
            int osztalyzatokSzama = 6; //A feladatban valamiért 6 osztályzat van.
            int segedvaltozo = 0;
            for (int i = 0; i < osztalyzatokSzama; i++)
            {
                pontHatarControls.Add(new PontHatarControl(panelPonthatarok, 30*segedvaltozo, pontHatarok[i, 0], pontHatarok[i, 1]));
                segedvaltozo++;
            }
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            if (FileBeolvas())
            {
                InitUI();
            }
        }

        private void InitUI()
        {
            //Inicializálás
            btnAdatbevitel.Enabled = false;
            btnKereses.Enabled = true;
            btnZhIras.Enabled = true;

            listBoxDiakok.Items.Clear();
            panelSzulEv.Controls.Clear();
            listBoxEredmeny.Items.Clear();

            //Kell a Diákok ListBox feltöltésére külön osztály? Nem hiszem

            List<Diak> diakNevsorrend = new List<Diak>();
            for (int i = 0; i < diakStorage.Count; i++)
            {
                diakNevsorrend.Add(diakStorage[i]);
            }

            diakNevsorrend.Sort((o1, o2) => (o1.Nev.CompareTo(o2.Nev)));

            for (int i = 0; i < diakStorage.Count; i++)
            {
                listBoxDiakok.Items.Add(diakNevsorrend[i].RovidToString());
            }

            //Évszámos gombok létrehozása
            //1. Születési évek meghatározása
            List<int> evSzamok = new List<int>();
            for(int i = 0; i < diakStorage.Count; i++)
            {
                if (!evSzamok.Contains(diakStorage[i].SzuletesiEv))
                {
                    evSzamok.Add(diakStorage[i].SzuletesiEv);
                }
            }

            //Gombok létrehozása a panelSzulEv-be
            int sorszam = 1;
            for(int i = 0; i < evSzamok.Count; i++)
            {
                szulEvControls.Add(new SzulEvControl(panelSzulEv,10,sorszam,evSzamok[i],listBoxEredmeny,diakStorage));
                sorszam++;
            }
            
        }

        private bool PontBeolvas()
        {
            try
            {
                //Ugyan így kéne egy parser? vagy elég ha csak itt beolvasom a számokat?
                StreamReader be = new StreamReader("hatarok.txt");
                int jegyekSzama = 6;
                for(int i = 0; i < jegyekSzama; i++) //Sor
                {
                    String[] sor = be.ReadLine().Split(';');
                    for(int j = 0; j < 2; j++) //Oszlop
                    {
                        pontHatarok[i,j] = int.Parse(sor[j]);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
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
                MessageBox.Show("Fájl olvasási hiba!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return false;
        }

        private void btnZhIras_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomPont;
            for (int i = 0; i < diakStorage.Count; i++)
            {                
                randomPont = random.Next(0, 100);
                diakStorage[i].ZhtIr(randomPont);
            }
        }

        private void btnKereses_Click(object sender, EventArgs e)
        {
            listBoxEredmeny.Items.Clear();
            //Ellenőrzés, hogy melyik CheckBox van kipipálva
            List<PontHatarControl> checkedCheckBoxes = new List<PontHatarControl>();
            bool isAnyChecked = false;
            foreach(PontHatarControl doboz in pontHatarControls)
            {
                if(doboz.isChecked()){
                    checkedCheckBoxes.Add(doboz);
                    isAnyChecked = true;
                }
            }
            if (!isAnyChecked)
            {
                MessageBox.Show("Nincsen egy ponthatár sem kijelölve!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            //Számok kinyerése

            List<int> pontHatarok = new List<int>();
            for(int i = 0; i < checkedCheckBoxes.Count; i++)
            {
                String boxText = checkedCheckBoxes[i].Text;
                //Whitespace és egyéb karakterek eltávolítása
                StringBuilder sb = new StringBuilder();
                sb.Append(boxText);
                sb.Replace("%",String.Empty);
                sb.Replace(" ",String.Empty);

                String[] splitString = sb.ToString().Split('-');

                for (int j = 0; j < splitString.Length; j++)
                {
                    pontHatarok.Add(int.Parse(splitString[j]));
                }
            }

            //Szélsőértékek megkeresése
            int min = pontHatarok.Min();
            int max = pontHatarok.Max();

            //Megfelelő diákok kiírása névsorrendben
            List<Diak> diakNevsorrend = new List<Diak>();
            for(int i = 0; i < diakStorage.Count; i++)
            {
                if (min < diakStorage[i].Atlag && diakStorage[i].Atlag < max)
                {
                    diakNevsorrend.Add(diakStorage[i]);
                }
            }

            diakNevsorrend.Sort((o1, o2) => (o1.Nev.CompareTo(o2.Nev)));
            for(int i = 0; i < diakNevsorrend.Count; i++)
            {
                listBoxEredmeny.Items.Add(diakNevsorrend[i]);
            }


        }

        private void listBoxEredmeny_SelectedIndexChanged(object sender, EventArgs e)
        {
            String valami = (string)listBoxEredmeny.SelectedItem;

            String[] splitArray = valami.Split('('); //MCJZT9.PTE)
            String[] splitArray2 = splitArray[1].Split('.');
            string neptunkod = splitArray2[0];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < diakStorage.Count; i++)
            {
                if (diakStorage[i].Neptun.Equals(neptunkod))
                {
                    string segedString = diakStorage[i].ToString();                    
                    sb.Append(segedString);
                    sb.Insert(segedString.IndexOf(')')+1, Environment.NewLine);
                    lbReszletek.Text = sb.ToString();
                }
            }
        }
    }
}
