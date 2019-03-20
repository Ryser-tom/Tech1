using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Triangle
{
    class Triangle
    {
        public double _SIDE1;
        public double _SIDE2;
        public double _SIDE3;

        public List<double> _SIDES = new List<double>();

        public Triangle(double s1, double s2, double s3)
        {
            this._SIDE1 = s1;
            this._SIDE2 = s2;
            this._SIDE3 = s3;
            SetSides();
        }
        private void SetSides()
        {
            this._SIDES.Add(this._SIDE1);
            this._SIDES.Add(this._SIDE2);
            this._SIDES.Add(this._SIDE3);
        }
        public Triangle SetSideLenghts(double s1, double s2, double s3)
        {
            this._SIDE1 = s1;
            this._SIDE2 = s2;
            this._SIDE3 = s3;
            SetSides();
            return this;
        }
        public string GetSideLengths()
        {
            return string.Format("{0}, {1}, {2}", this._SIDE1, this._SIDE2, this._SIDE3);
        }
        
    }
}
