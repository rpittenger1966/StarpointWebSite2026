using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class OrderLineItemDataReader
	{

				static public Pointstar.Core.Data.OrderLineItem BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.OrderLineItem o = new Pointstar.Core.Data.OrderLineItem();

			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.DiscountAmount = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "DiscountAmount");
			o.DiscountPercent = Pointstar.Core.Data.AdoHelper.ReadDouble(reader, "DiscountPercent");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.LicenseDescription = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LicenseDescription");
			o.LineTotal = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "LineTotal");
			o.MemberID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "MemberID");
			o.OrderComments = Pointstar.Core.Data.AdoHelper.ReadString(reader, "OrderComments");
			o.OrderID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "OrderID");
			o.OrderStatus = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "OrderStatus");
			o.Price = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "Price");
			o.ProductDescription = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ProductDescription");
			o.ProductID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ProductID");
			o.ProductLicenseID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ProductLicenseID");
			o.PromotionCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PromotionCode");
			o.Quantity = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "Quantity");
			o.RefundedDate = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "RefundedDate");
			o.RefundedMessage = Pointstar.Core.Data.AdoHelper.ReadString(reader, "RefundedMessage");
			o.VoidedDate = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "VoidedDate");
			o.VoidedMessage = Pointstar.Core.Data.AdoHelper.ReadString(reader, "VoidedMessage");

			return o;
		}


	}  // end of class
}  // end of namespace
