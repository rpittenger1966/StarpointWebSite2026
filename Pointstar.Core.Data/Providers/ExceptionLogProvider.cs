using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class ExceptionLogProvider : ProviderBase
	{
		public ExceptionLogProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertExceptionLogAsync(ExceptionLog entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertExceptionLogAsync(con, entity);
				}
			}
			catch
			{
				throw;
			}
			finally
			{
				con?.Close();
			}
		}

		public async Task InsertExceptionLogAsync(SqlConnection con, ExceptionLog entity)
		{
			string sql = @"INSERT INTO [dbo].[ExceptionLog]
           ([Cookie]
           ,[IPAddress]
           ,[VisitorID]
           ,[Message]
           ,[StackTrace]
           ,[Created])
     VALUES
           (@Cookie
           ,@IPAddress
           ,@VisitorID
           ,@Message
           ,@StackTrace
           ,getdate());";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("Cookie", entity.Cookie);
				command.Parameters.AddWithValue("IPAddress", entity.IPAddress);
				if (entity.VisitorID.HasValue)
					command.Parameters.AddWithValue("VisitorID", entity.VisitorID);
				else
					command.Parameters.AddWithValue("VisitorID", DBNull.Value);
				command.Parameters.AddWithValue("Message", entity.Message);
				command.Parameters.AddWithValue("StackTrace", entity.StackTrace);

				await command.ExecuteNonQueryAsync();
			}
		}

		//public async Task<List<ExceptionLog>> GetExceptionLogsAsync()
		//{
		//	SqlConnection con = null;

		//	try
		//	{
		//		using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
		//		{
		//			return await GetExceptionLogsAsync(con);
		//		}
		//	}
		//	catch
		//	{
		//		throw;
		//	}
		//	finally
		//	{
		//		con?.Close();
		//	}
		//}

		//public async Task<List<ExceptionLog>> GetExceptionLogsAsync(SqlConnection con)
		//{
		//	string sql = "SELECT * FROM [dbo].[ExceptionLog] order by [Created] desc";

		//	List<ExceptionLog> clientList = new List<ExceptionLog>();

		//	using (SqlCommand command = new SqlCommand(sql, con))
		//	{
		//		using (SqlDataReader reader = await command.ExecuteReaderAsync())
		//		{
		//			while (reader.Read())
		//			{
		//				ExceptionLog client = ExceptionLogDataReader.BuildFromDataReader(reader);
		//				if (client != null)
		//				{
		//					clientList.Add(client);
		//				}
		//			}
		//		}
		//	}

		//	return clientList;
		//}


		//public async Task<ExceptionLog> GetByIdAsync(Guid id)
		//{
		//	if (id == null) return null;

		//	SqlConnection con = null;

		//	try
		//	{
		//		using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
		//		{
		//			return await GetByIdAsync(id);
		//		}
		//	}
		//	catch
		//	{
		//		throw;
		//	}
		//	finally
		//	{
		//		con?.Close();
		//	}
		//}

		//public async Task<ExceptionLog> GetByIdAsync(SqlConnection con, int id)
		//{

		//	string sql = $"SELECT * FROM [dbo].[ExceptionLog] where ID = {id};";


		//	try
		//	{
		//		using (SqlCommand command = new SqlCommand(sql, con))
		//		{
		//			using (SqlDataReader reader = await command.ExecuteReaderAsync())
		//			{
		//				while (reader.Read())
		//				{
		//					ExceptionLog client = ExceptionLogDataReader.BuildFromDataReader(reader);
		//					return client;
		//				}
		//			}
		//		}

		//		return null;
		//	}
		//	catch
		//	{
		//		throw;
		//	}
		//	finally
		//	{
		//		con?.Close();
		//	}
		//}



	}  // end of class
}  // end of namespace
