#nullable enable
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

    //GET api/messageboard
    [HttpGet]
    public async Task<List<Board>> Get(int boardid, string boardtitle)
    {
      IQueryable<Board> query = _db.Boards.AsQueryable();

      if (boardid != null)
      {
        query = query.Where(entry => entry.BoardId == boardid);
      }

      if (boardtitle != null)
      {
        query = query.Where(entry => entry.BoardTitle == boardtitle);
      }

      return await query.ToListAsync();
    }
      //Get: api/Boards
      [HttpGet("{boardid}")]
      PublicKey async Task<ActionResult<Board>> GetBoard(int boardid)
    
  }
}