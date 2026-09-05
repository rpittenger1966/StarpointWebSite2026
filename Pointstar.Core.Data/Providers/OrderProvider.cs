using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class OrderProvider : ProviderBase
	{
		public OrderProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertOrderAsync(Order entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertOrderAsync(con, entity);
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

		public async Task InsertOrderAsync(SqlConnection con, Order entity)
		{
			string sql = @"INSERT INTO [dbo].[Order]
           ([ID]
           ,[VisitorID]
           ,[SiteVisitID]
           ,[MemberID]
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
           
		   ,[UserEmail]
           ,[EmailReceiptID]
           ,[ChargeResult]
           ,[TransactionNumber]
           ,[AuthorizationCode]
           
		   ,[ResponseXML]
           ,[ChargeMode]
           ,[MaskedCreditCardNumber]
           ,[NameOnCreditCard]
           ,[CreditCardType]
           
		   ,[SubTotal]
           ,[Discount]
           ,[Tax]
           ,[Total]
           ,[PromotionCode]
           
		   ,[BonusDays]
           ,[TermsAndConditions]
           ,[OrderStatus]
           ,[OrderComments]
           ,[RefundedDate]
           
		   ,[RefundedMessage]
           ,[VoidedDate]
           ,[VoidedMessage]
           ,[Created]
           ,[RedirectLink]
           ,[UserEmailAlternate])
     VALUES
           (@ID
           ,@VisitorID
           ,@SiteVisitID
           ,@MemberID
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
           
		   ,@UserEmail
           ,@EmailReceiptID
           ,@ChargeResult
           ,@TransactionNumber
           ,@AuthorizationCode
           
		   ,@ResponseXML
           ,@ChargeMode
           ,@MaskedCreditCardNumber
           ,@NameOnCreditCard
           ,@CreditCardType

           ,@SubTotal
		   ,@Discount
           ,@Tax
           ,@Total
           ,@PromotionCode

           ,@BonusDays
		   ,@TermsAndConditions
           ,@OrderStatus
           ,@OrderComments
           ,@RefundedDate

           ,@RefundedMessage
		   ,@VoidedDate
           ,@VoidedMessage
           ,getdate()
           ,@RedirectLink
           ,@UserEmailAlternate);
;";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);
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

				command.Parameters.AddWithValue("UserEmail", entity.UserEmail);
				if (entity.EmailReceiptID.HasValue)
					command.Parameters.AddWithValue("EmailReceiptID", entity.EmailReceiptID.Value);
				else
					command.Parameters.AddWithValue("EmailReceiptID", DBNull.Value);
				command.Parameters.AddWithValue("ChargeResult", entity.ChargeResult);
				command.Parameters.AddWithValue("TransactionNumber", entity.TransactionNumber);
				command.Parameters.AddWithValue("AuthorizationCode", entity.AuthorizationCode);

				if (entity.ResponseXML != null)
					command.Parameters.AddWithValue("ResponseXML", entity.ResponseXML.ToString());
				else
					command.Parameters.AddWithValue("ResponseXML", DBNull.Value);
				command.Parameters.AddWithValue("ChargeMode", entity.ChargeMode);
				command.Parameters.AddWithValue("MaskedCreditCardNumber", entity.MaskedCreditCardNumber);
				command.Parameters.AddWithValue("NameOnCreditCard", entity.NameOnCreditCard);
				command.Parameters.AddWithValue("CreditCardType", entity.CreditCardType);

				command.Parameters.AddWithValue("SubTotal", entity.SubTotal);
				command.Parameters.AddWithValue("Discount", entity.Discount);
				command.Parameters.AddWithValue("Tax", entity.Tax);
				command.Parameters.AddWithValue("Total", entity.Total);
				command.Parameters.AddWithValue("PromotionCode", entity.PromotionCode);

				command.Parameters.AddWithValue("BonusDays", entity.BonusDays);
				command.Parameters.AddWithValue("TermsAndConditions", entity.TermsAndConditions);
				command.Parameters.AddWithValue("OrderStatus", entity.OrderStatus);
				command.Parameters.AddWithValue("OrderComments", entity.OrderComments);
				if (entity.RefundedDate.HasValue)
					command.Parameters.AddWithValue("RefundedDate", entity.RefundedDate.Value);
				else
					command.Parameters.AddWithValue("RefundedDate", DBNull.Value);

				command.Parameters.AddWithValue("RefundedMessage", entity.RefundedMessage);
				if (entity.VoidedDate.HasValue)
					command.Parameters.AddWithValue("VoidedDate", entity.VoidedDate.Value);
				else
					command.Parameters.AddWithValue("VoidedDate", DBNull.Value);
				command.Parameters.AddWithValue("VoidedMessage", entity.VoidedMessage);
				command.Parameters.AddWithValue("RedirectLink", entity.RedirectLink);
				command.Parameters.AddWithValue("UserEmailAlternate", entity.UserEmailAlternate);

				await command.ExecuteNonQueryAsync();
			}
		}

		//public async Task<List<Order>> GetOrdersAsync()
		//{
		//	SqlConnection con = null;

		//	try
		//	{
		//		using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
		//		{
		//			return await GetOrdersAsync(con);
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

		//public async Task<List<Order>> GetOrdersAsync(SqlConnection con)
		//{
		//	string sql = "SELECT * FROM [dbo].[Order] order by [Created] desc";

		//	List<Order> clientList = new List<Order>();

		//	using (SqlCommand command = new SqlCommand(sql, con))
		//	{
		//		using (SqlDataReader reader = await command.ExecuteReaderAsync())
		//		{
		//			while (reader.Read())
		//			{
		//				Order client = OrderDataReader.BuildFromDataReader(reader);
		//				if (client != null)
		//				{
		//					clientList.Add(client);
		//				}
		//			}
		//		}
		//	}

		//	return clientList;
		//}


		public async Task<Order> GetByIdAsync(Guid id)
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

		public async Task<Order> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[Order] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							Order client = OrderDataReader.BuildFromDataReader(reader);
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

	//	public async Task UpdateOrderAsync(Order entity)
	//	{
	//		SqlConnection con = null;

	//		try
	//		{
	//			using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
	//			{
	//				await UpdateOrderAsync(con, entity);
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


	//	public async Task UpdateOrderAsync(SqlConnection con, Order entity)
	//	{
	//		throw new NotImplementedException();

	//		string sql = @"UPDATE [dbo].[Order]
 //  SET [ID] = <ID, uniqueidentifier,>
 //     ,[VisitorID] = <VisitorID, uniqueidentifier,>
 //     ,[SiteVisitID] = <SiteVisitID, uniqueidentifier,>
 //     ,[MemberID] = <MemberID, uniqueidentifier,>
 //     ,[FirstName] = <FirstName, varchar(50),>
 //     ,[LastName] = <LastName, varchar(50),>
 //     ,[CompanyName] = <CompanyName, varchar(80),>
 //     ,[JobTitle] = <JobTitle, varchar(50),>
 //     ,[Address1] = <Address1, varchar(50),>
 //     ,[Address2] = <Address2, varchar(40),>
 //     ,[City] = <City, varchar(50),>
 //     ,[StateProvince] = <StateProvince, varchar(50),>
 //     ,[StateCode] = <StateCode, varchar(5),>
 //     ,[PostalCode] = <PostalCode, varchar(50),>
 //     ,[Country] = <Country, varchar(50),>
 //     ,[CountryCode] = <CountryCode, varchar(5),>
 //     ,[PrimaryPhone] = <PrimaryPhone, varchar(20),>
 //     ,[PrimaryPhoneExt] = <PrimaryPhoneExt, varchar(10),>
 //     ,[PrimaryPhoneDigits] = <PrimaryPhoneDigits, varchar(20),>
 //     ,[PrimaryPhoneType] = <PrimaryPhoneType, int,>
 //     ,[UserEmail] = <UserEmail, varchar(300),>
 //     ,[EmailReceiptID] = <EmailReceiptID, uniqueidentifier,>
 //     ,[ChargeResult] = <ChargeResult, nvarchar(250),>
 //     ,[TransactionNumber] = <TransactionNumber, nvarchar(250),>
 //     ,[AuthorizationCode] = <AuthorizationCode, nvarchar(250),>
 //     ,[ResponseXML] = <ResponseXML, xml,>
 //     ,[ChargeMode] = <ChargeMode, int,>
 //     ,[MaskedCreditCardNumber] = <MaskedCreditCardNumber, varchar(20),>
 //     ,[NameOnCreditCard] = <NameOnCreditCard, varchar(50),>
 //     ,[CreditCardType] = <CreditCardType, varchar(25),>
 //     ,[SubTotal] = <SubTotal, decimal(18,0),>
 //     ,[Discount] = <Discount, decimal(18,0),>
 //     ,[Tax] = <Tax, decimal(18,0),>
 //     ,[Total] = <Total, decimal(18,0),>
 //     ,[PromotionCode] = <PromotionCode, varchar(25),>
 //     ,[BonusDays] = <BonusDays, int,>
 //     ,[TermsAndConditions] = <TermsAndConditions, varchar(max),>
 //     ,[OrderStatus] = <OrderStatus, int,>
 //     ,[OrderComments] = <OrderComments, varchar(max),>
 //     ,[RefundedDate] = <RefundedDate, datetime,>
 //     ,[RefundedMessage] = <RefundedMessage, varchar(max),>
 //     ,[VoidedDate] = <VoidedDate, datetime,>
 //     ,[VoidedMessage] = <VoidedMessage, varchar(max),>
 //     ,[Created] = <Created, datetime,>
 //     ,[LastModified] = <LastModified, datetime,>
 //     ,[RedirectLink] = <RedirectLink, varchar(1000),>
 //     ,[UserEmailAlternate] = <UserEmailAlternate, varchar(300),>
 //WHERE <Search Conditions,,>


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
	//			throw new Exception($"Failed to update Order {entity.ID}");
	//		}
	//	}



	}  // end of class
}  // end of namespace
