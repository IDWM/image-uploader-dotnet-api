using image_uploader_dotnet_api.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace image_uploader_dotnet_api.Src.Data;

class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>().ToTable("posts");
    }
}