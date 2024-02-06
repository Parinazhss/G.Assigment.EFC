using ConsoleApp.Entities;
using ConsoleApp.Repositories;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class BookService
    {

        private readonly BooksRepository _booksRepository;

        public BookService(BooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public BookEntity CreateBook(string title)
        {
            var BookEntity = _booksRepository.GetOne(x => x.Title == title);
            BookEntity ??= _booksRepository.Create(new BookEntity { Title = title });

            return BookEntity;
        }

        public BookEntity GetBookById(int id)
        {
            var BookEntity = _booksRepository.GetOne(x => x.BookId == id);
            return BookEntity;
        }

        public IEnumerable<BookEntity> GetBooks()
        {
            var books = _booksRepository.GetAll();
            return books;
        }

        public BookEntity UpdateBook(BookEntity BookEntity)
        {
            var updatedBookEntity = _booksRepository.Update(x => x.BookId == BookEntity.BookId, BookEntity);
            return updatedBookEntity;
        }

        public void DeleteBook(int id)
        {
            _booksRepository.Delete(x => x.BookId == id);
        }
    }
}
