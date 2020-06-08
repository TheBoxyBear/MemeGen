using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MemeGen
{
    public partial class frmSettings : Form
    {
        List<StepControl> steps = new List<StepControl>();

        public frmSettings()
        {
            InitializeComponent();
            AddStep();
        }

        private void btnAddNew_Click(object sender, EventArgs e) => AddStep();
        private void AddStep()
        {
            StepControl step = new StepControl((ushort)steps.Count);
            RowStyle style = new RowStyle(SizeType.AutoSize);

            if (steps.Count > 0)
            {
                tableSteps.RowCount += 1;
                tableSteps.RowStyles.Add(style);
            }
            else
                tableSteps.RowStyles[0] = style;

            tableSteps.Controls.Add(step, 0, steps.Count);
            steps.Add(step);

            if (steps.Count == ushort.MaxValue)
                btnAddNew.Visible = false;

            btnRemoveLast.Visible = true;
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            StepControl step = steps[steps.Count - 1];

            tableSteps.Controls.Remove(step);
            tableSteps.RowStyles.RemoveAt(tableSteps.RowStyles.Count - 1);
            tableSteps.RowCount -= 1;

            steps.Remove(step);

            if (steps.Count == 1)
                btnRemoveLast.Visible = false;

            btnAddNew.Visible = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            frmMeme f;

            List<(Image, string)> extractedSteps = new List<(Image, string)>();

            foreach (StepControl step in steps)
            {
                Image image;

                try { image = Image.FromFile(step.ImagePath); }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image", $"Error loading image {step.ImagePath}: {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                extractedSteps.Add((image, step.Caption));
            }

            f = new frmMeme(extractedSteps);
            f.ShowDialog();
        }
    }
}
