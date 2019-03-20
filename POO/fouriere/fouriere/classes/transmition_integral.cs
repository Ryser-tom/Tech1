using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fouriere.classes
{
    public class transmition_integral : quatres_roues
    {
        private int transmition;

        public transmition_integral(int transmition)
        {
            this.transmition = transmition;
        }
        public override void Accept(visiteur.vehicleVisiteur V)
        {
            V.visit(this);
        }
    }
}
