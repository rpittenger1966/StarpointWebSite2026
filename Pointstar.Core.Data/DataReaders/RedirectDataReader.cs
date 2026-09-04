using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class RedirectDataReader
	{

				static public Pointstar.Core.Data.Redirect BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.Redirect o = new Pointstar.Core.Data.Redirect();

			o.Caption = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Caption");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.Directory = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Directory");
			o.DownloadCount = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "DownloadCount");
			o.DownloadMax = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "DownloadMax");
			o.FileName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FileName");
			o.FirstUserCookie = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FirstUserCookie");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.MemberID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "MemberID");
			o.OrderID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "OrderID");
			o.OrderLineItemID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "OrderLineItemID");
			o.SingleUser = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "SingleUser");

			return o;
		}


	}  // end of class
}  // end of namespace
