using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class OutboundEmail
	{
		public string Body { get; set; }
		public string Cookie { get; set; }
		public DateTime Created { get; set; }
		public string Exception { get; set; }
		public int ID { get; set; }
		public string IPAddress { get; set; }
		public Guid? MemberID { get; set; }
		public Guid? OrderID { get; set; }
		public string Recipient { get; set; }
		public string Status { get; set; }
		public string Subject { get; set; }
		public string Type { get; set; }


		public OutboundEmail()
		{
			Body = "";
			Cookie = "";
			Created = DateTime.Now;
			Exception = "";
			ID = 0;
			IPAddress = "";
			MemberID = null;
			OrderID = null;
			Recipient = "";
			Status = "";
			Subject = "";
			Type = "";
		}




	}  // end of class
}  // end of namespace
