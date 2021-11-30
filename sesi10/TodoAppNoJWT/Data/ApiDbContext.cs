using Microsoft.EntityFrameworkCore;
using TodoAppNoJWT.Models;

namespace TodoAppNoJWT.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}