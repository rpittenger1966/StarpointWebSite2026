using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class UpgradeSubmission
	{
		public int ChemPointPro { get; set; }
		public int ChemPointStandard { get; set; }
		public int ChemStat { get; set; }
		public string Comments { get; set; }
		public DateTime Created { get; set; }
		public string CustomerEmailAddress { get; set; }
		public int DaysValid { get; set; }
		public Guid ID { get; set; }
		public int InfiniteExtent { get; set; }
		public DateTime LastModified { get; set; }
		public int MohrView { get; set; }
		public Guid? OrderID { get; set; }
		public int? OutboundEmailID { get; set; }
		public Decimal Price { get; set; }
		public int SieveGraph { get; set; }
		public string Status { get; set; }
		public int StepMaster { get; set; }
		public int SuperSlug { get; set; }


		public UpgradeSubmission()
		{
			ChemPointPro = 0;
			ChemPointStandard = 0;
			ChemStat = 0;
			Comments = "";
			Created = DateTime.Now;
			CustomerEmailAddress = "";
			DaysValid = 0;
			ID = Guid.NewGuid();
			InfiniteExtent = 0;
			LastModified = DateTime.Now;
			MohrView = 0;
			OrderID = null;
			OutboundEmailID = null;
			Price = 0.0m;
			SieveGraph = 0;
			Status = "";
			StepMaster = 0;
			SuperSlug = 0;
		}




	}  // end of class
}  // end of namespace
