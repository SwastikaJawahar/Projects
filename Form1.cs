namespace Wordgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frm_Menu menuForm = new frm_Menu();
            menuForm.Show();
            this.Hide();
        }
    }
}