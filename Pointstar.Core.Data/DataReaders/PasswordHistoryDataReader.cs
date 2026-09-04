using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class PasswordHistoryDataReader
	{

				static public Pointstar.Core.Data.PasswordHistory BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.PasswordHistory o = new Pointstar.Core.Data.PasswordHistory();

			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.CreatedBy = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CreatedBy");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.LastModifiedBy = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LastModifiedBy");
			o.MemberID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "MemberID");
			o.Password = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Password");
			o.PasswordHashAlgorithm = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "PasswordHashAlgorithm");
			o.PasswordSalt = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PasswordSalt");

			return o;
		}


	}  // end of class
}  // end of namespace
