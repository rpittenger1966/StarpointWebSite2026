using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.Support
{
    public class CSCrashModel : BasePageModel
    {
		public CSCrashModel()
		{
			Menu = MenuEnum.Support;
		}

		public void OnGet()
        {
        }
    }
}
