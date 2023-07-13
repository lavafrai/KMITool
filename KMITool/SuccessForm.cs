namespace KMITool
{
    public partial class SuccessForm : Form
    {
        String link;

        public SuccessForm(String link)
        {
            this.link = link;
            InitializeComponent();

            this.LinkTextBox.Text = link;
        }

        private void onOpenClick(object sender, EventArgs e)
        {
            this.Hide();
            System.Diagnostics.Process.Start("explorer", link);
            this.Close();
        }

        private void onCopyClick(object sender, EventArgs e)
        {
            this.Hide();
            Clipboard.SetText(this.link);
            this.Close();
        }
    }
}