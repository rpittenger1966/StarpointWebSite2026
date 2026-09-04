using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class ProductLicenseDataReader
	{

				static public Pointstar.Core.Data.ProductLicense BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.ProductLicense o = new Pointstar.Core.Data.ProductLicense();

			o.Active = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Active");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.Description = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Description");
			o.FreeTrial = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "FreeTrial");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.Network = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Network");
			o.Price = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "Price");
			o.ProductID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ProductID");
			o.RedirectID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "RedirectID");
			o.RedirectKey = Pointstar.Core.Data.AdoHelper.ReadString(reader, "RedirectKey");
			o.SiteLicense = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "SiteLicense");
			o.Upgrade = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Upgrade");
			o.Users = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "Users");

			return o;
		}


	}  // end of class
}  // end of namespace
