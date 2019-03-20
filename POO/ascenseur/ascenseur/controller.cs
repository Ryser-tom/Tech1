using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ascenseur
{
    class controller
    {
        private const int DEFAULT_POSITION_X = 12;
        private const int DEFAULT_POSITION_Y = 19;
        private const int DEFAULT_POSITION_INCREMENTATION = 10;
        private ascenseur data;

        public int CreatAscenseur(string maxEtage, string minEtage)
        {
            int parsedValueMax;
            int parsedValueMin;
            int min = Convert.ToInt32(minEtage);
            int max = Convert.ToInt32(maxEtage);

            if (maxEtage == "" && minEtage == "") {
                return 1;
            } else if (!int.TryParse(maxEtage, out parsedValueMax) && !int.TryParse(minEtage, out parsedValueMin)) {
                return 2;
            } else {
                data = new ascenseur(max, min * -1);
                return 0;
            }
        }
        public void Descendre()
        {
            int actualEtage = data.getEtage();
            int minEtage = data.getMinEtage();
            if (actualEtage * -1 != minEtage) { // ?
                data.updateEtage(actualEtage + 1);
            }
        }
        public void Monter()
        {
            int actualEtage = data.getEtage();
            int maxEtage = data.getMaxEtage();
            if (actualEtage * -1 != maxEtage) { // ?
                data.updateEtage(actualEtage - 1);
            }
        }
        public int Prendre(int nbPersonnes)
        {
            int actualPersonnes = data.getPersonnes();
            if (actualPersonnes + nbPersonnes <= 6) {
                data.updatePersonnes(actualPersonnes + nbPersonnes);
                // o is for okay
                return 0;
            } else {
                // 1 is for too much people
                return 1;
            }

        }
        public int Laisser(int nbPersonnes)
        {
            int actualPersonnes = data.getPersonnes();
            if (actualPersonnes - nbPersonnes >= 0) {
                data.updatePersonnes(actualPersonnes - nbPersonnes);
                // o is for okay
                return 0;
            } else {
                // 1 is for too much people
                return 1;
            }

        }
        public int GetActualLocation()
        {
            return data.getEtage();
        }
        public int GetMaxEtage()
        {
            return data.getMaxEtage();
        }
        public int getNbPersonnes()
        {
            return data.getPersonnes();
        }
        public void movement(int destination)
        {
            int actualEtage = data.getEtage() * -1;
            if (actualEtage != destination) {
                if (actualEtage > destination) {
                    Descendre();
                    movement(destination);
                } else {
                    Monter();
                    movement(destination);
                }
            }
        }
    }
}
