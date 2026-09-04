using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class ProductLicenseInstallationFileViewDataReader
	{

				static public Pointstar.Core.Data.ProductLicenseInstallationFileView BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.ProductLicenseInstallationFileView o = new Pointstar.Core.Data.ProductLicenseInstallationFileView();

			o.Active = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Active");
			o.Caption = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Caption");
			o.Directory = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Directory");
			o.FileName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FileName");
			o.FreeTrial = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "FreeTrial");
			o.LicenseDescription = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LicenseDescription");
			o.Network = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Network");
			o.Price = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "Price");
			o.ProductID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ProductID");
			o.ProductLicenseId = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ProductLicenseId");
			o.ProductName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ProductName");
			o.SiteLicense = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "SiteLicense");
			o.Upgrade = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Upgrade");
			o.Users = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "Users");

			return o;
		}


	}  // end of class
}  // end of namespace
