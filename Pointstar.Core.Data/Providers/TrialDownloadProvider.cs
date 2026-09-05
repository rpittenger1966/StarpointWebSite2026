using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class TrialDownloadProvider : ProviderBase
	{
		public TrialDownloadProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertTrialDownloadAsync(TrialDownload entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertTrialDownloadAsync(con, entity);
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

		public async Task InsertTrialDownloadAsync(SqlConnection con, TrialDownload entity)
		{
			string sql = @"INSERT INTO [dbo].[TrialDownload]
           ([VisitorID]
           ,[SiteVisitID]
           ,[MemberID]
           ,[IPAddress]
           ,[FirstName]
           ,[LastName]
           ,[CompanyName]
           ,[JobTitle]
           ,[Address1]
           ,[Address2]
           ,[City]
           ,[StateProvince]
           ,[StateCode]
           ,[PostalCode]
           ,[Country]
           ,[CountryCode]
           ,[PrimaryPhone]
           ,[PrimaryPhoneExt]
           ,[PrimaryPhoneDigits]
           ,[PrimaryPhoneType]
           ,[ChemPoint]
           ,[ChemStat]
           ,[ChemPointPro]
           ,[InfiniteExtent]
           ,[SuperSlug]
           ,[StepMaster]
           ,[MohrView]
           ,[SieveGraph]
           ,[Movies]
           ,[Created]
           ,[EmailAddress]
           ,[Taafi])
     VALUES
           (<VisitorID, uniqueidentifier,>
           ,<SiteVisitID, uniqueidentifier,>
           ,<MemberID, uniqueidentifier,>
           ,<IPAddress, varchar(20),>
           ,<FirstName, varchar(50),>
           ,<LastName, varchar(50),>
           ,<CompanyName, varchar(80),>
           ,<JobTitle, varchar(50),>
           ,<Address1, varchar(50),>
           ,<Address2, varchar(40),>
           ,<City, varchar(50),>
           ,<StateProvince, varchar(50),>
           ,<StateCode, varchar(5),>
           ,<PostalCode, varchar(50),>
           ,<Country, varchar(50),>
           ,<CountryCode, varchar(5),>
           ,<PrimaryPhone, varchar(20),>
           ,<PrimaryPhoneExt, varchar(10),>
           ,<PrimaryPhoneDigits, varchar(20),>
           ,<PrimaryPhoneType, int,>
           ,<ChemPoint, bit,>
           ,<ChemStat, bit,>
           ,<ChemPointPro, bit,>
           ,<InfiniteExtent, bit,>
           ,<SuperSlug, bit,>
           ,<StepMaster, bit,>
           ,<MohrView, bit,>
           ,<SieveGraph, bit,>
           ,<Movies, bit,>
           ,<Created, datetime,>
           ,<EmailAddress, varchar(100),>
           ,<Taafi, bit,>)
;
;";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<TrialDownload>> GetTrialDownloadsAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetTrialDownloadsAsync(con);
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

		public async Task<List<TrialDownload>> GetTrialDownloadsAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[TrialDownload] order by [Created] desc";

			List<TrialDownload> clientList = new List<TrialDownload>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						TrialDownload client = TrialDownloadDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<TrialDownload> GetByIdAsync(Guid id)
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

		public async Task<TrialDownload> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[TrialDownload] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							TrialDownload client = TrialDownloadDataReader.BuildFromDataReader(reader);
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
