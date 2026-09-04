using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class LicenseKey
	{
		public DateTime Created { get; set; }
		public string LicenseKeyBase64 { get; set; }
		public Guid LicenseKeyId { get; set; }
		public Guid? OrderId { get; set; }
		public Guid? OrderLineItemId { get; set; }
		public string Product { get; set; }


		public LicenseKey()
		{
			Created = DateTime.Now;
			LicenseKeyBase64 = "";
			LicenseKeyId = Guid.NewGuid();
			OrderId = null;
			OrderLineItemId = null;
			Product = "";
		}




	}  // end of class
}  // end of namespace
