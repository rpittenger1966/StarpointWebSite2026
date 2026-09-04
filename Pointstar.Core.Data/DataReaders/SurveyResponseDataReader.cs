using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class SurveyResponseDataReader
	{

				static public Pointstar.Core.Data.SurveyResponse BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.SurveyResponse o = new Pointstar.Core.Data.SurveyResponse();

			o.AlternateId = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "AlternateId");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.EmailAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "EmailAddress");
			o.MemberId = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "MemberId");
			o.Response = Pointstar.Core.Data.AdoHelper.ReadNullableXml(reader, "Response");
			o.SurveyName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "SurveyName");
			o.SurveyResponseId = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "SurveyResponseId");

			return o;
		}


	}  // end of class
}  // end of namespace
