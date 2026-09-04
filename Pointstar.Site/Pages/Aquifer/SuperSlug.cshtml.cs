using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.Aquifer
{
    public class SuperSlugModel : BasePageModel
	{
		public SuperSlugModel()
		{
			Menu = MenuEnum.Aquifer;
			MovieLinks = MovieLinksEnum.SuperSlug;
			MetaPageDescription = "Super Slug - The easiest aquifer slug test analysis software for Windows with all popular slug test methods and easy data logger import.";
		}

		public void OnGet()
        {
        }
    }
}
