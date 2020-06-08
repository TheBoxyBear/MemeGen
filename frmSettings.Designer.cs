namespace MemeGen
{
    partial class frmSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel Table;
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panSteps = new System.Windows.Forms.Panel();
            this.tableSteps = new System.Windows.Forms.TableLayoutPanel();
            this.ImageBrowser = new System.Windows.Forms.OpenFileDialog();
            Table = new System.Windows.Forms.TableLayoutPanel();
            Table.SuspendLayout();
            this.panSteps.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            Table.ColumnCount = 3;
            Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            Table.Controls.Add(this.btnRemoveLast, 0, 1);
            Table.Controls.Add(this.btnAddNew, 1, 1);
            Table.Controls.Add(this.btnGenerate, 2, 1);
            Table.Controls.Add(this.panSteps, 0, 0);
            Table.Dock = System.Windows.Forms.DockStyle.Fill;
            Table.Location = new System.Drawing.Point(0, 0);
            Table.Name = "Table";
            Table.RowCount = 2;
            Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            Table.Size = new System.Drawing.Size(414, 237);
            Table.TabIndex = 1;
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveLast.Location = new System.Drawing.Point(30, 212);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(76, 20);
            this.btnRemoveLast.TabIndex = 0;
            this.btnRemoveLast.Text = "Remove last";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNew.Location = new System.Drawing.Point(168, 212);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(76, 20);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.Location = new System.Drawing.Point(306, 212);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(76, 20);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panSteps
            // 
            this.panSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSteps.AutoScroll = true;
            Table.SetColumnSpan(this.panSteps, 3);
            this.panSteps.Controls.Add(this.tableSteps);
            this.panSteps.Location = new System.Drawing.Point(3, 3);
            this.panSteps.Name = "panSteps";
            this.panSteps.Size = new System.Drawing.Size(408, 201);
            this.panSteps.TabIndex = 3;
            // 
            // tableSteps
            // 
            this.tableSteps.AutoSize = true;
            this.tableSteps.ColumnCount = 1;
            this.tableSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSteps.Location = new System.Drawing.Point(0, 0);
            this.tableSteps.Name = "tableSteps";
            this.tableSteps.RowCount = 1;
            this.tableSteps.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSteps.Size = new System.Drawing.Size(408, 201);
            this.tableSteps.TabIndex = 0;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 237);
            this.Controls.Add(Table);
            this.Name = "frmSettings";
            this.Text = "Meme Generator";
            Table.ResumeLayout(false);
            this.panSteps.ResumeLayout(false);
            this.panSteps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ImageBrowser;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel panSteps;
        private System.Windows.Forms.TableLayoutPanel tableSteps;
    }
}
