using System.Linq;
using GraphQL.Data;
using GraphQL.Models;
using HotChocolate;

namespace GraphQL.Queries
{
    public class Query
    {
        public IQueryable<Platform> GetPlatform([Service] AppDbContext context)
        {
            
            return context.Platforms;
        }
    }
}