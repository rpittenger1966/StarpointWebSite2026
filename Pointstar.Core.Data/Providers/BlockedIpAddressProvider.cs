using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class BlockedIpAddressProvider : ProviderBase
	{
		public BlockedIpAddressProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertBlockedIpAddressAsync(BlockedIpAddress entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertBlockedIpAddressAsync(con, entity);
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

		public async Task InsertBlockedIpAddressAsync(SqlConnection con, BlockedIpAddress entity)
		{
			string sql = @"INSERT INTO [dbo].[BlockedIpAddress]
           ([IpAddress]
           ,[ErrorMessage]
           ,[RequestUrl]
           ,[Active]
           ,[Created])
     VALUES
           (@IpAddress
           ,@ErrorMessage
           ,@RequestUrl
           ,@Active
           ,getdate());";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("IpAddress", entity.IpAddress);
				command.Parameters.AddWithValue("ErrorMessage", entity.ErrorMessage);
				command.Parameters.AddWithValue("RequestUrl", entity.RequestUrl);
				command.Parameters.AddWithValue("Active", entity.Active);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<BlockedIpAddress>> GetBlockedIpAddresssAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetBlockedIpAddresssAsync(con);
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

		public async Task<List<BlockedIpAddress>> GetBlockedIpAddresssAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[BlockedIpAddress] order by [Created] desc";

			List<BlockedIpAddress> clientList = new List<BlockedIpAddress>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						BlockedIpAddress client = BlockedIpAddressDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<BlockedIpAddress> GetByIpAddressAsync(string ipAddress)
		{
			if (String.IsNullOrEmpty(ipAddress)) return null;

			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetByIpAddressAsync(ipAddress);
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

		public async Task<BlockedIpAddress> GetByIpAddressAsync(SqlConnection con, string ipAddress)
		{

			string sql = $"SELECT * FROM [dbo].[BlockedIpAddress] where [IPAddress] = '{ipAddress}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							BlockedIpAddress client = BlockedIpAddressDataReader.BuildFromDataReader(reader);
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

		public async Task UpdateBlockedIpAddressAsync(BlockedIpAddress entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await UpdateBlockedIpAddressAsync(con, entity);
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


		public async Task UpdateBlockedIpAddressAsync(SqlConnection con, BlockedIpAddress entity)
		{
			string sql = @"UPDATE [dbo].[BlockedIpAddress]
   SET [ErrorMessage] = @ErrorMessage
      ,[RequestUrl] = @RequestUrl
      ,[Active] = @Active
 WHERE IpAddress=@IpAddress;

		";

			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					command.Parameters.AddWithValue("IpAddress", entity.IpAddress);
					command.Parameters.AddWithValue("ErrorMessage", entity.ErrorMessage);
					command.Parameters.AddWithValue("RequestUrl", entity.RequestUrl);
					command.Parameters.AddWithValue("Active", entity.Active);

					await command.ExecuteNonQueryAsync();
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"Failed to update BlockedIpAddress {entity.IpAddress}");
			}
		}



	}  // end of class
}  // end of namespace
