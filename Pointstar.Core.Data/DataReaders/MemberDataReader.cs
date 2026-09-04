using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class MemberDataReader
	{

				static public Pointstar.Core.Data.Member BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.Member o = new Pointstar.Core.Data.Member();

			o.Address1 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Address1");
			o.Address2 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Address2");
			o.Address3 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Address3");
			o.AlternatePhone = Pointstar.Core.Data.AdoHelper.ReadString(reader, "AlternatePhone");
			o.AlternatePhoneDigits = Pointstar.Core.Data.AdoHelper.ReadString(reader, "AlternatePhoneDigits");
			o.AlternatePhoneExt = Pointstar.Core.Data.AdoHelper.ReadString(reader, "AlternatePhoneExt");
			o.AlternatePhoneType = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "AlternatePhoneType");
			o.CampaignID = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "CampaignID");
			o.City = Pointstar.Core.Data.AdoHelper.ReadString(reader, "City");
			o.CompanyID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "CompanyID");
			o.CompanyName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CompanyName");
			o.Cookie = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Cookie");
			o.Country = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Country");
			o.CountryCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CountryCode");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.CreatedBy = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CreatedBy");
			o.DisplayName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "DisplayName");
			o.EmailAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "EmailAddress");
			o.EmailAddress2 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "EmailAddress2");
			o.EmailAddressLower = Pointstar.Core.Data.AdoHelper.ReadString(reader, "EmailAddressLower");
			o.EmailOptIn = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "EmailOptIn");
			o.Encryption = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "Encryption");
			o.ExternalID = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ExternalID");
			o.FirstName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FirstName");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.IPAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IPAddress");
			o.JobTitle = Pointstar.Core.Data.AdoHelper.ReadString(reader, "JobTitle");
			o.LastActivity = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "LastActivity");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.LastModifiedBy = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LastModifiedBy");
			o.LastName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LastName");
			o.MembershipLevel = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "MembershipLevel");
			o.MemberStatus = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "MemberStatus");
			o.MiddleName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "MiddleName");
			o.MustResetPassword = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "MustResetPassword");
			o.Password = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Password");
			o.PasswordHashAlgorithm = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "PasswordHashAlgorithm");
			o.PasswordSalt = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PasswordSalt");
			o.Permissions = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "Permissions");
			o.PostalCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PostalCode");
			o.PrimaryPhone = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PrimaryPhone");
			o.PrimaryPhoneDigits = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PrimaryPhoneDigits");
			o.PrimaryPhoneExt = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PrimaryPhoneExt");
			o.PrimaryPhoneType = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "PrimaryPhoneType");
			o.RememberMe = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "RememberMe");
			o.Salutation = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Salutation");
			o.SignupDate = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "SignupDate");
			o.StateCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "StateCode");
			o.StateProvince = Pointstar.Core.Data.AdoHelper.ReadString(reader, "StateProvince");
			o.Suffix = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Suffix");
			o.VisitorID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "VisitorID");

			return o;
		}


	}  // end of class
}  // end of namespace
