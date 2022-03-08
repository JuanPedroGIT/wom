using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IConsumerRepository
    {
        Task<Consumer> GetConsumerByIdAsync(int id);
        Task<IReadOnlyList<Consumer>> GetConsumersAsync();
    }
}