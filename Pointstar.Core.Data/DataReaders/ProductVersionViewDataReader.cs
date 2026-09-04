using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class ProductVersionViewDataReader
	{

				static public Pointstar.Core.Data.ProductVersionView BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.ProductVersionView o = new Pointstar.Core.Data.ProductVersionView();

			o.Abbrev = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Abbrev");
			o.Active = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Active");
			o.Description = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Description");
			o.DisplayOrder = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "DisplayOrder");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ID");
			o.Name = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Name");
			o.ReleaseDate = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "ReleaseDate");

			return o;
		}


	}  // end of class
}  // end of namespace
