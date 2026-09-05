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

		public async Task InsertOutboundEmailAsync(OutboundEmail entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertOutboundEmailAsync(con, entity);
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

		public async Task InsertOutboundEmailAsync(SqlConnection con, OutboundEmail entity)
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
           (<OrderID, uniqueidentifier,>
           ,<MemberID, uniqueidentifier,>
           ,<Type, varchar(50),>
           ,<Subject, varchar(300),>
           ,<Recipient, varchar(300),>
           ,<Body, varchar(max),>
           ,<Exception, varchar(max),>
           ,<Cookie, varchar(50),>
           ,<IPAddress, varchar(50),>
           ,<Status, varchar(20),>
           ,<Created, datetime,>);";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);

				await command.ExecuteNonQueryAsync();
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


		public async Task<OutboundEmail> GetByIdAsync(Guid id)
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

		public async Task<OutboundEmail> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[OutboundEmail] where ID = '{id}';";


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
