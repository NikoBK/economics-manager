namespace economics_manager
{

    public enum Page
    {
        Menu,
        Income,
        Outcome,
        EditIncome,
        EditOutcome,
        AddIncome,
        AddOutcome
    }

    public partial class Form1 : Form
    {
        public Page CurrentPage { get; private set; }
        private bool noListBoxContent = false;

        List<string> Income = new List<string>();
        List<string> Outcome = new List<string>();

        public Form1()
        {
            InitializeComponent();
            CurrentPage = Page.Menu;

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
            EditButton.Enabled = false;
            AddButton.Enabled = true;
            DispatchPageListBox(Income.ToArray(), "income", true);
            CurrentPage = Page.Income;
        }

        private void OutcomeButton_Click(object sender, EventArgs e)
        {
            EditButton.Enabled = false;
            AddButton.Enabled = true;
            DispatchPageListBox(Outcome.ToArray(), "outcome", true);
            CurrentPage = Page.Outcome;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditButton.Enabled = false;
            if (CurrentPage == Page.Income) {
                CurrentPage = Page.EditIncome;
            } else if (CurrentPage == Page.Outcome) {
                CurrentPage = Page.EditOutcome;
            } else {
                return;
            }

            DispatchPageListBox(new string[] {}, "", false);
            DispatchEditScreen(true);
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
            } else {
                noListBoxContent = false;
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

            switch (CurrentPage)
            {
                case Page.AddIncome:
                    Income.Add($"{NameInputTextBox.Text}, {ValueInputTextBox.Text}, {DueDateTimePicker.Text}.");
                    DispatchPageListBox(Income.ToArray(), "income", true);
                    CurrentPage = Page.Income;
                    break;

                default:
                    MessageBox.Show("Something went wrong..");
                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string label = "";
            if (CurrentPage == Page.Income) {
                CurrentPage = Page.AddIncome;
                label = "Add Income";
            } else if (CurrentPage == Page.Outcome) {
                CurrentPage = Page.AddOutcome;
                label = "Add Outcome";
            } else {
                return;
            }

            DispatchPageListBox(null, "", false);
            DispatchEditScreen(true);
            CurrentPageLabel.Text = label;
        }
    }
}