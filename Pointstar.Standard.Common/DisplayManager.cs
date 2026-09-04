using System;
using System.Collections.Generic;
using System.Text;

namespace Pointstar.Standard.Common
{
	public class DisplayManager
	{
		public const int m_nControlWidth = 400;
		public const int m_nRichEditBoxWidth = 700;
		public const int m_nNarrowControlWidth = 200;
		public const int m_nRichEditBoxHeight = 400;





		//static public string GetCssFilePath(MasterPage page)
		//{
		//	string strStyleSheet = "StyleSheet.css";

		//	try
		//	{
		//		strStyleSheet = Convert.ToString(ConfigurationManager.AppSettings["StyleSheet"]);
		//	}
		//	catch
		//	{

		//	}

		//	return page.ResolveUrl("~/Css/" + strStyleSheet);
		//}

		//static public string GetReportServicesURL()
		//{
		//	try
		//	{
		//		return Convert.ToString(ConfigurationManager.AppSettings["ReportServicesURL"]);
		//	}
		//	catch
		//	{

		//	}

		//	return "";

		//}

		static public string WriteBoolSpan(bool bValue)
		{
			if (bValue)
			{
				return TextWriter.Span("permissiontrue", "true");
			}
			return TextWriter.Span("permissionfalse", "false");
		}

		public static string GetCaptionFilePath()
		{
			return "Not Implemented";
		}

		static public bool IsComplianceNavigator()
		{
			return true;
		}



		static public bool AllowOnlineOrders()
		{
			return false;
		}

		static public bool AllowOnlineOrdering()
		{
			return false;
		}

		static public bool IsPointstar()
		{
			return true;
		}


	}


}
