using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MessageBoardApi.Controllers;
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageBoardController : ControllerBase
    {
        private readonly MessageBoardContext _db;

        public MessageBoardController(MessageBoardContext db)
        {
            _db = db;
        }

        //GET api/messages???boards???messageboards??
        [HttpGet]
        public async Task<List<Message>> Get(string messagetext, string username, DateTime datetime)
        {
            
        }
    
    }
}

