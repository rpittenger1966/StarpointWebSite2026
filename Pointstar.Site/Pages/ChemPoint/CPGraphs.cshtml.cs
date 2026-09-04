using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.ChemPoint
{
    public class CPGraphsModel : BasePageModel
	{
		public CPGraphsModel()
		{
			Menu = MenuEnum.ChemPoint;
			MovieLinks = MovieLinksEnum.ChemPoint;
			MetaPageDescription = "ChemPoint Professional:  Environmental data management software for Windows with twelve types of graphs.";
		}

		public void OnGet()
        {
        }
    }
}
