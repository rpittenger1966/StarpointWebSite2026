using System;
using System.Collections.Generic;
using System.Text;

namespace Pointstar.Standard.Common
{
	public class ConnectionStringFactory
	{
		static public string GetConnectionString()
		{
			return "Server=(local);Database=StarpointWebSite;Trusted_Connection=True;TrustServerCertificate=True;";
		}

	}
}
