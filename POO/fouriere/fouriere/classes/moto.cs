using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fouriere.classes
{
    public class moto : deux_roues
    {
        private bool bride;

        public moto(bool bride)
        {
            this.bride = bride;
        }
        public override string ToString()
        {
            if (bride) {
                return "moto bridée ";
            } else {
                return "moto non bridée ";
            }
        }
        public override void Accept(visiteur.vehicleVisiteur V)
        {
            V.visit(this);
        }
    }
}
