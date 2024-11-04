using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
