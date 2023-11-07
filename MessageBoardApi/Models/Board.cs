using System.Collections.Generic;
using System;

namespace MessageBoardApi.Models
{
  public class Board
  {
    public int BoardId { get; set; }
    public string BoardTitle { get; set; }
    public List<MessageBoard> JoinEntities { get; }
  }
}