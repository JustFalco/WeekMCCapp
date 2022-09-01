using SQLite;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WeekMCCapp.Models
{
	public class Database
	{
		private readonly SQLiteAsyncConnection _database;

		public Database(string dbPath)
		{
			_database = new SQLiteAsyncConnection(dbPath);
			_database.CreateTableAsync<User>();
			_database.CreateTableAsync<Car>();
			_database.CreateTableAsync<Incasso>();
			_database.CreateTableAsync<Payment>();
		}

		public Task<User> GetUserFromDatabase()
		{
			return _database.Table<User>().FirstAsync();
		}

		public Task<int> SaveUserToDatabase(User user)
		{
			return _database.InsertAsync(user);
		}
	}
}
