using System.Collections.Generic;
using System.Threading.Tasks;
using Volt.Mobile.Models;
using Volt.Mobile.Services.Interfaces;

namespace Volt.Mobile.Services
{
    public class ItemService : IItemService
    {
        public Task<bool> AddItemAsync(Item item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Item> GetItemAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Item item)
        {
            throw new System.NotImplementedException();
        }
    }
}
