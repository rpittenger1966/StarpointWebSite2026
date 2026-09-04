using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class ShoppingCart
	{
		public DateTime Created { get; set; }
		public string GuidCookie { get; set; }
		public Guid ID { get; set; }
		public DateTime LastModified { get; set; }
		public Guid? MemberID { get; set; }


		public ShoppingCart()
		{
			Created = DateTime.Now;
			GuidCookie = "";
			ID = Guid.NewGuid();
			LastModified = DateTime.Now;
			MemberID = null;
		}




	}  // end of class
}  // end of namespace
