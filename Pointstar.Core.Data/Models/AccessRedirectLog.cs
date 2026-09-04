using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class AccessRedirectLog
	{
		public DateTime Created { get; set; }
		public int? Day { get; set; }
		public int? DayOfWeek { get; set; }
		public string Directory { get; set; }
		public string FileName { get; set; }
		public int? Hour { get; set; }
		public int ID { get; set; }
		public int? Minute { get; set; }
		public int? Month { get; set; }
		public Guid? OrderID { get; set; }
		public string RedirectKey { get; set; }
		public string SaleKey { get; set; }
		public int? Second { get; set; }
		public string Server { get; set; }
		public Guid? SiteVisitID { get; set; }
		public Guid? VisitorID { get; set; }
		public int? Year { get; set; }


		public AccessRedirectLog()
		{
			Created = DateTime.Now;
			Day = null;
			DayOfWeek = null;
			Directory = "";
			FileName = "";
			Hour = null;
			ID = 0;
			Minute = null;
			Month = null;
			OrderID = null;
			RedirectKey = "";
			SaleKey = "";
			Second = null;
			Server = "";
			SiteVisitID = null;
			VisitorID = null;
			Year = null;
		}




	}  // end of class
}  // end of namespace
