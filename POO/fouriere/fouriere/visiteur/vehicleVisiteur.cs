using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fouriere.classes;

namespace fouriere.visiteur{
    public interface vehicleVisiteur
    {
        void visit(transmition_integral integral);
        void visit(transmition_AVAR AVAR);
        void visit(moto moto);
        void visit(electrique electrique);
        void visit(bicyclette bicyclette);
    }
    public class useVisitor : vehicleVisiteur
    {
        public void visit(transmition_integral integral)
        {

        }

        public void visit(transmition_AVAR AVAR)
        {

        }

        public void visit(moto moto)
        {

        }

        public void visit(electrique electrique)
        {

        }

        public void visit(bicyclette bicyclette)
        {

        }
    }
}
