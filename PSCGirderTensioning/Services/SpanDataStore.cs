using PSCGirderTensioning.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSCGirderTensioning.Services
{
    public class SpanDataStore : IDataStore<SpanInfoDataModel>
    {
        private readonly SQLiteAsyncConnection _database;
        //readonly List<SpanInfoDataModel> spans;
        //readonly List<SpanInfoDataModel> spans;
        public SpanDataStore()
        {
            string dbPath = new GlobalData().dbPath;
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<SpanInfoDataModel>().GetAwaiter().GetResult();
            //spans = new List<SpanInfoDataModel>()
            //{

            //};
        }

        public async Task<bool> AddItemAsync(SpanInfoDataModel span)
        {
            int rowsAffected = await _database.InsertAsync(span);
            return rowsAffected > 0;
            //spans.Add(span);

            //return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(SpanInfoDataModel span)
        {
            int rowsAffected = await _database.UpdateAsync(span);
            return rowsAffected > 0;
            //var oldItem = spans.Where((SpanInfoDataModel arg) => arg.spanId == span.spanId).FirstOrDefault();
            //spans.Remove(oldItem);
            //spans.Add(span);

            //return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string spanid)
        {
            int rowsAffected = await _database.DeleteAsync<SpanInfoDataModel>(spanid);
            return rowsAffected > 0;
            //var oldItem = spans.Where((SpanInfoDataModel arg) => arg.spanId == spanid).FirstOrDefault();
            //spans.Remove(oldItem);

            //return await Task.FromResult(true);
        }

        public async Task<SpanInfoDataModel> GetItemAsync(string spanid)
        {
            return await _database.Table<SpanInfoDataModel>().FirstOrDefaultAsync(x => x.spanId == spanid);
            //return await Task.FromResult(spans.FirstOrDefault(s => s.spanId == spanid));
        }

        public async Task<IEnumerable<SpanInfoDataModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await _database.Table<SpanInfoDataModel>().ToListAsync();
            //return await Task.FromResult(spans);
        }

        public async Task<IEnumerable<SpanInfoDataModel>> GetItemsAsyncForParent(string parentid, bool forceRefresh = false)
        {
            return await _database.Table<SpanInfoDataModel>().Where(s => s.bridgeId == parentid).ToListAsync();
            //return await Task.FromResult(spans);
        }
    }
}
