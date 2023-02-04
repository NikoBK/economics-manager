namespace economics_manager
{
    partial class Form1
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
            this.IncomeButton = new System.Windows.Forms.Button();
            this.OutcomeButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CurrentPagePanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.ValueInputTextBox = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.NameInputTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CurrentPageLabel = new System.Windows.Forms.Label();
            this.PageListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CurrentPagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IncomeButton
            // 
            this.IncomeButton.Location = new System.Drawing.Point(12, 12);
            this.IncomeButton.Name = "IncomeButton";
            this.IncomeButton.Size = new System.Drawing.Size(116, 33);
            this.IncomeButton.TabIndex = 0;
            this.IncomeButton.Text = "Income";
            this.IncomeButton.UseVisualStyleBackColor = true;
            this.IncomeButton.Click += new System.EventHandler(this.IncomeButton_Click);
            // 
            // OutcomeButton
            // 
            this.OutcomeButton.Location = new System.Drawing.Point(12, 51);
            this.OutcomeButton.Name = "OutcomeButton";
            this.OutcomeButton.Size = new System.Drawing.Size(116, 33);
            this.OutcomeButton.TabIndex = 1;
            this.OutcomeButton.Text = "Outcome";
            this.OutcomeButton.UseVisualStyleBackColor = true;
            this.OutcomeButton.Click += new System.EventHandler(this.OutcomeButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(12, 90);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(116, 33);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CurrentPagePanel
            // 
            this.CurrentPagePanel.Controls.Add(this.okButton);
            this.CurrentPagePanel.Controls.Add(this.DueDateLabel);
            this.CurrentPagePanel.Controls.Add(this.ValueInputTextBox);
            this.CurrentPagePanel.Controls.Add(this.ValueLabel);
            this.CurrentPagePanel.Controls.Add(this.NameInputTextBox);
            this.CurrentPagePanel.Controls.Add(this.NameLabel);
            this.CurrentPagePanel.Controls.Add(this.DueDateTimePicker);
            this.CurrentPagePanel.Controls.Add(this.CurrentPageLabel);
            this.CurrentPagePanel.Controls.Add(this.PageListBox);
            this.CurrentPagePanel.Location = new System.Drawing.Point(134, 12);
            this.CurrentPagePanel.Name = "CurrentPagePanel";
            this.CurrentPagePanel.Size = new System.Drawing.Size(419, 286);
            this.CurrentPagePanel.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(341, 251);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 32);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Location = new System.Drawing.Point(16, 96);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(58, 15);
            this.DueDateLabel.TabIndex = 7;
            this.DueDateLabel.Text = "Due Date:";
            // 
            // ValueInputTextBox
            // 
            this.ValueInputTextBox.Location = new System.Drawing.Point(245, 57);
            this.ValueInputTextBox.Name = "ValueInputTextBox";
            this.ValueInputTextBox.Size = new System.Drawing.Size(112, 23);
            this.ValueInputTextBox.TabIndex = 6;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(245, 39);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(38, 15);
            this.ValueLabel.TabIndex = 5;
            this.ValueLabel.Text = "Value:";
            // 
            // NameInputTextBox
            // 
            this.NameInputTextBox.Location = new System.Drawing.Point(16, 57);
            this.NameInputTextBox.Name = "NameInputTextBox";
            this.NameInputTextBox.Size = new System.Drawing.Size(161, 23);
            this.NameInputTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(16, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            // 
            // DueDateTimePicker
            // 
            this.DueDateTimePicker.Location = new System.Drawing.Point(16, 114);
            this.DueDateTimePicker.Name = "DueDateTimePicker";
            this.DueDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.DueDateTimePicker.TabIndex = 2;
            // 
            // CurrentPageLabel
            // 
            this.CurrentPageLabel.AutoSize = true;
            this.CurrentPageLabel.Location = new System.Drawing.Point(3, 9);
            this.CurrentPageLabel.Name = "CurrentPageLabel";
            this.CurrentPageLabel.Size = new System.Drawing.Size(107, 15);
            this.CurrentPageLabel.TabIndex = 1;
            this.CurrentPageLabel.Text = "Current Page Label";
            // 
            // PageListBox
            // 
            this.PageListBox.FormattingEnabled = true;
            this.PageListBox.ItemHeight = 15;
            this.PageListBox.Location = new System.Drawing.Point(0, 27);
            this.PageListBox.Name = "PageListBox";
            this.PageListBox.Size = new System.Drawing.Size(419, 259);
            this.PageListBox.TabIndex = 0;
            this.PageListBox.SelectedIndexChanged += new System.EventHandler(this.PageListBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(12, 129);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(116, 33);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CurrentPagePanel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OutcomeButton);
            this.Controls.Add(this.IncomeButton);
            this.Name = "Form1";
            this.Text = "Economics Manager";
            this.CurrentPagePanel.ResumeLayout(false);
            this.CurrentPagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button IncomeButton;
        private Button OutcomeButton;
        private Button EditButton;
        private Panel CurrentPagePanel;
        private ListBox PageListBox;
        private Label CurrentPageLabel;
        private Button okButton;
        private Label DueDateLabel;
        private TextBox ValueInputTextBox;
        private Label ValueLabel;
        private TextBox NameInputTextBox;
        private Label NameLabel;
        private DateTimePicker DueDateTimePicker;
        private Button AddButton;
    }
}