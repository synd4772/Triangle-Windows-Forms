using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle.Core.Enums;

namespace Triangle.Logic.Number
{
    public class Sides: Vector3
    {
        private Vector3Type Type { get { return Vector3Type.Sides; } }

        public Sides(double a, double b, double c) : base(a, b, c) { }

    }
}
