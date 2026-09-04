using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class CommunicationPreferences
	{
		public Int64 CommunicationPreferencesId { get; set; }
		public DateTime Created { get; set; }
		public string EmailAddress { get; set; }
		public bool Newsletter { get; set; }
		public bool OtherProductUpdates { get; set; }
		public bool ProductSurveys { get; set; }
		public bool YourProductUpdates { get; set; }


		public CommunicationPreferences()
		{
			CommunicationPreferencesId = 0;
			Created = DateTime.Now;
			EmailAddress = "";
			Newsletter = false;
			OtherProductUpdates = false;
			ProductSurveys = false;
			YourProductUpdates = false;
		}




	}  // end of class
}  // end of namespace
