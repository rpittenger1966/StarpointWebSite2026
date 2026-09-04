using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class ProductVersionDataReader
	{

				static public Pointstar.Core.Data.ProductVersion BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.ProductVersion o = new Pointstar.Core.Data.ProductVersion();

			o.ProductId = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ProductId");
			o.ReleaseDate = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "ReleaseDate");

			return o;
		}


	}  // end of class
}  // end of namespace
