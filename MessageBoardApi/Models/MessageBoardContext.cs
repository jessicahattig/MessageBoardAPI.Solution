using Microsoft.EntityFrameworkCore;
using System;

namespace MessageBoardApi.Models
{
  public class MessageBoardApiContext : DbContext
  {
    public DbSet<Message> Messages { get; set; }
    public DbSet<Board> Boards { get; set; }
    public DbSet<MessageBoard> MessageBoards { get; set; }

    public MessageBoardApiContext(DbContextOptions options) : base(options) 
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Message>()
        .HasData(
          new Message { MessageId = 1, MessageDateTime = new DateTime(2023,06,11,20,00,00), UserName = "Whoosh101", MessageText = "Helloooo" }         
        );

        builder.Entity<Board>()
        .HasData(
          new Board { BoardId = 1, BoardTitle = "DnDMeetUp"}
        );

        builder.Entity<MessageBoard>()
        .HasData (
          new MessageBoard { MessageBoardId = 1, MessageId = 1, BoardId = 1 }
        );
    }
  }
}
