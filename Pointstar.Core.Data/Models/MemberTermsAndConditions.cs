using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class MemberTermsAndConditions
	{
		public DateTime Created { get; set; }
		public string CreatedBy { get; set; }
		public Guid ID { get; set; }
		public DateTime LastModified { get; set; }
		public string LastModifiedBy { get; set; }
		public Guid MemberID { get; set; }
		public string TermsAndConditions { get; set; }


		public MemberTermsAndConditions()
		{
			Created = DateTime.Now;
			CreatedBy = "";
			ID = Guid.NewGuid();
			LastModified = DateTime.Now;
			LastModifiedBy = "";
			MemberID = Guid.NewGuid();
			TermsAndConditions = "";
		}




	}  // end of class
}  // end of namespace
