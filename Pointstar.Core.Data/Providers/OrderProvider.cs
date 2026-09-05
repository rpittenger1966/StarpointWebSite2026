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
           ,[LastModified]
           ,[RedirectLink]
           ,[UserEmailAlternate])
     VALUES
           (<ID, uniqueidentifier,>
           ,<VisitorID, uniqueidentifier,>
           ,<SiteVisitID, uniqueidentifier,>
           ,<MemberID, uniqueidentifier,>
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
           ,<UserEmail, varchar(300),>
           ,<EmailReceiptID, uniqueidentifier,>
           ,<ChargeResult, nvarchar(250),>
           ,<TransactionNumber, nvarchar(250),>
           ,<AuthorizationCode, nvarchar(250),>
           ,<ResponseXML, xml,>
           ,<ChargeMode, int,>
           ,<MaskedCreditCardNumber, varchar(20),>
           ,<NameOnCreditCard, varchar(50),>
           ,<CreditCardType, varchar(25),>
           ,<SubTotal, decimal(18,0),>
           ,<Discount, decimal(18,0),>
           ,<Tax, decimal(18,0),>
           ,<Total, decimal(18,0),>
           ,<PromotionCode, varchar(25),>
           ,<BonusDays, int,>
           ,<TermsAndConditions, varchar(max),>
           ,<OrderStatus, int,>
           ,<OrderComments, varchar(max),>
           ,<RefundedDate, datetime,>
           ,<RefundedMessage, varchar(max),>
           ,<VoidedDate, datetime,>
           ,<VoidedMessage, varchar(max),>
           ,<Created, datetime,>
           ,<LastModified, datetime,>
           ,<RedirectLink, varchar(1000),>
           ,<UserEmailAlternate, varchar(300),>)
);
;";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<Order>> GetOrdersAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetOrdersAsync(con);
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

		public async Task<List<Order>> GetOrdersAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[Order] order by [Created] desc";

			List<Order> clientList = new List<Order>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						Order client = OrderDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


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

		public async Task UpdateOrderAsync(Order entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await UpdateOrderAsync(con, entity);
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


		public async Task UpdateOrderAsync(SqlConnection con, Order entity)
		{
			throw new NotImplementedException();

			string sql = @"UPDATE [dbo].[Order]
   SET [ID] = <ID, uniqueidentifier,>
      ,[VisitorID] = <VisitorID, uniqueidentifier,>
      ,[SiteVisitID] = <SiteVisitID, uniqueidentifier,>
      ,[MemberID] = <MemberID, uniqueidentifier,>
      ,[FirstName] = <FirstName, varchar(50),>
      ,[LastName] = <LastName, varchar(50),>
      ,[CompanyName] = <CompanyName, varchar(80),>
      ,[JobTitle] = <JobTitle, varchar(50),>
      ,[Address1] = <Address1, varchar(50),>
      ,[Address2] = <Address2, varchar(40),>
      ,[City] = <City, varchar(50),>
      ,[StateProvince] = <StateProvince, varchar(50),>
      ,[StateCode] = <StateCode, varchar(5),>
      ,[PostalCode] = <PostalCode, varchar(50),>
      ,[Country] = <Country, varchar(50),>
      ,[CountryCode] = <CountryCode, varchar(5),>
      ,[PrimaryPhone] = <PrimaryPhone, varchar(20),>
      ,[PrimaryPhoneExt] = <PrimaryPhoneExt, varchar(10),>
      ,[PrimaryPhoneDigits] = <PrimaryPhoneDigits, varchar(20),>
      ,[PrimaryPhoneType] = <PrimaryPhoneType, int,>
      ,[UserEmail] = <UserEmail, varchar(300),>
      ,[EmailReceiptID] = <EmailReceiptID, uniqueidentifier,>
      ,[ChargeResult] = <ChargeResult, nvarchar(250),>
      ,[TransactionNumber] = <TransactionNumber, nvarchar(250),>
      ,[AuthorizationCode] = <AuthorizationCode, nvarchar(250),>
      ,[ResponseXML] = <ResponseXML, xml,>
      ,[ChargeMode] = <ChargeMode, int,>
      ,[MaskedCreditCardNumber] = <MaskedCreditCardNumber, varchar(20),>
      ,[NameOnCreditCard] = <NameOnCreditCard, varchar(50),>
      ,[CreditCardType] = <CreditCardType, varchar(25),>
      ,[SubTotal] = <SubTotal, decimal(18,0),>
      ,[Discount] = <Discount, decimal(18,0),>
      ,[Tax] = <Tax, decimal(18,0),>
      ,[Total] = <Total, decimal(18,0),>
      ,[PromotionCode] = <PromotionCode, varchar(25),>
      ,[BonusDays] = <BonusDays, int,>
      ,[TermsAndConditions] = <TermsAndConditions, varchar(max),>
      ,[OrderStatus] = <OrderStatus, int,>
      ,[OrderComments] = <OrderComments, varchar(max),>
      ,[RefundedDate] = <RefundedDate, datetime,>
      ,[RefundedMessage] = <RefundedMessage, varchar(max),>
      ,[VoidedDate] = <VoidedDate, datetime,>
      ,[VoidedMessage] = <VoidedMessage, varchar(max),>
      ,[Created] = <Created, datetime,>
      ,[LastModified] = <LastModified, datetime,>
      ,[RedirectLink] = <RedirectLink, varchar(1000),>
      ,[UserEmailAlternate] = <UserEmailAlternate, varchar(300),>
 WHERE <Search Conditions,,>


		";

			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					command.Parameters.AddWithValue("ID", entity.ID);

					await command.ExecuteNonQueryAsync();
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"Failed to update Order {entity.ID}");
			}
		}



	}  // end of class
}  // end of namespace
