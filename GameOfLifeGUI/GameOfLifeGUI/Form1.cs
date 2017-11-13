using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeGUI
{
    public partial class Form1 : Form
    {
        const int MARK = 0;
        const int UPDATE = 1;
        const int MAX_TURNS = 20;

        int state = MARK;
        List<Generation> generations = new List<Generation>();

        public Form1()
        {
            InitializeComponent();
        }
        public bool GameOver()
        {
            if (generations[generations.Count].IsExtinct())
            {
                return true;
            }

            else if (generations.Count > MAX_TURNS) // max number of turns reached
                return true;
            for (int i = 0; i < generations.Count; i++)
            {
                if (generations[i].Equals(generations.Last()))
                {
                    return true;
                }
            }

            return false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void steadyStateToolStripMenuItem_Click(object sender, EventArgs e)
        { // Steady_State
            /* Stop the timer
            Clear the generations list
            Create a new generation object
            Add the lifeforms to specific squares on it.
            Add the new generation to the list
            Call Invalidate() on the picture box to trigger a
            repaint.
            Start the timer*/

            timer1.Stop();
            generations.Clear();
            Generation SteadyState = new Generation();
            // add lifeforms
            SteadyState.AddOrganism(3, 3);
            pictureBox1.Invalidate();
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(state == MARK)
            {
                generations.Last().Mark();
                state = UPDATE;
                pictureBox1.Invalidate();
            }
            else
            {
                Generation nextGen = generations.Last().Update();
                generations.Add(nextGen);
                state = MARK;
                pictureBox1.Invalidate();
                if (GameOver())
                {
                    timer1.Stop();
                }
                
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            generations.Last().Draw(e.Graphics, Convert.ToBoolean(state));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
