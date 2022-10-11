using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BilAPIDemo.model
{
    public class BilerContext2:DbContext
    {
        public BilerContext2(DbContextOptions<BilerContext2> options) : base(options) { }


        public virtual DbSet<Bil> Biler { get; set; }
    }
}
