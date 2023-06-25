using InstagramClone.Models;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Data;

public class InstaDbContext : DbContext
{
    public InstaDbContext(DbContextOptions<InstaDbContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
}