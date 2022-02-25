using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ConsumerRepository : IConsumerRepository
    {
        private readonly WomContext _context;
        public ConsumerRepository(WomContext context)
        {
            _context = context;
        }

        public async Task<Consumer> GetConsumerByIdAsync(int id)
        {
            return await _context.Consumers.FindAsync(id);
        }

        public async Task<IReadOnlyList<Consumer>> GetConsumersAsync() 
        {
            return await _context.Consumers.ToListAsync();
        } 
    }
}