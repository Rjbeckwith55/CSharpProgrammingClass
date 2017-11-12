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
        int current = 0;

        int state = MARK;
        List<Generation> generations = new List<Generation>();

        public Form1()
        {
            InitializeComponent();
        }
        public bool GameOver()
        {
            if (generations[current].IsExtinct())
            {
                return true;
            }

            else if (current > MAX_TURNS) // max number of turns reached
                return true;
            for (int i = 0; i < current; i++)
            {
                if (generations[i].Equals(generations[current]))
                {
                    return true;
                }
            }

            return false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            generations.Last().Draw(e.Graphics, Convert.ToBoolean(state));
        }
    }
}
