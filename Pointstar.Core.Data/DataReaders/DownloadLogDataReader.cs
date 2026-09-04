using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class DownloadLogDataReader
	{

				static public Pointstar.Core.Data.DownloadLog BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.DownloadLog o = new Pointstar.Core.Data.DownloadLog();

			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.FileName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FileName");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.LandingPageEmail = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LandingPageEmail");
			o.LandingPageName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LandingPageName");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.MemberID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "MemberID");
			o.MemberName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "MemberName");
			o.OrderID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "OrderID");
			o.OrderLineItemID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "OrderLineItemID");
			o.PageUrl = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PageUrl");
			o.RedirectID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "RedirectID");
			o.SiteVisitID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "SiteVisitID");
			o.VisitorID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "VisitorID");

			return o;
		}


	}  // end of class
}  // end of namespace
