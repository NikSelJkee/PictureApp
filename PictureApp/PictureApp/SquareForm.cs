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
    public partial class SquareForm : Form
    {
        public Color color;
        public Color fill;
        public float width;

        public SquareForm()
        {
            InitializeComponent();

            color = Color.Black;
            fill = Color.White;
            width = 5.0F;
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            if (colorDialogLine.ShowDialog() == DialogResult.Cancel) return;

            color = colorDialogLine.Color;
        }

        private void ButtonFill_Click(object sender, EventArgs e)
        {
            if (colorDialogFill.ShowDialog() == DialogResult.Cancel) return;

            fill = colorDialogFill.Color;
        }
    }
}
