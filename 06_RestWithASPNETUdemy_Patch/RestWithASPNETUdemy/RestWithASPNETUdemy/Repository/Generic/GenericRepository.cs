using Microsoft.EntityFrameworkCore;
using RestWithASPNETUdemy.Model.Base;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        protected SQLContext _context;
        private DbSet<T> _dataSet;

        public GenericRepository(SQLContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                _dataSet.Add(item);
                _context.SaveChanges();
                return item;
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
                var result = _dataSet.SingleOrDefault(x => x.Id.Equals(id));
                _dataSet.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Exists(long id)
        {
            return _dataSet.Any(x => x.Id.Equals(id));
        }

        public List<T> FindAll()
        {
            return _dataSet.ToList();
        }

        public T FindById(long id)
        {
            return _dataSet.SingleOrDefault(x => x.Id.Equals(id));
        }

        public T Update(T item)
        {
            var result = _dataSet.SingleOrDefault(x => x.Id.Equals(item.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
