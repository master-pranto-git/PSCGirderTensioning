using PSCGirderTensioning.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSCGirderTensioning.Services
{

    public class CableDataStore : IDataStore<CableInfo>
    {
        private readonly SQLiteAsyncConnection _database;
        //readonly List<CableInfo> cables;
        public CableDataStore()
        {
            string dbPath = new GlobalData().dbPath;
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<CableInfo>().GetAwaiter().GetResult();
            //cables = new List<CableInfo>()
            //{
            //};
        }

        public async Task<bool> AddItemAsync(CableInfo cable)
        {
            int rowsAffected = await _database.InsertAsync(cable);
            return rowsAffected > 0;

            //cables.Add(cable);

            //return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(CableInfo cable)
        {
            int rowsAffected = await _database.UpdateAsync(cable);
            return rowsAffected > 0;

            //var oldItem = cables.Where((CableInfo arg) => arg.cableId == cable.cableId).FirstOrDefault();
            //cables.Remove(oldItem);
            //cables.Add(cable);

            //return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string cableid)
        {
            int rowsAffected = await _database.DeleteAsync<CableInfo>(cableid);
            return rowsAffected > 0;
            //var oldItem = cables.Where((CableInfo arg) => arg.cableId == cableid).FirstOrDefault();
            //cables.Remove(oldItem);

            //return await Task.FromResult(true);
        }

        public async Task<CableInfo> GetItemAsync(string cableid)
        {
            return await _database.Table<CableInfo>().FirstOrDefaultAsync(x => x.cableId == cableid);
            //return await Task.FromResult(cables.FirstOrDefault(s => s.cableId == cableid));
        }

        public async Task<IEnumerable<CableInfo>> GetItemsAsync(bool forceRefresh = false)
        {
            return await _database.Table<CableInfo>().ToListAsync();
            //return await Task.FromResult(cables);
        }

        public async Task<IEnumerable<CableInfo>> GetItemsAsyncForParent(string parentid, bool forceRefresh = false)
        {
            return await _database.Table<CableInfo>().Where(s => s.girderId == parentid).ToListAsync();
        }
    }
}
