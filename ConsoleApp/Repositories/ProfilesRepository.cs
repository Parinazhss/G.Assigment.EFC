using ConsoleApp.Contexts;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Repositories
{
    
    internal class ProfilesRepository : BaseRepository<ProfileEntity>
    {
        private readonly DataContext _context;
        public ProfilesRepository(DataContext context) : base(context)
        {
            _context = context;
        }

       
    }
}
