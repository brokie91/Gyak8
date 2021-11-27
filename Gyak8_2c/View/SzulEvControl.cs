using Gyak8_2c.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak8_2c.View
{
    internal class SzulEvControl
    {
        //Elhelyezésre szolgáló változók
        const int gombSzelesseg = 75;
        const int gombMagassag = 23;
        int xKulonbseg;
        int yKulonbseg;

        ListBox talalatok;
        DiakStorage diakLista;

        private Button szulEv;

        public SzulEvControl(Panel container, int kulonbseg, int sorszam, int ev, ListBox keresesEredmenye, DiakStorage diakok)
        {
            this.xKulonbseg = (gombSzelesseg + kulonbseg) * sorszam;
            this.yKulonbseg = (gombMagassag + kulonbseg) * sorszam;

            //Gomb beállítása
            szulEv = new Button();
            szulEv.Text = ev.ToString();

            if (sorszam != 1 && sorszam % 2 != 0)
            {
                szulEv.Location = new Point(10 + xKulonbseg, 15 + yKulonbseg);
            }
            else
            {
                szulEv.Location = new Point(10 + xKulonbseg, 15);
            }

            talalatok = keresesEredmenye;
            diakLista = diakok;

            szulEv.Click += SzulEv_Click;

            container.Controls.Add(szulEv);
        }

        private void SzulEv_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < diakLista.Count; i++)
            {
                if (diakLista[i].SzuletesiEv == int.Parse(Text))
                {
                    talalatok.Items.Add(diakLista[i].RovidToString());
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
