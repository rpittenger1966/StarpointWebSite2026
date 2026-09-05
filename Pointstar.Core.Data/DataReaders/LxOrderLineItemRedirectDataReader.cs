using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class LxOrderLineItemRedirectDataReader
	{

				static public Pointstar.Core.Data.LxOrderLineItemRedirect BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.LxOrderLineItemRedirect o = new Pointstar.Core.Data.LxOrderLineItemRedirect();

			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.OrderID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "OrderID");
			o.OrderLineItemID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "OrderLineItemID");
			o.RedirectID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "RedirectID");

			return o;
		}


	}  // end of class
}  // end of namespace
