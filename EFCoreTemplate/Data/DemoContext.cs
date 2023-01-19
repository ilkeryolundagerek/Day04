using EFCoreTemplate.Entities.Demo;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTemplate.Data
{
    public class DemoContext : DbContext
    {

        //Options Constructor: Bu yapı program.cs tarafından çağırılan servistir.
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }

        //İsteğe bağlı olarak alttaki gibi bir yapı da eklenebilir fakat tek başına veritabanına bağlanmaz.
        protected DemoContext() : base(GetOptions())
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Product>().HasKey(x => x.Id);//Key attribute yapısıyla aynı
        }

        private static DbContextOptions GetOptions()
        {
            string cs = @"Server=.;Database=demodata;User Id=sa;Password=1;MultipleActiveResultSets=true;";
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), cs).Options;
        }
    }
}
