using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak8_2c.Model
{
    class Diak
    {
        List<int> zhEredmenyek;

        private double atlag;
        public double Atlag
        {
            get
            {
                return zhEredmenyek.Sum() / zhEredmenyek.Count();
            }
        }
        public string Nev
        {
            get; private set;
        }

        public string Neptun
        {
            get; private set;
        }

        public int SzuletesiEv
        {
            get; private set;
        }

        public Diak(string nev, string neptun_kod, int szuletesi_ev)
        {
            this.Nev = nev;
            this.Neptun = neptun_kod;
            this.SzuletesiEv = szuletesi_ev;
            zhEredmenyek = new List<int>();
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}.PTE), szül. éve: {2}, átlaga: {3}",Nev,Neptun,SzuletesiEv,Atlag);
        }

        public string RovidToString()
        {
            return String.Format("{0} ({1}.PTE)", Nev, Neptun);
        }

        public void ZhtIr(int pont)
        {
            zhEredmenyek.Add(pont);
        }
    }
}
