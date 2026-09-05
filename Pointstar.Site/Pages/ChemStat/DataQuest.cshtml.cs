using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.ChemStat
{
    public class DataQuestModel : BasePageModel
	{
		public DataQuestModel()
		{
			Menu = MenuEnum.ChemStat;
			MovieLinks = MovieLinksEnum.ChemStat;
			MetaPageDescription = "ChemStat Software for Statistical Analysis of Environmental Data compared to USEPA DataQuest";
		}

		public void OnGet()
        {
        }
    }
}
