using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class ShoppingCartItem
	{
		public DateTime Created { get; set; }
		public bool Deleted { get; set; }
		public Guid ID { get; set; }
		public Decimal ItemPrice { get; set; }
		public DateTime LastModified { get; set; }
		public string LicenseDescription { get; set; }
		public Decimal LineTotal { get; set; }
		public string ProductDescription { get; set; }
		public int ProductID { get; set; }
		public Guid ProductLicenseID { get; set; }
		public int Quantity { get; set; }
		public Guid ShoppingCartID { get; set; }
		public Guid? SpecialItemID { get; set; }


		public ShoppingCartItem()
		{
			Created = DateTime.Now;
			Deleted = false;
			ID = Guid.NewGuid();
			ItemPrice = 0.0m;
			LastModified = DateTime.Now;
			LicenseDescription = "";
			LineTotal = 0.0m;
			ProductDescription = "";
			ProductID = 0;
			ProductLicenseID = Guid.NewGuid();
			Quantity = 0;
			ShoppingCartID = Guid.NewGuid();
			SpecialItemID = null;
		}




	}  // end of class
}  // end of namespace
