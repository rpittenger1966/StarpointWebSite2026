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
           ,[EmailAddress2])
     VALUES
           (@ID
           ,@CompanyID
           ,@DisplayName
           ,@EmailAddress
           ,@EmailAddressLower
           ,@Salutation
           ,@FirstName
           ,@MiddleName
           ,@LastName
           ,@CompanyName
           ,@Suffix
           ,@JobTitle
           ,@Address1
           ,@Address2
           ,@Address3
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
           ,@AlternatePhone
           ,@AlternatePhoneExt
           ,@AlternatePhoneDigits
           ,@AlternatePhoneType
           ,@Encryption
           ,@Password
           ,@PasswordSalt
           ,@PasswordHashAlgorithm
           ,@MustResetPassword
           ,@SignupDate
           ,@Cookie
           ,@IPAddress
           ,@MemberStatus
           ,@RememberMe
           ,@Permissions
           ,@EmailOptIn
           ,@CampaignID
           ,@MembershipLevel
           ,@LastActivity
           ,@VisitorID
           ,@ExternalID
           ,@CreatedBy
           ,getdate()
           ,@EmailAddress2);";


			using (SqlCommand command = new SqlCommand(sql, con))
			{
				command.Parameters.AddWithValue("ID", entity.ID);
				if (entity.CompanyID.HasValue)
					command.Parameters.AddWithValue("CompanyID", entity.CompanyID);
				else
					command.Parameters.AddWithValue("CompanyID", DBNull.Value);
				command.Parameters.AddWithValue("DisplayName", entity.DisplayName);
				command.Parameters.AddWithValue("EmailAddress", entity.EmailAddress);
				command.Parameters.AddWithValue("EmailAddressLower", entity.EmailAddress.ToLower());

				command.Parameters.AddWithValue("Salutation", entity.Salutation);
				command.Parameters.AddWithValue("FirstName", entity.FirstName);
				command.Parameters.AddWithValue("MiddleName", entity.MiddleName);
				command.Parameters.AddWithValue("LastName", entity.LastName);
				command.Parameters.AddWithValue("CompanyName", entity.CompanyName);

				command.Parameters.AddWithValue("Suffix", entity.Suffix);
				command.Parameters.AddWithValue("JobTitle", entity.JobTitle);
				command.Parameters.AddWithValue("Address1", entity.Address1);
				command.Parameters.AddWithValue("Address2", entity.Address2);
				command.Parameters.AddWithValue("Address3", entity.Address3);

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

				command.Parameters.AddWithValue("AlternatePhone", entity.AlternatePhone);
				command.Parameters.AddWithValue("AlternatePhoneExt", entity.AlternatePhoneExt);
				command.Parameters.AddWithValue("AlternatePhoneDigits", entity.AlternatePhoneDigits);
				command.Parameters.AddWithValue("AlternatePhoneType", entity.AlternatePhoneType);
				command.Parameters.AddWithValue("Encryption", entity.Encryption);

				command.Parameters.AddWithValue("Password", entity.Password);
				command.Parameters.AddWithValue("PasswordSalt", entity.PasswordSalt);
				command.Parameters.AddWithValue("PasswordHashAlgorithm", entity.PasswordHashAlgorithm);
				command.Parameters.AddWithValue("MustResetPassword", entity.MustResetPassword);
				command.Parameters.AddWithValue("SignupDate", entity.SignupDate);

				command.Parameters.AddWithValue("Cookie", entity.Cookie);
				command.Parameters.AddWithValue("IPAddress", entity.IPAddress);
				command.Parameters.AddWithValue("MemberStatus", entity.MemberStatus);
				command.Parameters.AddWithValue("RememberMe", entity.RememberMe);
				command.Parameters.AddWithValue("Permissions", entity.Permissions);

				command.Parameters.AddWithValue("EmailOptIn", entity.EmailOptIn);
				if (entity.CampaignID.HasValue)
					command.Parameters.AddWithValue("CampaignID", entity.CampaignID);
				else
					command.Parameters.AddWithValue("CampaignID", DBNull.Value);
				command.Parameters.AddWithValue("MembershipLevel", entity.MembershipLevel);
				command.Parameters.AddWithValue("LastActivity", entity.LastActivity);
				if (entity.VisitorID.HasValue)
					command.Parameters.AddWithValue("VisitorID", entity.VisitorID);
				else
					command.Parameters.AddWithValue("VisitorID", DBNull.Value);

				command.Parameters.AddWithValue("ExternalID", entity.ExternalID);
				command.Parameters.AddWithValue("CreatedBy", this._userId);

				if (!String.IsNullOrEmpty(entity.EmailAddress2))
					command.Parameters.AddWithValue("EmailAddress2", entity.EmailAddress2);
				else
					command.Parameters.AddWithValue("EmailAddress2", DBNull.Value);

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
   SET [CompanyID] = @CompanyID
      ,[DisplayName] = @DisplayName
      ,[EmailAddress] = @EmailAddress
      ,[EmailAddressLower] = @EmailAddressLower
      ,[Salutation] = @Salutation
      ,[FirstName] = @FirstName
      ,[MiddleName] = @MiddleName
      ,[LastName] = @LastName
      ,[CompanyName] = @CompanyName
      ,[Suffix] = @Suffix
      ,[JobTitle] = @JobTitle
      ,[Address1] = @Address1
      ,[Address2] = @Address2
      ,[Address3] = @Address3
      ,[City] = @City
      ,[StateProvince] = @StateProvince
      ,[StateCode] = @StateCode
      ,[PostalCode] = @PostalCode
      ,[Country] = @Country
      ,[CountryCode] = @CountryCode
      ,[PrimaryPhone] = @PrimaryPhone
      ,[PrimaryPhoneExt] = @PrimaryPhoneExt
      ,[PrimaryPhoneDigits] = @PrimaryPhoneDigits
      ,[PrimaryPhoneType] = @PrimaryPhoneType
      ,[AlternatePhone] = @AlternatePhone
      ,[AlternatePhoneExt] = @AlternatePhoneExt
      ,[AlternatePhoneDigits] = @AlternatePhoneDigits
      ,[AlternatePhoneType] = @AlternatePhoneType
      ,[Encryption] = @Encryption
      ,[Password] = @Password
      ,[PasswordSalt] = @PasswordSalt
      ,[PasswordHashAlgorithm] = @PasswordHashAlgorithm
      ,[MustResetPassword] = @MustResetPassword
      ,[SignupDate] = @SignupDate
      ,[Cookie] = @Cookie
      ,[IPAddress] = @IPAddress
      ,[MemberStatus] = @MemberStatus
      ,[RememberMe] = @RememberMe
      ,[Permissions] = @Permissions
      ,[EmailOptIn] = @EmailOptIn
      ,[CampaignID] = @CampaignID
      ,[MembershipLevel] = @MembershipLevel
      ,[LastActivity] = @LastActivity
      ,[VisitorID] = @VisitorID
      ,[ExternalID] = @ExternalID
      ,[LastModifiedBy] = @LastModifiedBy
      ,[LastModified] = getdate()
      ,[EmailAddress2] = @EmailAddress2
 WHERE ID=@ID;
		";

			try
			{
				using (SqlCommand command = new SqlCommand(sql, con))
				{
					command.Parameters.AddWithValue("ID", entity.ID);
					if (entity.CompanyID.HasValue)
						command.Parameters.AddWithValue("CompanyID", entity.CompanyID);
					else
						command.Parameters.AddWithValue("CompanyID", DBNull.Value);
					command.Parameters.AddWithValue("DisplayName", entity.DisplayName);
					command.Parameters.AddWithValue("EmailAddress", entity.EmailAddress);
					command.Parameters.AddWithValue("EmailAddressLower", entity.EmailAddress.ToLower());

					command.Parameters.AddWithValue("Salutation", entity.Salutation);
					command.Parameters.AddWithValue("FirstName", entity.FirstName);
					command.Parameters.AddWithValue("MiddleName", entity.MiddleName);
					command.Parameters.AddWithValue("LastName", entity.LastName);
					command.Parameters.AddWithValue("CompanyName", entity.CompanyName);

					command.Parameters.AddWithValue("Suffix", entity.Suffix);
					command.Parameters.AddWithValue("JobTitle", entity.JobTitle);
					command.Parameters.AddWithValue("Address1", entity.Address1);
					command.Parameters.AddWithValue("Address2", entity.Address2);
					command.Parameters.AddWithValue("Address3", entity.Address3);

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

					command.Parameters.AddWithValue("AlternatePhone", entity.AlternatePhone);
					command.Parameters.AddWithValue("AlternatePhoneExt", entity.AlternatePhoneExt);
					command.Parameters.AddWithValue("AlternatePhoneDigits", entity.AlternatePhoneDigits);
					command.Parameters.AddWithValue("AlternatePhoneType", entity.AlternatePhoneType);
					command.Parameters.AddWithValue("Encryption", entity.Encryption);

					command.Parameters.AddWithValue("Password", entity.Password);
					command.Parameters.AddWithValue("PasswordSalt", entity.PasswordSalt);
					command.Parameters.AddWithValue("PasswordHashAlgorithm", entity.PasswordHashAlgorithm);
					command.Parameters.AddWithValue("MustResetPassword", entity.MustResetPassword);
					command.Parameters.AddWithValue("SignupDate", entity.SignupDate);

					command.Parameters.AddWithValue("Cookie", entity.Cookie);
					command.Parameters.AddWithValue("IPAddress", entity.IPAddress);
					command.Parameters.AddWithValue("MemberStatus", entity.MemberStatus);
					command.Parameters.AddWithValue("RememberMe", entity.RememberMe);
					command.Parameters.AddWithValue("Permissions", entity.Permissions);

					command.Parameters.AddWithValue("EmailOptIn", entity.EmailOptIn);
					if (entity.CampaignID.HasValue)
						command.Parameters.AddWithValue("CampaignID", entity.CampaignID);
					else
						command.Parameters.AddWithValue("CampaignID", DBNull.Value);
					command.Parameters.AddWithValue("MembershipLevel", entity.MembershipLevel);
					command.Parameters.AddWithValue("LastActivity", entity.LastActivity);
					if (entity.VisitorID.HasValue)
						command.Parameters.AddWithValue("VisitorID", entity.VisitorID);
					else
						command.Parameters.AddWithValue("VisitorID", DBNull.Value);

					command.Parameters.AddWithValue("ExternalID", entity.ExternalID);
					command.Parameters.AddWithValue("LastModifiedBy", this._userId);

					if (!String.IsNullOrEmpty(entity.EmailAddress2))
						command.Parameters.AddWithValue("EmailAddress2", entity.EmailAddress2);
					else
						command.Parameters.AddWithValue("EmailAddress2", DBNull.Value);

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
