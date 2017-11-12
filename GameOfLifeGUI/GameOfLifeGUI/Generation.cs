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
            MarkCell() on each of them.*/
            for (int y = 0; y < BOARD_HEIGHT; y++)
            {
                for (int x = 0; x < BOARD_WIDTH; x++)
                {
                    MarkCell(x, y);
                }
            }

        }
        public void Draw(Graphics g, bool showInMarkedState)
        {
            for (int y = 0; y < BOARD_HEIGHT; y++)
            {
                for (int x = 0; x < BOARD_WIDTH; x++)
                {
                    if (!showInMarkedState)
                    {
                        //draw generic organism
                        board[x, y]; // draw something here
                    }
                    else if (showInMarkedState)
                    {
                        //draw what is going to happen to this cell

                    }
                }
            }
        }
        void MarkCell(int x, int y)
        {
            //sets state flag on whether a cell is going to live or die
            //check for organisms in the area at these locations

            //square around the cell
            board[x, y].state += CountOrganism(x + 1, y);
            board[x, y].state += CountOrganism(x - 1, y);
            board[x, y].state += CountOrganism(x, y + 1);
            board[x, y].state += CountOrganism(x, y - 1);
            //diagonals
            board[x, y].state += CountOrganism(x - 1, y - 1);
            board[x, y].state += CountOrganism(x + 1, y + 1);
            board[x, y].state += CountOrganism(x - 1, y + 1);
            board[x, y].state += CountOrganism(x + 1, y - 1);
        }
        public int CountOrganism(int x, int y)
        {
            //board size constraint
            if (x < BOARD_WIDTH && x >= 0 && y < BOARD_HEIGHT && y >= 0)
            {
                if (board[x, y].hasOrganism == true)
                {
                    return 1;
                }
                else
                    return 0;
            }

            else
                return 0;
        }

        public bool IsExtinct()
        {
            //Function to check if the game is over
            //return true if any square has an organism else return false -- Isn't this backwards...?
            for (int y = 0; y < BOARD_HEIGHT; y++)
            {
                for (int x = 0; x < BOARD_WIDTH; x++)
                {
                    if (board[x, y].hasOrganism)
                    {
                        return false; // is not extinct
                    }
                }
            }
            return true; //is extinct

        }

        public void AddOrganism(int x,int y)
        {
            board[x, y].hasOrganism = true;
        }

        public bool Equals(Generation g)
        {
            //check if the current generation is equal to the current generation
            for (int y = 0; y < BOARD_HEIGHT; y++)
            {
                for (int x = 0; x < BOARD_WIDTH; x++)
                {
                    if (board[x, y].state!=g.board[x,y].state)
                    {
                        return false; // is not equal
                    }
                }
            }
            return true;
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
