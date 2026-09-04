using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class ProductInstallationFileDataReader
	{

				static public Pointstar.Core.Data.ProductInstallationFile BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.ProductInstallationFile o = new Pointstar.Core.Data.ProductInstallationFile();

			o.Caption = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Caption");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.Directory = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Directory");
			o.FileName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FileName");
			o.ProductInstallationFileId = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ProductInstallationFileId");

			return o;
		}


	}  // end of class
}  // end of namespace
