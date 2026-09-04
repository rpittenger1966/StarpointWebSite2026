using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class OrderLineItem
	{
		public DateTime Created { get; set; }
		public Decimal DiscountAmount { get; set; }
		public double DiscountPercent { get; set; }
		public Guid ID { get; set; }
		public DateTime LastModified { get; set; }
		public string LicenseDescription { get; set; }
		public Decimal LineTotal { get; set; }
		public Guid? MemberID { get; set; }
		public string OrderComments { get; set; }
		public Guid OrderID { get; set; }
		public int? OrderStatus { get; set; }
		public Decimal Price { get; set; }
		public string ProductDescription { get; set; }
		public int ProductID { get; set; }
		public Guid ProductLicenseID { get; set; }
		public string PromotionCode { get; set; }
		public int Quantity { get; set; }
		public DateTime? RefundedDate { get; set; }
		public string RefundedMessage { get; set; }
		public DateTime? VoidedDate { get; set; }
		public string VoidedMessage { get; set; }


		public OrderLineItem()
		{
			Created = DateTime.Now;
			DiscountAmount = 0.0m;
			DiscountPercent = 0.0;
			ID = Guid.NewGuid();
			LastModified = DateTime.Now;
			LicenseDescription = "";
			LineTotal = 0.0m;
			MemberID = null;
			OrderComments = "";
			OrderID = Guid.NewGuid();
			OrderStatus = null;
			Price = 0.0m;
			ProductDescription = "";
			ProductID = 0;
			ProductLicenseID = Guid.NewGuid();
			PromotionCode = "";
			Quantity = 0;
			RefundedDate = null;
			RefundedMessage = "";
			VoidedDate = null;
			VoidedMessage = "";
		}




	}  // end of class
}  // end of namespace
