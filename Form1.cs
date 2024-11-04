using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        Button Button { get; set; }

        public Form1()
        {
            this.InitForm();
            this.InitButton();
            this.Controls.Add(Button);
        }

        private void InitButton()
        {
            this.Button = new Button
            {
                Text = "Запуск",
                BackColor = Color.FromArgb(255, 255, 192),
                Font = new Font("Arial", 28),
                Cursor = Cursors.Hand,

            };
            Button.Size = new Size(200, 100);
            Button.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            Button.FlatAppearance.BorderSize = 10;
            Button.FlatStyle = FlatStyle.Flat;
            Button.Location = new Point(this.ClientSize.Width / 2 - Button.Width / 2, 0);
        }

        public void InitForm()
        {
            this.ClientSize = new Size(800, 400);
            this.Text = "Работа с треугольнииком";
        }
    }
}
