using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages
{
	public class IndexModel : BasePageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
			Menu = MenuEnum.Unspecified;
			MetaPageDescription = "Starpoint Software - Windows applications for Science and Engineering - Cincinnati, Ohio";
		}

		public void OnGet()
		{

		}
	}
}
