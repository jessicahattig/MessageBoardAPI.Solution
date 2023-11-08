using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MessageBoardApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BoardsController : ControllerBase
  {
    private readonly MessageBoardApiContext _db;

    public BoardsController(MessageBoardApiContext db)
    {
      _db = db;
    }

    #nullable enable
    //GET api/messageboard
    [HttpGet]
    public async Task<List<Board>> Get(string? boardtitle)
    {
      IQueryable<Board> query = _db.Boards.AsQueryable();

      if (boardtitle != null)
      {
        query = query.Where(entry => entry.BoardTitle == boardtitle)
                    .Include(entry => entry.JoinEntities);
      }
      return await query.ToListAsync();
    }

      //Get: api/Boards
      [HttpGet("{boardid}")]
      public async Task<ActionResult<Board>> GetBoard(int boardid)
      {
        Board? board = await _db.Boards.FindAsync(boardid);
        if(board==null)
        {
          return NotFound();
        }

        return board;
      }
    
  }
  #nullable disable
}