namespace Ision
{
    public partial class Start_form : Form
    {
        public Start_form()
        {
            InitializeComponent();
        }

        private void Button_enter_Click(object sender, EventArgs e)
        {
            string? login = Convert.ToString(textBox_login);
            string? password = Convert.ToString(textBox_password);

            Login.FileCreate(login, password);
            bool result = Login.Enter(login, password);

            if (result == true)
            {
                MessageBox.Show("¬ход успешный");
            }
        }

        private void Start_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}