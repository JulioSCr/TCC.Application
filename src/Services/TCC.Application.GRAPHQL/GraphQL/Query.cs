using HotChocolate;
using HotChocolate.Data;
using System.Linq;
using TCC.Application.GRAPHQL.Data;
using TCC.Application.GRAPHQL.Models;

namespace TCC.Application.GRAPHQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(PaisDbContext))]
        public IQueryable<Pais> GetPais([ScopedService] PaisDbContext context)
        {
            return context.Paises;
        }
    }
}
