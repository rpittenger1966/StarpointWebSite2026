using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class ExceptionLogDataReader
	{

				static public Pointstar.Core.Data.ExceptionLog BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.ExceptionLog o = new Pointstar.Core.Data.ExceptionLog();

			o.Cookie = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Cookie");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ID");
			o.IPAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IPAddress");
			o.Message = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Message");
			o.StackTrace = Pointstar.Core.Data.AdoHelper.ReadString(reader, "StackTrace");
			o.VisitorID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "VisitorID");

			return o;
		}


	}  // end of class
}  // end of namespace
