using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class ExceptionLog
	{
		public string Cookie { get; set; }
		public DateTime Created { get; set; }
		public int ID { get; set; }
		public string IPAddress { get; set; }
		public string Message { get; set; }
		public string StackTrace { get; set; }
		public Guid? VisitorID { get; set; }


		public ExceptionLog()
		{
			Cookie = "";
			Created = DateTime.Now;
			ID = 0;
			IPAddress = "";
			Message = "";
			StackTrace = "";
			VisitorID = null;
		}




	}  // end of class
}  // end of namespace
