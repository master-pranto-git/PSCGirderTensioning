using PSCGirderTensioning.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSCGirderTensioning.Services
{
    public class JackDataStore : IDataStore<JackInfo>
    {

        private readonly SQLiteAsyncConnection _database;

        public JackDataStore()
        {
            string dbPath = new GlobalData().dbPath;
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<JackInfo>().GetAwaiter().GetResult();
        }

        public async Task<bool> AddItemAsync(JackInfo item)
        {
            int rowsAffected = await _database.InsertAsync(item);
            return rowsAffected > 0;
        }

        public async Task<bool> UpdateItemAsync(JackInfo item)
        {
            int rowsAffected = await _database.UpdateAsync(item);
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            int rowsAffected = await _database.DeleteAsync<JackInfo>(id);
            return rowsAffected > 0;
        }

        public async Task<JackInfo> GetItemAsync(string id)
        {
            return await _database.Table<JackInfo>().FirstOrDefaultAsync(x => x.jackId == id);
        }

        public async Task<IEnumerable<JackInfo>> GetItemsAsync(bool forceRefresh = false)
        {
            return await _database.Table<JackInfo>().ToListAsync();
        }

        public async Task<IEnumerable<JackInfo>> GetItemsAsyncForParent(string parentid, bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }


        //readonly List<JackInfo> jacks;

        //public JackDataStore()
        //{
        //    jacks = new List<JackInfo>()
        //    {
        //        new JackInfo() { jackingEndRef = "1", jackId = Guid.NewGuid().ToString(), x_coefficient = 1.0028, c_coefficient = 9.1714, y_unit = "Ton", jackEquation = "y = 1.0028x + 9.1714" },
        //        new JackInfo() { jackingEndRef = "2", jackId = Guid.NewGuid().ToString(), x_coefficient = 0.9806, c_coefficient = 0.6161, y_unit = "Ton", jackEquation = "y = 0.9806x + 0.6161"},
        //    };
        //}
        //public async Task<bool> AddItemAsync(JackInfo jack)
        //{
        //    jacks.Add(jack);

        //    return await Task.FromResult(true);
        //}

        //public async Task<bool> DeleteItemAsync(string id)
        //{
        //    var oldItem = jacks.Where((JackInfo arg) => arg.jackId == id).FirstOrDefault();
        //    jacks.Remove(oldItem);

        //    return await Task.FromResult(true);
        //}

        //public async Task<JackInfo> GetItemAsync(string id)
        //{
        //    return await Task.FromResult(jacks.FirstOrDefault(s => s.jackId == id));
        //}

        //public async Task<IEnumerable<JackInfo>> GetItemsAsync(bool forceRefresh = false)
        //{
        //    return await Task.FromResult(jacks);

        //}

        //public async Task<bool> UpdateItemAsync(JackInfo jack)
        //{
        //    var oldItem = jacks.Where((JackInfo arg) => arg.jackId == jack.jackId).FirstOrDefault();
        //    jacks.Remove(oldItem);
        //    jacks.Add(jack);

        //    return await Task.FromResult(true);
        //}
    }
}
