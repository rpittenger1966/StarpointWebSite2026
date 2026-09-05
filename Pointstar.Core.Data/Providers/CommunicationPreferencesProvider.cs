using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class CommunicationPreferencesProvider : ProviderBase
	{
		public CommunicationPreferencesProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertCommunicationPreferencesAsync(CommunicationPreferences entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertCommunicationPreferencesAsync(con, entity);
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

		public async Task InsertCommunicationPreferencesAsync(SqlConnection con, CommunicationPreferences entity)
		{
			string sql = @"INSERT INTO [dbo].[CommunicationPreferences]
           ([EmailAddress]
           ,[Created]
           ,[Newsletter]
           ,[YourProductUpdates]
           ,[OtherProductUpdates]
           ,[ProductSurveys])
     VALUES
           (@EmailAddress
           ,getdate()
           ,@Newsletter
           ,@YourProductUpdates
           ,@OtherProductUpdates
           ,@ProductSurveys);";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("EmailAddress", entity.EmailAddress);
				command.Parameters.AddWithValue("Newsletter", entity.Newsletter);
				command.Parameters.AddWithValue("YourProductUpdates", entity.YourProductUpdates);
				command.Parameters.AddWithValue("OtherProductUpdates", entity.OtherProductUpdates);
				command.Parameters.AddWithValue("ProductSurveys", entity.ProductSurveys);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<CommunicationPreferences>> GetCommunicationPreferencessAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetCommunicationPreferencessAsync(con);
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

		public async Task<List<CommunicationPreferences>> GetCommunicationPreferencessAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[CommunicationPreferences] order by [Created] desc";

			List<CommunicationPreferences> clientList = new List<CommunicationPreferences>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						CommunicationPreferences client = CommunicationPreferencesDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<CommunicationPreferences> GetByEmailAddressAsync(string emailAddress)
		{
			if (String.IsNullOrEmpty(emailAddress)) return null;

			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetByEmailAddressAsync(emailAddress);
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

		public async Task<CommunicationPreferences> GetByEmailAddressAsync(SqlConnection con, string emailAddress)
		{

			string sql = $"SELECT * FROM [dbo].[CommunicationPreferences] where [EmailAddress] = '{emailAddress}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							CommunicationPreferences client = CommunicationPreferencesDataReader.BuildFromDataReader(reader);
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

		public async Task UpdateCommunicationPreferencesAsync(CommunicationPreferences entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await UpdateCommunicationPreferencesAsync(con, entity);
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


		public async Task UpdateCommunicationPreferencesAsync(SqlConnection con, CommunicationPreferences entity)
		{
			string sql = @"UPDATE [dbo].[CommunicationPreferences]
   SET [Newsletter] = @Newsletter
      ,[YourProductUpdates] = @YourProductUpdates
      ,[OtherProductUpdates] = @OtherProductUpdates
      ,[ProductSurveys] = @ProductSurveys
 WHERE [EmailAddress] = @EmailAddress;
 		";

			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					command.Parameters.AddWithValue("EmailAddress", entity.EmailAddress);
					command.Parameters.AddWithValue("Newsletter", entity.Newsletter);
					command.Parameters.AddWithValue("YourProductUpdates", entity.YourProductUpdates);
					command.Parameters.AddWithValue("OtherProductUpdates", entity.OtherProductUpdates);
					command.Parameters.AddWithValue("ProductSurveys", entity.ProductSurveys);

					await command.ExecuteNonQueryAsync();
				}
			}
			catch (Exception ex)
			{
				//throw new Exception($"Failed to update CommunicationPreferences {entity.ID} for {entity.CustomerEmailAddress}");
			}
		}



	}  // end of class
}  // end of namespace
