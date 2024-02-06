using ConsoleApp.Contexts;
using Infrastructure.Entities;

namespace ConsoleApp.Repositories
{
    internal class LoansRepository : BaseRepository<LoansEntity>
    {
        public LoansRepository(DataContext context) : base(context)
        {
        }
    }
}
