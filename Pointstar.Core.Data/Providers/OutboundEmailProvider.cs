using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class OutboundEmailProvider : ProviderBase
	{
		public OutboundEmailProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task<int> InsertOutboundEmailAsync(OutboundEmail entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await InsertOutboundEmailAsync(con, entity);
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

		public async Task<int> InsertOutboundEmailAsync(SqlConnection con, OutboundEmail entity)
		{
			string sql = @"INSERT INTO [dbo].[OutboundEmail]
           ([OrderID]
           ,[MemberID]
           ,[Type]
           ,[Subject]
           ,[Recipient]
           
		   ,[Body]
           ,[Exception]
           ,[Cookie]
           ,[IPAddress]
           ,[Status]
           
		   ,[Created])
     VALUES
           (@OrderID
           ,@MemberID
           ,@Type
           ,@Subject
           ,@Recipient
           
		   ,@Body
           ,@Exception
           ,@Cookie
           ,@IPAddress
           ,@Status
           
		   ,getdate());";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				if (entity.OrderID.HasValue)
					command.Parameters.AddWithValue("OrderID", entity.OrderID.Value);
				else
					command.Parameters.AddWithValue("OrderID", DBNull.Value);
				if (entity.MemberID.HasValue)
					command.Parameters.AddWithValue("MemberID", entity.MemberID);
				else
					command.Parameters.AddWithValue("MemberID", DBNull.Value);
				command.Parameters.AddWithValue("Type", entity.Type);
				command.Parameters.AddWithValue("Subject", entity.Subject);
				command.Parameters.AddWithValue("Recipient", entity.Recipient);

				command.Parameters.AddWithValue("Body", entity.Body);
				command.Parameters.AddWithValue("Exception", entity.Exception);
				command.Parameters.AddWithValue("Cookie", entity.Cookie);
				command.Parameters.AddWithValue("IPAddress", entity.IPAddress);
				command.Parameters.AddWithValue("Status", entity.Status);

				object o = await command.ExecuteScalarAsync();

				int retval = Convert.ToInt32(o);
				return retval;
			}
		}

		public async Task<List<OutboundEmail>> GetOutboundEmailsAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetOutboundEmailsAsync(con);
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

		public async Task<List<OutboundEmail>> GetOutboundEmailsAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[OutboundEmail] order by [Created] desc";

			List<OutboundEmail> clientList = new List<OutboundEmail>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						OutboundEmail client = OutboundEmailDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<OutboundEmail> GetByIdAsync(int id)
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

		public async Task<OutboundEmail> GetByIdAsync(SqlConnection con, int id)
		{

			string sql = $"SELECT * FROM [dbo].[OutboundEmail] where ID = {id};";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							OutboundEmail client = OutboundEmailDataReader.BuildFromDataReader(reader);
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
