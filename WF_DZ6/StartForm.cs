namespace WF_DZ6
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ChoiseModules form = new ChoiseModules(Location);
            form.Show();
            Hide();
        }
    }
}
