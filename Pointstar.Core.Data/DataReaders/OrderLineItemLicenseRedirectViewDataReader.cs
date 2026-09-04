using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class OrderLineItemLicenseRedirectViewDataReader
	{

				static public Pointstar.Core.Data.OrderLineItemLicenseRedirectView BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.OrderLineItemLicenseRedirectView o = new Pointstar.Core.Data.OrderLineItemLicenseRedirectView();

			o.EmailAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "EmailAddress");
			o.FirstName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FirstName");
			o.LastName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LastName");
			o.LicenseDescription = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LicenseDescription");
			o.OrderComments = Pointstar.Core.Data.AdoHelper.ReadString(reader, "OrderComments");
			o.OrderDate = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "OrderDate");
			o.OrderId = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "OrderId");
			o.ProductDescription = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ProductDescription");
			o.ProductID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ProductID");
			o.ProductLicenseID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ProductLicenseID");

			return o;
		}


	}  // end of class
}  // end of namespace
