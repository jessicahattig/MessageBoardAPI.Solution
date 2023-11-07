using System.Collections.Generic;
using System;

namespace MessageBoardApi.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    public DateTime MessageDateTime { get; set; }
    public string UserName { get; set; }
    public string MessageText { get; set; }
    public List<MessageBoard> JoinEntities { get; }
  }
}