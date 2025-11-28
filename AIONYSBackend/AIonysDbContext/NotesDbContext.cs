using AIONYSBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace AIONYSBackend.AIonysDbContext
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
        {
            
        }

        public DbSet<Note> Notes { get; set; }
    }
}
