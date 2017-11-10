using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeGUI
{
    class Generation
    {
        const int BOARD_WIDTH = 60;
        const int BOARD_HEIGHT = 40;
        const int CELL_SIZE = 20;
        Cell[,] board;
        public void Mark()
        {
            /*Loop over all the rows and columns in the board and call
MarkCell() on each of them. The FloodIt game contains
numerous examples of nested loops.*/
        }
        public void Draw(Graphics g, bool showInMarkedState)
        {

        }
        public bool IsExtinct()
        {
            for (int i = 0; i < BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < BOARD_WIDTH; j++)
                {
                     if (Cell[i,j].
                }
            }
        }

    }
    struct Cell
    {
        public bool hasOrganism; //does this square have a life form?
        public int state; //what will happen to this life form (if present)?
        public const int EMPTY = 0;
        public const int SURVIVES = 1;
        public const int DEATH_BY_OVERCROWDING = 2;
        public const int DEATH_BY_LONELINESS = 3;
        public const int SPAWNING = 4;
        public const int UNMARKED = 5;
        public Cell(bool hasOrganism)
        {
            this.hasOrganism = hasOrganism;
            this.state = EMPTY;
        }
    }
}
