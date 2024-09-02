using Apideneme.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Apideneme.Data
{
    public class ContactsAPIDbContext : IdentityDbContext<AppUser>
    {
        public ContactsAPIDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            //options ile bağlantı dizesi alınmış olacak
        }
        public DbSet<Contact> Contacts { get; set; } //Tablo

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }

}
