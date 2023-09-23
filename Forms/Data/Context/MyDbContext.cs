using Forms.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Forms.Data.Context
{
    public class MyDbContext : IdentityDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> contextOptions)  
            :base(contextOptions)
        {  }

        public DbSet<Form> Form { get; set; }
        public DbSet<RespuestasUsuario> RespuestasUsuario { get; set; }
    }
}
