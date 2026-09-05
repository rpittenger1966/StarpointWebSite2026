using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class DownloadLogProvider : ProviderBase
	{
		public DownloadLogProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertDownloadLogAsync(DownloadLog entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertDownloadLogAsync(con, entity);
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

		public async Task InsertDownloadLogAsync(SqlConnection con, DownloadLog entity)
		{
			string sql = @"INSERT INTO [dbo].[DownloadLog]
           ([ID]
           ,[VisitorID]
           ,[RedirectID]
           ,[SiteVisitID]
           ,[MemberID]
           
		   ,[OrderID]
           ,[OrderLineItemID]
           ,[FileName]
           ,[MemberName]
           ,[LandingPageName]
           
		   ,[LandingPageEmail]
           ,[PageUrl]
           ,[Created])
     VALUES
           (@ID
           ,@VisitorID
           ,@RedirectID
           ,@SiteVisitID
           ,@MemberID
           
		   ,@OrderID
           ,@OrderLineItemID
           ,@FileName
           ,@MemberName
           ,@LandingPageName
           
		   ,@LandingPageEmail
           ,@PageUrl
           ,getdate());";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);
				if (entity.VisitorID.HasValue)
					command.Parameters.AddWithValue("VisitorID", entity.VisitorID.Value);
				else
					command.Parameters.AddWithValue("VisitorID", DBNull.Value);
				if (entity.RedirectID.HasValue)
					command.Parameters.AddWithValue("RedirectID", entity.RedirectID.Value);
				else
					command.Parameters.AddWithValue("RedirectID", DBNull.Value);
				if (entity.SiteVisitID.HasValue)
					command.Parameters.AddWithValue("SiteVisitID", entity.SiteVisitID.Value);
				else
					command.Parameters.AddWithValue("SiteVisitID", DBNull.Value);
				if (entity.MemberID.HasValue)
					command.Parameters.AddWithValue("MemberID", entity.MemberID.Value);
				else
					command.Parameters.AddWithValue("MemberID", DBNull.Value);

				if (entity.OrderID.HasValue)
					command.Parameters.AddWithValue("OrderID", entity.OrderID.Value);
				else
					command.Parameters.AddWithValue("OrderID", DBNull.Value);
				if (entity.OrderLineItemID.HasValue)
					command.Parameters.AddWithValue("OrderLineItemID", entity.OrderLineItemID.Value);
				else
					command.Parameters.AddWithValue("OrderLineItemID", DBNull.Value);

				command.Parameters.AddWithValue("FileName", entity.FileName);
				command.Parameters.AddWithValue("MemberName", entity.MemberName);
				command.Parameters.AddWithValue("LandingPageName", entity.LandingPageName);

				command.Parameters.AddWithValue("LandingPageEmail", entity.LandingPageEmail);
				command.Parameters.AddWithValue("PageUrl", entity.PageUrl);

				await command.ExecuteNonQueryAsync();
			}
		}

		//public async Task<List<DownloadLog>> GetDownloadLogsAsync()
		//{
		//	SqlConnection con = null;

		//	try
		//	{
		//		using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
		//		{
		//			return await GetDownloadLogsAsync(con);
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

		//public async Task<List<DownloadLog>> GetDownloadLogsAsync(SqlConnection con)
		//{
		//	string sql = "SELECT * FROM [dbo].[DownloadLog] order by [Created] desc";

		//	List<DownloadLog> clientList = new List<DownloadLog>();

		//	using (SqlCommand command = new SqlCommand(sql, con))
		//	{
		//		using (SqlDataReader reader = await command.ExecuteReaderAsync())
		//		{
		//			while (reader.Read())
		//			{
		//				DownloadLog client = DownloadLogDataReader.BuildFromDataReader(reader);
		//				if (client != null)
		//				{
		//					clientList.Add(client);
		//				}
		//			}
		//		}
		//	}

		//	return clientList;
		//}


		//public async Task<DownloadLog> GetByIdAsync(Guid id)
		//{
		//	if (id == null) return null;

		//	SqlConnection con = null;

		//	try
		//	{
		//		using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
		//		{
		//			return await GetByIdAsync(id);
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

		//public async Task<DownloadLog> GetByIdAsync(SqlConnection con, Guid id)
		//{

		//	string sql = $"SELECT * FROM [dbo].[DownloadLog] where ID = '{id}';";


		//	try
		//	{
		//		using (SqlCommand command = new SqlCommand(sql, con))
		//		{
		//			using (SqlDataReader reader = await command.ExecuteReaderAsync())
		//			{
		//				while (reader.Read())
		//				{
		//					DownloadLog client = DownloadLogDataReader.BuildFromDataReader(reader);
		//					return client;
		//				}
		//			}
		//		}

		//		return null;
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



	}  // end of class
}  // end of namespace
