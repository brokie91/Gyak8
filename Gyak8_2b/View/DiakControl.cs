using Gyak8_2b.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak8_2b.View
{
    internal class DiakControl
    {
        //Elhelyezésre szolgáló változók
        const int gombSzelesseg = 75;
        const int gombMagassag = 23;
        int xKulonbseg;

        ListBox talatok;
        DiakStorage diakLista;

        private Button szulEv;

        public DiakControl(Panel container, int kulonbseg, int sorszam, int ev, ListBox keresesEredmenye, DiakStorage diakok) //Megfelelő a sorszám használata? Hogyan lehetne másképp?
        {
            this.xKulonbseg = (gombSzelesseg + kulonbseg)*sorszam;

            //Gomb beállítása
            szulEv = new Button();
            szulEv.Text = ev.ToString();
            szulEv.Location = new Point(10+xKulonbseg,15);

            talatok = keresesEredmenye;
            diakLista = diakok;

            szulEv.Click += SzulEv_Click;

            container.Controls.Add(szulEv);
        }

        private void SzulEv_Click(object sender, EventArgs e)
        {
            talatok.Items.Clear();
            for(int i = 0; i < diakLista.Count; i++)
            {
                if (diakLista[i].SzuletesiEv == int.Parse(Text))
                {
                    talatok.Items.Add(diakLista[i].RovidToString());
                }
            }
        }

        public string Text
        {
            get
            {
                return szulEv.Text;
            }
        }
    }
}
