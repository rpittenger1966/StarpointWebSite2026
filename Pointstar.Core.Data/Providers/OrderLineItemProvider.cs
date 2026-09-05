using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class OrderLineItemProvider : ProviderBase
	{
		public OrderLineItemProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertOrderLineItemAsync(OrderLineItem entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertOrderLineItemAsync(con, entity);
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

		public async Task InsertOrderLineItemAsync(SqlConnection con, OrderLineItem entity)
		{
			string sql = @"INSERT INTO [dbo].[OrderLineItem]
           ([ID]
           ,[MemberID]
           ,[OrderID]
           ,[ProductID]
           ,[ProductLicenseID]
           ,[ProductDescription]
           ,[LicenseDescription]
           ,[Price]
           ,[Quantity]
           ,[DiscountAmount]
           ,[DiscountPercent]
           ,[LineTotal]
           ,[PromotionCode]
           ,[OrderStatus]
           ,[OrderComments]
           ,[RefundedDate]
           ,[RefundedMessage]
           ,[VoidedDate]
           ,[VoidedMessage]
           ,[Created]
           ,[LastModified])
     VALUES
           (<ID, uniqueidentifier,>
           ,<MemberID, uniqueidentifier,>
           ,<OrderID, uniqueidentifier,>
           ,<ProductID, int,>
           ,<ProductLicenseID, uniqueidentifier,>
           ,<ProductDescription, varchar(300),>
           ,<LicenseDescription, varchar(300),>
           ,<Price, decimal(18,0),>
           ,<Quantity, int,>
           ,<DiscountAmount, decimal(18,0),>
           ,<DiscountPercent, float,>
           ,<LineTotal, decimal(18,0),>
           ,<PromotionCode, varchar(25),>
           ,<OrderStatus, int,>
           ,<OrderComments, varchar(max),>
           ,<RefundedDate, datetime,>
           ,<RefundedMessage, varchar(max),>
           ,<VoidedDate, datetime,>
           ,<VoidedMessage, varchar(max),>
           ,<Created, datetime,>
           ,<LastModified, datetime,>)
;";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);

//				command.Parameters.AddWithValue("Status", entity.Status);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<OrderLineItem>> GetOrderLineItemsAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetOrderLineItemsAsync(con);
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

		public async Task<List<OrderLineItem>> GetOrderLineItemsAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[OrderLineItem] order by [Created] desc";

			List<OrderLineItem> clientList = new List<OrderLineItem>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						OrderLineItem client = OrderLineItemDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<OrderLineItem> GetByIdAsync(Guid id)
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

		public async Task<OrderLineItem> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[OrderLineItem] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							OrderLineItem client = OrderLineItemDataReader.BuildFromDataReader(reader);
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

	//	public async Task UpdateOrderLineItemAsync(OrderLineItem entity)
	//	{
	//		SqlConnection con = null;

	//		try
	//		{
	//			using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
	//			{
	//				await UpdateOrderLineItemAsync(con, entity);
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


	//	public async Task UpdateOrderLineItemAsync(SqlConnection con, OrderLineItem entity)
	//	{
			
	//		string sql = @"UPDATE [dbo].[OrderLineItem]
 //  SET [ID] = <ID, uniqueidentifier,>
 //     ,[MemberID] = <MemberID, uniqueidentifier,>
 //     ,[OrderID] = <OrderID, uniqueidentifier,>
 //     ,[ProductID] = <ProductID, int,>
 //     ,[ProductLicenseID] = <ProductLicenseID, uniqueidentifier,>
 //     ,[ProductDescription] = <ProductDescription, varchar(300),>
 //     ,[LicenseDescription] = <LicenseDescription, varchar(300),>
 //     ,[Price] = <Price, decimal(18,0),>
 //     ,[Quantity] = <Quantity, int,>
 //     ,[DiscountAmount] = <DiscountAmount, decimal(18,0),>
 //     ,[DiscountPercent] = <DiscountPercent, float,>
 //     ,[LineTotal] = <LineTotal, decimal(18,0),>
 //     ,[PromotionCode] = <PromotionCode, varchar(25),>
 //     ,[OrderStatus] = <OrderStatus, int,>
 //     ,[OrderComments] = <OrderComments, varchar(max),>
 //     ,[RefundedDate] = <RefundedDate, datetime,>
 //     ,[RefundedMessage] = <RefundedMessage, varchar(max),>
 //     ,[VoidedDate] = <VoidedDate, datetime,>
 //     ,[VoidedMessage] = <VoidedMessage, varchar(max),>
 //     ,[Created] = <Created, datetime,>
 //     ,[LastModified] = <LastModified, datetime,>
 //WHERE <Search Conditions,,>


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
	//			throw new Exception($"Failed to update OrderLineItem {entity.ID} for {entity.CustomerEmailAddress}");
	//		}
	//	}



	}  // end of class
}  // end of namespace
