using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class ShoppingCartItemDataReader
	{

				static public Pointstar.Core.Data.ShoppingCartItem BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.ShoppingCartItem o = new Pointstar.Core.Data.ShoppingCartItem();

			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.Deleted = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Deleted");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.ItemPrice = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "ItemPrice");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.LicenseDescription = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LicenseDescription");
			o.LineTotal = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "LineTotal");
			o.ProductDescription = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ProductDescription");
			o.ProductID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ProductID");
			o.ProductLicenseID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ProductLicenseID");
			o.Quantity = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "Quantity");
			o.ShoppingCartID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ShoppingCartID");
			o.SpecialItemID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "SpecialItemID");

			return o;
		}


	}  // end of class
}  // end of namespace
