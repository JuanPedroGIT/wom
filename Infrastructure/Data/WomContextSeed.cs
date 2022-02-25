using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class WomContextSeed
    {
        public static async Task SeedAsinc(WomContext context , ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.Consumers.Any())
                {
                    var consumerData = File.ReadAllText("../Infrastructure/Data/SeedData/consumer.json");
                    var consumer = JsonSerializer.Deserialize<List<Consumer>>(consumerData);
                    foreach(var c in consumer)
                    {
                         context.Consumers.Add(c);   
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch(Exception e)
            {
                var logger = loggerFactory.CreateLogger<WomContextSeed>();
                logger.LogError(e.Message);
            }

        }
        
    }
}