using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak8_2b.Model
{
    class DiakStorage
    {
        private List<Diak> diakok;

        #region Elemekhez való hozzáférés
        public int Count
        {
            get { return diakok.Count; }
        }

        public Diak this[int index] //Indexer
        {
            get { return diakok[index]; }
        }

        #endregion

        public DiakStorage()
        {
            diakok = new List<Diak>();
        }

        #region Elemek hozzáadása

        public void Add(Diak ujDiak)
        {
            diakok.Add(ujDiak);
        }

        public void FilebolOlvas(string fileNev, IDiakParser parser)
        {
            diakok.Clear();

            string multilineTextInput = ""; //Sorok közötti elválasztó
            using (StreamReader sr = new StreamReader(fileNev))
            {
                multilineTextInput = sr.ReadToEnd();
            }

            diakok.AddRange(parser.Parse(multilineTextInput));
        }

        #endregion
    }
}
