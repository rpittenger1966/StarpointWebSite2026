using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class TrialDownloadDataReader
	{

				static public Pointstar.Core.Data.TrialDownload BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.TrialDownload o = new Pointstar.Core.Data.TrialDownload();

			o.Address1 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Address1");
			o.Address2 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Address2");
			o.ChemPoint = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "ChemPoint");
			o.ChemPointPro = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "ChemPointPro");
			o.ChemStat = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "ChemStat");
			o.City = Pointstar.Core.Data.AdoHelper.ReadString(reader, "City");
			o.CompanyName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CompanyName");
			o.Country = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Country");
			o.CountryCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CountryCode");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.EmailAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "EmailAddress");
			o.FirstName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FirstName");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ID");
			o.InfiniteExtent = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "InfiniteExtent");
			o.IPAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IPAddress");
			o.JobTitle = Pointstar.Core.Data.AdoHelper.ReadString(reader, "JobTitle");
			o.LastName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LastName");
			o.MemberID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "MemberID");
			o.MohrView = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "MohrView");
			o.Movies = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "Movies");
			o.PostalCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PostalCode");
			o.PrimaryPhone = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PrimaryPhone");
			o.PrimaryPhoneDigits = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PrimaryPhoneDigits");
			o.PrimaryPhoneExt = Pointstar.Core.Data.AdoHelper.ReadString(reader, "PrimaryPhoneExt");
			o.PrimaryPhoneType = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "PrimaryPhoneType");
			o.SieveGraph = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "SieveGraph");
			o.SiteVisitID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "SiteVisitID");
			o.StateCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "StateCode");
			o.StateProvince = Pointstar.Core.Data.AdoHelper.ReadString(reader, "StateProvince");
			o.StepMaster = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "StepMaster");
			o.SuperSlug = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "SuperSlug");
			o.Taafi = Pointstar.Core.Data.AdoHelper.ReadNullableBoolean(reader, "Taafi");
			o.VisitorID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "VisitorID");

			return o;
		}


	}  // end of class
}  // end of namespace
