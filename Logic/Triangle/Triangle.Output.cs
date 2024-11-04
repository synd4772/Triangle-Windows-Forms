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
        public string OutputA()
        {
            return Convert.ToString(Sides.A);
        }
        public string OutputB()
        {
            return Convert.ToString(Sides.B);
        }
        public string OutputC()
        {
            return Convert.ToString(Sides.C);
        }
    }
}
