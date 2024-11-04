using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle.Core.Enums;

namespace Triangle.Logic
{
    public class Vector3
    {
        public Vector3Type Vector3Type { get; }
        private double[] _doubles { get; set; } = new double[3];
        public double A
        {
            get
            {
                return _doubles[0];
            }
            set
            {
                _doubles[0] = value;
            }
        }
        public double B
        {
            get
            {
                return _doubles[1];
            }
            set
            {
                _doubles[1] = value;
            }
        }
        public double C
        {
            get
            {
                return _doubles[2];
            }
            set
            {
                _doubles[2] = value;
            }
        }

    }
}
    