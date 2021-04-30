using GameOfLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLife.Services
{
    public class GameService : IGameService
    {
        public Board GetNextBoard(Board currentBoard)
        {
            var nextBoard = new Board(currentBoard.LengthX, currentBoard.LengthY);

            for(int x = 0; x < currentBoard.LengthX; x++)
            {
                for(int y = 0; y < currentBoard.LengthY; y++)
                {
                    nextBoard.Cells[x][y].Value = GetNextValue(currentBoard, x, y);
                }
            }
            return nextBoard;
        }

        private static int GetNextValue(Board currentBoard, int x, int y)
        {
            int liveNeighborCount = GetNeighboringValues(currentBoard, x, y).Count(i => i == 1);
            int currentValue = currentBoard.Cells[x][y].Value;
            int nextValue = currentValue;

            if(currentValue == 1)
            {
                if(liveNeighborCount < 2 || liveNeighborCount > 3)
                {
                    nextValue = 0;
                }
            }
            else
            {
                if(liveNeighborCount == 3)
                {
                    nextValue = 1;
                }
            }

            return nextValue;
        }

        private static List<int> GetNeighboringValues(Board currentBoard, int x, int y)
        {
            var result = new List<int>();

            for(int i = x-1; i <= x+1; i++)
            {
                for(int j = y-1; j <= y+1; j++)
                {
                    if(!(i == x && j == y) && i >= 0 && i < currentBoard.LengthX && j >= 0 && j< currentBoard.LengthY)
                    {
                        result.Add(currentBoard.Cells[i][j].Value);
                    }
                }
            }

            return result;
        }
    }
}
