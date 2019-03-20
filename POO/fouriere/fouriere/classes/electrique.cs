using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fouriere.classes
{
    public class electrique : velo
    {
        private int puissance_KW;

        public electrique(int puissance_KW, bool panier)
            : base(panier)
        {
            this.puissance_KW = puissance_KW;
        }
        public string ToString()
        {
            return "vélo éléctrique " + base.ToString() + "avec une puissance de " + puissance_KW + " KW" + Environment.NewLine;
        }
        public override void Accept(visiteur.vehicleVisiteur V)
        {
            V.visit(this);
        }
    }
}
