using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.Support
{
    public class CSImportModel : BasePageModel
    {
		public CSImportModel()
		{
			Menu = MenuEnum.Support;
		}

		public void OnGet()
        {
        }
    }
}
