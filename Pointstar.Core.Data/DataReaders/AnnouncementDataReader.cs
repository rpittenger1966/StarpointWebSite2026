using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class AnnouncementDataReader
	{

				static public Pointstar.Core.Data.Announcement BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.Announcement o = new Pointstar.Core.Data.Announcement();

			o.AnnouncementStatus = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "AnnouncementStatus");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.CreatedBy = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CreatedBy");
			o.EndDate = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "EndDate");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ID");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.LastModifiedBy = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LastModifiedBy");
			o.PlainText = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PlainText");
			o.PostDate = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "PostDate");
			o.Title = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Title");
			o.Url = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Url");

			return o;
		}


	}  // end of class
}  // end of namespace
