using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fouriere.classes
{
     public class bicyclette : velo 
    {
        private bool fixie;

        public bicyclette(bool fixie, bool panier)
            : base(panier)
        {
            this.fixie = fixie;
        }
        public string ToString()
        {
            if (fixie) {
                return "bicyclette " + base.ToString() + " est un fixie " + Environment.NewLine;
            } else {
                return "bicyclette " + base.ToString() + "n'est pas un fixie " + Environment.NewLine;
            }
           
        }
        public override void Accept(visiteur.vehicleVisiteur V)
        {
            V.visit(this);
        }
    }
}
