using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.Download
{
    public class MoviesModel : BasePageModel
	{
        public void OnGet()
        {
			Menu = MenuEnum.Default;
			MovieLinks = MovieLinksEnum.All;
			MetaPageDescription = "";
        }
    }
}
