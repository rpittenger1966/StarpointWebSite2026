using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class DownloadLogProvider : ProviderBase
	{
		public DownloadLogProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertDownloadLogAsync(DownloadLog entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertDownloadLogAsync(con, entity);
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

		public async Task InsertDownloadLogAsync(SqlConnection con, DownloadLog entity)
		{
			string sql = @"INSERT INTO [dbo].[DownloadLog]
           ([ID]
           ,[VisitorID]
           ,[RedirectID]
           ,[SiteVisitID]
           ,[MemberID]
           ,[OrderID]
           ,[OrderLineItemID]
           ,[FileName]
           ,[MemberName]
           ,[LandingPageName]
           ,[LandingPageEmail]
           ,[PageUrl]
           ,[Created]
           ,[LastModified])
     VALUES
           (<ID, uniqueidentifier,>
           ,<VisitorID, uniqueidentifier,>
           ,<RedirectID, uniqueidentifier,>
           ,<SiteVisitID, uniqueidentifier,>
           ,<MemberID, uniqueidentifier,>
           ,<OrderID, uniqueidentifier,>
           ,<OrderLineItemID, uniqueidentifier,>
           ,<FileName, varchar(300),>
           ,<MemberName, varchar(300),>
           ,<LandingPageName, varchar(300),>
           ,<LandingPageEmail, varchar(300),>
           ,<PageUrl, varchar(200),>
           ,<Created, datetime,>
           ,<LastModified, datetime,>);
;";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<DownloadLog>> GetDownloadLogsAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetDownloadLogsAsync(con);
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

		public async Task<List<DownloadLog>> GetDownloadLogsAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[DownloadLog] order by [Created] desc";

			List<DownloadLog> clientList = new List<DownloadLog>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						DownloadLog client = DownloadLogDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<DownloadLog> GetByIdAsync(Guid id)
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

		public async Task<DownloadLog> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[DownloadLog] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							DownloadLog client = DownloadLogDataReader.BuildFromDataReader(reader);
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
