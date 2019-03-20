using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class controller
    {

        private Triangle T = new Triangle(0, 0, 0);
        private List<double> _SIDES = new List<double>();
        public void SetSideLenghts(double s1, double s2, double s3){
            T = T.SetSideLenghts(Convert.ToDouble(s1), Convert.ToDouble(s2), Convert.ToDouble(s3));
        }
    public bool IsImpossible()
        {
            if (T._SIDE1 > (T._SIDE2 + T._SIDE3) || T._SIDE2 > (T._SIDE1 + T._SIDE3) || T._SIDE3 > (T._SIDE1 + T._SIDE2)) {
                return true;
            } else {
                return false;
            }
        }
        public double GetPerimeter()
        {
            if (true) {
                return T._SIDE1 + T._SIDE2 + T._SIDE3;
            } else {
                return -1;
            }
        }
        public double GetArea()
        {
            double s, area;

            if (T._SIDE2 + T._SIDE3 < T._SIDE1 || T._SIDE1 + T._SIDE3 < T._SIDE2 || T._SIDE1 + T._SIDE2 < T._SIDE3) {
                return -1.0;
            }
            s = (T._SIDE1 + T._SIDE2 + T._SIDE3) / 2;
            area = Math.Sqrt(s * (s - T._SIDE1) * (s - T._SIDE2) * (s - T._SIDE3));
            area = Math.Round(area, 2);
            return area;
        }
        public string Classify()
        {
            if (IsImpossible()) {
                return "Triangle impossible";
            } else if (IsEquilateral()) {
                return "Triangle équilatéral";
            } else if (IsIsoceles()) {
                return "Triangle isocèle";
            } else if (IsScalene()) {
                return "Triangle scalène";
            } else if (IsRightAngled()) {
                return "Triangle rectangle";
            } else {
                return "une erreur est survenue";
            }

        }
        public bool IsIsoceles()
        {
            if (T._SIDE1 == T._SIDE2 || T._SIDE2 == T._SIDE3 || T._SIDE1 == T._SIDE3) {
                return true;
            } else {
                return false;
            }
        }
        public bool IsEquilateral()
        {
            if (T._SIDE1 == T._SIDE2 && T._SIDE2 == T._SIDE3) {
                return true;
            } else {
                return false;
            }
        }
        public bool IsRightAngled()
        {
            List<double> values = new List<double>();
            T._SIDES.Sort();
            values = T._SIDES;
            if (Math.Pow(T._SIDES[0], 2) == ((Math.Pow(T._SIDES[1], 2)) + (Math.Pow(T._SIDES[2], 2)))) {
                return true;
            } else {
                return false;
            }
        }
        public bool IsScalene()
        {
            if (T._SIDE1 != T._SIDE2 && T._SIDE2 != T._SIDE3 && T._SIDE1 != T._SIDE3) {
                return true;
            } else {
                return false;
            }
        }
    }
}
