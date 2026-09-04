using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class BlockedIpAddress
	{
		public bool Active { get; set; }
		public int BlockedIpAddressId { get; set; }
		public DateTime Created { get; set; }
		public string ErrorMessage { get; set; }
		public string IpAddress { get; set; }
		public string RequestUrl { get; set; }


		public BlockedIpAddress()
		{
			Active = false;
			BlockedIpAddressId = 0;
			Created = DateTime.Now;
			ErrorMessage = "";
			IpAddress = "";
			RequestUrl = "";
		}




	}  // end of class
}  // end of namespace
