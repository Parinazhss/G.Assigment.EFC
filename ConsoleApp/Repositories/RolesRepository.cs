using ConsoleApp.Contexts;
using Infrastructure.Entities;

namespace ConsoleApp.Repositories
{
    internal class RolesRepository : BaseRepository<RoleEntity>
    {
        public RolesRepository(DataContext context) : base(context)
        {
        }
    }
}
