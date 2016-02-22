namespace DefectFinder
{
    partial class ConsoleView
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
            this.label_Console = new System.Windows.Forms.Label();
            this.textBox_Console = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Console
            // 
            this.label_Console.AutoSize = true;
            this.label_Console.Location = new System.Drawing.Point(3, 3);
            this.label_Console.Name = "label_Console";
            this.label_Console.Size = new System.Drawing.Size(48, 13);
            this.label_Console.TabIndex = 2;
            this.label_Console.Text = "Console:";
            // 
            // textBox_Console
            // 
            this.textBox_Console.Location = new System.Drawing.Point(7, 22);
            this.textBox_Console.Multiline = true;
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Console.Size = new System.Drawing.Size(484, 202);
            this.textBox_Console.TabIndex = 3;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_Console);
            this.Controls.Add(this.label_Console);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(498, 234);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Console;
        private System.Windows.Forms.TextBox textBox_Console;
    }
}
