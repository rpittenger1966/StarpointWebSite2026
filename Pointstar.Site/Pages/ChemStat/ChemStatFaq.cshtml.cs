using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.ChemStat
{
    public class ChemStatFaqModel : BasePageModel
	{
		public ChemStatFaqModel()
		{
			Menu = MenuEnum.ChemStat;
			MovieLinks = MovieLinksEnum.ChemStat;
			MetaPageDescription = "ChemStat Software for Statistical Analysis of Environmental Data - Frequently Asked Questions";
		}

		public void OnGet()
        {
        }
    }
}
