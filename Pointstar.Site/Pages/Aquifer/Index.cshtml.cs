using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.Aquifer
{
    public class IndexModel : BasePageModel
    {
		public IndexModel()
		{
			Menu = MenuEnum.Aquifer;
		}

		public void OnGet()
        {
        }
    }
}
