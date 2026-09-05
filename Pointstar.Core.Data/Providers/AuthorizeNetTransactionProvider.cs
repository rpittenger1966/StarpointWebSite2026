using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class AuthorizeNetTransactionProvider : ProviderBase
	{
		public AuthorizeNetTransactionProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertAuthorizeNetTransactionAsync(AuthorizeNetTransaction entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertAuthorizeNetTransactionAsync(con, entity);
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

		public async Task InsertAuthorizeNetTransactionAsync(SqlConnection con, AuthorizeNetTransaction entity)
		{
			string sql = @"INSERT INTO [dbo].[AuthorizeNetTransaction]
           ([PostValues]
           ,[ResponseValues]
           ,[FirstName]
           ,[LastName]
           ,[StartDate]
           
		   ,[EndDate]
           ,[Exception]
           ,[Result]
           ,[TransactionDuration]
           ,[OrderDescription]
           
		   ,[ChargeAmount]
           ,[TestMode])
     VALUES
           (@PostValues
           ,@ResponseValues
           ,@FirstName
           ,@LastName
           ,@StartDate
           
		   ,@EndDate
           ,@Exception
           ,@Result
           ,@TransactionDuration
           ,@OrderDescription
           
		   ,@ChargeAmount
           ,@TestMode);";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("PostValues", entity.PostValues.ToString());
				command.Parameters.AddWithValue("ResponseValues", entity.ResponseValues);
				command.Parameters.AddWithValue("FirstName", entity.FirstName);
				command.Parameters.AddWithValue("LastName", entity.LastName);
				command.Parameters.AddWithValue("StartDate", entity.StartDate);

				command.Parameters.AddWithValue("EndDate", entity.EndDate);
				if (entity.Exception != null)
					command.Parameters.AddWithValue("Exception", entity.Exception);
				else
					command.Parameters.AddWithValue("Exception", DBNull.Value);
				command.Parameters.AddWithValue("Result", entity.Result);
				command.Parameters.AddWithValue("TransactionDuration", entity.TransactionDuration);
				command.Parameters.AddWithValue("OrderDescription", entity.OrderDescription);

				command.Parameters.AddWithValue("ChargeAmount", entity.ChargeAmount);
				command.Parameters.AddWithValue("TestMode", entity.TestMode);

				await command.ExecuteNonQueryAsync();
			}
		}

		//public async Task<List<AuthorizeNetTransaction>> GetAuthorizeNetTransactionsAsync()
		//{
		//	SqlConnection con = null;

		//	try
		//	{
		//		using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
		//		{
		//			return await GetAuthorizeNetTransactionsAsync(con);
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

		//public async Task<List<AuthorizeNetTransaction>> GetAuthorizeNetTransactionsAsync(SqlConnection con)
		//{
		//	string sql = "SELECT * FROM [dbo].[AuthorizeNetTransaction] order by [ID] desc";

		//	List<AuthorizeNetTransaction> clientList = new List<AuthorizeNetTransaction>();

		//	using (SqlCommand command = new SqlCommand(sql, con))
		//	{
		//		using (SqlDataReader reader = await command.ExecuteReaderAsync())
		//		{
		//			while (reader.Read())
		//			{
		//				AuthorizeNetTransaction client = AuthorizeNetTransactionDataReader.BuildFromDataReader(reader);
		//				if (client != null)
		//				{
		//					clientList.Add(client);
		//				}
		//			}
		//		}
		//	}

		//	return clientList;
		//}


		public async Task<AuthorizeNetTransaction> GetByIdAsync(Guid id)
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

		public async Task<AuthorizeNetTransaction> GetByIdAsync(SqlConnection con, int id)
		{

			string sql = $"SELECT * FROM [dbo].[AuthorizeNetTransaction] where ID = {id};";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							AuthorizeNetTransaction client = AuthorizeNetTransactionDataReader.BuildFromDataReader(reader);
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
