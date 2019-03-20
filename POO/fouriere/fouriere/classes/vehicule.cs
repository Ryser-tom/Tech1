using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fouriere.classes
{
    public abstract class vehicule
    {
        public abstract void Accept(visiteur.vehicleVisiteur V);
    }
}
