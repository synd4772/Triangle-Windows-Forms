using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle.Core.Enums;

namespace Triangle.Logic.Number
{
    public class Angles: Vector3
    {
        public new Vector3Type Vector3Type { get {
                return Vector3Type.Angles;
            } }

        public Angles(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }
    }
}
