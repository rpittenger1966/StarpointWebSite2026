using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class Visitor
	{
		public string BrowserAgent { get; set; }
		public int? BrowserType { get; set; }
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
		public DateTime InitialVisitDate { get; set; }
		public string IPAddress { get; set; }
		public Guid? LastSiteVisitID { get; set; }
		public DateTime? LastVisitDate { get; set; }
		public int? Minute { get; set; }
		public int? Month { get; set; }
		public int NewOrReturningCustomer { get; set; }
		public string Referrer { get; set; }
		public int? Second { get; set; }
		public string Server { get; set; }
		public int? Year { get; set; }


		public Visitor()
		{
			BrowserAgent = "";
			BrowserType = null;
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
			InitialVisitDate = DateTime.Now;
			IPAddress = "";
			LastSiteVisitID = null;
			LastVisitDate = null;
			Minute = null;
			Month = null;
			NewOrReturningCustomer = 0;
			Referrer = "";
			Second = null;
			Server = "";
			Year = null;
		}




	}  // end of class
}  // end of namespace
