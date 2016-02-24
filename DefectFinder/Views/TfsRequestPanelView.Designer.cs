namespace DefectFinder.Views
{
    partial class TfsRequestPanelView
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
            this.groupBox_Criteria = new System.Windows.Forms.GroupBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Skip = new System.Windows.Forms.Label();
            this.textBox_Skip = new System.Windows.Forms.TextBox();
            this.label_Top = new System.Windows.Forms.Label();
            this.textBox_Top = new System.Windows.Forms.TextBox();
            this.label_ProjectState = new System.Windows.Forms.Label();
            this.comboBox_ProjectState = new System.Windows.Forms.ComboBox();
            this.label_comboBoxRequestType = new System.Windows.Forms.Label();
            this.comboBox_RequestType = new System.Windows.Forms.ComboBox();
            this.groupBox_Criteria.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox_Criteria.Location = new System.Drawing.Point(10, 32);
            this.groupBox_Criteria.Name = "groupBox_Criteria";
            this.groupBox_Criteria.Size = new System.Drawing.Size(822, 180);
            this.groupBox_Criteria.TabIndex = 9;
            this.groupBox_Criteria.TabStop = false;
            this.groupBox_Criteria.Text = "Criteria";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(78, 97);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(261, 20);
            this.textBox_Id.TabIndex = 12;
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
            // label_Skip
            // 
            this.label_Skip.AutoSize = true;
            this.label_Skip.Location = new System.Drawing.Point(42, 70);
            this.label_Skip.Name = "label_Skip";
            this.label_Skip.Size = new System.Drawing.Size(28, 13);
            this.label_Skip.TabIndex = 10;
            this.label_Skip.Text = "Skip";
            // 
            // textBox_Skip
            // 
            this.textBox_Skip.Location = new System.Drawing.Point(78, 67);
            this.textBox_Skip.Name = "textBox_Skip";
            this.textBox_Skip.Size = new System.Drawing.Size(121, 20);
            this.textBox_Skip.TabIndex = 9;
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
            // textBox_Top
            // 
            this.textBox_Top.Location = new System.Drawing.Point(78, 41);
            this.textBox_Top.Name = "textBox_Top";
            this.textBox_Top.Size = new System.Drawing.Size(121, 20);
            this.textBox_Top.TabIndex = 7;
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
            // label_comboBoxRequestType
            // 
            this.label_comboBoxRequestType.AutoSize = true;
            this.label_comboBoxRequestType.Location = new System.Drawing.Point(7, 8);
            this.label_comboBoxRequestType.Name = "label_comboBoxRequestType";
            this.label_comboBoxRequestType.Size = new System.Drawing.Size(73, 13);
            this.label_comboBoxRequestType.TabIndex = 8;
            this.label_comboBoxRequestType.Text = "Request type:";
            // 
            // comboBox_RequestType
            // 
            this.comboBox_RequestType.FormattingEnabled = true;
            this.comboBox_RequestType.Items.AddRange(new object[] {
            "Projects",
            "Project",
            "Changesets",
            "Changeset"});
            this.comboBox_RequestType.Location = new System.Drawing.Point(88, 5);
            this.comboBox_RequestType.Name = "comboBox_RequestType";
            this.comboBox_RequestType.Size = new System.Drawing.Size(147, 21);
            this.comboBox_RequestType.TabIndex = 7;
            // 
            // TfsRequestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Criteria);
            this.Controls.Add(this.label_comboBoxRequestType);
            this.Controls.Add(this.comboBox_RequestType);
            this.Name = "TfsRequestPanel";
            this.Size = new System.Drawing.Size(842, 226);
            this.groupBox_Criteria.ResumeLayout(false);
            this.groupBox_Criteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Criteria;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Skip;
        private System.Windows.Forms.TextBox textBox_Skip;
        private System.Windows.Forms.Label label_Top;
        private System.Windows.Forms.TextBox textBox_Top;
        private System.Windows.Forms.Label label_ProjectState;
        private System.Windows.Forms.ComboBox comboBox_ProjectState;
        private System.Windows.Forms.Label label_comboBoxRequestType;
        private System.Windows.Forms.ComboBox comboBox_RequestType;
    }
}
