using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class AccessSale
	{
		public string ApprovalCode { get; set; }
		public int AquiferTest { get; set; }
		public int ChemPointChemStat { get; set; }
		public int ChemPointPro { get; set; }
		public int ChemPointStd { get; set; }
		public int ChemStat { get; set; }
		public string ConfirmationNumber { get; set; }
		public DateTime Created { get; set; }
		public int? Day { get; set; }
		public int? DayOfWeek { get; set; }
		public string Email { get; set; }
		public string Email2 { get; set; }
		public DateTime ExpirationDate { get; set; }
		public string FirstName { get; set; }
		public int Geotech { get; set; }
		public Decimal GrandTotal { get; set; }
		public int? Hour { get; set; }
		public int ID { get; set; }
		public int InfiniteExtent { get; set; }
		public string IPAddress { get; set; }
		public string LastName { get; set; }
		public int? Minute { get; set; }
		public int MohrView { get; set; }
		public int? Month { get; set; }
		public DateTime OrderDate { get; set; }
		public Guid OrderID { get; set; }
		public string SaleKey { get; set; }
		public Decimal SalesTax { get; set; }
		public double SalesTaxRate { get; set; }
		public int? Second { get; set; }
		public string Server { get; set; }
		public Decimal Shipping { get; set; }
		public int SieveGraph { get; set; }
		public int StepMaster { get; set; }
		public int SuperSlug { get; set; }
		public int? Taafi { get; set; }
		public int? Year { get; set; }


		public AccessSale()
		{
			ApprovalCode = "";
			AquiferTest = 0;
			ChemPointChemStat = 0;
			ChemPointPro = 0;
			ChemPointStd = 0;
			ChemStat = 0;
			ConfirmationNumber = "";
			Created = DateTime.Now;
			Day = null;
			DayOfWeek = null;
			Email = "";
			Email2 = "";
			ExpirationDate = DateTime.Now;
			FirstName = "";
			Geotech = 0;
			GrandTotal = 0.0m;
			Hour = null;
			ID = 0;
			InfiniteExtent = 0;
			IPAddress = "";
			LastName = "";
			Minute = null;
			MohrView = 0;
			Month = null;
			OrderDate = DateTime.Now;
			OrderID = Guid.NewGuid();
			SaleKey = "";
			SalesTax = 0.0m;
			SalesTaxRate = 0.0;
			Second = null;
			Server = "";
			Shipping = 0.0m;
			SieveGraph = 0;
			StepMaster = 0;
			SuperSlug = 0;
			Taafi = null;
			Year = null;
		}




	}  // end of class
}  // end of namespace
