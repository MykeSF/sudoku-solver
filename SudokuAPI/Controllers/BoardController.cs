using SudokuAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SudokuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly BoardDBContext _context;
        public BoardController(BoardDBContext context)
        {
            _context = context;
        }

        // GET: api/Board
        [HttpGet]
        public ActionResult<IEnumerable<Board>> GetBoard()
        {
            return _context.Board.ToList();
        }

        // GET: api/Board/1
        [HttpGet("{id}")]
        public ActionResult<Board> GetBoard(int id)
        {
            var board = _context.Board.Find(id);
            if (board == null)
            {
                return NotFound();
            }
            return board;
        }

        // POST: api/Board
        [HttpPost]
        public ActionResult<Board> CreateBoard(Board board)
        {
            if (board == null)
            {
                return BadRequest();
            }
            _context.Board.Add(board);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetBoard), new { id = board.BoardId }, board);
        }
    }
}