using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class CommunicationPreferencesDataReader
	{

				static public Pointstar.Core.Data.CommunicationPreferences BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.CommunicationPreferences o = new Pointstar.Core.Data.CommunicationPreferences();

			o.CommunicationPreferencesId = Pointstar.Core.Data.AdoHelper.ReadLong(reader, "CommunicationPreferencesId");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.EmailAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "EmailAddress");
			o.Newsletter = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Newsletter");
			o.OtherProductUpdates = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "OtherProductUpdates");
			o.ProductSurveys = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "ProductSurveys");
			o.YourProductUpdates = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "YourProductUpdates");

			return o;
		}


	}  // end of class
}  // end of namespace
