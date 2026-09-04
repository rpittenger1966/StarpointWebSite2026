using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class RedirectLog
	{
		public DateTime Created { get; set; }
		public string FileName { get; set; }
		public Guid ID { get; set; }
		public string IPAddress { get; set; }
		public Guid? MemberID { get; set; }
		public Guid RedirectID { get; set; }
		public Guid? SiteVisitID { get; set; }
		public Guid? VisitorID { get; set; }


		public RedirectLog()
		{
			Created = DateTime.Now;
			FileName = "";
			ID = Guid.NewGuid();
			IPAddress = "";
			MemberID = null;
			RedirectID = Guid.NewGuid();
			SiteVisitID = null;
			VisitorID = null;
		}




	}  // end of class
}  // end of namespace
