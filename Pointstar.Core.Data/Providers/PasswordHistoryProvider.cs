using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class PasswordHistoryProvider : ProviderBase
	{
		public PasswordHistoryProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertPasswordHistoryAsync(PasswordHistory entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertPasswordHistoryAsync(con, entity);
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

		public async Task InsertPasswordHistoryAsync(SqlConnection con, PasswordHistory entity)
		{
			string sql = @"INSERT INTO [dbo].[PasswordHistory]
           ([ID]
           ,[MemberID]
           ,[Password]
           ,[PasswordSalt]
           ,[PasswordHashAlgorithm]
           ,[Created]
           ,[CreatedBy]
           ,[LastModified]
           ,[LastModifiedBy])
     VALUES
           (<ID, uniqueidentifier,>
           ,<MemberID, uniqueidentifier,>
           ,<Password, varchar(50),>
           ,<PasswordSalt, varchar(50),>
           ,<PasswordHashAlgorithm, int,>
           ,<Created, datetime,>
           ,<CreatedBy, varchar(50),>
           ,<LastModified, datetime,>
           ,<LastModifiedBy, varchar(50),>);";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<PasswordHistory>> GetPasswordHistorysAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetPasswordHistorysAsync(con);
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

		public async Task<List<PasswordHistory>> GetPasswordHistorysAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[PasswordHistory] order by [Created] desc";

			List<PasswordHistory> clientList = new List<PasswordHistory>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						PasswordHistory client = PasswordHistoryDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<PasswordHistory> GetByIdAsync(Guid id)
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

		public async Task<PasswordHistory> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[PasswordHistory] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							PasswordHistory client = PasswordHistoryDataReader.BuildFromDataReader(reader);
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
