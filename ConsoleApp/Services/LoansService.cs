using ConsoleApp.Repositories;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class LoansService
    {
        private readonly LoansRepository _loansRepository;
        private readonly UserService _userService;
        private readonly BookService _bookService;

        public LoansService(LoansRepository loansRepository, UserService userService, BookService bookService)
        {
            _loansRepository = loansRepository;
            _userService = userService;
            _bookService = bookService;
        }


        public LoansEntity CreateLoans(DateTime loanDate, DateTime returnDate, string title, string email, string password)
        {
            var bookEntity = _bookService.CreateBook(title);
            var userEntity = _userService.CreateUser(email);

            var loansEntity = new LoansEntity
            {
                LoanDate = loanDate,
                ReturnDate = returnDate,
                BookId = bookEntity.BookId,
                

            };
            loansEntity = _loansRepository.Create(loansEntity);
            return loansEntity;
        }






        public LoansEntity GetLoansById(int id)
        {
            var LoansEntity = _loansRepository.GetOne(x => x.LoanId == id);
            return LoansEntity;
        }

        public IEnumerable<LoansEntity> GetLoans()
        {
            var loans = _loansRepository.GetAll();
            return loans;
        }

        public LoansEntity UpdateLoans(LoansEntity loansEntity)
        {
            var updatedLoansEntity = _loansRepository.Update(x => x.LoanId == loansEntity.LoanId, loansEntity);
            return updatedLoansEntity;
        }

        public void DeleteLoans(int id)
        {
            _loansRepository.Delete(x => x.LoanId == id);
        }
    }
}
