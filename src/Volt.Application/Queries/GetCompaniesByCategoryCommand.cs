using MediatR;
using Volt.Application.Requests;
using Volt.Dtos;

namespace Volt.Application.Queries
{
    public class GetCompaniesByCategoryCommand : IRequestHandler<GetCompaniesByCategoryRequest, IEnumerable<CompanyDto>>
    {
        public GetCompaniesByCategoryCommand()
        {
        }

        public Task<IEnumerable<CompanyDto>> Handle(GetCompaniesByCategoryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
