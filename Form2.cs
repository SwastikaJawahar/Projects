using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordgame
{
    public partial class frm_Menu : Form
    {
        string line;
        List<string> words = new List<string>();
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_Beginner_Click(object sender, EventArgs e)
        {
            frm_Beginner menuForm = new frm_Beginner("Beginnerwords.txt");
            menuForm.Show();
            this.Hide();
            }
        private void btn_intermediate_Click(object sender, EventArgs e)
        {
            frm_Beginner menuForm = new frm_Beginner("Intermediatewords.txt");
            menuForm.Show();
            this.Hide();
        }

        private void btn_Expert_Click(object sender, EventArgs e)
        {
            frm_Beginner menuForm = new frm_Beginner("Expertwords.txt");
            menuForm.Show();
            this.Hide();
        }
    }
}
