using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class ProductDataReader
	{

				static public Pointstar.Core.Data.Product BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.Product o = new Pointstar.Core.Data.Product();

			o.Abbrev = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Abbrev");
			o.Active = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Active");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.Description = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Description");
			o.DisplayOrder = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "DisplayOrder");
			o.ExtraInfo = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ExtraInfo");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ID");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.Name = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Name");
			o.ProductComment = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ProductComment");
			o.ProductType = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ProductType");
			o.RedirectID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "RedirectID");

			return o;
		}


	}  // end of class
}  // end of namespace
