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
           (@VisitorID
           ,@SiteVisitID
           ,@MemberID
           ,@IPAddress
           ,@FirstName
           
		   ,@LastName
           ,@CompanyName
           ,@JobTitle
           ,@Address1
           ,@Address2
           
		   ,@City
           ,@StateProvince
           ,@StateCode
           ,@PostalCode
           ,@Country
           
		   ,@CountryCode
           ,@PrimaryPhone
           ,@PrimaryPhoneExt
           ,@PrimaryPhoneDigits
           ,@PrimaryPhoneType
           
		   ,@ChemPoint
           ,@ChemStat
           ,@ChemPointPro
           ,@InfiniteExtent
           ,@SuperSlug
           
		   ,@StepMaster
           ,@MohrView
           ,@SieveGraph
           ,@Movies
           ,getdate()
           
		   ,@EmailAddress
           ,@Taafi);";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				if (entity.VisitorID.HasValue)
					command.Parameters.AddWithValue("VisitorID", entity.VisitorID.Value);
				else
					command.Parameters.AddWithValue("VisitorID", DBNull.Value);
				if (entity.SiteVisitID.HasValue)
					command.Parameters.AddWithValue("SiteVisitID", entity.SiteVisitID.Value);
				else
					command.Parameters.AddWithValue("SiteVisitID", DBNull.Value);
				if (entity.MemberID.HasValue)
					command.Parameters.AddWithValue("MemberID", entity.MemberID.Value);
				else
					command.Parameters.AddWithValue("MemberID", DBNull.Value);
				command.Parameters.AddWithValue("IPAddress", entity.IPAddress);
				command.Parameters.AddWithValue("FirstName", entity.FirstName);

				command.Parameters.AddWithValue("LastName", entity.LastName);
				command.Parameters.AddWithValue("CompanyName", entity.CompanyName);
				command.Parameters.AddWithValue("JobTitle", entity.JobTitle);
				command.Parameters.AddWithValue("Address1", entity.Address1);
				command.Parameters.AddWithValue("Address2", entity.Address2);

				command.Parameters.AddWithValue("City", entity.City);
				command.Parameters.AddWithValue("StateProvince", entity.StateProvince);
				command.Parameters.AddWithValue("StateCode", entity.StateCode);
				command.Parameters.AddWithValue("PostalCode", entity.PostalCode);
				command.Parameters.AddWithValue("Country", entity.Country);

				command.Parameters.AddWithValue("CountryCode", entity.CountryCode);
				command.Parameters.AddWithValue("PrimaryPhone", entity.PrimaryPhone);
				command.Parameters.AddWithValue("PrimaryPhoneExt", entity.PrimaryPhoneExt);
				command.Parameters.AddWithValue("PrimaryPhoneDigits", entity.PrimaryPhoneDigits);
				command.Parameters.AddWithValue("PrimaryPhoneType", entity.PrimaryPhoneType);

				command.Parameters.AddWithValue("ChemPoint", entity.ChemPoint);
				command.Parameters.AddWithValue("ChemStat", entity.ChemStat);
				command.Parameters.AddWithValue("ChemPointPro", entity.ChemPointPro);
				command.Parameters.AddWithValue("InfiniteExtent", entity.InfiniteExtent);
				command.Parameters.AddWithValue("SuperSlug", entity.SuperSlug);

				command.Parameters.AddWithValue("StepMaster", entity.StepMaster);
				command.Parameters.AddWithValue("MohrView", entity.MohrView);
				command.Parameters.AddWithValue("SieveGraph", entity.SieveGraph);
				command.Parameters.AddWithValue("Movies", entity.Movies);

				command.Parameters.AddWithValue("EmailAddress", entity.EmailAddress);
				command.Parameters.AddWithValue("Taafi", entity.Taafi);

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
