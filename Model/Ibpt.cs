using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.Model
{
    class Ibpt
    {
        public int id { get; set; }
        public double ibptImpostoFederal { get; set; }
        public double ibptImpostoEstadual { get; set; }
        public double ibptImpostoMunicipal { get; set; }
    }
}
