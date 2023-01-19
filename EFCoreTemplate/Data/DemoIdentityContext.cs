using Microsoft.EntityFrameworkCore;

namespace EFCoreTemplate.Data
{
    public class DemoIdentityContext : DbContext
    {

        //Options Constructor: Bu yapı program.cs tarafından çağırılan servistir.
        public DemoIdentityContext(DbContextOptions<DemoIdentityContext> options) : base(options)
        {
        }

        //İsteğe bağlı olarak alttaki gibi bir yapı da eklenebilir fakat tek başına veritabanına bağlanmaz.
        protected DemoIdentityContext()
        {
        }
    }
}
