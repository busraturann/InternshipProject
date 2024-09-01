using Apideneme.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Apideneme.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            //options ile bağlantı dizesi alınmış olacak
        }
        public DbSet<Contact> Contacts { get; set; } //Tablo
    }
}
