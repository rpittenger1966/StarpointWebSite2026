using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class AccessRedirectDataReader
	{

				static public Pointstar.Core.Data.AccessRedirect BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.AccessRedirect o = new Pointstar.Core.Data.AccessRedirect();

			o.Directory = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Directory");
			o.FileName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FileName");
			o.RedirectKey = Pointstar.Core.Data.AdoHelper.ReadString(reader, "RedirectKey");

			return o;
		}


	}  // end of class
}  // end of namespace
