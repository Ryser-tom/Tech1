using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fouriere.visiteur;

namespace fouriere.classes
{
    public class velo : deux_roues
    {
        private bool panier;

        public velo(bool panier)
        {
            this.panier = panier;
        }

        public string ToString()
        {
            if (panier) {
                return "avec un panier ";
            } else {
                return "sans panier ";
            }
        }
        public override void Accept(vehicleVisiteur V)
        {
            throw new NotImplementedException();
        }
    }
}
