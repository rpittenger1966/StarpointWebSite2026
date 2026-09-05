using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.Starpoint
{
    public class AboutStarpointModel : BasePageModel
    {
		public AboutStarpointModel()
		{
			Menu = MenuEnum.Unspecified;
			MetaPageDescription = "About Starpoint Software - Provider of Windows and web software for science, engineering, and IT security since 1994.";
		}

        public void OnGet()
        {
        }
    }
}
