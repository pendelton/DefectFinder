namespace DefectFinder
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Console = new System.Windows.Forms.TextBox();
            this.label_Console = new System.Windows.Forms.Label();
            this.button_SendRequest = new System.Windows.Forms.Button();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Console
            // 
            this.textBox_Console.Location = new System.Drawing.Point(12, 162);
            this.textBox_Console.Multiline = true;
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Console.Size = new System.Drawing.Size(521, 87);
            this.textBox_Console.TabIndex = 0;
            // 
            // label_Console
            // 
            this.label_Console.AutoSize = true;
            this.label_Console.Location = new System.Drawing.Point(13, 143);
            this.label_Console.Name = "label_Console";
            this.label_Console.Size = new System.Drawing.Size(48, 13);
            this.label_Console.TabIndex = 1;
            this.label_Console.Text = "Console:";
            // 
            // button_SendRequest
            // 
            this.button_SendRequest.Location = new System.Drawing.Point(442, 133);
            this.button_SendRequest.Name = "button_SendRequest";
            this.button_SendRequest.Size = new System.Drawing.Size(91, 23);
            this.button_SendRequest.TabIndex = 2;
            this.button_SendRequest.Text = "SendRequest";
            this.button_SendRequest.UseVisualStyleBackColor = true;
            this.button_SendRequest.Click += new System.EventHandler(this.button_SendRequest_Click);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(16, 13);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(58, 13);
            this.label_Username.TabIndex = 3;
            this.label_Username.Text = "Username:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(80, 10);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(165, 20);
            this.textBox_Username.TabIndex = 4;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(18, 39);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(56, 13);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Password:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(80, 36);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(165, 20);
            this.textBox_Password.TabIndex = 6;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 261);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.button_SendRequest);
            this.Controls.Add(this.label_Console);
            this.Controls.Add(this.textBox_Console);
            this.Name = "MainForm";
            this.Text = "Defect finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Console;
        private System.Windows.Forms.Label label_Console;
        private System.Windows.Forms.Button button_SendRequest;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
    }
}

