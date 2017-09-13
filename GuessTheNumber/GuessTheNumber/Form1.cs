using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        int Number;
        int prevGuess;
        public Form1()
        {
            InitializeComponent();
            Number = generateRandom();
            textBox1.Font = new Font("sans serif", 10);
            textBox1.Text = "I have a number between 1 and 1000--can you guess my number?\n Please enter your first guess";
        }
        int generateRandom()
        {
            int random;
            
            Random r = new Random();
            random = r.Next(0, 1000);
            return random;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("sans serif", 25);
            if (Convert.ToInt32(textBox2.Text) > Number)
            {
                textBox1.Text = "Too High";
            }
            else if (Convert.ToInt32(textBox2.Text) < Number)
            {
                textBox1.Text = "Too Low";
             
            }
            else if (Convert.ToInt32(textBox2.Text) == Number)
            {
                textBox1.Text = "Correct!";
                textBox1.BackColor = Color.Green;
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Text = "Invalid Input";
            }
            if (Math.Abs(Number - prevGuess)>Math.Abs(Number- Convert.ToInt32(textBox2.Text))){
                textBox1.BackColor = Color.LightBlue;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            prevGuess = Convert.ToInt32(textBox2.Text);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Number = generateRandom();
            textBox1.Enabled = true;
            textBox1.BackColor = DefaultBackColor;
            textBox1.Font = new Font("sans serif",10);
            textBox1.Text = "I have a number between 1 and 1000--can you guess my number?  Please enter your first guess";

        }
    }
}
