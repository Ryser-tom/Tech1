using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascenseur
{
    public class ascenseur
    {
        private int _etage;
        private int _minEtage;
        private int _maxEtage;
        private int _personnes;
        private int _maxPersonnes;
        private int _recordsCount;
        private int _serialID;

        public ascenseur(int maxEtage, int minEtage)
        {
            _etage = 0;
            _minEtage = minEtage;
            _maxEtage = maxEtage;
            _personnes = 0;
            _maxPersonnes = 6;
            _recordsCount = 0;
            _serialID = 0;
        }

        public void updateEtage(int etage)
        {
            this._etage = etage;
        }
        public void updatePersonnes(int personnes)
        {
            this._personnes = personnes;
        }
        public int getEtage()
        {
            return this._etage;
        }
        public int getPersonnes()
        {
            return this._personnes;
        }
        public int getMaxEtage()
        {
            return this._maxEtage;
        }
        public int getMinEtage()
        {
            return this._minEtage;
        }
    }
}
