using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class OrderLineItemLicenseRedirectView
	{
		public string EmailAddress { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string LicenseDescription { get; set; }
		public string OrderComments { get; set; }
		public DateTime OrderDate { get; set; }
		public Guid OrderId { get; set; }
		public string ProductDescription { get; set; }
		public int ProductID { get; set; }
		public Guid ProductLicenseID { get; set; }


		public OrderLineItemLicenseRedirectView()
		{
			EmailAddress = "";
			FirstName = "";
			LastName = "";
			LicenseDescription = "";
			OrderComments = "";
			OrderDate = DateTime.Now;
			OrderId = Guid.NewGuid();
			ProductDescription = "";
			ProductID = 0;
			ProductLicenseID = Guid.NewGuid();
		}




	}  // end of class
}  // end of namespace
