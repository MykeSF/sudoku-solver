using Microsoft.EntityFrameworkCore;

namespace SudokuAPI.Models
{
     public partial class BoardDBContext : DbContext
     {
       public BoardDBContext(DbContextOptions
       <BoardDBContext> options)
           : base(options)
       {
       }
       public virtual DbSet<Board> Board { get; set; }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<Board>(entity => {
               entity.HasKey(k => k.BoardId);
           });
           OnModelCreatingPartial(modelBuilder);
       }
       partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
     }
}