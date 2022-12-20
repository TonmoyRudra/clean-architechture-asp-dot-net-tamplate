using Application.Core;
using Application.Interfaces;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Menu
{
    public class List
    {
        public class Query : IRequest<Result<UM_MENU_ACCESS_V>>
        {
            public PaginationParams param { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<UM_MENU_ACCESS_V>>
        {
            private readonly IReposotory<UM_MENU_ACCESS_V> _listRepo;

            public Handler(IReposotory<UM_MENU_ACCESS_V> listRepo)
            {
                _listRepo = listRepo;
            }

            public Task<Result<UM_MENU_ACCESS_V>> Handle(Query request, CancellationToken cancellationToken)
            {
                //var activities = _listRepo.GetQueryAble();
                var activities = _listRepo.FindListAllAsync(x=>x.LOOKUP_ID == request.param.AppId && x.USERID == request.param.UserId);

                //var nullActivity = await _listRepo.GetListAsync();




                return Task.FromResult(Result<UM_MENU_ACCESS_V>.CreatePagination(activities, request.param.PageIndex, 100));
            }
        }
    }
}
