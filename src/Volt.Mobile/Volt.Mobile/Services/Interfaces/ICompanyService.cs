using System.Collections.Generic;
using System.Threading.Tasks;
using Volt.Domain.Entities;
using Volt.Domain.Enums;

namespace Volt.Mobile.Services.Interfaces
{
    public interface ICompanyService : IDataStore<Company>
    {
        public Task<IEnumerable<CompanyCategory>> GetCategoriesAsync();
    }
}
