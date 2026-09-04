using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class OrderLineItemRedirectViewDataReader
	{

				static public Pointstar.Core.Data.OrderLineItemRedirectView BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.OrderLineItemRedirectView o = new Pointstar.Core.Data.OrderLineItemRedirectView();

			o.Caption = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Caption");
			o.OrderID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "OrderID");
			o.OrderLineItemID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "OrderLineItemID");
			o.RedirectID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "RedirectID");

			return o;
		}


	}  // end of class
}  // end of namespace
