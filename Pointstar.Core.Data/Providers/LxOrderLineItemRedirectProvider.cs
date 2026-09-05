using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class LxOrderLineItemRedirectProvider : ProviderBase
	{
		public LxOrderLineItemRedirectProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertLxOrderLineItemRedirectAsync(LxOrderLineItemRedirect entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertLxOrderLineItemRedirectAsync(con, entity);
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

		public async Task InsertLxOrderLineItemRedirectAsync(SqlConnection con, LxOrderLineItemRedirect entity)
		{
			string sql = @"INSERT INTO [dbo].[LxOrderLineItemRedirect]
           ([OrderLineItemID]
           ,[RedirectID]
           ,[OrderID]
           ,[Created])
     VALUES
           (<OrderLineItemID, uniqueidentifier,>
           ,<RedirectID, uniqueidentifier,>
           ,<OrderID, uniqueidentifier,>
           ,<Created, datetime,>);
;";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("OrderLineItemID", entity.OrderLineItemID);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<LxOrderLineItemRedirect>> GetLxOrderLineItemRedirectsAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetLxOrderLineItemRedirectsAsync(con);
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

		public async Task<List<LxOrderLineItemRedirect>> GetLxOrderLineItemRedirectsAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[LxOrderLineItemRedirect] order by [Created] desc";

			List<LxOrderLineItemRedirect> clientList = new List<LxOrderLineItemRedirect>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						LxOrderLineItemRedirect client = LxOrderLineItemRedirectDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<LxOrderLineItemRedirect> GetByIdAsync(Guid id)
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

		public async Task<LxOrderLineItemRedirect> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[LxOrderLineItemRedirect] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							LxOrderLineItemRedirect client = LxOrderLineItemRedirectDataReader.BuildFromDataReader(reader);
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
