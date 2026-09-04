using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.ChemPoint
{
    public class CPFeaturesModel : BasePageModel
	{
		public CPFeaturesModel()
		{
			Menu = MenuEnum.ChemPoint;
			MovieLinks = MovieLinksEnum.ChemPoint;
			MetaPageDescription = "ChemPoint Professional: Environmental Data Management Software for Windows with built-in graphs and 2-D contouring";
		}

		public void OnGet()
        {
        }
    }
}
