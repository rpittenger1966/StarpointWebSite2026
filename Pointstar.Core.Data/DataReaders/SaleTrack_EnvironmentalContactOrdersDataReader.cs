using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class SaleTrack_EnvironmentalContactOrdersDataReader
	{

				static public Pointstar.Core.Data.SaleTrack_EnvironmentalContactOrders BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.SaleTrack_EnvironmentalContactOrders o = new Pointstar.Core.Data.SaleTrack_EnvironmentalContactOrders();

			o.Address1 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Address1");
			o.Address2 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Address2");
			o.City = Pointstar.Core.Data.AdoHelper.ReadString(reader, "City");
			o.Company = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Company");
			o.CompanyId = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CompanyId");
			o.CompanyName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CompanyName");
			o.ContactId = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ContactId");
			o.Country = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Country");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "Created");
			o.Email = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Email");
			o.FirstName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FirstName");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "LastModified");
			o.LastName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LastName");
			o.LineTotal = Pointstar.Core.Data.AdoHelper.ReadNullableDouble(reader, "LineTotal");
			o.MailingListEligible = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "MailingListEligible");
			o.NoMailingListEver = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "NoMailingListEver");
			o.OrderDate = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "OrderDate");
			o.OrderId = Pointstar.Core.Data.AdoHelper.ReadString(reader, "OrderId");
			o.OriginalDB = Pointstar.Core.Data.AdoHelper.ReadString(reader, "OriginalDB");
			o.PostalCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PostalCode");
			o.ProductName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ProductName");
			o.Source = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Source");
			o.StateOrProvince = Pointstar.Core.Data.AdoHelper.ReadString(reader, "StateOrProvince");
			o.Upgrade = Pointstar.Core.Data.AdoHelper.ReadNullableBoolean(reader, "Upgrade");
			o.VendorName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "VendorName");

			return o;
		}


	}  // end of class
}  // end of namespace
