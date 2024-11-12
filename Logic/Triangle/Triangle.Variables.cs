using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Triangle.Core.Enums;
using Triangle.Logic.Number;

namespace Triangle.Logic.Triangle
{
    public partial class Triangle
    {
        [XmlElement("Sides")]
        public Sides Sides { get; set; }
        [XmlElement("Angles")]
        public Angles Angles { get; set; }
        public bool ExistTriangle
        {
            get
            {
                if ((Sides.A > Sides.B + Sides.C) && (Sides.B > Sides.A + Sides.C) && (Sides.C > Sides.A + Sides.B)) return false;
                else return true;
            }
        }
       
        public double Height { get
            {
                return this._getTriangleHeight(this.Sides.A);
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

        public double TriangleSquare { get
            {
                return this._getTriangleSquare();
            }
        }


    }
}
