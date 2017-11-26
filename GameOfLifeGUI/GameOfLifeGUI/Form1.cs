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
        const int MAX_TURNS = 6000;

        public const int BOARD_WIDTH = 20;
        public const int BOARD_HEIGHT = 20;
        public const int CELL_SIZE = 20;


        int state = MARK;
        Generation basic = new Generation();
        Generation currGen;
        List<Generation> generations = new List<Generation>();


        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < BOARD_WIDTH; i++)
            {
                for (int j = 0; j < BOARD_HEIGHT; j++)
                {
                    basic.board[i, j].state = 0;
                }
            }
            generations.Add(basic);
        }
        public bool GameOver()
        {
            if (currGen.IsExtinct())
            {
                return true;
            }
            if (generations.Count == MAX_TURNS)
            {
                return true;
            }


            for (int i = 0; i < generations.Count - 1; i++)
            {
                if (currGen.Equals(generations[i]))
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
            currGen = new Generation();

            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 1, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2 - 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 1, BOARD_HEIGHT / 2 - 1].hasOrganism = true;

            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2 + 4].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 1, BOARD_HEIGHT / 2 + 5].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 1, BOARD_HEIGHT / 2 + 5].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 1, BOARD_HEIGHT / 2 + 6].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 1, BOARD_HEIGHT / 2 + 6].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2 + 7].hasOrganism = true;

            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2 - 5].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 1, BOARD_HEIGHT / 2 - 6].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 1, BOARD_HEIGHT / 2 - 6].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2 - 7].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 1, BOARD_HEIGHT / 2 - 7].hasOrganism = true;

            currGen.board[BOARD_WIDTH / 2 - 4, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 4, BOARD_HEIGHT / 2 - 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 5, BOARD_HEIGHT / 2 - 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 5, BOARD_HEIGHT / 2 + 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 6, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 6, BOARD_HEIGHT / 2 + 1].hasOrganism = true;

            currGen.board[BOARD_WIDTH / 2 + 5, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 6, BOARD_HEIGHT / 2 - 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 6, BOARD_HEIGHT / 2 + 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 7, BOARD_HEIGHT / 2 + 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 7, BOARD_HEIGHT / 2 - 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 8, BOARD_HEIGHT / 2 - 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 8, BOARD_HEIGHT / 2].hasOrganism = true;

            generations.Add(currGen);

            pictureBox1.Invalidate();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (state == MARK)
            {
                currGen.Mark();
                state = UPDATE;
                pictureBox1.Invalidate();
            }
            else
            {
                currGen = currGen.Update();
                generations.Add(currGen);

                state = MARK;

                pictureBox1.Invalidate();

                if (GameOver())
                {
                    timer1.Stop();
                    MessageBox.Show("Game Over");
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

        private void verticalOscillationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            generations.Clear();
            currGen = new Generation();

            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2 + 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2 - 1].hasOrganism = true;


            currGen.board[BOARD_WIDTH / 2 - 4, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 5, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 5, BOARD_HEIGHT / 2 + 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 6, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 6, BOARD_HEIGHT / 2 + 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 7, BOARD_HEIGHT / 2 + 1].hasOrganism = true;


            generations.Add(currGen);

            pictureBox1.Invalidate();
            timer1.Start();
        }

        private void rPentominoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pentamino
            timer1.Stop();
            generations.Clear();
            currGen = new Generation();

            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2 + 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2, BOARD_HEIGHT / 2 - 1].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 - 1, BOARD_HEIGHT / 2].hasOrganism = true;
            currGen.board[BOARD_WIDTH / 2 + 1, BOARD_HEIGHT / 2 + 1].hasOrganism = true;

            generations.Add(currGen);
            pictureBox1.Invalidate();
            timer1.Start();
        }
    }
}
