namespace MessageBoardApi.Models
{
  public class MessageBoard 
  {
    public int MessageBoardId { get; set; }
    public int MessageId { get; set; }
    public Message Message { get; set; }
    public int BoardId { get; set; }
    public Board Board { get; set; }
  }
} 