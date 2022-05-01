using System.Collections.Generic;
using System.Threading.Tasks;
using Volt.Mobile.Models;
using Volt.Mobile.Services.Interfaces;

namespace Volt.Mobile.Services
{
    public class CompanyService : ICompanyService
    {
        public Task<bool> AddItemAsync(Company item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Company> GetItemAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Company>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Company item)
        {
            throw new System.NotImplementedException();
        }
    }
}
