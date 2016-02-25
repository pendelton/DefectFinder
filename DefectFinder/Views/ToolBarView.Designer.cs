namespace DefectFinder.Views
{
    partial class ToolbarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolbarView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonSettings = new System.Windows.Forms.ToolStripButton();
            this.buttonData = new System.Windows.Forms.ToolStripButton();
            this.buttonStart = new System.Windows.Forms.ToolStripButton();
            this.buttonTrash = new System.Windows.Forms.ToolStripButton();
            this.buttonFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSettings,
            this.buttonData,
            this.buttonStart,
            this.buttonTrash,
            this.buttonFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(665, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonSettings
            // 
            this.buttonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(23, 22);
            this.buttonSettings.Text = "toolStripButton1";
            // 
            // buttonData
            // 
            this.buttonData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonData.Image = ((System.Drawing.Image)(resources.GetObject("buttonData.Image")));
            this.buttonData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(23, 22);
            this.buttonData.Text = "toolStripButton2";
            // 
            // buttonStart
            // 
            this.buttonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonStart.Image")));
            this.buttonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(23, 22);
            this.buttonStart.Text = "toolStripButton3";
            // 
            // buttonTrash
            // 
            this.buttonTrash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonTrash.Image = ((System.Drawing.Image)(resources.GetObject("buttonTrash.Image")));
            this.buttonTrash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonTrash.Name = "buttonTrash";
            this.buttonTrash.Size = new System.Drawing.Size(23, 22);
            this.buttonTrash.Text = "toolStripButton4";
            // 
            // buttonFilter
            // 
            this.buttonFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonFilter.Image = ((System.Drawing.Image)(resources.GetObject("buttonFilter.Image")));
            this.buttonFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(23, 22);
            this.buttonFilter.Text = "toolStripButton5";
            // 
            // ToolbarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "ToolbarView";
            this.Size = new System.Drawing.Size(665, 25);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonSettings;
        private System.Windows.Forms.ToolStripButton buttonData;
        private System.Windows.Forms.ToolStripButton buttonStart;
        private System.Windows.Forms.ToolStripButton buttonTrash;
        private System.Windows.Forms.ToolStripButton buttonFilter;
    }
}
