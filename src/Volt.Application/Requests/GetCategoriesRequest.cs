using MediatR;
using Volt.Dtos;

namespace Volt.Application.Requests;

public class GetCategoriesRequest : IRequest<IEnumerable<CategoryDto>>
{
}
