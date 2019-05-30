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
    public partial class LineForm : Form
    {
        public Color color;
        public float width;

        public LineForm()
        {
            InitializeComponent();

            color = Color.Black;
            width = 5.0F;
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            if (colorDialogLine.ShowDialog() == DialogResult.Cancel) return;

            color = colorDialogLine.Color;
        }
    }
}
