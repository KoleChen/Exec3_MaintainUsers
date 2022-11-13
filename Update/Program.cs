using Ispan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"UPDATE Users SET Name=@Name, Password=@Password WHERE Id=@Id";

			var dbHelper = new SqlDbHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("Name", 50, "TomChen")
					.AddNVarchar("Password", 50, "12345")
					.AddNInt("id", 7)
					.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);
				Console.WriteLine("成功更新");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"錯誤訊息：{ex.Message}");
			}
		}
	}
}
