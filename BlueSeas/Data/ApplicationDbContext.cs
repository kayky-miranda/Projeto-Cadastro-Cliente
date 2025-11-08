using Microsoft.EntityFrameworkCore;
using BlueSeas.Models;

namespace BlueSeas.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CadastrosModel> Cadastros {  get; set; }

    }
}
