using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class AccessRedirectProvider : ProviderBase
	{
		public AccessRedirectProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task<List<AccessRedirect>> GetAccessRedirectsAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetAccessRedirectsAsync(con);
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

		public async Task<List<AccessRedirect>> GetAccessRedirectsAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[AccessRedirect]";

			List<AccessRedirect> clientList = new List<AccessRedirect>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						AccessRedirect client = AccessRedirectDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<AccessRedirect> GetByIdAsync(string redirectKey)
		{
			if (String.IsNullOrEmpty(redirectKey)) return null;

			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetByIdAsync(redirectKey);
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

		public async Task<AccessRedirect> GetByIdAsync(SqlConnection con, string redirectKey)
		{

			string sql = $"SELECT * FROM [dbo].[AccessRedirect] where [RedirectKey] = '{redirectKey}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							AccessRedirect client = AccessRedirectDataReader.BuildFromDataReader(reader);
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
