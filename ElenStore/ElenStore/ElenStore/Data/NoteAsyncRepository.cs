using ElenStore.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElenStore.Data
{
    public class NoteAsyncRepository
    {
        SQLiteAsyncConnection database;

        public NoteAsyncRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Note>();
        }
        public async Task<List<Note>> GetItemsAsync()
        {
            return await database.Table<Note>().ToListAsync();

        }
        public async Task<Note> GetItemAsync(int id)
        {
            return await database.GetAsync<Note>(id);
        }
        public async Task<int> DeleteItemAsync(Note item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Note item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
}
