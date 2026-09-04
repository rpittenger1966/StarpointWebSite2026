using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class AuthorizeNetTransactionDataReader
	{

				static public Pointstar.Core.Data.AuthorizeNetTransaction BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.AuthorizeNetTransaction o = new Pointstar.Core.Data.AuthorizeNetTransaction();

			o.ChargeAmount = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "ChargeAmount");
			o.EndDate = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "EndDate");
			o.Exception = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Exception");
			o.FirstName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FirstName");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ID");
			o.LastName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LastName");
			o.OrderDescription = Pointstar.Core.Data.AdoHelper.ReadString(reader, "OrderDescription");
			o.PostValues = Pointstar.Core.Data.AdoHelper.ReadXml(reader, "PostValues");
			o.ResponseValues = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ResponseValues");
			o.Result = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Result");
			o.StartDate = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "StartDate");
			o.TestMode = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "TestMode");
			o.TransactionDuration = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "TransactionDuration");

			return o;
		}


	}  // end of class
}  // end of namespace
