using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangle.Logic.Triangle;
using tr = Triangle.Logic.Triangle;
using Triangle.Logic.Number;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this._initAll();
            
            this.Controls.Add(Button);
            Triangle = new tr.Triangle(new Sides(5, 6, 3), new Angles(90, 50, 40));

            this.Controls.Add(ListView);
            for (int i = 0; i < 3; i++)
            {
                this.Controls.Add(this.AnglesTextBoxes[i]);
                this.Controls.Add(this.AnglesTextBoxesLabels[i]);
                this.Controls.Add(this.SidesTextBoxes[i]);
                this.Controls.Add(this.SidesTextBoxesLabels[i]);
            }
        }
    }
}
