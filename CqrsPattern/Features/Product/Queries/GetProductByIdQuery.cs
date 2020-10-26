using CqrsPattern.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsPattern.Features.Product.Queries
{
    public class GetProductByIdQuery : IRequest<Models.Product>
    {
        public int Id { get; set; }
        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Models.Product>
        {
            private readonly IApplicationContext _context;
            public GetProductByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<Models.Product> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
            {
                var product = _context.Products.Where(a => a.Id == query.Id).FirstOrDefault();
                if (product == null) return null;
                return product;
            }
        }
    }
}
