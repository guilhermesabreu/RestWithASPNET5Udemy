using RestWithASPNETUdemy.Data.Converter.Implementations;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using RestWithASPNETUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVO Create(BookVO book)
        {
            try
            {
                var bookEntity = _converter.Parse(book);
                bookEntity = _repository.Create(bookEntity);
                return _converter.Parse(_repository.Create(bookEntity));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BookVO Update(BookVO book)
        {
            try
            {
                var bookEntity = _converter.Parse(book);
                bookEntity = _repository.Create(bookEntity);
                return _converter.Parse(_repository.Update(bookEntity));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(long id)
        {
            try
            {
                _repository.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
