namespace loginatubaw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox.Checked && TxtPass.UseSystemPasswordChar == true)
            {
                TxtPass.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPass.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "admin" && TxtPass.Text == "0000")
            {
                Home form2 = new Home();
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
