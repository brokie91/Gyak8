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
    internal class PontHatarControl
    {
        //Elhelyezésre szolgáló változók
        private const int hallgatoX = 20;
        private const int hallgatoY = 25;

        private CheckBox hallgato;

        private Diak diak;
        public PontHatarControl(Panel container, int y, int pontMin, int pontMax)
        {
            this.diak = diak;

            //Checkbox beállítása
            hallgato = new CheckBox();
            hallgato.Text = String.Format("{0} - {1} %", pontMin, pontMax);
            hallgato.Location = new Point(hallgatoX, hallgatoY + y);
            container.Controls.Add(hallgato);
        }

        public bool isChecked()
        {
            if (this.hallgato.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Text
        {
            get
            {
                return hallgato.Text;
            }
        }
    }
}
