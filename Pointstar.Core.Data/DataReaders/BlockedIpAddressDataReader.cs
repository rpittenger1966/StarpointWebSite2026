using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class BlockedIpAddressDataReader
	{

				static public Pointstar.Core.Data.BlockedIpAddress BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.BlockedIpAddress o = new Pointstar.Core.Data.BlockedIpAddress();

			o.Active = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Active");
			o.BlockedIpAddressId = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "BlockedIpAddressId");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.ErrorMessage = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ErrorMessage");
			o.IpAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IpAddress");
			o.RequestUrl = Pointstar.Core.Data.AdoHelper.ReadString(reader, "RequestUrl");

			return o;
		}


	}  // end of class
}  // end of namespace
