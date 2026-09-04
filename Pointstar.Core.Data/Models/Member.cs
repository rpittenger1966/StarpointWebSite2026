using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class Member
	{
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string Address3 { get; set; }
		public string AlternatePhone { get; set; }
		public string AlternatePhoneDigits { get; set; }
		public string AlternatePhoneExt { get; set; }
		public int AlternatePhoneType { get; set; }
		public int? CampaignID { get; set; }
		public string City { get; set; }
		public Guid? CompanyID { get; set; }
		public string CompanyName { get; set; }
		public string Cookie { get; set; }
		public string Country { get; set; }
		public string CountryCode { get; set; }
		public DateTime Created { get; set; }
		public string CreatedBy { get; set; }
		public string DisplayName { get; set; }
		public string EmailAddress { get; set; }
		public string EmailAddress2 { get; set; }
		public string EmailAddressLower { get; set; }
		public bool EmailOptIn { get; set; }
		public int Encryption { get; set; }
		public string ExternalID { get; set; }
		public string FirstName { get; set; }
		public Guid ID { get; set; }
		public string IPAddress { get; set; }
		public string JobTitle { get; set; }
		public DateTime? LastActivity { get; set; }
		public DateTime LastModified { get; set; }
		public string LastModifiedBy { get; set; }
		public string LastName { get; set; }
		public int MembershipLevel { get; set; }
		public int MemberStatus { get; set; }
		public string MiddleName { get; set; }
		public bool MustResetPassword { get; set; }
		public string Password { get; set; }
		public int PasswordHashAlgorithm { get; set; }
		public string PasswordSalt { get; set; }
		public int Permissions { get; set; }
		public string PostalCode { get; set; }
		public string PrimaryPhone { get; set; }
		public string PrimaryPhoneDigits { get; set; }
		public string PrimaryPhoneExt { get; set; }
		public int PrimaryPhoneType { get; set; }
		public bool RememberMe { get; set; }
		public string Salutation { get; set; }
		public DateTime SignupDate { get; set; }
		public string StateCode { get; set; }
		public string StateProvince { get; set; }
		public string Suffix { get; set; }
		public Guid? VisitorID { get; set; }


		public Member()
		{
			Address1 = "";
			Address2 = "";
			Address3 = "";
			AlternatePhone = "";
			AlternatePhoneDigits = "";
			AlternatePhoneExt = "";
			AlternatePhoneType = 0;
			CampaignID = null;
			City = "";
			CompanyID = null;
			CompanyName = "";
			Cookie = "";
			Country = "";
			CountryCode = "";
			Created = DateTime.Now;
			CreatedBy = "";
			DisplayName = "";
			EmailAddress = "";
			EmailAddress2 = "";
			EmailAddressLower = "";
			EmailOptIn = false;
			Encryption = 0;
			ExternalID = "";
			FirstName = "";
			ID = Guid.NewGuid();
			IPAddress = "";
			JobTitle = "";
			LastActivity = null;
			LastModified = DateTime.Now;
			LastModifiedBy = "";
			LastName = "";
			MembershipLevel = 0;
			MemberStatus = 0;
			MiddleName = "";
			MustResetPassword = false;
			Password = "";
			PasswordHashAlgorithm = 0;
			PasswordSalt = "";
			Permissions = 0;
			PostalCode = "";
			PrimaryPhone = "";
			PrimaryPhoneDigits = "";
			PrimaryPhoneExt = "";
			PrimaryPhoneType = 0;
			RememberMe = false;
			Salutation = "";
			SignupDate = DateTime.Now;
			StateCode = "";
			StateProvince = "";
			Suffix = "";
			VisitorID = null;
		}




	}  // end of class
}  // end of namespace
