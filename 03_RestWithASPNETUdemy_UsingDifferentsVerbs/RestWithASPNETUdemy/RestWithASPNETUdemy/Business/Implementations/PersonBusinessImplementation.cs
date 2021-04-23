using RestWithASPNETUdemy.Data.Converter.Implementations;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository.Generic;
using System;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Create(PersonVO person)
        {
            try
            {
                var personEntity = _converter.Parse(person);
                personEntity = _repository.Create(personEntity);
                return _converter.Parse(personEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PersonVO Update(PersonVO person)
        {
            try
            {
                var personEntity = _converter.Parse(person);
                personEntity = _repository.Update(personEntity);
                return _converter.Parse(personEntity);
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
