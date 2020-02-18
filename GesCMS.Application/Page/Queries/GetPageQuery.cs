using AutoMapper;
using AutoMapper.QueryableExtensions;
using GesCMS.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GesCMS.Application.Page.Queries
{
    public class GetPageQuery : IRequest<PageViewModel>
    {
        public class GetTodosQueryHandler : IRequestHandler<GetPageQuery, PageViewModel>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetTodosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
                        
            public async Task<PageViewModel> Handle(GetPageQuery request, CancellationToken cancellationToken)
            {
                var vm = new PageViewModel();

                vm.Lists = await _context.Page
                    .ProjectTo<PageDTO>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.PageTitle)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
