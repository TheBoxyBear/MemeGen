namespace MemeGen
{
    partial class StepDisplay
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCaption = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tableCaption = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tableCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(113, 87);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(73, 25);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "Caption";
            // 
            // pbImage
            // 
            this.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(300, 200);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // tableCaption
            // 
            this.tableCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableCaption.AutoScroll = true;
            this.tableCaption.ColumnCount = 1;
            this.tableCaption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCaption.Controls.Add(this.lblCaption, 0, 0);
            this.tableCaption.Location = new System.Drawing.Point(300, 0);
            this.tableCaption.Name = "tableCaption";
            this.tableCaption.RowCount = 1;
            this.tableCaption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCaption.Size = new System.Drawing.Size(300, 200);
            this.tableCaption.TabIndex = 3;
            // 
            // StepDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableCaption);
            this.Controls.Add(this.pbImage);
            this.Name = "StepDisplay";
            this.Size = new System.Drawing.Size(600, 203);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tableCaption.ResumeLayout(false);
            this.tableCaption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TableLayoutPanel tableCaption;
    }
}
