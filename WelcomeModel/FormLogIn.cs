namespace TravelEase
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUserName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxUserName.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            if (!checkBox1.Checked)
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
}
