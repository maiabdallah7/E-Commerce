using Application.Contracts;
using System;
using Application.Contracts;
using Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbset; //err

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>(); //err
        }

        public T Create(T entity)
        {
            return _context.Add(entity).Entity;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public T Update(T entity)
        {
            return _context.Update(entity).Entity;
        }

        public T Delete(T entity)
        {
            return _context.Remove(entity).Entity;
        }
        // IQueryable vs Icollection
        // IQ ==> just typing the query , No execution just build (No yeild in database)

        public IQueryable<T> GetAll()
        {
            return _dbset;
        }

        public T? GetById(int Id)
        {
            return _dbset.Find(Id);
        }
    }
}
