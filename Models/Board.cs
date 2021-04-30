using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLife.Models
{
    public class Board
    {
        public int LengthX{ get; set; }
        public int LengthY { get; set; }
        public Cell[][] Cells { get; set; }

        public Board()
        {

        }

        public Board(int lengthX, int lengthY)
        {
            LengthX = lengthX;
            LengthY = lengthY;

            Cells = new Cell[lengthX][];
            for(int x = 0; x < lengthX; x++)
            {
                Cells[x] = new Cell[lengthY];
                for(int y = 0; y < lengthY; y++)
                {
                    Cells[x][y] = new Cell();
                }
            }
        }
    }

    public class Cell
    {
        [Range(0, 1, ErrorMessage = "Cell value must be either 0 or 1.")]
        [Required(ErrorMessage = "Cell value is required.")]
        public int Value { get; set; }
    }
}
