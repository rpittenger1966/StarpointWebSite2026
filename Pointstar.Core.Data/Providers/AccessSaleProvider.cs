using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class AccessSaleProvider : ProviderBase
	{
		public AccessSaleProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertAccessSaleAsync(AccessSale entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertAccessSaleAsync(con, entity);
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

		public async Task InsertAccessSaleAsync(SqlConnection con, AccessSale entity)
		{
			string sql = @"INSERT INTO [dbo].[AccessSale]
           ([OrderID]
           ,[SaleKey]
           ,[FirstName]
           ,[LastName]
           ,[IPAddress]
           
		   ,[Email]
           ,[ChemPointStd]
           ,[ChemPointPro]
           ,[ChemStat]
           ,[ChemPointChemStat]
           
		   ,[InfiniteExtent]
           ,[SuperSlug]
           ,[StepMaster]
           ,[AquiferTest]
           ,[MohrView]
           
		   ,[SieveGraph]
           ,[Geotech]
           ,[OrderDate]
           ,[ExpirationDate]
           ,[GrandTotal]
           
		   ,[Shipping]
           ,[SalesTax]
           ,[SalesTaxRate]
           ,[ConfirmationNumber]
           ,[ApprovalCode]
           
		   ,[Server]
           ,[Year]
           ,[Month]
           ,[Day]
           ,[Hour]
           
		   ,[Minute]
           ,[Second]
           ,[DayOfWeek]
           ,[Created]
           ,[Email2]
           
		   ,[Taafi])
     VALUES
           (@OrderID
           ,@SaleKey
           ,@FirstName
           ,@LastName
           ,@IPAddress
           
		   ,@Email
           ,@ChemPointStd
           ,@ChemPointPro
           ,@ChemStat
           ,@ChemPointChemStat
           
		   ,@InfiniteExtent
           ,@SuperSlug
           ,@StepMaster
           ,@AquiferTest
           ,@MohrView
           
		   ,@SieveGraph
           ,@Geotech
           ,@OrderDate
           ,@ExpirationDate
           ,@GrandTotal
           
		   ,@Shipping
           ,@SalesTax
           ,@SalesTaxRate
           ,@ConfirmationNumber
           ,@ApprovalCode
           
		   ,@Server
           ,@Year
           ,@Month
           ,@Day
           ,@Hour
           
		   ,@Minute
           ,@Second
           ,@DayOfWeek
           ,getdate()
           ,@Email2
           ,@Taafi);";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("OrderID", entity.OrderID);
				command.Parameters.AddWithValue("SaleKey", entity.SaleKey);
				command.Parameters.AddWithValue("FirstName", entity.FirstName);
				command.Parameters.AddWithValue("LastName", entity.LastName);
				command.Parameters.AddWithValue("IPAddress", entity.IPAddress);

				command.Parameters.AddWithValue("Email", entity.Email);
				command.Parameters.AddWithValue("ChemPointStd", entity.ChemPointStd);
				command.Parameters.AddWithValue("ChemPointPro", entity.ChemPointPro);
				command.Parameters.AddWithValue("ChemStat", entity.ChemStat);
				command.Parameters.AddWithValue("ChemPointChemStat", entity.ChemPointChemStat);

				command.Parameters.AddWithValue("InfiniteExtent", entity.InfiniteExtent);
				command.Parameters.AddWithValue("SuperSlug", entity.SuperSlug);
				command.Parameters.AddWithValue("StepMaster", entity.StepMaster);
				command.Parameters.AddWithValue("AquiferTest", entity.AquiferTest);
				command.Parameters.AddWithValue("MohrView", entity.MohrView);

				command.Parameters.AddWithValue("SieveGraph", entity.SieveGraph);
				command.Parameters.AddWithValue("Geotech", entity.Geotech);
				command.Parameters.AddWithValue("OrderDate", entity.OrderDate);
				command.Parameters.AddWithValue("ExpirationDate", entity.ExpirationDate);
				command.Parameters.AddWithValue("GrandTotal", entity.GrandTotal);

				command.Parameters.AddWithValue("Shipping", entity.Shipping);
				command.Parameters.AddWithValue("SalesTax", entity.SalesTax);
				command.Parameters.AddWithValue("SalesTaxRate", entity.SalesTaxRate);
				command.Parameters.AddWithValue("ConfirmationNumber", entity.ConfirmationNumber);
				command.Parameters.AddWithValue("ApprovalCode", entity.ApprovalCode);

				command.Parameters.AddWithValue("Server", entity.Server);
				command.Parameters.AddWithValue("Year", DateTime.Now.Year);
				command.Parameters.AddWithValue("Month", DateTime.Now.Month);
				command.Parameters.AddWithValue("Day", DateTime.Now.Day);
				command.Parameters.AddWithValue("Hour", DateTime.Now.Hour);

				command.Parameters.AddWithValue("Minute", DateTime.Now.Minute);
				command.Parameters.AddWithValue("Second", DateTime.Now.Second);
				command.Parameters.AddWithValue("DayOfWeek", Convert.ToInt32(DateTime.Now.DayOfWeek));
				command.Parameters.AddWithValue("Email2", entity.Email2);
				command.Parameters.AddWithValue("Taafi", entity.Taafi);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<AccessSale>> GetAccessSalesAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetAccessSalesAsync(con);
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

		public async Task<List<AccessSale>> GetAccessSalesAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[AccessSale] order by [Created] desc";

			List<AccessSale> clientList = new List<AccessSale>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						AccessSale client = AccessSaleDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<AccessSale> GetByIdAsync(Guid id)
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

		public async Task<AccessSale> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[AccessSale] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							AccessSale client = AccessSaleDataReader.BuildFromDataReader(reader);
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

	//	public async Task UpdateAccessSaleAsync(AccessSale entity)
	//	{
	//		SqlConnection con = null;

	//		try
	//		{
	//			using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
	//			{
	//				await UpdateAccessSaleAsync(con, entity);
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


	//	public async Task UpdateAccessSaleAsync(SqlConnection con, AccessSale entity)
	//	{
	//		string sql = @"UPDATE [dbo].[AccessSale]
 //  SET [OrderID] = <OrderID, uniqueidentifier,>
 //     ,[SaleKey] = <SaleKey, varchar(50),>
 //     ,[FirstName] = <FirstName, varchar(50),>
 //     ,[LastName] = <LastName, varchar(50),>
 //     ,[IPAddress] = <IPAddress, varchar(50),>
 //     ,[Email] = <Email, varchar(50),>
 //     ,[ChemPointStd] = <ChemPointStd, int,>
 //     ,[ChemPointPro] = <ChemPointPro, int,>
 //     ,[ChemStat] = <ChemStat, int,>
 //     ,[ChemPointChemStat] = <ChemPointChemStat, int,>
 //     ,[InfiniteExtent] = <InfiniteExtent, int,>
 //     ,[SuperSlug] = <SuperSlug, int,>
 //     ,[StepMaster] = <StepMaster, int,>
 //     ,[AquiferTest] = <AquiferTest, int,>
 //     ,[MohrView] = <MohrView, int,>
 //     ,[SieveGraph] = <SieveGraph, int,>
 //     ,[Geotech] = <Geotech, int,>
 //     ,[OrderDate] = <OrderDate, datetime,>
 //     ,[ExpirationDate] = <ExpirationDate, datetime,>
 //     ,[GrandTotal] = <GrandTotal, decimal(18,0),>
 //     ,[Shipping] = <Shipping, decimal(18,0),>
 //     ,[SalesTax] = <SalesTax, decimal(18,0),>
 //     ,[SalesTaxRate] = <SalesTaxRate, float,>
 //     ,[ConfirmationNumber] = <ConfirmationNumber, varchar(255),>
 //     ,[ApprovalCode] = <ApprovalCode, varchar(255),>
 //     ,[Server] = <Server, varchar(20),>
 //     ,[Year] = <Year, int,>
 //     ,[Month] = <Month, int,>
 //     ,[Day] = <Day, int,>
 //     ,[Hour] = <Hour, int,>
 //     ,[Minute] = <Minute, int,>
 //     ,[Second] = <Second, int,>
 //     ,[DayOfWeek] = <DayOfWeek, int,>
 //     ,[Created] = <Created, datetime,>
 //     ,[Email2] = <Email2, varchar(100),>
 //     ,[Taafi] = <Taafi, int,>
 //WHERE ID=@ID;

	//	";

	//		try
	//		{
	//			using (SqlCommand command = new SqlCommand(sql, con))
	//			{
	//				command.Parameters.AddWithValue("ID", entity.ID);

	//				await command.ExecuteNonQueryAsync();
	//			}
	//		}
	//		catch (Exception ex)
	//		{
	//			throw new Exception($"Failed to update AccessSale {entity.ID} ");
	//		}
	//	}



	}  // end of class
}  // end of namespace
