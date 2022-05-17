using MediatR;
using Volt.Dtos;

namespace Volt.Application.Requests
{
    public class GetCompaniesByCategoryRequest : IRequest<IEnumerable<CompanyDto>>
    {
        public int CategoryId { get; set; }
    }
}
