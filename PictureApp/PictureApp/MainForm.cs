using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureApp
{
    public partial class MainForm : Form
    {
        Point element;
        Pen pen;
        SolidBrush fill;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonLine_Click(object sender, EventArgs e)
        {
            LineForm lineForm = new LineForm();
            DialogResult result =  lineForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            element = new Line
            {
                X1 = int.Parse(lineForm.textBoxX1.Text),
                Y1 = int.Parse(lineForm.textBoxY1.Text),
                X2 = int.Parse(lineForm.textBoxX2.Text),
                Y2 = int.Parse(lineForm.textBoxY2.Text),
                Color = lineForm.color,
                Width = lineForm.width
            };

            if (lineForm.textBoxWidthLine.Text != string.Empty)
                element.Width = float.Parse(lineForm.textBoxWidthLine.Text);

            pen = new Pen(element.Color, element.Width);

            pictureBox.Refresh();
        }

        private void ButtonCircle_Click(object sender, EventArgs e)
        {
            CircleForm circleForm = new CircleForm();
            DialogResult result = circleForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            element = new Circle
            {
                X1 = int.Parse(circleForm.textBoxX.Text),
                Y1 = int.Parse(circleForm.textBoxY.Text),
                X2 = int.Parse(circleForm.textBoxWidth.Text),
                Y2 = int.Parse(circleForm.textBoxWidth.Text),
                Color = circleForm.color,
                Width = circleForm.width,              
            };

            if (circleForm.textBoxWidthLine.Text != string.Empty)
                element.Width = float.Parse(circleForm.textBoxWidthLine.Text);

            pen = new Pen(element.Color, element.Width);
            fill = new SolidBrush(circleForm.fill);

            pictureBox.Refresh();
        }

        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            SquareForm squareForm = new SquareForm();
            DialogResult result = squareForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            element = new Square
            {
                X1 = int.Parse(squareForm.textBoxX.Text),
                Y1 = int.Parse(squareForm.textBoxY.Text),
                X2 = int.Parse(squareForm.textBoxWidth.Text),
                Y2 = int.Parse(squareForm.textBoxWidth.Text),
                Color = squareForm.color,
                Width = squareForm.width,
            };

            if (squareForm.textBoxWidthLine.Text != string.Empty)
                element.Width = float.Parse(squareForm.textBoxWidthLine.Text);

            pen = new Pen(element.Color, element.Width);
            fill = new SolidBrush(squareForm.fill);

            pictureBox.Refresh();
        }

        private void ButtonTriangle_Click(object sender, EventArgs e)
        {
            TriangleForm triangleForm = new TriangleForm();
            DialogResult result = triangleForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            element = new Triangle
            {
                X1 = int.Parse(triangleForm.textBoxX1.Text),
                Y1 = int.Parse(triangleForm.textBoxY1.Text),
                X2 = int.Parse(triangleForm.textBoxX2.Text),
                Y2 = int.Parse(triangleForm.textBoxY2.Text),
                X3 = int.Parse(triangleForm.textBoxX3.Text),
                Y3 = int.Parse(triangleForm.textBoxY3.Text),
                Color = triangleForm.color,
                Width = triangleForm.width,
            };

            if (triangleForm.textBoxWidthLine.Text != string.Empty)
                element.Width = float.Parse(triangleForm.textBoxWidthLine.Text);

            pen = new Pen(element.Color, element.Width);
            fill = new SolidBrush(triangleForm.fill);

            pictureBox.Refresh();          
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (element is Line)
                e.Graphics.DrawLine(pen, new PointF(element.X1, element.Y1), new PointF(element.X2, element.Y2));
            else if (element is Circle)
            {
                e.Graphics.DrawEllipse(pen, new Rectangle(element.X1, element.Y2, element.X2, element.Y2));
                e.Graphics.FillEllipse(fill, new Rectangle(element.X1, element.Y2, element.X2, element.Y2));
            }
            else if (element is Square)
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(element.X1, element.Y2, element.X2, element.Y2));
                e.Graphics.FillRectangle(fill, new Rectangle(element.X1, element.Y2, element.X2, element.Y2));
            }
            else if (element is Triangle)
            {
                e.Graphics.DrawLine(pen, new PointF(element.X1, element.Y1), new PointF(element.X2, element.Y2));
                e.Graphics.DrawLine(pen, new PointF(element.X2, element.Y2), new PointF(element.X3, element.Y3));
                e.Graphics.DrawLine(pen, new PointF(element.X3, element.Y3), new PointF(element.X1, element.Y1));

                e.Graphics.FillPolygon(fill, new PointF[] { new PointF(element.X1, element.Y1), new PointF(element.X2, element.Y2),
                 new PointF(element.X2, element.Y2), new PointF(element.X3, element.Y3),
                new PointF(element.X3, element.Y3), new PointF(element.X1, element.Y1)});
            }
            else
                e.Graphics.Clear(Color.White);
        }
    }
}
