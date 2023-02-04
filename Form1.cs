namespace economics_manager
{
    public partial class Form1 : Form
    {
        private bool noListBoxContent = false;

        public Form1()
        {
            InitializeComponent();
            CurrentPagePanel.Visible = false;

            NameLabel.Visible = false;
            ValueLabel.Visible = false;
            DueDateLabel.Visible = false;

            NameInputTextBox.Visible = false;
            ValueInputTextBox.Visible = false;
            DueDateTimePicker.Visible = false;

            okButton.Visible = false;
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            string[] income = { };
            DispatchPageListBox(income, "income", true);
        }

        private void OutcomeButton_Click(object sender, EventArgs e)
        {
            string[] outcome = { };
            DispatchPageListBox(outcome, "outcome", true);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DispatchPageListBox(null, "", false);
            DispatchEditScreen(true);
            EditButton.Enabled = false;
        }

        private void PageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!noListBoxContent) {
                EditButton.Enabled = true;
            }
        }

        public void DispatchPageListBox(string[] content, string label, bool visible)
        {
            if (!CurrentPagePanel.Visible) {
                CurrentPagePanel.Visible = true;
            }

            CurrentPageLabel.Text = $"All monthly {label}:";

            PageListBox.Items.Clear();
            PageListBox.Visible = visible;

            if (content != null) {
                PageListBox.Items.AddRange(content);
            }

            if (PageListBox.Items.Count == 0) {
                noListBoxContent = true;
                PageListBox.Items.Add($"No monthly {label} found...");
            }
        }

        public void DispatchEditScreen(bool visible)
        {
            NameLabel.Visible       = visible;
            ValueLabel.Visible      = visible;
            DueDateLabel.Visible    = visible;
            NameInputTextBox.Visible    = visible;
            ValueInputTextBox.Visible   = visible;
            DueDateTimePicker.Visible   = visible;
            okButton.Visible = visible;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DispatchEditScreen(false);
            EditButton.Enabled = false;
        }
    }
}