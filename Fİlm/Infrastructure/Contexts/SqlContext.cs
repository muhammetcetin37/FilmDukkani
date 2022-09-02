using FİlmMvc.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FİlmMvc.Infrastructure.Contexts
{
    public class SqlContext : IdentityDbContext<AppUser>
    {

        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

    }
}
