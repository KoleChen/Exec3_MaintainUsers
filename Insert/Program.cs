using Ispan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"INSERT INTO Users(Name, Account, Password, DateOfBirthd, Height)VALUES(@Name, @Account, @Password, @DateOfBirthd, @Height)";
			var dbHelper = new SqlDbHelper("default");

			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("name", 50, "Tom")
					.AddNVarchar("account", 50, "Tom123")
					.AddNVarchar("password", 50, "T1O2M3")
					.AddNInt("height", 180)
					.AddNDateTime("@DateOfBirthd", new DateTime(1995, 8, 7))
					.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);
				Console.WriteLine("成功新增");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"錯誤訊息：{ex.Message}");
			}
		}
	}
}
