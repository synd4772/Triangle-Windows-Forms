using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangle.Logic.Number;

namespace Triangle
{
    public partial class Form1: Form
    {
        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

    // Масштабирование для улучшения видимости треугольника
    float scale = 50.0f;

    // Задаем первую точку (начало) треугольника
    PointF p1 = new PointF(100, 200);

    // Вторая точка - конец стороны B, лежит горизонтально вправо от p1
    PointF p2 = new PointF(
        p1.X + (float)(this.Triangle.Sides.C * scale),
        p1.Y
    );

    // Вычисляем третью точку p3 на основе угла между сторонами
    double angle = Math.PI * this.Triangle.Angles.B / 180.0; // угол напротив стороны A
    PointF p3 = new PointF(
        p1.X + (float)(this.Triangle.Sides.C * Math.Cos(angle) * scale),
        p1.Y - (float)(this.Triangle.Sides.C * Math.Sin(angle) * scale)
    );

    // Рисуем треугольник
    g.DrawLine(Pens.Black, p1, p2);
    g.DrawLine(Pens.Black, p2, p3);
    g.DrawLine(Pens.Black, p3, p1);

    // Отображаем длины сторон
    g.DrawString($"A: {this.Triangle.Sides.A}", new Font("Arial", 10), Brushes.Black, p1);
    g.DrawString($"B: {this.Triangle.Sides.B}", new Font("Arial", 10), Brushes.Black, p2);
    g.DrawString($"C: {this.Triangle.Sides.C}", new Font("Arial", 10), Brushes.Black, (p3.X + p1.X) / 2, (p3.Y + p1.Y) / 2);
        }
    }
}
