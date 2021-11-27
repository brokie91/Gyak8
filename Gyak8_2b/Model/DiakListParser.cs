using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak8_2b.Model
{
    class DiakListParser : IDiakParser
    {
        public List<Diak> Parse(string multiLineText)
        {
            List<Diak> betoltott = new List<Diak>();

            string[] sorok = multiLineText.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            );

            foreach (var sor in sorok)
            {
                string[] szavak = sor.Split(';');

                if (szavak.Length == 3)
                {
                    betoltott.Add(
                        new Diak(
                            szavak[0],
                            szavak[1],
                            int.Parse(szavak[2])
                        )
                    );
                }
            }

            return betoltott;
        }
    }
}
