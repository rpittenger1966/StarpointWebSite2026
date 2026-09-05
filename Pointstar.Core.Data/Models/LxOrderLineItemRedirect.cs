using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class LxOrderLineItemRedirect
	{
		public DateTime Created { get; set; }
		public Guid OrderID { get; set; }
		public Guid OrderLineItemID { get; set; }
		public Guid RedirectID { get; set; }


		public LxOrderLineItemRedirect()
		{
			Created = DateTime.Now;
			OrderID = Guid.NewGuid();
			OrderLineItemID = Guid.NewGuid();
			RedirectID = Guid.NewGuid();
		}




	}  // end of class
}  // end of namespace
