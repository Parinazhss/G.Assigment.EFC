﻿

using ConsoleApp.Contexts;
using System.Diagnostics;
using System.Linq.Expressions;

namespace ConsoleApp.Repositories
{
    internal class BaseRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public TEntity Create(TEntity entity)
        {
            
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
                return entity;
            
        }

        public virtual  IEnumerable<TEntity> GetAll()
        {
            
                return _context.Set<TEntity>().ToList();
            
        }

        public virtual TEntity GetOne(Expression<Func<TEntity, bool>> expression)
        {
            var entity = _context.Set<TEntity>().FirstOrDefault(expression);
                return entity!;
            
        }

        public virtual TEntity Update(Expression<Func<TEntity, bool>> expression, TEntity entity)
        {
           var entityToUpdate = _context.Set<TEntity>().FirstOrDefault(expression);
            _context.Entry(entityToUpdate!).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            return entityToUpdate!;
        }

        public void  Delete(Expression<Func<TEntity, bool>> expression)
        {
           
                var entity = _context.Set<TEntity>().FirstOrDefault(expression);
               

                    _context.Set<TEntity>().Remove(entity!);
                    _context.SaveChanges();

                   
        }
    }
}
