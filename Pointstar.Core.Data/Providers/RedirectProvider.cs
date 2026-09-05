using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class RedirectProvider : ProviderBase
	{
		public RedirectProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertRedirectAsync(Redirect entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertRedirectAsync(con, entity);
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

		public async Task InsertRedirectAsync(SqlConnection con, Redirect entity)
		{
			string sql = @"INSERT INTO [dbo].[Redirect]
           ([ID]
           ,[OrderID]
           ,[OrderLineItemID]
           ,[MemberID]
           ,[Caption]
           
		   ,[Directory]
           ,[FileName]
           ,[DownloadCount]
           ,[DownloadMax]
           ,[SingleUser]
           
		   ,[FirstUserCookie]
           ,[Created])
     VALUES
           (@ID
           ,@OrderID
           ,@OrderLineItemID
           ,@MemberID
           ,@Caption
           
		   ,@Directory
           ,@FileName
           ,@DownloadCount
           ,@DownloadMax
           ,@SingleUser
           
		   ,@FirstUserCookie
           ,getdate())
;";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);
				if (entity.OrderID.HasValue)
					command.Parameters.AddWithValue("OrderID", entity.OrderID.Value);
				else
					command.Parameters.AddWithValue("OrderID", DBNull.Value);
				if (entity.OrderLineItemID.HasValue)
					command.Parameters.AddWithValue("OrderLineItemID", entity.OrderLineItemID.Value);
				else
					command.Parameters.AddWithValue("OrderLineItemID", DBNull.Value);
				if (entity.MemberID.HasValue)
					command.Parameters.AddWithValue("MemberID", entity.MemberID.Value);
				else
					command.Parameters.AddWithValue("MemberID", DBNull.Value);
				command.Parameters.AddWithValue("Caption", entity.Caption);

				command.Parameters.AddWithValue("Directory", entity.Directory);
				command.Parameters.AddWithValue("FileName", entity.FileName);
				command.Parameters.AddWithValue("DownloadCount", entity.DownloadCount);
				command.Parameters.AddWithValue("DownloadMax", entity.DownloadMax);
				command.Parameters.AddWithValue("SingleUser", entity.SingleUser);

				if (!String.IsNullOrEmpty(entity.FirstUserCookie))
					command.Parameters.AddWithValue("FirstUserCookie", entity.FirstUserCookie);
				else
					command.Parameters.AddWithValue("FirstUserCookie", DBNull.Value);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<Redirect>> GetRedirectsAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetRedirectsAsync(con);
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

		public async Task<List<Redirect>> GetRedirectsAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[Redirect] order by [Created] desc";

			List<Redirect> clientList = new List<Redirect>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						Redirect client = RedirectDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<Redirect> GetByIdAsync(Guid id)
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

		public async Task<Redirect> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[Redirect] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							Redirect client = RedirectDataReader.BuildFromDataReader(reader);
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

	//	public async Task UpdateRedirectAsync(Redirect entity)
	//	{
	//		SqlConnection con = null;

	//		try
	//		{
	//			using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
	//			{
	//				await UpdateRedirectAsync(con, entity);
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


	//	public async Task UpdateRedirectAsync(SqlConnection con, Redirect entity)
	//	{
	//		string sql = @"UPDATE [dbo].[Redirect]
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
	//			throw new Exception($"Failed to update Redirect {entity.ID} for {entity.CustomerEmailAddress}");
	//		}
	//	}



	}  // end of class
}  // end of namespace
