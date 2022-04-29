using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ElenStore.Models;
using SQLite;

namespace ElenStore.Data
{
    public class CourseDB
    {
        SQLiteAsyncConnection database;
        public CourseDB(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }
        public async Task CreateTable()
        {
            await database.CreateTableAsync<Course>();
        }
        public async Task<List<Course>> GetItemsAsync()
        {
            return await database.Table<Course>().ToListAsync();
        }
        public async Task<Course> GetCourseAsync(int id)
        {
            return await database.GetAsync<Course>(id);
        }
    }
}
