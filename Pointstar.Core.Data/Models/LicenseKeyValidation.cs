using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class LicenseKeyValidation
	{
		public string BaseboardManufacturer { get; set; }
		public string BaseboardProduct { get; set; }
		public string BrowserAgent { get; set; }
		public DateTime Created { get; set; }
		public string InvalidReason { get; set; }
		public string IpAddress { get; set; }
		public Guid? LicenseKeyId { get; set; }
		public Int64 LicenseKeyValidationId { get; set; }
		public string ProcessorId { get; set; }
		public bool? Valid { get; set; }


		public LicenseKeyValidation()
		{
			BaseboardManufacturer = "";
			BaseboardProduct = "";
			BrowserAgent = "";
			Created = DateTime.Now;
			InvalidReason = "";
			IpAddress = "";
			LicenseKeyId = null;
			LicenseKeyValidationId = 0;
			ProcessorId = "";
			Valid = null;
		}




	}  // end of class
}  // end of namespace
