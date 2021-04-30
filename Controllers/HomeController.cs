using GameOfLife.Models;
using GameOfLife.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GameOfLife.Controllers
{
    public class HomeController : Controller
    {
        const int MIN_LENGTH = 3;
        const int MAX_LENGTH = 10;

        private readonly IGameService _gameService;

        public HomeController(IGameService gameService)
        {
            _gameService = gameService;
        }

        public IActionResult Index(int lenX = 5, int lenY = 5)
        {
            int lengthX = lenX < MIN_LENGTH ? MIN_LENGTH : lenX;
            lengthX = lengthX > MAX_LENGTH ? MAX_LENGTH : lengthX;

            int lengthY = lenY < MIN_LENGTH ? MIN_LENGTH : lenY;
            lengthY = lengthY > MAX_LENGTH ? MAX_LENGTH : lengthY;

            var board = new Board(lengthX, lengthY);
            return View(board);
        }

        [HttpPost]
        public IActionResult Index(Board model)
        {
            ModelState.Clear();
            var nextBoard = _gameService.GetNextBoard(model);
            return View(nextBoard);
        }
    }
}
