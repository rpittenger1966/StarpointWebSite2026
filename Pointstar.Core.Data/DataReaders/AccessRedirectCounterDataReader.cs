using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class AccessRedirectCounterDataReader
	{

				static public Pointstar.Core.Data.AccessRedirectCounter BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.AccessRedirectCounter o = new Pointstar.Core.Data.AccessRedirectCounter();

			o.Count = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "Count");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.Directory = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Directory");
			o.FileName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FileName");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ID");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.Max = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "Max");
			o.OrderID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "OrderID");
			o.RedirectKey = Pointstar.Core.Data.AdoHelper.ReadString(reader, "RedirectKey");
			o.SaleKey = Pointstar.Core.Data.AdoHelper.ReadString(reader, "SaleKey");

			return o;
		}


	}  // end of class
}  // end of namespace
