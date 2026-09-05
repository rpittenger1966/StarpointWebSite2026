using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class OrderDataReader
	{

				static public Pointstar.Core.Data.Order BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.Order o = new Pointstar.Core.Data.Order();

			o.Address1 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Address1");
			o.Address2 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Address2");
			o.AuthorizationCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "AuthorizationCode");
			o.BonusDays = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "BonusDays");
			o.ChargeMode = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ChargeMode");
			o.ChargeResult = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ChargeResult");
			o.City = Pointstar.Core.Data.AdoHelper.ReadString(reader, "City");
			o.CompanyName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CompanyName");
			o.Country = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Country");
			o.CountryCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CountryCode");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.CreditCardType = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CreditCardType");
			o.Discount = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "Discount");
			o.EmailReceiptID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "EmailReceiptID");
			o.FirstName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FirstName");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.JobTitle = Pointstar.Core.Data.AdoHelper.ReadString(reader, "JobTitle");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.LastName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LastName");
			o.MaskedCreditCardNumber = Pointstar.Core.Data.AdoHelper.ReadString(reader, "MaskedCreditCardNumber");
			o.MemberID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "MemberID");
			o.NameOnCreditCard = Pointstar.Core.Data.AdoHelper.ReadString(reader, "NameOnCreditCard");
			o.OrderComments = Pointstar.Core.Data.AdoHelper.ReadString(reader, "OrderComments");
			o.OrderStatus = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "OrderStatus");
			o.PostalCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PostalCode");
			o.PrimaryPhone = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PrimaryPhone");
			o.PrimaryPhoneDigits = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PrimaryPhoneDigits");
			o.PrimaryPhoneExt = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PrimaryPhoneExt");
			o.PrimaryPhoneType = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "PrimaryPhoneType");
			o.PromotionCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PromotionCode");
			o.RedirectLink = Pointstar.Core.Data.AdoHelper.ReadString(reader, "RedirectLink");
			o.RefundedDate = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "RefundedDate");
			o.RefundedMessage = Pointstar.Core.Data.AdoHelper.ReadString(reader, "RefundedMessage");
			o.ResponseXML = Pointstar.Core.Data.AdoHelper.ReadNullableXml(reader, "ResponseXML");
			o.SiteVisitID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "SiteVisitID");
			o.StateCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "StateCode");
			o.StateProvince = Pointstar.Core.Data.AdoHelper.ReadString(reader, "StateProvince");
			o.SubTotal = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "SubTotal");
			o.Tax = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "Tax");
			o.TermsAndConditions = Pointstar.Core.Data.AdoHelper.ReadString(reader, "TermsAndConditions");
			o.Total = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "Total");
			o.TransactionNumber = Pointstar.Core.Data.AdoHelper.ReadString(reader, "TransactionNumber");
			o.UserEmail = Pointstar.Core.Data.AdoHelper.ReadString(reader, "UserEmail");
			o.UserEmailAlternate = Pointstar.Core.Data.AdoHelper.ReadString(reader, "UserEmailAlternate");
			o.VisitorID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "VisitorID");
			o.VoidedDate = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "VoidedDate");
			o.VoidedMessage = Pointstar.Core.Data.AdoHelper.ReadString(reader, "VoidedMessage");

			return o;
		}


	}  // end of class
}  // end of namespace
