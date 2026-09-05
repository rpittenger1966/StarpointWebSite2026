using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Site.Pages.Starpoint
{
    public class PricingModel : BasePageModel
	{
		public string litChemPointChemStat { get; set; }
		public string litChemPointPro { get; set; }
		public string litChemPointProUpgrade { get; set; }
		public string litChemPointStandard { get; set; }
		public string litChemStatSingleUser { get; set; }
		public string litChemStatUpgrade { get; set; }


		public string litStepMaster { get; set; }
		public string litSuperSlug { get; set; }
		public string litInfiniteExtent { get; set; }
		public string litAquiferTestPackage { get; set; }
		public string litChemPointStdUpgrade { get; set; }

		public PricingModel()
		{
			litChemPointChemStat = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetChemPointChemStat()));
			litChemPointPro = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetChemPointPro()));
			litChemPointProUpgrade = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetChemPointProUpgrade()));
			litChemPointStandard = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetChemPointStandard()));
			litChemStatSingleUser = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetChemStat()));
			litChemStatUpgrade = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetChemStatUpgrade()));


			litStepMaster = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetStepMaster()));
			litSuperSlug = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetSuperSlug()));
			litInfiniteExtent = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetInfiniteExtent()));
			litAquiferTestPackage = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetAquiferTestPack()));
			litChemPointStdUpgrade = String.Format("{0} ea.", StringFunctions.FormatDollars(PriceManager.GetChemPointStandardUpgrade()));
			MetaPageDescription = "Starpoint Software Price List - Software for science and engineering";
		}

		public void OnGet()
        {
        }
    }
}
