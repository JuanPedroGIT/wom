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
                if(!context.Generations.Any())
                {
                    var generationData = File.ReadAllText("../Infrastructure/Data/SeedData/generation.json");
                    var generation = JsonSerializer.Deserialize<List<Generation>>(generationData);
                    foreach(var g in generation)
                    {
                        context.Generations.Add(g);
                    }
                    await context.SaveChangesAsync();
                }
                 if(!context.Programs.Any())
                {
                    var programData = File.ReadAllText("../Infrastructure/Data/SeedData/program.json");
                    var program = JsonSerializer.Deserialize<List<Program>>(programData);
                    foreach(var p in program)
                    {
                        context.Programs.Add(p);
                    }
                    await context.SaveChangesAsync();
                }
                if(!context.Statuses.Any())
                {
                    var statusData = File.ReadAllText("../Infrastructure/Data/SeedData/status.json");
                    var status = JsonSerializer.Deserialize<List<Status>>(statusData);
                    foreach(var s in status)
                    {
                        context.Statuses.Add(s);
                    }
                    await context.SaveChangesAsync();
                }
                if(!context.ProgramPromotions.Any())
                {
                    var programPromotionData = File.ReadAllText("../Infrastructure/Data/SeedData/programPromotion.json");
                    var programPromotion = JsonSerializer.Deserialize<List<ProgramPromotion>>(programPromotionData);
                    foreach(var p in programPromotion)
                    {
                        context.ProgramPromotions.Add(p);
                    }
                    await context.SaveChangesAsync();
                }
                if(!context.ProgramQuestions.Any())
                {
                    var programQuestionData = File.ReadAllText("../Infrastructure/Data/SeedData/programQuestion.json");
                    var options = new JsonSerializerOptions();
                    var programQuestion = JsonSerializer.Deserialize<List<ProgramQuestion>>(programQuestionData);
                    foreach(var p in programQuestion)
                    {
                        context.ProgramQuestions.Add(p);
                    }
                    await context.SaveChangesAsync();
                }
                if(!context.ProgramGenerationPeriods.Any())
                {
                    var programGenerationPeriodData = File.ReadAllText("../Infrastructure/Data/SeedData/programGenerationPeriod.json");
                    var programGenerationPeriod = JsonSerializer.Deserialize<List<ProgramGenerationPeriod>>(programGenerationPeriodData);
                    foreach(var p in programGenerationPeriod)
                    {
                        context.ProgramGenerationPeriods.Add(p);
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