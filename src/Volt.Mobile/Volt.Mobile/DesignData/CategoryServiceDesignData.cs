using System.Collections.Generic;
using System.Threading.Tasks;
using Volt.Dtos;
using Volt.WebClientAPI;

namespace Volt.Mobile.DesignData
{
    public class CategoryServiceDesignData : ICategoryAPIService
    {
        public CategoryServiceDesignData()
        {
        }

        public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            var categories = new List<CategoryDto>
            {
                new CategoryDto() { Id = 1, Description= "Groceries"},
                new CategoryDto() { Id = 2, Description= "Coffee"},
                new CategoryDto() { Id = 3, Description= "Grill"},
                new CategoryDto() { Id = 4, Description= "Sandwich"},
                new CategoryDto() { Id = 5, Description= "Salad"},
                new CategoryDto() { Id = 6, Description= "Burgers"},
                new CategoryDto() { Id = 7, Description= "Dessert"},
                new CategoryDto() { Id = 8, Description= "Pastry"},
                new CategoryDto() { Id = 9, Description= "Juice"},
                new CategoryDto() { Id = 10, Description= "Meat"},
                new CategoryDto() { Id = 11, Description= "Kebab"},
                new CategoryDto() { Id = 12, Description= "Smoothie"},
                new CategoryDto() { Id = 13, Description= "Healthy"},
                new CategoryDto() { Id = 14, Description= "Stores"},
                new CategoryDto() { Id = 15, Description= "Breakfast"},
                new CategoryDto() { Id = 16, Description= "American"},
                new CategoryDto() { Id = 17, Description= "Pizza"},
                new CategoryDto() { Id = 18, Description= "Asian"},
                new CategoryDto() { Id = 19, Description= "Pasta"},
                new CategoryDto() { Id = 20, Description= "Sushi"},
                new CategoryDto() { Id = 21, Description= "Ice cream"},

            };

            return await Task.FromResult(categories);
        }
    }
}