using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.Aquifer
{
    public class StepMasterModel : BasePageModel
	{
		public StepMasterModel()
		{
			Menu = MenuEnum.Aquifer;
		}

		public void OnGet()
        {
        }
    }
}
