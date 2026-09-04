using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class Product
	{
		public string Abbrev { get; set; }
		public bool Active { get; set; }
		public DateTime Created { get; set; }
		public string Description { get; set; }
		public int DisplayOrder { get; set; }
		public int ExtraInfo { get; set; }
		public int ID { get; set; }
		public DateTime LastModified { get; set; }
		public string Name { get; set; }
		public string ProductComment { get; set; }
		public int ProductType { get; set; }
		public Guid? RedirectID { get; set; }


		public Product()
		{
			Abbrev = "";
			Active = false;
			Created = DateTime.Now;
			Description = "";
			DisplayOrder = 0;
			ExtraInfo = 0;
			ID = 0;
			LastModified = DateTime.Now;
			Name = "";
			ProductComment = "";
			ProductType = 0;
			RedirectID = null;
		}




	}  // end of class
}  // end of namespace
