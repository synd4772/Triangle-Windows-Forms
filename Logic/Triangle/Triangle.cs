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
        public Triangle(Sides sides)
        {
            this.Sides = sides;
            
        }
        public Triangle(Sides sides, Angles angles)
        {
            this.Sides = sides;
            this.Angles = angles;
        }

        private TriangleTypeByAngle _getTriangleTypeByAngle()
        {
            List<double> angles = new List<double>()
            {
                this.Angles.A, this.Angles.B, this.Angles.C,
            };
            int acuted = 0;
            int obtuse = 0;

            foreach (double angle in angles) {
                if(angle == 90)
                {
                    return TriangleTypeByAngle.Right;
                }
                if (angle > 90)
                {
                    obtuse++;
                    continue;
                }
                acuted++;
            }
            if (obtuse == 1) return TriangleTypeByAngle.Obtuse;
            return TriangleTypeByAngle.Acute;
        }
        private TriangleTypeBySide _getTriangleTypeBySide()
        {
            List<double> doubles = new List<double>()
            {
                Sides.A, Sides.B, Sides.C
            };
            foreach(double side in doubles)
            {
                List<double> doublesCopy = new List<double>()
                {
                    Sides.A, Sides.B, Sides.C
                };
                int index = -1;
                doublesCopy.ForEach((element) =>
                {
                    index++;
                    if (element != side)
                    {
                        doublesCopy.RemoveAt(index);
                    }
                });
                if(doublesCopy.Count == 2)
                {
                    return TriangleTypeBySide.Isosceles;
                }
                else if (doublesCopy.Count == 3)
                {
                    return TriangleTypeBySide.Equilateral;
                }
            }
            return TriangleTypeBySide.Scalene;
        }
    }
}
