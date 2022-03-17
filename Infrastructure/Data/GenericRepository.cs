using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly WomContext _context;

        public GenericRepository(WomContext  context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
             return await _context.Set<T>().ToListAsync();
            
        }

        public async Task<T> GetByIdAsync(int id)
        {
             return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetEntityWhithSpec(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }
        public async Task<int> CountAsync(ISpecification<T> spec)
        {
             return await ApplySpecification(spec).CountAsync();
        }
        public void DeleteOne(T entity)
        {
              //_context.Set<T>().Remove(entity);  
        }

        public void UpdateOne(T entity)
        {
            //_context.Set<T>().Update(entity);
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(),spec);
        }


    }
}