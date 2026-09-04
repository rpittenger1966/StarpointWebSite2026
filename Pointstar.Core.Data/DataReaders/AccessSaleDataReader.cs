using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class AccessSaleDataReader
	{

				static public Pointstar.Core.Data.AccessSale BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.AccessSale o = new Pointstar.Core.Data.AccessSale();

			o.ApprovalCode = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ApprovalCode");
			o.AquiferTest = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "AquiferTest");
			o.ChemPointChemStat = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ChemPointChemStat");
			o.ChemPointPro = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ChemPointPro");
			o.ChemPointStd = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ChemPointStd");
			o.ChemStat = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ChemStat");
			o.ConfirmationNumber = Pointstar.Core.Data.AdoHelper.ReadString(reader, "ConfirmationNumber");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.Day = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Day");
			o.DayOfWeek = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "DayOfWeek");
			o.Email = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Email");
			o.Email2 = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Email2");
			o.ExpirationDate = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "ExpirationDate");
			o.FirstName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "FirstName");
			o.Geotech = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "Geotech");
			o.GrandTotal = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "GrandTotal");
			o.Hour = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Hour");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ID");
			o.InfiniteExtent = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "InfiniteExtent");
			o.IPAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "IPAddress");
			o.LastName = Pointstar.Core.Data.AdoHelper.ReadString(reader, "LastName");
			o.Minute = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Minute");
			o.MohrView = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "MohrView");
			o.Month = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Month");
			o.OrderDate = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "OrderDate");
			o.OrderID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "OrderID");
			o.SaleKey = Pointstar.Core.Data.AdoHelper.ReadString(reader, "SaleKey");
			o.SalesTax = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "SalesTax");
			o.SalesTaxRate = Pointstar.Core.Data.AdoHelper.ReadDouble(reader, "SalesTaxRate");
			o.Second = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Second");
			o.Server = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Server");
			o.Shipping = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "Shipping");
			o.SieveGraph = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "SieveGraph");
			o.StepMaster = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "StepMaster");
			o.SuperSlug = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "SuperSlug");
			o.Taafi = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Taafi");
			o.Year = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "Year");

			return o;
		}


	}  // end of class
}  // end of namespace
