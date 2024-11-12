using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tr = Triangle.Logic.Triangle;
using Triangle.Logic.Number;
using System.Security.Cryptography.X509Certificates;
using Triangle.Forms.XmlForm;

namespace Triangle
{
    public partial class Form1: Form
    {
        Button Button { get; set; }
        public tr.Triangle Triangle { get; set; }
        ListView ListView { get; set; }
        List<ListViewItem> Items { get; set; }
        public Panel DrawPanel { get; set; }
        List<TextBox> SidesTextBoxes { get; set; }
        List<Label> SidesTextBoxesLabels { get; set; }
        List<TextBox> AnglesTextBoxes { get; set; }
        List<Label> AnglesTextBoxesLabels { get; set; }
        private XmlTabelForm XmlTableForm { get; set; }

        public int LabelsWidth { get; private set; } = 100;
        public int StartAnglesTextBoxesX { get; private set; } = 90;
        public int FormWidth { get; private set; } = 800;
        public int FormHeight { get; private set; } = 400;
        public int StartTextBoxesLocationY { get; private set; } = 270;
        public int TextBoxesHeight { get; private set; } = 20;
        public int SpaceBetweenTextBoxes { get; private set; } = 20;

    }
}
