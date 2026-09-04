using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class VisitorDataReader
	{

				static public Pointstar.Core.Data.Visitor BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.Visitor o = new Pointstar.Core.Data.Visitor();

			o.BrowserAgent = Pointstar.Core.Data.AdoHelper.ReadString(reader, "BrowserAgent");
			o.BrowserType = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "BrowserType");
			o.CampaignID = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "CampaignID");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.Day = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Day");
			o.DayOfWeek = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "DayOfWeek");
			o.DomainAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "DomainAddress");
			o.GuidCookie = Pointstar.Core.Data.AdoHelper.ReadString(reader, "GuidCookie");
			o.Hour = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Hour");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.InitialPage = Pointstar.Core.Data.AdoHelper.ReadString(reader, "InitialPage");
			o.InitialSiteVisitID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "InitialSiteVisitID");
			o.InitialVisitDate = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "InitialVisitDate");
			o.IPAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IPAddress");
			o.LastSiteVisitID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "LastSiteVisitID");
			o.LastVisitDate = Pointstar.Core.Data.AdoHelper.ReadNullableDateTime(reader, "LastVisitDate");
			o.Minute = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Minute");
			o.Month = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Month");
			o.NewOrReturningCustomer = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "NewOrReturningCustomer");
			o.Referrer = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Referrer");
			o.Second = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Second");
			o.Server = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Server");
			o.Year = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Year");

			return o;
		}


	}  // end of class
}  // end of namespace
