//using TravelEase.Resources;
using TravelEase.WelcomeModel;

namespace TravelEase
{
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }

        private string text;
        private int len = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                label2.Text += text.ElementAt(len);
                len++;
            }
            else
                timer1.Stop();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            text = label2.Text;
            label2.Text = "";
            timer1.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration(); 
            formRegistration.Show();
            this.Hide();
        }
    }
}
