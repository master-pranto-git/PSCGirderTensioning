using PSCGirderTensioning.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PSCGirderTensioning.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        private readonly SQLiteAsyncConnection _database;
        //readonly List<Item> items;
        public MockDataStore()
        {
            string dbPath = new GlobalData().dbPath;
            Debug.WriteLine(dbPath);
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Item>().GetAwaiter().GetResult();
            //items = new List<Item>()
            //{
            //        new Item { Id = Guid.NewGuid().ToString(), BridgeName="Construction of 81.0m Bridge at Lohagara Narail", District = "Narail", Upazilla="Lohagara", PackageNo = "Habi1", SpanNos = 2 },
            //        new Item { Id = Guid.NewGuid().ToString(), BridgeName="Const. of 10.0m Bridge at Kalia Narail", District = "Narail", Upazilla="Kalia", PackageNo = "Habi2",  SpanNos = 3 }
            //};
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            int rowsAffected = await _database.InsertAsync(item);
            return rowsAffected > 0;
            //items.Add(item);

            //return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            int rowsAffected = await _database.UpdateAsync(item);
            return rowsAffected > 0;
            //var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            //items.Remove(oldItem);
            //items.Add(item);

            //return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            int rowsAffected = await _database.DeleteAsync<Item>(id);
            return rowsAffected > 0;
            //var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            //items.Remove(oldItem);

            //return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await _database.Table<Item>().FirstOrDefaultAsync(x => x.Id == id);
            //return await Task.FromResult(items.FirstOrDefault(s => s.Id == id)); 
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await _database.Table<Item>().ToListAsync();
            //return await Task.FromResult(items);
        }

        public Task<IEnumerable<Item>> GetItemsAsyncForParent(string parentid, bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }
    }
}