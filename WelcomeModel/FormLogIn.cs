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
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxUsername.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //database theke check korbe kun user
            //jodi passenger hoy tahole passenger er dashboard e dukbe
            //jodi....

        }
    }
}
