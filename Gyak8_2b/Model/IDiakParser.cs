using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak8_2b.Model
{
    interface IDiakParser
    {
        List<Diak> Parse(string multiLineText);
    }
}
