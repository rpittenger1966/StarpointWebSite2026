using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class PasswordResetProvider : ProviderBase
	{
		public PasswordResetProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertPasswordResetAsync(PasswordReset entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertPasswordResetAsync(con, entity);
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

		public async Task InsertPasswordResetAsync(SqlConnection con, PasswordReset entity)
		{
			string sql = @"INSERT INTO [dbo].[PasswordReset]
           ([ID]
           ,[MemberID]
           ,[Password]
           ,[PasswordSalt]
           ,[PasswordHashAlgorithm]
           ,[Created]
           ,[CreatedBy])
     VALUES
           (@ID
           ,@MemberID
           ,@Password
           ,@PasswordSalt
           ,@PasswordHashAlgorithm
           ,getdate()
           ,@CreatedBy);";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);
				command.Parameters.AddWithValue("MemberID", entity.MemberID);
				command.Parameters.AddWithValue("Password", entity.Password);
				command.Parameters.AddWithValue("PasswordSalt", entity.PasswordSalt);
				command.Parameters.AddWithValue("PasswordHashAlgorithm", entity.PasswordHashAlgorithm);
				command.Parameters.AddWithValue("CreatedBy", this._userId);

				await command.ExecuteNonQueryAsync();
			}
		}

		//public async Task<List<PasswordReset>> GetPasswordResetsAsync()
		//{
		//	SqlConnection con = null;

		//	try
		//	{
		//		using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
		//		{
		//			return await GetPasswordResetsAsync(con);
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

		//public async Task<List<PasswordReset>> GetPasswordResetsAsync(SqlConnection con)
		//{
		//	string sql = "SELECT * FROM [dbo].[PasswordReset] order by [Created] desc";

		//	List<PasswordReset> clientList = new List<PasswordReset>();

		//	using (SqlCommand command = new SqlCommand(sql, con))
		//	{
		//		using (SqlDataReader reader = await command.ExecuteReaderAsync())
		//		{
		//			while (reader.Read())
		//			{
		//				PasswordReset client = PasswordResetDataReader.BuildFromDataReader(reader);
		//				if (client != null)
		//				{
		//					clientList.Add(client);
		//				}
		//			}
		//		}
		//	}

		//	return clientList;
		//}


		public async Task<PasswordReset> GetByIdAsync(Guid id)
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

		public async Task<PasswordReset> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[PasswordReset] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							PasswordReset client = PasswordResetDataReader.BuildFromDataReader(reader);
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

		public async Task UpdatePasswordResetAsync(PasswordReset entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await UpdatePasswordResetAsync(con, entity);
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


		public async Task UpdatePasswordResetAsync(SqlConnection con, PasswordReset entity)
		{
			string sql = @"UPDATE [dbo].[PasswordHistory]
   SET [ID] = <ID, uniqueidentifier,>
      ,[MemberID] = <MemberID, uniqueidentifier,>
      ,[Password] = <Password, varchar(50),>
      ,[PasswordSalt] = <PasswordSalt, varchar(50),>
      ,[PasswordHashAlgorithm] = <PasswordHashAlgorithm, int,>
      ,[Created] = <Created, datetime,>
      ,[CreatedBy] = <CreatedBy, varchar(50),>
      ,[LastModified] = <LastModified, datetime,>
      ,[LastModifiedBy] = <LastModifiedBy, varchar(50),>
 WHERE <Search Conditions,,>

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
				throw new Exception($"Failed to update PasswordReset {entity.ID} ");
			}
		}



	}  // end of class
}  // end of namespace
