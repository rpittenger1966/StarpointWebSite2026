using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class LicenseKeyValidationDataReader
	{

				static public Pointstar.Core.Data.LicenseKeyValidation BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.LicenseKeyValidation o = new Pointstar.Core.Data.LicenseKeyValidation();

			o.BaseboardManufacturer = Pointstar.Core.Data.AdoHelper.ReadString(reader, "BaseboardManufacturer");
			o.BaseboardProduct = Pointstar.Core.Data.AdoHelper.ReadString(reader, "BaseboardProduct");
			o.BrowserAgent = Pointstar.Core.Data.AdoHelper.ReadString(reader, "BrowserAgent");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.InvalidReason = Pointstar.Core.Data.AdoHelper.ReadString(reader, "InvalidReason");
			o.IpAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IpAddress");
			o.LicenseKeyId = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "LicenseKeyId");
			o.LicenseKeyValidationId = Pointstar.Core.Data.AdoHelper.ReadLong(reader, "LicenseKeyValidationId");
			o.ProcessorId = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ProcessorId");
			o.Valid = Pointstar.Core.Data.AdoHelper.ReadNullableBoolean(reader, "Valid");

			return o;
		}


	}  // end of class
}  // end of namespace
