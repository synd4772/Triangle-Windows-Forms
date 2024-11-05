using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tr = Triangle.Logic.Triangle;
using Triangle.Logic.Number;

namespace Triangle
{
    public partial class Form1: Form
    {
        private void onButtonClick(object sender, EventArgs e)
        {
            Sides sides = new Sides(double.Parse(this.SidesTextBoxes[0].Text), double.Parse(this.SidesTextBoxes[1].Text), double.Parse(this.SidesTextBoxes[2].Text));
            Angles angles = new Angles(double.Parse(this.AnglesTextBoxes[0].Text), double.Parse(this.AnglesTextBoxes[1].Text), double.Parse(this.AnglesTextBoxes[2].Text));
            tr.Triangle triangle = new tr.Triangle(sides, angles);
        }
    }
}
