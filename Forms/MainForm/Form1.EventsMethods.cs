using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tr = Triangle.Logic.Triangle;
using Triangle.Logic.Number;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;
using Triangle.Logic.XMLSerializer;

namespace Triangle
{
    public partial class Form1: Form
    {
        
        private void onButtonClick(object sender, EventArgs e)
        {
            Sides sides; Angles angles;
            foreach (TextBox textBox in this.SidesTextBoxes)
            {
                if (textBox.Text == "")
                {
                    MessageBox.Show("Fill side empty boxes");
                    return;
                }
            }
            foreach(TextBox textBox in this.AnglesTextBoxes)
            {
                if (textBox.Text == "")
                {
                    MessageBox.Show("Fill angle empty boxes");
                    return;
                }
            }
            try
            {
                sides = new Sides(double.Parse(this.SidesTextBoxes[0].Text), double.Parse(this.SidesTextBoxes[1].Text), double.Parse(this.SidesTextBoxes[2].Text));
                angles = new Angles(double.Parse(this.AnglesTextBoxes[0].Text), double.Parse(this.AnglesTextBoxes[1].Text), double.Parse(this.AnglesTextBoxes[2].Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message == "invalid" ? "Angles aren't 180" : ex.Message);
                return;
            }
            
            tr.Triangle triangle = new tr.Triangle(sides, angles);
            if (Items[0].SubItems.Count >= 2)
            {
                foreach (ListViewItem item in Items)
                {
                    item.SubItems.RemoveAt(1);
                }
            }


            Items[0].SubItems.Add(sides.A.ToString());
            Items[1].SubItems.Add(sides.B.ToString());
            Items[2].SubItems.Add(sides.C.ToString());
            Items[3].SubItems.Add(angles.A.ToString());
            Items[4].SubItems.Add(angles.B.ToString());
            Items[5].SubItems.Add(angles.C.ToString());
            Items[6].SubItems.Add(triangle.ExistTriangle.ToString());
            Items[7].SubItems.Add(triangle.TriangleTypeBySide.ToString());
            Items[8].SubItems.Add(triangle.TrinagleTypeByAngle.ToString());
            Items[9].SubItems.Add(triangle.TriangleSquare.ToString());
            Items[10].SubItems.Add(triangle.Height.ToString());
            Items[11].SubItems.Add(triangle.Perimeter().ToString());

            string currentDirectory = Directory.GetCurrentDirectory();
            string path = $"{currentDirectory}..\\..\\..\\Data\\triangles-data.xml";
            List<tr.Triangle> triangles = TrianglesSerializer.DeserializeTriangles(path);
            triangles.Add(triangle);
            TrianglesSerializer.SerializeTriangles(path, triangles);
            this.DrawPanel.Invalidate();
        }
    }
}
