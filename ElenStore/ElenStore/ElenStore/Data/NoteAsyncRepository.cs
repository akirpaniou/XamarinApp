using ElenStore.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElenStore.Data
{
    public class NoteAsyncRepository
    {
        SQLiteConnection database;
        public NoteAsyncRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Note>();
        }
        public IEnumerable<Note> GetItems()
        {
            return database.Table<Note>().ToList();
        }
        public Note GetItem(int id)
        {
            return database.Get<Note>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Note>(id);
        }
        public int SaveItem(Note item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
