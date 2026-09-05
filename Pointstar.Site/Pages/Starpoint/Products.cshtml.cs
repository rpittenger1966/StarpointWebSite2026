using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.Starpoint
{
    public class ProductsModel : BasePageModel
	{
		public ProductsModel()
		{
			MetaPageDescription = "Starpoint Software products - Windows applications for science and engineering.";
		}

		public void OnGet()
        {
        }
    }
}
