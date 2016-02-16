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
            this.comboBox_RequestType = new System.Windows.Forms.ComboBox();
            this.label_comboBoxRequestType = new System.Windows.Forms.Label();
            this.label_comboBoxMetricType = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_Criteria = new System.Windows.Forms.GroupBox();
            this.comboBox_ProjectState = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_clearConsole = new System.Windows.Forms.Button();
            this.label_ProjectState = new System.Windows.Forms.Label();
            this.textBox_Top = new System.Windows.Forms.TextBox();
            this.label_Top = new System.Windows.Forms.Label();
            this.textBox_Skip = new System.Windows.Forms.TextBox();
            this.label_Skip = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_Criteria.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Console
            // 
            this.textBox_Console.Location = new System.Drawing.Point(12, 318);
            this.textBox_Console.Multiline = true;
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Console.Size = new System.Drawing.Size(845, 259);
            this.textBox_Console.TabIndex = 0;
            // 
            // label_Console
            // 
            this.label_Console.AutoSize = true;
            this.label_Console.Location = new System.Drawing.Point(12, 297);
            this.label_Console.Name = "label_Console";
            this.label_Console.Size = new System.Drawing.Size(48, 13);
            this.label_Console.TabIndex = 1;
            this.label_Console.Text = "Console:";
            // 
            // button_SendRequest
            // 
            this.button_SendRequest.Location = new System.Drawing.Point(766, 262);
            this.button_SendRequest.Name = "button_SendRequest";
            this.button_SendRequest.Size = new System.Drawing.Size(91, 23);
            this.button_SendRequest.TabIndex = 2;
            this.button_SendRequest.Text = "SendRequest";
            this.button_SendRequest.UseVisualStyleBackColor = true;
            this.button_SendRequest.Click += new System.EventHandler(this.button_SendRequest_Click);
            // 
            // comboBox_RequestType
            // 
            this.comboBox_RequestType.FormattingEnabled = true;
            this.comboBox_RequestType.Items.AddRange(new object[] {
            "Projects",
            "Project",
            "Changesets",
            "Changeset"});
            this.comboBox_RequestType.Location = new System.Drawing.Point(87, 9);
            this.comboBox_RequestType.Name = "comboBox_RequestType";
            this.comboBox_RequestType.Size = new System.Drawing.Size(147, 21);
            this.comboBox_RequestType.TabIndex = 3;
            this.comboBox_RequestType.SelectedValueChanged += new System.EventHandler(this.comboBox_RequestType_SelectedValueChanged);
            // 
            // label_comboBoxRequestType
            // 
            this.label_comboBoxRequestType.AutoSize = true;
            this.label_comboBoxRequestType.Location = new System.Drawing.Point(6, 12);
            this.label_comboBoxRequestType.Name = "label_comboBoxRequestType";
            this.label_comboBoxRequestType.Size = new System.Drawing.Size(73, 13);
            this.label_comboBoxRequestType.TabIndex = 4;
            this.label_comboBoxRequestType.Text = "Request type:";
            // 
            // label_comboBoxMetricType
            // 
            this.label_comboBoxMetricType.AutoSize = true;
            this.label_comboBoxMetricType.Location = new System.Drawing.Point(6, 13);
            this.label_comboBoxMetricType.Name = "label_comboBoxMetricType";
            this.label_comboBoxMetricType.Size = new System.Drawing.Size(62, 13);
            this.label_comboBoxMetricType.TabIndex = 5;
            this.label_comboBoxMetricType.Text = "Metric type:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(845, 248);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_Criteria);
            this.tabPage1.Controls.Add(this.label_comboBoxRequestType);
            this.tabPage1.Controls.Add(this.comboBox_RequestType);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(837, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TFS Requests";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox_Criteria
            // 
            this.groupBox_Criteria.Controls.Add(this.textBox_Id);
            this.groupBox_Criteria.Controls.Add(this.label_Id);
            this.groupBox_Criteria.Controls.Add(this.label_Skip);
            this.groupBox_Criteria.Controls.Add(this.textBox_Skip);
            this.groupBox_Criteria.Controls.Add(this.label_Top);
            this.groupBox_Criteria.Controls.Add(this.textBox_Top);
            this.groupBox_Criteria.Controls.Add(this.label_ProjectState);
            this.groupBox_Criteria.Controls.Add(this.comboBox_ProjectState);
            this.groupBox_Criteria.Location = new System.Drawing.Point(9, 36);
            this.groupBox_Criteria.Name = "groupBox_Criteria";
            this.groupBox_Criteria.Size = new System.Drawing.Size(822, 180);
            this.groupBox_Criteria.TabIndex = 6;
            this.groupBox_Criteria.TabStop = false;
            this.groupBox_Criteria.Text = "Criteria";
            // 
            // comboBox_ProjectState
            // 
            this.comboBox_ProjectState.FormattingEnabled = true;
            this.comboBox_ProjectState.Items.AddRange(new object[] {
            "WellFormed",
            "CreatePending",
            "Deleting",
            "New",
            "All"});
            this.comboBox_ProjectState.Location = new System.Drawing.Point(78, 13);
            this.comboBox_ProjectState.Name = "comboBox_ProjectState";
            this.comboBox_ProjectState.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ProjectState.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_comboBoxMetricType);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(837, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Metrics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_clearConsole
            // 
            this.button_clearConsole.Location = new System.Drawing.Point(782, 583);
            this.button_clearConsole.Name = "button_clearConsole";
            this.button_clearConsole.Size = new System.Drawing.Size(75, 23);
            this.button_clearConsole.TabIndex = 7;
            this.button_clearConsole.Text = "Clear";
            this.button_clearConsole.UseVisualStyleBackColor = true;
            this.button_clearConsole.Click += new System.EventHandler(this.button_clearConsole_Click);
            // 
            // label_ProjectState
            // 
            this.label_ProjectState.AutoSize = true;
            this.label_ProjectState.Location = new System.Drawing.Point(6, 16);
            this.label_ProjectState.Name = "label_ProjectState";
            this.label_ProjectState.Size = new System.Drawing.Size(66, 13);
            this.label_ProjectState.TabIndex = 6;
            this.label_ProjectState.Text = "Project state";
            // 
            // textBox_Top
            // 
            this.textBox_Top.Location = new System.Drawing.Point(78, 41);
            this.textBox_Top.Name = "textBox_Top";
            this.textBox_Top.Size = new System.Drawing.Size(121, 20);
            this.textBox_Top.TabIndex = 7;
            // 
            // label_Top
            // 
            this.label_Top.AutoSize = true;
            this.label_Top.Location = new System.Drawing.Point(44, 44);
            this.label_Top.Name = "label_Top";
            this.label_Top.Size = new System.Drawing.Size(26, 13);
            this.label_Top.TabIndex = 8;
            this.label_Top.Text = "Top";
            // 
            // textBox_Skip
            // 
            this.textBox_Skip.Location = new System.Drawing.Point(78, 67);
            this.textBox_Skip.Name = "textBox_Skip";
            this.textBox_Skip.Size = new System.Drawing.Size(121, 20);
            this.textBox_Skip.TabIndex = 9;
            // 
            // label_Skip
            // 
            this.label_Skip.AutoSize = true;
            this.label_Skip.Location = new System.Drawing.Point(42, 70);
            this.label_Skip.Name = "label_Skip";
            this.label_Skip.Size = new System.Drawing.Size(28, 13);
            this.label_Skip.TabIndex = 10;
            this.label_Skip.Text = "Skip";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(54, 100);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(16, 13);
            this.label_Id.TabIndex = 11;
            this.label_Id.Text = "Id";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(78, 97);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(261, 20);
            this.textBox_Id.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 611);
            this.Controls.Add(this.button_clearConsole);
            this.Controls.Add(this.label_Console);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button_SendRequest);
            this.Controls.Add(this.textBox_Console);
            this.Name = "MainForm";
            this.Text = "Defect finder";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox_Criteria.ResumeLayout(false);
            this.groupBox_Criteria.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Console;
        private System.Windows.Forms.Label label_Console;
        private System.Windows.Forms.Button button_SendRequest;
        private System.Windows.Forms.ComboBox comboBox_RequestType;
        private System.Windows.Forms.Label label_comboBoxRequestType;
        private System.Windows.Forms.Label label_comboBoxMetricType;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_clearConsole;
        private System.Windows.Forms.ComboBox comboBox_ProjectState;
        private System.Windows.Forms.GroupBox groupBox_Criteria;
        private System.Windows.Forms.Label label_Skip;
        private System.Windows.Forms.TextBox textBox_Skip;
        private System.Windows.Forms.Label label_Top;
        private System.Windows.Forms.TextBox textBox_Top;
        private System.Windows.Forms.Label label_ProjectState;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Id;
    }
}

