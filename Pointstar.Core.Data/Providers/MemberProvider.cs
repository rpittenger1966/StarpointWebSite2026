using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data.Providers
{
	public class MemberProvider : ProviderBase
	{
		public MemberProvider(string connectionString, Guid userId) : base(connectionString, userId)
		{
		}

		public async Task InsertMemberAsync(Member entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await InsertMemberAsync(con, entity);
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

		public async Task InsertMemberAsync(SqlConnection con, Member entity)
		{
			string sql = @"INSERT INTO [dbo].[Member]
           ([ID]
           ,[CompanyID]
           ,[DisplayName]
           ,[EmailAddress]
           ,[EmailAddressLower]
           ,[Salutation]
           ,[FirstName]
           ,[MiddleName]
           ,[LastName]
           ,[CompanyName]
           ,[Suffix]
           ,[JobTitle]
           ,[Address1]
           ,[Address2]
           ,[Address3]
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
           ,[AlternatePhone]
           ,[AlternatePhoneExt]
           ,[AlternatePhoneDigits]
           ,[AlternatePhoneType]
           ,[Encryption]
           ,[Password]
           ,[PasswordSalt]
           ,[PasswordHashAlgorithm]
           ,[MustResetPassword]
           ,[SignupDate]
           ,[Cookie]
           ,[IPAddress]
           ,[MemberStatus]
           ,[RememberMe]
           ,[Permissions]
           ,[EmailOptIn]
           ,[CampaignID]
           ,[MembershipLevel]
           ,[LastActivity]
           ,[VisitorID]
           ,[ExternalID]
           ,[CreatedBy]
           ,[Created]
           ,[LastModifiedBy]
           ,[LastModified]
           ,[EmailAddress2])
     VALUES
           (<ID, uniqueidentifier,>
           ,<CompanyID, uniqueidentifier,>
           ,<DisplayName, varchar(50),>
           ,<EmailAddress, varchar(100),>
           ,<EmailAddressLower, varchar(100),>
           ,<Salutation, varchar(10),>
           ,<FirstName, varchar(50),>
           ,<MiddleName, varchar(50),>
           ,<LastName, varchar(50),>
           ,<CompanyName, varchar(80),>
           ,<Suffix, varchar(20),>
           ,<JobTitle, varchar(50),>
           ,<Address1, varchar(50),>
           ,<Address2, varchar(40),>
           ,<Address3, varchar(40),>
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
           ,<AlternatePhone, varchar(20),>
           ,<AlternatePhoneExt, varchar(10),>
           ,<AlternatePhoneDigits, varchar(20),>
           ,<AlternatePhoneType, int,>
           ,<Encryption, int,>
           ,<Password, varchar(50),>
           ,<PasswordSalt, varchar(50),>
           ,<PasswordHashAlgorithm, int,>
           ,<MustResetPassword, bit,>
           ,<SignupDate, datetime,>
           ,<Cookie, varchar(50),>
           ,<IPAddress, varchar(50),>
           ,<MemberStatus, int,>
           ,<RememberMe, bit,>
           ,<Permissions, int,>
           ,<EmailOptIn, bit,>
           ,<CampaignID, int,>
           ,<MembershipLevel, int,>
           ,<LastActivity, datetime,>
           ,<VisitorID, uniqueidentifier,>
           ,<ExternalID, varchar(50),>
           ,<CreatedBy, varchar(50),>
           ,<Created, datetime,>
           ,<LastModifiedBy, varchar(50),>
           ,<LastModified, datetime,>
           ,<EmailAddress2, varchar(100),>);";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);

				await command.ExecuteNonQueryAsync();
			}
		}

		public async Task<List<Member>> GetMembersAsync()
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					return await GetMembersAsync(con);
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

		public async Task<List<Member>> GetMembersAsync(SqlConnection con)
		{
			string sql = "SELECT * FROM [dbo].[Member] order by [Created] desc";

			List<Member> clientList = new List<Member>();

			using (SqlCommand command = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					while (reader.Read())
					{
						Member client = MemberDataReader.BuildFromDataReader(reader);
						if (client != null)
						{
							clientList.Add(client);
						}
					}
				}
			}

			return clientList;
		}


		public async Task<Member> GetByIdAsync(Guid id)
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

		public async Task<Member> GetByIdAsync(SqlConnection con, Guid id)
		{

			string sql = $"SELECT * FROM [dbo].[Member] where ID = '{id}';";


			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					using (SqlDataReader reader = await command.ExecuteReaderAsync())
					{
						while (reader.Read())
						{
							Member client = MemberDataReader.BuildFromDataReader(reader);
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

		public async Task UpdateMemberAsync(Member entity)
		{
			SqlConnection con = null;

			try
			{
				using (con = SqlConnectionFactory.GetSqlConnection(_connectionString))
				{
					await UpdateMemberAsync(con, entity);
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


		public async Task UpdateMemberAsync(SqlConnection con, Member entity)
		{
			string sql = @"UPDATE [dbo].[Member]
   SET [ID] = <ID, uniqueidentifier,>
      ,[CompanyID] = <CompanyID, uniqueidentifier,>
      ,[DisplayName] = <DisplayName, varchar(50),>
      ,[EmailAddress] = <EmailAddress, varchar(100),>
      ,[EmailAddressLower] = <EmailAddressLower, varchar(100),>
      ,[Salutation] = <Salutation, varchar(10),>
      ,[FirstName] = <FirstName, varchar(50),>
      ,[MiddleName] = <MiddleName, varchar(50),>
      ,[LastName] = <LastName, varchar(50),>
      ,[CompanyName] = <CompanyName, varchar(80),>
      ,[Suffix] = <Suffix, varchar(20),>
      ,[JobTitle] = <JobTitle, varchar(50),>
      ,[Address1] = <Address1, varchar(50),>
      ,[Address2] = <Address2, varchar(40),>
      ,[Address3] = <Address3, varchar(40),>
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
      ,[AlternatePhone] = <AlternatePhone, varchar(20),>
      ,[AlternatePhoneExt] = <AlternatePhoneExt, varchar(10),>
      ,[AlternatePhoneDigits] = <AlternatePhoneDigits, varchar(20),>
      ,[AlternatePhoneType] = <AlternatePhoneType, int,>
      ,[Encryption] = <Encryption, int,>
      ,[Password] = <Password, varchar(50),>
      ,[PasswordSalt] = <PasswordSalt, varchar(50),>
      ,[PasswordHashAlgorithm] = <PasswordHashAlgorithm, int,>
      ,[MustResetPassword] = <MustResetPassword, bit,>
      ,[SignupDate] = <SignupDate, datetime,>
      ,[Cookie] = <Cookie, varchar(50),>
      ,[IPAddress] = <IPAddress, varchar(50),>
      ,[MemberStatus] = <MemberStatus, int,>
      ,[RememberMe] = <RememberMe, bit,>
      ,[Permissions] = <Permissions, int,>
      ,[EmailOptIn] = <EmailOptIn, bit,>
      ,[CampaignID] = <CampaignID, int,>
      ,[MembershipLevel] = <MembershipLevel, int,>
      ,[LastActivity] = <LastActivity, datetime,>
      ,[VisitorID] = <VisitorID, uniqueidentifier,>
      ,[ExternalID] = <ExternalID, varchar(50),>
      ,[CreatedBy] = <CreatedBy, varchar(50),>
      ,[Created] = <Created, datetime,>
      ,[LastModifiedBy] = <LastModifiedBy, varchar(50),>
      ,[LastModified] = <LastModified, datetime,>
      ,[EmailAddress2] = <EmailAddress2, varchar(100),>
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
				throw new Exception($"Failed to update Member {entity.ID}");
			}
		}



	}  // end of class
}  // end of namespace
