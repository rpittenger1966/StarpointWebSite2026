using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class LicenseKeyDataReader
	{

				static public Pointstar.Core.Data.LicenseKey BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.LicenseKey o = new Pointstar.Core.Data.LicenseKey();

			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.LicenseKeyBase64 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LicenseKeyBase64");
			o.LicenseKeyId = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "LicenseKeyId");
			o.OrderId = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "OrderId");
			o.OrderLineItemId = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "OrderLineItemId");
			o.Product = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Product");

			return o;
		}


	}  // end of class
}  // end of namespace
