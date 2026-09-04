using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class IpRedirectDataReader
	{

				static public Pointstar.Core.Data.IpRedirect BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.IpRedirect o = new Pointstar.Core.Data.IpRedirect();

			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.IpAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IpAddress");

			return o;
		}


	}  // end of class
}  // end of namespace
