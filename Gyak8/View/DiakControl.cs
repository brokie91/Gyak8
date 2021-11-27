using Gyak8.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak8.View
{
    class DiakControl
    {
        //Elhelyezésre szolgáló változók
        private const int hallgatoX = 20;
        private const int hallgatoY = 25;
        
        private CheckBox hallgato;

        #region Model
        private Diak diak;
        #endregion
        public DiakControl(Panel container, int y, Diak diak)
        {
            this.diak = diak;

            //CheckBox beállítása
            hallgato = new CheckBox();
            hallgato.Text = getData();
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

        public string getData()
        {
            return diak.RovidToString();
        }

        public Diak getDiak()
        {
            return this.diak;
        }
    }
}
