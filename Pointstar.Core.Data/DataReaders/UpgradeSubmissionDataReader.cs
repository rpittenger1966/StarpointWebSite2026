using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */


	public class UpgradeSubmissionDataReader
	{

				static public Pointstar.Core.Data.UpgradeSubmission BuildFromDataReader(Microsoft.Data.SqlClient.SqlDataReader reader)
		{
			Pointstar.Core.Data.UpgradeSubmission o = new Pointstar.Core.Data.UpgradeSubmission();

			o.ChemPointPro = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ChemPointPro");
			o.ChemPointStandard = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ChemPointStandard");
			o.ChemStat = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "ChemStat");
			o.Comments = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Comments");
			o.Created = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "Created");
			o.CustomerEmailAddress = Pointstar.Core.Data.AdoHelper.ReadString(reader, "CustomerEmailAddress");
			o.DaysValid = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "DaysValid");
			o.ID = Pointstar.Core.Data.AdoHelper.ReadGuid(reader, "ID");
			o.InfiniteExtent = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "InfiniteExtent");
			o.LastModified = Pointstar.Core.Data.AdoHelper.ReadDateTime(reader, "LastModified");
			o.MohrView = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "MohrView");
			o.OrderID = Pointstar.Core.Data.AdoHelper.ReadNullableGuid(reader, "OrderID");
			o.OutboundEmailID = Pointstar.Core.Data.AdoHelper.ReadNullableInt(reader, "OutboundEmailID");
			o.Price = Pointstar.Core.Data.AdoHelper.ReadDecimal(reader, "Price");
			o.SieveGraph = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "SieveGraph");
			o.Status = Pointstar.Core.Data.AdoHelper.ReadString(reader, "Status");
			o.StepMaster = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "StepMaster");
			o.SuperSlug = Pointstar.Core.Data.AdoHelper.ReadInt(reader, "SuperSlug");

			return o;
		}


	}  // end of class
}  // end of namespace
