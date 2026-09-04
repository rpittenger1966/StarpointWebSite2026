using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class SiteVisitDataReader
	{

				static public Pointstar.Core.Data.SiteVisit BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.SiteVisit o = new Pointstar.Core.Data.SiteVisit();

			o.BrowserAgent = Pointstar.Core.Data.AdoHelper.ReadString(reader, "BrowserAgent");
			o.BrowserID = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "BrowserID");
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
			o.IPAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IPAddress");
			o.IsFirstVisit = Pointstar.Core.Data.AdoHelper.ReadBoolean(reader, "IsFirstVisit");
			o.Minute = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Minute");
			o.Month = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Month");
			o.Referrer = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Referrer");
			o.Second = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Second");
			o.Server = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Server");
			o.SessionID = Pointstar.Core.Data.AdoHelper.ReadString(reader, "SessionID");
			o.VisitorID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "VisitorID");
			o.Year = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Year");

			return o;
		}


	}  // end of class
}  // end of namespace
