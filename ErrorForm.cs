namespace week_5_assignment
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string error)
        {
            InitializeComponent();
            errLbl.Text = error;
        }
    }
}
