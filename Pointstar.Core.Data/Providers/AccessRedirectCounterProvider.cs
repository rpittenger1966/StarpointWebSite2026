using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class AccessRedirectCounterProvider : ProviderBase
	{
		public AccessRedirectCounterProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertAccessRedirectCounterAsync(AccessRedirectCounter entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertAccessRedirectCounterAsync(con, entity);
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

		public async Task InsertAccessRedirectCounterAsync(SqlConnection con, AccessRedirectCounter entity)
		{
			string sql = @"INSERT INTO [dbo].[AccessRedirectCounter]
           ([OrderID]
           ,[SaleKey]
           ,[RedirectKey]
           ,[Directory]
           ,[FileName]
           ,[Count]
           ,[Max]
           ,[Created])
     VALUES
           (@OrderID
           ,@SaleKey
           ,@RedirectKey
           ,@Directory
           ,@FileName
           ,@Count
           ,@Max
           ,getdate());
;";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);
				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<AccessRedirectCounter>> GetAccessRedirectCountersAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetAccessRedirectCountersAsync(con);
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

		public async Task<List<AccessRedirectCounter>> GetAccessRedirectCountersAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[AccessRedirectCounter] order by [Created] desc";

			List<AccessRedirectCounter> clientList = new List<AccessRedirectCounter>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						AccessRedirectCounter client = AccessRedirectCounterDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<AccessRedirectCounter> GetByIdAsync(Guid id)
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

		public async Task<AccessRedirectCounter> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[AccessRedirectCounter] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							AccessRedirectCounter client = AccessRedirectCounterDataReader.BuildFromDataReader(reader);
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

		public async Task UpdateAccessRedirectCounterAsync(AccessRedirectCounter entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await UpdateAccessRedirectCounterAsync(con, entity);
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


		public async Task UpdateAccessRedirectCounterAsync(SqlConnection con, AccessRedirectCounter entity)
		{
			string sql = @"UPDATE [dbo].[AccessRedirectCounter]
   SET [OrderID] = @OrderID
      ,[SaleKey] = @SaleKey
      ,[RedirectKey] = @RedirectKey
      ,[Directory] = @Directory
      ,[FileName] = @FileName
      ,[Count] = @Count
      ,[Max] = @Max
      ,[LastModified] = getdate()
 WHERE ID=@ID;

		";

			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					command.Parameters.AddWithValue("ID", entity.ID);

					await command.ExecuteNonQueryAsync();
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"Failed to update AccessRedirectCounter {entity.ID} for order {entity.OrderID}");
			}
		}



	}  // end of class
}  // end of namespace
