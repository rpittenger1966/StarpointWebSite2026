using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class Order
	{
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string AuthorizationCode { get; set; }
		public int BonusDays { get; set; }
		public int ChargeMode { get; set; }
		public string ChargeResult { get; set; }
		public string City { get; set; }
		public string CompanyName { get; set; }
		public string Country { get; set; }
		public string CountryCode { get; set; }
		public DateTime Created { get; set; }
		public string CreditCardType { get; set; }
		public Decimal Discount { get; set; }
		public Guid? EmailReceiptID { get; set; }
		public string FirstName { get; set; }
		public Guid ID { get; set; }
		public string JobTitle { get; set; }
		public DateTime LastModified { get; set; }
		public string LastName { get; set; }
		public string MaskedCreditCardNumber { get; set; }
		public Guid? MemberID { get; set; }
		public string NameOnCreditCard { get; set; }
		public string OrderComments { get; set; }
		public int? OrderStatus { get; set; }
		public string PostalCode { get; set; }
		public string PrimaryPhone { get; set; }
		public string PrimaryPhoneDigits { get; set; }
		public string PrimaryPhoneExt { get; set; }
		public int PrimaryPhoneType { get; set; }
		public string PromotionCode { get; set; }
		public string RedirectLink { get; set; }
		public DateTime? RefundedDate { get; set; }
		public string RefundedMessage { get; set; }
		public XElement ResponseXML { get; set; }
		public Guid? SiteVisitID { get; set; }
		public string StateCode { get; set; }
		public string StateProvince { get; set; }
		public Decimal SubTotal { get; set; }
		public Decimal Tax { get; set; }
		public string TermsAndConditions { get; set; }
		public Decimal Total { get; set; }
		public string TransactionNumber { get; set; }
		public string UserEmail { get; set; }
		public string UserEmailAlternate { get; set; }
		public Guid? VisitorID { get; set; }
		public DateTime? VoidedDate { get; set; }
		public string VoidedMessage { get; set; }


		public Order()
		{
			Address1 = "";
			Address2 = "";
			AuthorizationCode = "";
			BonusDays = 0;
			ChargeMode = 0;
			ChargeResult = "";
			City = "";
			CompanyName = "";
			Country = "";
			CountryCode = "";
			Created = DateTime.Now;
			CreditCardType = "";
			Discount = 0.0m;
			EmailReceiptID = null;
			FirstName = "";
			ID = Guid.NewGuid();
			JobTitle = "";
			LastModified = DateTime.Now;
			LastName = "";
			MaskedCreditCardNumber = "";
			MemberID = null;
			NameOnCreditCard = "";
			OrderComments = "";
			OrderStatus = null;
			PostalCode = "";
			PrimaryPhone = "";
			PrimaryPhoneDigits = "";
			PrimaryPhoneExt = "";
			PrimaryPhoneType = 0;
			PromotionCode = "";
			RedirectLink = "";
			RefundedDate = null;
			RefundedMessage = "";
			ResponseXML = null;
			SiteVisitID = null;
			StateCode = "";
			StateProvince = "";
			SubTotal = 0.0m;
			Tax = 0.0m;
			TermsAndConditions = "";
			Total = 0.0m;
			TransactionNumber = "";
			UserEmail = "";
			UserEmailAlternate = "";
			VisitorID = null;
			VoidedDate = null;
			VoidedMessage = "";
		}




	}  // end of class
}  // end of namespace
