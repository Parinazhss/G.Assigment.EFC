using ConsoleApp.Entities;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Contexts
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<RoleEntity> Roles { get; set; }

        public  DbSet<UserEntity> Users { get; set; }

        public  DbSet<ProfileEntity> Profiles { get; set; }

        public DbSet<LoansEntity> Loans { get; set; }

        public   DbSet<BookEntity> Books { get; set; }

    }
}
