using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Features.Models.Queries.GetList;


public class GetListModelQueryHandler : IRequestHandler<GetListModelQuery, GetListResponse<GetListModelListItemDto>>
{
    private readonly IMapper _mapper;
    private readonly IModelRepository _modelRepository;

    public GetListModelQueryHandler(IModelRepository modelRepository, IMapper mapper)
    {
        _mapper = mapper;
        _modelRepository = modelRepository;
    }

    public async Task<GetListResponse<GetListModelListItemDto>> Handle(GetListModelQuery request, CancellationToken cancellationToken)
    {
        Paginate<Model> models = await _modelRepository.GetListAsync(include: m => m.Include(m => m.Brand)
                                                                                      .Include(m => m.Fuel)
                                                                                      .Include(m => m.Transmission),
                                                                       index: request.PageRequest.PageIndex,
                                                                       size: request.PageRequest.PageSize);

        var response = _mapper.Map<GetListResponse<GetListModelListItemDto>>(models);

        return response;
    }
}

