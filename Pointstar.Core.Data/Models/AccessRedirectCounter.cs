using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class AccessRedirectCounter
	{
		public int Count { get; set; }
		public DateTime Created { get; set; }
		public string Directory { get; set; }
		public string FileName { get; set; }
		public int ID { get; set; }
		public DateTime LastModified { get; set; }
		public int Max { get; set; }
		public Guid? OrderID { get; set; }
		public string RedirectKey { get; set; }
		public string SaleKey { get; set; }


		public AccessRedirectCounter()
		{
			Count = 0;
			Created = DateTime.Now;
			Directory = "";
			FileName = "";
			ID = 0;
			LastModified = DateTime.Now;
			Max = 0;
			OrderID = null;
			RedirectKey = "";
			SaleKey = "";
		}




	}  // end of class
}  // end of namespace
