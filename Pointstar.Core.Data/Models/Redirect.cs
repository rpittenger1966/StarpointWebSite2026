using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class Redirect
	{
		public string Caption { get; set; }
		public DateTime Created { get; set; }
		public string Directory { get; set; }
		public int DownloadCount { get; set; }
		public int DownloadMax { get; set; }
		public string FileName { get; set; }
		public string FirstUserCookie { get; set; }
		public Guid ID { get; set; }
		public Guid? MemberID { get; set; }
		public Guid? OrderID { get; set; }
		public Guid? OrderLineItemID { get; set; }
		public bool SingleUser { get; set; }


		public Redirect()
		{
			Caption = "";
			Created = DateTime.Now;
			Directory = "";
			DownloadCount = 0;
			DownloadMax = 0;
			FileName = "";
			FirstUserCookie = "";
			ID = Guid.NewGuid();
			MemberID = null;
			OrderID = null;
			OrderLineItemID = null;
			SingleUser = false;
		}




	}  // end of class
}  // end of namespace
