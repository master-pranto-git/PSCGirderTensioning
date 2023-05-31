using PSCGirderTensioning.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSCGirderTensioning.Services
{
    public class GirderDataStore : IDataStore<GirderInfo>
    {
        private readonly SQLiteAsyncConnection _database;
        //readonly List<GirderInfo> girders;

        public GirderDataStore()
        {
            string dbPath = new GlobalData().dbPath;
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<GirderInfo>().GetAwaiter().GetResult();
            //girders = new List<GirderInfo>()
            //{

            //};
        }

        public async Task<bool> AddItemAsync(GirderInfo girder)
        {
            int rowsAffected = await _database.InsertAsync(girder);
            return rowsAffected > 0;
            //girders.Add(girder);

            //return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(GirderInfo girder)
        {
            int rowsAffected = await _database.UpdateAsync(girder);
            return rowsAffected > 0;
            //var oldItem = girders.Where((GirderInfo arg) => arg.girderId == girder.spanId).FirstOrDefault();
            //girders.Remove(oldItem);
            //girders.Add(girder);

            //return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string girderid)
        {
            int rowsAffected = await _database.DeleteAsync<GirderInfo>(girderid);
            return rowsAffected > 0;
            //var oldItem = girders.Where((GirderInfo arg) => arg.girderId == girderid).FirstOrDefault();
            //girders.Remove(oldItem);

            //return await Task.FromResult(true);
        }

        public async Task<GirderInfo> GetItemAsync(string girderid)
        {
            return await _database.Table<GirderInfo>().FirstOrDefaultAsync(x => x.girderId == girderid);
            //return await Task.FromResult(girders.FirstOrDefault(s => s.girderId == girderid));
        }

        public async Task<IEnumerable<GirderInfo>> GetItemsAsync(bool forceRefresh = false)
        {
            return await _database.Table<GirderInfo>().ToListAsync();
            //return await Task.FromResult(girders);
        }

        public async Task<IEnumerable<GirderInfo>> GetItemsAsyncForParent(string parentid, bool forceRefresh = false)
        {
            return await _database.Table<GirderInfo>().Where(g => g.spanId == parentid).ToListAsync();
        }
    }
}
