using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class ProductLicense
	{
		public bool Active { get; set; }
		public DateTime Created { get; set; }
		public string Description { get; set; }
		public bool FreeTrial { get; set; }
		public Guid ID { get; set; }
		public DateTime LastModified { get; set; }
		public bool Network { get; set; }
		public Decimal Price { get; set; }
		public int ProductID { get; set; }
		public Guid? RedirectID { get; set; }
		public string RedirectKey { get; set; }
		public bool SiteLicense { get; set; }
		public bool Upgrade { get; set; }
		public int Users { get; set; }


		public ProductLicense()
		{
			Active = false;
			Created = DateTime.Now;
			Description = "";
			FreeTrial = false;
			ID = Guid.NewGuid();
			LastModified = DateTime.Now;
			Network = false;
			Price = 0.0m;
			ProductID = 0;
			RedirectID = null;
			RedirectKey = "";
			SiteLicense = false;
			Upgrade = false;
			Users = 0;
		}




	}  // end of class
}  // end of namespace
