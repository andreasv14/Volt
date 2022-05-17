using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Volt.Application.Common.Interfaces;
using Volt.Application.Requests;
using Volt.Dtos;

namespace Volt.Application.Queries;

public class GetCategoriesQuery : IRequestHandler<GetCategoriesRequest, IEnumerable<CategoryDto>>
{
    private readonly IApplicationDbContext context;
    private readonly IMapper mapper;

    public GetCategoriesQuery(
        IApplicationDbContext context, 
        IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<CategoryDto>> Handle(GetCategoriesRequest request, CancellationToken cancellationToken)
    {
        var categories = await context.Categories.ToListAsync();

        return mapper.Map<IEnumerable<CategoryDto>>(categories);
    }
}