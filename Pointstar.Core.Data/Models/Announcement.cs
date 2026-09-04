using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class Announcement
	{
		public int AnnouncementStatus { get; set; }
		public DateTime Created { get; set; }
		public string CreatedBy { get; set; }
		public DateTime EndDate { get; set; }
		public int ID { get; set; }
		public DateTime LastModified { get; set; }
		public string LastModifiedBy { get; set; }
		public string PlainText { get; set; }
		public DateTime PostDate { get; set; }
		public string Title { get; set; }
		public string Url { get; set; }


		public Announcement()
		{
			AnnouncementStatus = 0;
			Created = DateTime.Now;
			CreatedBy = "";
			EndDate = DateTime.Now;
			ID = 0;
			LastModified = DateTime.Now;
			LastModifiedBy = "";
			PlainText = "";
			PostDate = DateTime.Now;
			Title = "";
			Url = "";
		}




	}  // end of class
}  // end of namespace
