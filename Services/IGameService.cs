using GameOfLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLife.Services
{
    public interface IGameService
    {
        Board GetNextBoard(Board currentBoard);
    }
}
