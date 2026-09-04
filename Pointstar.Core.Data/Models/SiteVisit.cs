using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class SiteVisit
	{
		public string BrowserAgent { get; set; }
		public int? BrowserID { get; set; }
		public int? CampaignID { get; set; }
		public DateTime Created { get; set; }
		public int? Day { get; set; }
		public int? DayOfWeek { get; set; }
		public string DomainAddress { get; set; }
		public string GuidCookie { get; set; }
		public int? Hour { get; set; }
		public Guid ID { get; set; }
		public string InitialPage { get; set; }
		public Guid? InitialSiteVisitID { get; set; }
		public string IPAddress { get; set; }
		public bool IsFirstVisit { get; set; }
		public int? Minute { get; set; }
		public int? Month { get; set; }
		public string Referrer { get; set; }
		public int? Second { get; set; }
		public string Server { get; set; }
		public string SessionID { get; set; }
		public Guid? VisitorID { get; set; }
		public int? Year { get; set; }


		public SiteVisit()
		{
			BrowserAgent = "";
			BrowserID = null;
			CampaignID = null;
			Created = DateTime.Now;
			Day = null;
			DayOfWeek = null;
			DomainAddress = "";
			GuidCookie = "";
			Hour = null;
			ID = Guid.NewGuid();
			InitialPage = "";
			InitialSiteVisitID = null;
			IPAddress = "";
			IsFirstVisit = false;
			Minute = null;
			Month = null;
			Referrer = "";
			Second = null;
			Server = "";
			SessionID = "";
			VisitorID = null;
			Year = null;
		}




	}  // end of class
}  // end of namespace
