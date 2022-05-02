using MediatR;
using Volt.Application.Requests;
using Volt.Dtos;

namespace Volt.Application.Commands;

public class GetCategoriesCommand : IRequestHandler<GetCategoriesRequest, IEnumerable<CategoryDto>>
{
    public async Task<IEnumerable<CategoryDto>> Handle(GetCategoriesRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
