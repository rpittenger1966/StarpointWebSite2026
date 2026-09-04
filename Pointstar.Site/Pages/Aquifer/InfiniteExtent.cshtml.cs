using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.Aquifer
{
    public class InfiniteExtentModel : BasePageModel
	{
		public InfiniteExtentModel()
		{
			Menu = MenuEnum.Aquifer;
			MovieLinks = MovieLinksEnum.InfiniteExtent;
			MetaPageDescription = "Infinite Extent - Aquifer Constant Rate Pump Test and Recovery Test Software for Windows";
		}

		public void OnGet()
        {
        }
    }
}
