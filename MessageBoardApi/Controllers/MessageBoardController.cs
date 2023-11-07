using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MessageBoardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageBoardController : ControllerBase
    {
        private readonly MessageBoardApiContext _db;

        public MessageBoardController(MessageBoardApiContext db)
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
                query = query.Where(e => e.Board.BoardTitle == boardTitle);
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

