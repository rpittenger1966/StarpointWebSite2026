using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.ChemPoint
{
    public class ContouringModel : BasePageModel
	{
		public ContouringModel()
		{
			Menu = MenuEnum.ChemPoint;
			MovieLinks = MovieLinksEnum.ChemPoint;
			MetaPageDescription = "";
		}

		public void OnGet()
        {
        }
    }
}
