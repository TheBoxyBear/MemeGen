namespace MemeGen
{
    partial class StepControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StepControl));
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.tableImage = new System.Windows.Forms.TableLayoutPanel();
            this.txtPickImage = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.gbCaption = new System.Windows.Forms.GroupBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.ImagePicker = new System.Windows.Forms.OpenFileDialog();
            this.Table.SuspendLayout();
            this.gbImage.SuspendLayout();
            this.tableImage.SuspendLayout();
            this.gbCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.gbImage, 0, 0);
            this.Table.Controls.Add(this.gbCaption, 1, 0);
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Size = new System.Drawing.Size(493, 68);
            this.Table.TabIndex = 0;
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.tableImage);
            this.gbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbImage.Location = new System.Drawing.Point(3, 3);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(240, 62);
            this.gbImage.TabIndex = 0;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Image";
            // 
            // tableImage
            // 
            this.tableImage.ColumnCount = 2;
            this.tableImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableImage.Controls.Add(this.txtPickImage, 1, 0);
            this.tableImage.Controls.Add(this.txtImage, 0, 0);
            this.tableImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableImage.Location = new System.Drawing.Point(3, 16);
            this.tableImage.Name = "tableImage";
            this.tableImage.RowCount = 1;
            this.tableImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableImage.Size = new System.Drawing.Size(234, 43);
            this.tableImage.TabIndex = 0;
            // 
            // txtPickImage
            // 
            this.txtPickImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPickImage.Location = new System.Drawing.Point(207, 11);
            this.txtPickImage.Name = "txtPickImage";
            this.txtPickImage.Size = new System.Drawing.Size(24, 21);
            this.txtPickImage.TabIndex = 1;
            this.txtPickImage.Text = "...";
            this.txtPickImage.UseVisualStyleBackColor = true;
            this.txtPickImage.Click += new System.EventHandler(this.txtPickImage_Click);
            // 
            // txtImage
            // 
            this.txtImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImage.Location = new System.Drawing.Point(3, 11);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(198, 20);
            this.txtImage.TabIndex = 0;
            // 
            // gbCaption
            // 
            this.gbCaption.Controls.Add(this.txtCaption);
            this.gbCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCaption.Location = new System.Drawing.Point(249, 3);
            this.gbCaption.Name = "gbCaption";
            this.gbCaption.Size = new System.Drawing.Size(241, 62);
            this.gbCaption.TabIndex = 1;
            this.gbCaption.TabStop = false;
            this.gbCaption.Text = "Caption";
            // 
            // txtCaption
            // 
            this.txtCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaption.Location = new System.Drawing.Point(6, 27);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(229, 20);
            this.txtCaption.TabIndex = 0;
            // 
            // ImagePicker
            // 
            this.ImagePicker.Filter = resources.GetString("ImagePicker.Filter");
            this.ImagePicker.FileOk += new System.ComponentModel.CancelEventHandler(this.FilePicker_FileOk);
            // 
            // StepControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Table);
            this.Name = "StepControl";
            this.Size = new System.Drawing.Size(493, 68);
            this.Table.ResumeLayout(false);
            this.gbImage.ResumeLayout(false);
            this.tableImage.ResumeLayout(false);
            this.tableImage.PerformLayout();
            this.gbCaption.ResumeLayout(false);
            this.gbCaption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button txtPickImage;
        private System.Windows.Forms.TextBox txtCaption;
        public System.Windows.Forms.OpenFileDialog ImagePicker;
        private System.Windows.Forms.GroupBox gbCaption;
        private System.Windows.Forms.TableLayoutPanel tableImage;
    }
}
