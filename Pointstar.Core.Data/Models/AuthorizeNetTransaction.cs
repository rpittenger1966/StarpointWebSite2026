using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class AuthorizeNetTransaction
	{
		public Decimal ChargeAmount { get; set; }
		public DateTime? EndDate { get; set; }
		public string Exception { get; set; }
		public string FirstName { get; set; }
		public int ID { get; set; }
		public string LastName { get; set; }
		public string OrderDescription { get; set; }
		public XElement PostValues { get; set; }
		public string ResponseValues { get; set; }
		public int? Result { get; set; }
		public DateTime StartDate { get; set; }
		public bool TestMode { get; set; }
		public int? TransactionDuration { get; set; }


		public AuthorizeNetTransaction()
		{
			ChargeAmount = 0.0m;
			EndDate = null;
			Exception = "";
			FirstName = "";
			ID = 0;
			LastName = "";
			OrderDescription = "";
			PostValues = null;
			ResponseValues = "";
			Result = null;
			StartDate = DateTime.Now;
			TestMode = false;
			TransactionDuration = null;
		}




	}  // end of class
}  // end of namespace
