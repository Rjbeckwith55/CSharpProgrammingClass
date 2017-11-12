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
        int state = MARK;
        List<Generation> generations = new List<Generation>();

        public Form1()
        {
            InitializeComponent();
        }
        bool GameOver()
        {
            if (generations().isExtinct())
            {
                return true;
            } 

            if() // max number of turns reached
            return true;
            for (int i = 0; i < Current generation; i++)
            {
                if (generations[i].Equals(Currentgeneration))
            }
            
        }
    }
}
