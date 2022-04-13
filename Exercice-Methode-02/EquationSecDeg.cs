using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Methode_02
{
    public struct EquationSecDeg
    {
        public double A, B, C;

        //public bool Resoudre(out double? X1, out double? X2) {
        //    double delta = (B * B) - (4 * A * C);
        //    X1 = X2 = null;
        //    if (delta < 0 ) return false;
        //    if (delta == 0) {
        //        X2 = X1 = CalculX();
        //    }
        //    if (delta > 0) {
        //        double root = Math.Sqrt(delta);
        //        X1 = CalculX(-root);
        //        X2 = CalculX(root);
        //    }
        //    return true;
        //}

        public bool Resoudre(out double? X1, out double? X2)
        {
            double delta = (B * B) - (4 * A * C);
            X1 = X2 = null;
            if (delta < 0) return false;
            double root =(delta > 0)?Math.Sqrt(delta): 0;
            X1 = CalculX(-root);
            X2 = CalculX(root);
            return true;
        }

        public double CalculX(double sqrtDelta = 0) {
            return (-B + sqrtDelta) / (2 * A);
        }
    }
}
