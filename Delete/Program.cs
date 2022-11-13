using Ispan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"DELETE FROM Users WHERE Id = @Id";

			var dbHelper = new SqlDbHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNInt("id", 6)
					.Build();
				dbHelper.ExecuteNonQuery(sql, parameters);
				Console.WriteLine("成功刪除");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"錯誤訊息：{ex.Message}");
			}
		}
	}
}
