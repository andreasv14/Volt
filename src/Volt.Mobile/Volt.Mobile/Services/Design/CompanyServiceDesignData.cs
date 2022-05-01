using System.Collections.Generic;
using System.Threading.Tasks;
using Volt.Mobile.Models;
using Volt.Mobile.Services.Interfaces;

namespace Volt.Mobile.Services.Design
{
    public class CompanyServiceDesignData : ICompanyService
    {
        public Task<bool> AddItemAsync(Company item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Company> GetItemAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Company>> GetItemsAsync(bool forceRefresh = false)
        {
            var starbucksCompany = new Company
            {
                Id = 1,
                Name = "Stabucks"
            };

            starbucksCompany.Items.Add(new Item
            {
                Id = 1,
                Text = "Freddo espresso",
                Description = "This is a freddo espresso "
            });


            var salutCompany = new Company
            {
                Id = 1,
                Name = "Salut"
            };

            salutCompany.Items.Add(new Item
            {
                Id = 1,
                Text = "Hamburger",
                Description = "This is a Hamburger."
            });

            var companies = new List<Company>()
            {
                starbucksCompany,
                salutCompany
            };

            return await Task.FromResult(companies);
        }

        public Task<bool> UpdateItemAsync(Company item)
        {
            throw new System.NotImplementedException();
        }
    }
}
