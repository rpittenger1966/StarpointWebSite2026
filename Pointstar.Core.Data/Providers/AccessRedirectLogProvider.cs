using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class AccessRedirectLogProvider : ProviderBase
	{
		public AccessRedirectLogProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertAccessRedirectLogAsync(AccessRedirectLog entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertAccessRedirectLogAsync(con, entity);
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

		public async Task InsertAccessRedirectLogAsync(SqlConnection con, AccessRedirectLog entity)
		{
			string sql = @"INSERT INTO [dbo].[AccessRedirectLog]
           ([VisitorID]
           ,[SiteVisitID]
           ,[OrderID]
           ,[SaleKey]
           ,[RedirectKey]

           ,[Directory]
           ,[FileName]
           ,[Server]
           ,[Year]
           ,[Month]

           ,[Day]
           ,[Hour]
           ,[Minute]
           ,[Second]
           ,[DayOfWeek]

           ,[Created])
     VALUES
           (@VisitorID
           ,@SiteVisitID
           ,@OrderID
           ,@SaleKey
           ,@RedirectKey
           
		   ,@Directory
           ,@FileName
           ,@Server
           ,@Year
           ,@Month
           
		   ,@Day
           ,@Hour
           ,@Minute
           ,@Second
           ,@DayOfWeek

           ,getdate());";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				if (entity.VisitorID.HasValue)
					command.Parameters.AddWithValue("VisitorID", entity.VisitorID);
				else
					command.Parameters.AddWithValue("VisitorID", DBNull.Value);

				if (entity.SiteVisitID.HasValue)
					command.Parameters.AddWithValue("SiteVisitID", entity.SiteVisitID);
				else
					command.Parameters.AddWithValue("SiteVisitID", DBNull.Value);

				if (entity.OrderID.HasValue)
					command.Parameters.AddWithValue("OrderID", entity.OrderID);
				else
					command.Parameters.AddWithValue("OrderID", DBNull.Value);
				command.Parameters.AddWithValue("SaleKey", entity.SaleKey);
				command.Parameters.AddWithValue("RedirectKey", entity.RedirectKey);

				command.Parameters.AddWithValue("Directory", entity.Directory);
				command.Parameters.AddWithValue("FileName", entity.FileName);
				command.Parameters.AddWithValue("Server", entity.Server);
				command.Parameters.AddWithValue("Year", DateTime.Now.Year);
				command.Parameters.AddWithValue("Month", DateTime.Now.Month);

				command.Parameters.AddWithValue("Day", DateTime.Now.Day);
				command.Parameters.AddWithValue("Hour", DateTime.Now.Hour);
				command.Parameters.AddWithValue("Minute", DateTime.Now.Minute);
				command.Parameters.AddWithValue("Second", DateTime.Now.Second);
				command.Parameters.AddWithValue("DayOfWeek", Convert.ToInt32(DateTime.Now.DayOfWeek));

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<AccessRedirectLog>> GetAccessRedirectLogsAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetAccessRedirectLogsAsync(con);
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

		public async Task<List<AccessRedirectLog>> GetAccessRedirectLogsAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[AccessRedirectLog] order by [Created] desc";

			List<AccessRedirectLog> clientList = new List<AccessRedirectLog>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						AccessRedirectLog client = AccessRedirectLogDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<AccessRedirectLog> GetByIdAsync(int id)
		{
			if (id == null) return null;

			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetByIdAsync(id);
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

		public async Task<AccessRedirectLog> GetByIdAsync(SqlConnection con, int id)
		{

			string sql = $"SELECT * FROM [dbo].[AccessRedirectLog] where ID = {id};";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							AccessRedirectLog client = AccessRedirectLogDataReader.BuildFromDataReader(reader);
							return client;
						}
					}
				}

				return null;
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



	}  // end of class
}  // end of namespace
