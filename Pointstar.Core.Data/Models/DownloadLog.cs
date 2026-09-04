using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class DownloadLog
	{
		public DateTime Created { get; set; }
		public string FileName { get; set; }
		public Guid ID { get; set; }
		public string LandingPageEmail { get; set; }
		public string LandingPageName { get; set; }
		public DateTime LastModified { get; set; }
		public Guid? MemberID { get; set; }
		public string MemberName { get; set; }
		public Guid? OrderID { get; set; }
		public Guid? OrderLineItemID { get; set; }
		public string PageUrl { get; set; }
		public Guid? RedirectID { get; set; }
		public Guid? SiteVisitID { get; set; }
		public Guid? VisitorID { get; set; }


		public DownloadLog()
		{
			Created = DateTime.Now;
			FileName = "";
			ID = Guid.NewGuid();
			LandingPageEmail = "";
			LandingPageName = "";
			LastModified = DateTime.Now;
			MemberID = null;
			MemberName = "";
			OrderID = null;
			OrderLineItemID = null;
			PageUrl = "";
			RedirectID = null;
			SiteVisitID = null;
			VisitorID = null;
		}




	}  // end of class
}  // end of namespace
