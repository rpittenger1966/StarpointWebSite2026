using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class ProductInstallationFileProvider : ProviderBase
	{
		public ProductInstallationFileProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}


		public async Task<List<ProductInstallationFile>> GetProductInstallationFilesAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetProductInstallationFilesAsync(con);
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

		public async Task<List<ProductInstallationFile>> GetProductInstallationFilesAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[ProductInstallationFile] order by [Created] desc";

			List<ProductInstallationFile> clientList = new List<ProductInstallationFile>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						ProductInstallationFile client = ProductInstallationFileDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<ProductInstallationFile> GetByIdAsync(Guid id)
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

		public async Task<ProductInstallationFile> GetByIdAsync(SqlConnection con, int id)
		{

			string sql = $"SELECT * FROM [dbo].[ProductInstallationFile] where ID = {id};";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							ProductInstallationFile client = ProductInstallationFileDataReader.BuildFromDataReader(reader);
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
