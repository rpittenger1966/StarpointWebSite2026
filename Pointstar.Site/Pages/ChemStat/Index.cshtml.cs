using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.ChemStat
{
    public class IndexModel : BasePageModel
	{
		public IndexModel()
		{
			Menu = MenuEnum.ChemStat;
			MovieLinks = MovieLinksEnum.ChemStat;
			MetaPageDescription = "ChemStat Software for Statistical Analysis of Environmental Data from Starpoint Software Inc.";
		}

        public void OnGet()
        {
        }
    }
}
