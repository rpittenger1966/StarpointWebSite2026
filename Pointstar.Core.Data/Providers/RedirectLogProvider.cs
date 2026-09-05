using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class RedirectLogProvider : ProviderBase
	{
		public RedirectLogProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertRedirectLogAsync(RedirectLog entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertRedirectLogAsync(con, entity);
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

		public async Task InsertRedirectLogAsync(SqlConnection con, RedirectLog entity)
		{
			string sql = @"INSERT INTO [dbo].[RedirectLog]
           ([ID]
           ,[RedirectID]
           ,[FileName]
           ,[MemberID]
           ,[SiteVisitID]
           ,[VisitorID]
           ,[IPAddress]
           ,[Created])
     VALUES
           (@ID
           ,@RedirectID
           ,@FileName
           ,@MemberID
           ,@SiteVisitID
           ,@VisitorID
           ,@IPAddress
           ,getdate());";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);
				command.Parameters.AddWithValue("RedirectID", entity.RedirectID);
				command.Parameters.AddWithValue("FileName", entity.FileName);
				if (entity.MemberID.HasValue)
					command.Parameters.AddWithValue("MemberID", entity.MemberID.Value);
				else
					command.Parameters.AddWithValue("MemberID", DBNull.Value);
				if (entity.SiteVisitID.HasValue)
					command.Parameters.AddWithValue("SiteVisitID", entity.SiteVisitID.Value);
				else
					command.Parameters.AddWithValue("SiteVisitID", DBNull.Value);
				if (entity.VisitorID.HasValue)
					command.Parameters.AddWithValue("VisitorID", entity.VisitorID.Value);
				else
					command.Parameters.AddWithValue("VisitorID", DBNull.Value);
				command.Parameters.AddWithValue("IPAddress", entity.IPAddress);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<RedirectLog>> GetRedirectLogsAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetRedirectLogsAsync(con);
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

		public async Task<List<RedirectLog>> GetRedirectLogsAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[RedirectLog] order by [Created] desc";

			List<RedirectLog> clientList = new List<RedirectLog>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						RedirectLog client = RedirectLogDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<RedirectLog> GetByIdAsync(Guid id)
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

		public async Task<RedirectLog> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[RedirectLog] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							RedirectLog client = RedirectLogDataReader.BuildFromDataReader(reader);
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

	//	public async Task UpdateRedirectLogAsync(RedirectLog entity)
	//	{
	//		SqlConnection con = null;

	//		try
	//		{
	//			using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
	//			{
	//				await UpdateRedirectLogAsync(con, entity);
	//			}
	//		}
	//		catch
	//		{
	//			throw;
	//		}
	//		finally
	//		{
	//			con?.Close();
	//		}
	//	}


	//	public async Task UpdateRedirectLogAsync(SqlConnection con, RedirectLog entity)
	//	{
	//		string sql = @"UPDATE [dbo].[RedirectLog]
 //  SET [ChemPointStandard] = @ChemPointStandard
 //     ,[ChemPointPro] = @ChemPointPro
 //     ,[ChemStat] = @ChemStat
 //     ,[StepMaster] = @StepMaster
 //     ,[SuperSlug] = @SuperSlug
 //     ,[InfiniteExtent] = @InfiniteExtent
 //     ,[MohrView] = @MohrView
 //     ,[SieveGraph] = @SieveGraph
 //     ,[Comments] = @Comments
 //     ,[Price] = @Price
 //     ,[CustomerEmailAddress] = @CustomerEmailAddress
 //     ,[OutboundEmailID] = @OutboundEmailID
 //     ,[DaysValid] = @DaysValid
 //     ,[OrderID] = @OrderID
 //     ,[Status] = @Status
 //     ,[LastModified] = getdate()
 //WHERE ID=@ID;

	//	";

	//		try
	//		{
	//			using (SqlCommand command = new SqlCommand(sql, con))
	//			{
	//				command.Parameters.AddWithValue("ID", entity.ID);
	//				command.Parameters.AddWithValue("ChemPointStandard", entity.ChemPointStandard);
	//				command.Parameters.AddWithValue("ChemPointPro", entity.ChemPointPro);
	//				command.Parameters.AddWithValue("ChemStat", entity.ChemStat);
	//				command.Parameters.AddWithValue("StepMaster", entity.StepMaster);

	//				command.Parameters.AddWithValue("SuperSlug", entity.SuperSlug);
	//				command.Parameters.AddWithValue("InfiniteExtent", entity.InfiniteExtent);
	//				command.Parameters.AddWithValue("MohrView", entity.MohrView);
	//				command.Parameters.AddWithValue("SieveGraph", entity.SieveGraph);
	//				command.Parameters.AddWithValue("Comments", entity.Comments);

	//				command.Parameters.AddWithValue("Price", entity.Price);
	//				command.Parameters.AddWithValue("CustomerEmailAddress", entity.CustomerEmailAddress);

	//				if (entity.OutboundEmailID.HasValue)
	//					command.Parameters.AddWithValue("OutboundEmailID", entity.OutboundEmailID);
	//				else
	//					command.Parameters.AddWithValue("OutboundEmailID", DBNull.Value);

	//				command.Parameters.AddWithValue("DaysValid", entity.DaysValid);

	//				if (entity.OrderID.HasValue)
	//					command.Parameters.AddWithValue("OrderID", entity.OrderID);
	//				else
	//					command.Parameters.AddWithValue("OrderID", DBNull.Value);

	//				command.Parameters.AddWithValue("Status", entity.Status);

	//				await command.ExecuteNonQueryAsync();
	//			}
	//		}
	//		catch (Exception ex)
	//		{
	//			throw new Exception($"Failed to update RedirectLog {entity.ID} for {entity.CustomerEmailAddress}");
	//		}
	//	}



	}  // end of class
}  // end of namespace
