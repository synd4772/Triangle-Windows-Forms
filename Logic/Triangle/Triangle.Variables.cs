using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle.Core.Enums;
using Triangle.Logic.Number;

namespace Triangle.Logic.Triangle
{
    public partial class Triangle
    {
        public Sides Sides { get; set; }
        public Angles Angles { get; set; }
        public bool ExistTriangle
        {
            get
            {
                if ((Sides.A > Sides.B + Sides.C) && (Sides.B > Sides.A + Sides.C) && (Sides.C > Sides.A + Sides.B)) return false;
                else return true;
            }
        }
        public TriangleTypeBySide TriangleTypeBySide
        {
            get
            {
                return this._getTriangleTypeBySide();
            }
        }
        public TriangleTypeByAngle TrinagleTypeByAngle
        {
            get
            {
                return this._getTriangleTypeByAngle();
            }
        }

    }
}
