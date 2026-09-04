using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointstar.Core.Data
{
	/*  this is automatically generated code from Code Generator app - do not modify */

	public partial class ProductInstallationFile
	{
		public string Caption { get; set; }
		public DateTime Created { get; set; }
		public string Directory { get; set; }
		public string FileName { get; set; }
		public int ProductInstallationFileId { get; set; }


		public ProductInstallationFile()
		{
			Caption = "";
			Created = DateTime.Now;
			Directory = "";
			FileName = "";
			ProductInstallationFileId = 0;
		}




	}  // end of class
}  // end of namespace
