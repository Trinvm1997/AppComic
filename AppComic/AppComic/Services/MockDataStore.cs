using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppComic.Models;

namespace AppComic.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chap 1", Description="Chuong 1 day ne" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chap 2", Description="Chuong 2 day ne" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chap 3", Description="Chuong 3 day ne" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chap 4", Description="Chuong 4 day ne" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chap 5", Description="Chuong 5 day ne" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chap 6", Description="Chuong 6 day ne" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}