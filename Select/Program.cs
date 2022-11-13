using Ispan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var dbHelper = new SqlDbHelper("default");
			string sql = "SELECT * FROM Users ";
			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNInt("id", 0)
					.Build();
				DataTable news = dbHelper.Select(sql, parameters);
				foreach (DataRow row in news.Rows)
				{
					int id = row.Field<int>("id");
					string Name = row.Field<string>("name");
					string Account = row.Field<string>("account");
					string Password = row.Field<string>("password");
					DateTime DateOfBirthd = row.Field<DateTime>("dateofbirthd");
					int Height = row.Field<int>("height");
					Console.WriteLine($"ID:{id}  Name:{Name}  Account:{Account}  Password:{Password}  Height:{Height}  DateOfBirth:{DateOfBirthd}");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"錯誤訊息：{ex.Message}");
			}
		}
	}
}
