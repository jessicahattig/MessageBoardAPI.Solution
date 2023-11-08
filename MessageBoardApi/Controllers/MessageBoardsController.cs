using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MessageBoardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageBoardsController : ControllerBase
    {
        private readonly MessageBoardApiContext _db;

        public MessageBoardsController(MessageBoardApiContext db)
        {
            _db = db;
        }
        //GET api/messages???boards???messageboards??
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MessageBoard>>> Get([FromQuery] string messageText, string boardTitle, string userName, DateTime? date)
        {
            IQueryable<MessageBoard> query = _db.MessageBoards.AsQueryable();

            if(boardTitle != null)
            {
                query = query.Where(e => e.Board.BoardTitle == boardTitle); //1 1 1 -> Message {MessageText} Board {}
            }
            if(messageText != null)
            {
                query = query.Where(e => e.Message.MessageText == messageText);
            }
            if (userName != null)
            {
            query = query.Where(e => e.Message.UserName == userName);
            }
            if(date != null)
            {
                query = query.Where(e => e.Message.MessageDateTime == date);
            }
            return await query.ToListAsync();
        }
    }
}

