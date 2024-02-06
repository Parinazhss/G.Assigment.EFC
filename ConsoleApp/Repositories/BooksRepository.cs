using ConsoleApp.Contexts;
using ConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleApp.Repositories
{
    internal class BooksRepository : BaseRepository<BookEntity>
    {
        private readonly DataContext _context;
        public BooksRepository(DataContext context) : base(context)
        {
            _context = context;
        }



    }
}

