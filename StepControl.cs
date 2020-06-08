using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MemeGen
{
    public partial class StepControl : UserControl
    {
        public ushort StepNumber { get; set; }
        public string ImagePath => txtImage.Text;
        public string Caption => txtCaption.Text;

        public StepControl(ushort stepNumber)
        {
            InitializeComponent();
            StepNumber = stepNumber;
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void txtPickImage_Click(object sender, EventArgs e) => ImagePicker.ShowDialog();

        private void FilePicker_FileOk(object sender, CancelEventArgs e) => txtImage.Text = ImagePicker.FileName;
    }
}
