using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1: Form
    {

        private void _initAll()
        {
            this._initForm();
            this._initButton();
            this._initListView();
            this._initSidesTextBoxes();
            this._initAnglesTextBoxes();
        }

        private void _initButton()
        {
            this.Button = new Button
            {
                Text = "Start",
                BackColor = Color.FromArgb(255, 255, 192),
                Font = new Font("Arial", 28),
                Cursor = Cursors.Hand,

            };
            Button.Size = new Size(200, 100);
            Button.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            Button.FlatAppearance.BorderSize = 10;
            Button.FlatStyle = FlatStyle.Flat;
            Button.Location = new Point(this.ClientSize.Width - Button.Width - 100, 50);
            Button.Click += this.onButtonClick;
        }

        private void _initForm()
        {
            this.ClientSize = new Size(this.FormWidth, this.FormHeight);
            this.Text = "Работа с треугольнииком";
        }
        
        private void _initListView()
        {
            ListViewItem item1 = new ListViewItem("Pool - \"A\"", 0);
            ListViewItem item2 = new ListViewItem("Pool - \"B\"", 1);
            ListViewItem item3 = new ListViewItem("Pool - \"С\"", 0);
            ListViewItem item4 = new ListViewItem("Nurk - \"A\"", 1);
            ListViewItem item5 = new ListViewItem("Nurk - \"B\"", 0);
            ListViewItem item6 = new ListViewItem("Nurk - \"C\"", 1);
            ListViewItem item7 = new ListViewItem("Kas kolmnurk on olemas", 0);
            ListViewItem item8 = new ListViewItem("Kolmnurga tüüp külgedel", 1);
            ListViewItem item9 = new ListViewItem("Kolmnurga tüüp nurkade järgi", 0);
            ListViewItem item10 = new ListViewItem("Kolmnurga pindala", 1);
            ListViewItem item11 = new ListViewItem("Kolmnurga kõrgus", 0);
 
            ListViewItem item12 = new ListViewItem("Perimeeter", 1);



            Items = new List<ListViewItem>()
            {
                item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12
            };
            ListView = new ListView();
            ListView.Bounds = new Rectangle(new Point(20, 20), new Size(390, 230));
            ListView.Columns.Add("Väli", -2, HorizontalAlignment.Left);
            ListView.Columns.Add("Tähendus", -2, HorizontalAlignment.Left);
            foreach(ListViewItem item in Items)
            {
                ListView.Items.Add(item);
            }
            ListView.View = View.Details;

        }
        private void _initSidesTextBoxes()
        {
            this.SidesTextBoxes = new List<TextBox>()
            {
                this._returnNewTextBox("txtA"),
                this._returnNewTextBox("txtB"),
                this._returnNewTextBox("txtC")
            };
            int y = this.StartTextBoxesLocationY;
            foreach (TextBox textBox in this.SidesTextBoxes)
            {
                textBox.Location = new Point(this.StartAnglesTextBoxesX + 195, y);
                y += this.SpaceBetweenTextBoxes + textBox.Height;
            }
            this._initSidesTextBoxesLabels();
        }
        private void _initAnglesTextBoxes()
        {
            this.AnglesTextBoxes = new List<TextBox>()
            {
                this._returnNewTextBox("txtAngleA"),
                this._returnNewTextBox("txtAngleB"),
                this._returnNewTextBox("txtAngleC")
            };
            int y = this.StartTextBoxesLocationY;
            foreach(TextBox textBox in this.AnglesTextBoxes)
            {
                textBox.Location = new Point(this.StartAnglesTextBoxesX, y);
                y += this.SpaceBetweenTextBoxes + textBox.Height;
            }
            this._initAnglesTextBoxesLabels();
        }

        private TextBox _returnNewTextBox(string name)
        {
            TextBox textBox = new TextBox();
            this._initTextBox(textBox);
            textBox.Name = name;
            return textBox;
        }

        private void _initTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Arial", 12);
            textBox.AutoSize = false;
            textBox.Size = new Size(120, this.TextBoxesHeight);
        }

        private void _initSidesTextBoxesLabels()
        {
            this.SidesTextBoxesLabels = new List<Label>()
            {
                this._returnNewLabel("Side A:"),
                this._returnNewLabel("Side B:"),
                this._returnNewLabel("Side C:")
            };
            int y = this.StartTextBoxesLocationY;
            foreach (Label label in this.SidesTextBoxesLabels)
            {
                label.Location = new Point(220, y);
                y += this.SpaceBetweenTextBoxes + label.Height;
            }
        }
        private void _initAnglesTextBoxesLabels()
        {
            this.AnglesTextBoxesLabels = new List<Label>()
            {
                this._returnNewLabel("Angle A:"),
                this._returnNewLabel("Angle B:"),
                this._returnNewLabel("Angle C:")
            };
            int y = this.StartTextBoxesLocationY;
            foreach (Label label in this.AnglesTextBoxesLabels)
            {
                label.Location = new Point(20, y);
                y += this.SpaceBetweenTextBoxes + label.Height;
            }
        }

        private Label _returnNewLabel(string text)
        {
            Label label = new Label();
            this._initLabel(label);
            label.Text = text;
            return label;

        }
        private void _initLabel(Label label)
        {
            label.Font = new Font("Arial", 12);
            label.Size = new Size(this.LabelsWidth, TextBoxesHeight);
        }

    }
}
