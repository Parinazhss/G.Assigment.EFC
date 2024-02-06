using ConsoleApp.Contexts;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Repositories
{
    internal class UserRepository : BaseRepository<UserEntity>
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<UserEntity> GetAll()
        {
            return _context.Users
                .Include(i => i.Profile)
                .Include(i => i.Role)
                .ToList();
        }

        
    }
}
