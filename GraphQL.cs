using System.Linq;
using GraphQL.Data;
using GraphQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQL.Queries
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]     // use pull back any child objects
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
        {
            
            return context.Platforms;
        }
    }
}