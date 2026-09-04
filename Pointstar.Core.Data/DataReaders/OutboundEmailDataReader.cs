using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class OutboundEmailDataReader
	{

				static public Pointstar.Core.Data.OutboundEmail BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.OutboundEmail o = new Pointstar.Core.Data.OutboundEmail();

			o.Body = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Body");
			o.Cookie = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Cookie");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.Exception = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Exception");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ID");
			o.IPAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IPAddress");
			o.MemberID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "MemberID");
			o.OrderID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "OrderID");
			o.Recipient = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Recipient");
			o.Status = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Status");
			o.Subject = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Subject");
			o.Type = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Type");

			return o;
		}


	}  // end of class
}  // end of namespace
