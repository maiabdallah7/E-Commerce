﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IGenericRepository<T>
    {
        public T Create(T entity);
        public T Update(T entity);
        public T Delete(T entity);
        public IQueryable<T> GetAll();
        public T GetById(int id);
        public void SaveChanges();
    }
}
