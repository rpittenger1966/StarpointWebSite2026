using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class PasswordHistory
	{
		public DateTime Created { get; set; }
		public string CreatedBy { get; set; }
		public Guid ID { get; set; }
		public DateTime LastModified { get; set; }
		public string LastModifiedBy { get; set; }
		public Guid MemberID { get; set; }
		public string Password { get; set; }
		public int PasswordHashAlgorithm { get; set; }
		public string PasswordSalt { get; set; }


		public PasswordHistory()
		{
			Created = DateTime.Now;
			CreatedBy = "";
			ID = Guid.NewGuid();
			LastModified = DateTime.Now;
			LastModifiedBy = "";
			MemberID = Guid.NewGuid();
			Password = "";
			PasswordHashAlgorithm = 0;
			PasswordSalt = "";
		}




	}  // end of class
}  // end of namespace
