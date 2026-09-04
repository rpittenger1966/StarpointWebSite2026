using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class RedirectLogDataReader
	{

				static public Pointstar.Core.Data.RedirectLog BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.RedirectLog o = new Pointstar.Core.Data.RedirectLog();

			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.FileName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FileName");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.IPAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IPAddress");
			o.MemberID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "MemberID");
			o.RedirectID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "RedirectID");
			o.SiteVisitID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "SiteVisitID");
			o.VisitorID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "VisitorID");

			return o;
		}


	}  // end of class
}  // end of namespace
