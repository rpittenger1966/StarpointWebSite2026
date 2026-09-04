using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class SurveyResponse
	{
		public Guid? AlternateId { get; set; }
		public DateTime Created { get; set; }
		public string EmailAddress { get; set; }
		public Guid? MemberId { get; set; }
		public XElement Response { get; set; }
		public string SurveyName { get; set; }
		public int SurveyResponseId { get; set; }


		public SurveyResponse()
		{
			AlternateId = null;
			Created = DateTime.Now;
			EmailAddress = "";
			MemberId = null;
			Response = null;
			SurveyName = "";
			SurveyResponseId = 0;
		}




	}  // end of class
}  // end of namespace
