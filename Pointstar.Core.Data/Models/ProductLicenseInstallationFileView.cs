using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class ProductLicenseInstallationFileView
	{
		public bool Active { get; set; }
		public string Caption { get; set; }
		public string Directory { get; set; }
		public string FileName { get; set; }
		public bool FreeTrial { get; set; }
		public string LicenseDescription { get; set; }
		public bool Network { get; set; }
		public Decimal Price { get; set; }
		public int ProductID { get; set; }
		public Guid ProductLicenseId { get; set; }
		public string ProductName { get; set; }
		public bool SiteLicense { get; set; }
		public bool Upgrade { get; set; }
		public int Users { get; set; }


		public ProductLicenseInstallationFileView()
		{
			Active = false;
			Caption = "";
			Directory = "";
			FileName = "";
			FreeTrial = false;
			LicenseDescription = "";
			Network = false;
			Price = 0.0m;
			ProductID = 0;
			ProductLicenseId = Guid.NewGuid();
			ProductName = "";
			SiteLicense = false;
			Upgrade = false;
			Users = 0;
		}




	}  // end of class
}  // end of namespace
