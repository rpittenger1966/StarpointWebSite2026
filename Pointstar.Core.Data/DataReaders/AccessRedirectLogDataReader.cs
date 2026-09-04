using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class AccessRedirectLogDataReader
	{

				static public Pointstar.Core.Data.AccessRedirectLog BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.AccessRedirectLog o = new Pointstar.Core.Data.AccessRedirectLog();

			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.Day = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Day");
			o.DayOfWeek = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "DayOfWeek");
			o.Directory = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Directory");
			o.FileName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FileName");
			o.Hour = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Hour");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ID");
			o.Minute = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Minute");
			o.Month = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Month");
			o.OrderID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "OrderID");
			o.RedirectKey = Pointstar.Core.Data.AdoHelper.ReadString(reader, "RedirectKey");
			o.SaleKey = Pointstar.Core.Data.AdoHelper.ReadString(reader, "SaleKey");
			o.Second = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Second");
			o.Server = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Server");
			o.SiteVisitID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "SiteVisitID");
			o.VisitorID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "VisitorID");
			o.Year = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Year");

			return o;
		}


	}  // end of class
}  // end of namespace
