using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Triangle.Logic.Number;

namespace Triangle.Logic.Triangle
{
    public partial class Triangle
    {
        public double Perimeter()
        {
            double p = 0;
            p = Sides.A + Sides.B + Sides.C;
            return p;
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (Sides.A + Sides.B + Sides.C) / 2;
            s = Math.Sqrt(p * (p - Sides.A) * (p - Sides.B) * (p - Sides.C));
            return s;
        }

        private double _getTriangleHeight(double bySide)
        {
            Vector3 vect1 = this.Sides as Vector3;
            Vector3 vect2 = this.Angles as Vector3;
            if(this.TriangleTypeBySide == Core.Enums.TriangleTypeBySide.Equilateral) { 
                double h = (this.Sides.A * Math.Sqrt(3)) / 2;
                return h;
            }
            else if(this.TrinagleTypeByAngle == Core.Enums.TriangleTypeByAngle.Right){
                int index = -1;
                double? side = null;
                foreach (double x in this.Angles.newList)
                {
                    index++;
                    if (x == 90)
                    {
                        side = this.Sides.newList[index];
                        return side.Value;
                    }
                }
            }
            else if ( this.TriangleTypeBySide == Core.Enums.TriangleTypeBySide.Isosceles || this.TriangleTypeBySide == Core.Enums.TriangleTypeBySide.Scalene && vect2.DoesArrayHaveAllNumbers())
            {
                double S = this._getTriangleSquare();
                return (2 * S) / bySide; 
            }
            return 0;
        }
        private double _getTriangleSquare()
        {
            if (this.TriangleTypeBySide != Core.Enums.TriangleTypeBySide.Equilateral)
            {
                double pp = this.Perimeter() / 2;
                double S = Math.Sqrt(pp * (pp - this.Sides.A) * (pp - this.Sides.B) * (pp - this.Sides.C));
                return S;
            }
            else
            {
                return (this.Sides.A * this.Sides.A * Math.Sqrt(3)) / 4;
            }
        }
    }
}
