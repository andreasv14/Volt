using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volt.Domain.Entities;
using Volt.Domain.Enums;
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

        public Task<IEnumerable<CompanyCategory>> GetCategoriesAsync()
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
                Name = "Stabucks",
                Description = "This is a description",
            };

            starbucksCompany.Categories.Add(Domain.Enums.CompanyCategory.Coffee);

            starbucksCompany.Items.Add(new Item
            {
                Id = 1,
                Text = "Freddo espresso",
                Description = "This is a freddo espresso "
            });


            var salutCompany = new Company
            {
                Id = 1,
                Name = "Salut",
                Description = "This is a freddo espresso "
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
