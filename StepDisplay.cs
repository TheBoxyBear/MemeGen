using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemeGen
{
    public partial class StepDisplay : UserControl
    {
        public Image Image { get; }
        public string Caption { get; }

        public StepDisplay() { }
        public StepDisplay(Image image, string caption)
        {
            InitializeComponent();
            Image = image;
            Caption = caption;

            Height = tableCaption.Height = pbImage.Height = (int)Math.Round(Image.Height / (decimal)Image.Width * pbImage.Width);

            pbImage.Location = new Point { X = 0, Y = 0 };
            tableCaption.Location = new Point { X = 300, Y = 0 };

            pbImage.Image = Image = image;
            lblCaption.Text = Caption = caption;
        }
    }
}
