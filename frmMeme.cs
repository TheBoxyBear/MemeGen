using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemeGen
{
    public partial class frmMeme : Form
    {
        public frmMeme(ICollection<(Image, string)> steps)
        {
            InitializeComponent();

            foreach ((Image, string) step in steps)
            {
                StepDisplay display = new StepDisplay(step.Item1, step.Item2);

                RowStyle style = new RowStyle(SizeType.Absolute, display.Height);

                if (Table.Controls.Count > 0)
                {
                    Table.RowCount += 1;
                    Table.RowStyles.Add(style);
                }
                else
                    Table.RowStyles[0] = style;

                Table.Controls.Add(display, 0, Table.Controls.Count);
            }
        }
    }
}
