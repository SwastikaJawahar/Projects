using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Wordgame
{
    public partial class frm_Beginner : Form
    {
        public string Level;
       public frm_Beginner(string level)
        {
            Level = level ;
            InitializeComponent();
        }
        //Initializing variables 
        private string word="";
        public char[] guess;
        public int lives = 5;
        int maxLives = 5;
        private int counter = 180;

        private void frm_Beginner_Load(object sender, EventArgs e)
        {
            Restart();//Methods to call
        }
        private void timer1_Tick(object sender, EventArgs e) // timer clock code
        {
            counter--;
            lbl_timer.Text = "Time : " + counter.ToString();
            if (counter == 0)
                timer1.Stop();
            if (lives == 0)
                timer1.Enabled = false;
        }
        private void frm_Beginner_Exit(object sender, EventArgs e) 
        {
            timer1.Stop();
        }
        public void ButtonPress(object sender, EventArgs e)
        {
            char text = char.Parse((sender as Button).Text);
            bool found = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == text && guess[i] != text)
                {
                    found = true;
                    guess[i] = text;

                }


            }
            string current = "";
            foreach (var item in guess)
            {
                current += item;
            }
            if (word == current)
            {
                timer1.Stop();
                if (Level != "Expertwords.txt")
                {
                    DialogResult res = MessageBox.Show("You won this Level.! Do you want to continue to Next Level?", "You won", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        if (Level == "Beginnerwords.txt")
                        {
                            Level = "Intermediatewords.txt";
                            this.Text = "Intermediate";
                        }
                        else if(Level == "Intermediatewords.txt")
                        {
                            Level = "Expertwords.txt";
                            this.Text = "Expert";
                        }
                    }
                }
                else
                {
                    DialogResult res = MessageBox.Show("You won all Level.!Do you want to Play again.!", "You won", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        Level = "Beginnerwords.txt";
                        this.Text = "Beginner";
                    }
                    if (res == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                Restart();
            }
            if (found)
            {
                this.label3.Text = "";
                string temp = "";
                for (int i = 0; i < guess.Length; i++)
                {
                    if (guess[i] == '_')
                    {
                        temp += '_' + " ";
                    }
                    else
                    {
                        temp += guess[i];
                    }
                }
                this.label3.Text = temp;
            }
            else
            {

                int temp = maxLives - lives;
                lives--;
                if (lives == 0)
                {
                    timer1.Stop();
                    DialogResult res = MessageBox.Show("You Lose this Level.!Do you want to Play again.!", "You Lose", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        Restart();
                    }
                    if (res == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.lbl_turn.Text = "Lives: " + lives;
                }
            }
        }
        public void Restart()
        {

            ChooseWord();
            lives = maxLives;
            this.lbl_turn.Text = "Lives: " + lives;
            timer1.Start();
            counter = 180;
            this.lbl_timer.Text = "Time: " + counter;
        }
        public void ChooseWord()
        {

            using (StreamReader sr = new StreamReader(Level))
            { 
                string line;
                List<string> words = new List<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);

                    Random r = new Random();
                    word = words[r.Next(0, words.Count)].ToUpper();
                    string[] splitWord = word.Split(",");
                    string clueWord = splitWord[1].ToUpperInvariant();
                    this.lbl_hint.Text ="Hint: " + clueWord;
                    word = splitWord[0];
                    guess = new char[word.Length];
                    this.label3.Text = "";
                    for (int i = 0; i < word.Length; i++)
                    {
                        guess[i] = '_';
                        this.label3.Text += "_ ";
                    }
                    if (1 == 1)
                    {
                        //this.Text = word;
                    }

                }
            }

        }
    }
}