using System;
using System.Collections.Generic;
using System.Text;

namespace Pointstar.Standard.Common
{
	public class InvalidEmailAddressException : System.ApplicationException
	{
		public InvalidEmailAddressException(string emailAddress)
			: base(String.Format("{0} is not a valid email address.", emailAddress))
		{

		}
	}
}
