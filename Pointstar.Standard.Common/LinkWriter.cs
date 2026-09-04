using System;
using System.Collections.Generic;
using System.Text;

namespace Pointstar.Standard.Common
{
	public class LinkWriter
	{
		public LinkWriter()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		static public string BracketLink(string strLink)
		{
			if (strLink.Length == 0) return "";
			return "[" + strLink + "]&nbsp;";
		}


		static public string MakePageLink(string strCaption, string strPage)
		{
			return MakePageLink(strCaption, strPage, true);
		}

		static public string MakePageLink(string strCaption, string strPage, bool bPermission)
		{
			if (bPermission == false) return "";
			return "<a href=\"" + strPage + "\">" + strCaption + "</a>";
		}


		static public string MakeNewObjectLink(string strCaption, string strPage, bool bPermission)
		{
			string s;
			if (bPermission == false)
			{
				s = "Read Only Access";
			}
			else
			{
				s = BracketLink(LinkWriter.MakePageLink(strCaption, strPage, true));
			}

			return s;
		}



		static public string MakeGuidancePageLink(string strCaption,
			string strPage, string strKeyValue, string strBookmark, bool bPermission)
		{
			return MakeGuidancePageLink(strCaption, strPage, "GuidanceKey",
				strKeyValue, strBookmark, bPermission);
		}

		static public string MakeGuidancePageLink(string strCaption,
			string strPage, string strKeyName, string strKeyValue, string strBookmark, bool bPermission)
		{
			if (bPermission == false) return "";

			string strTarget = "target=\"_blank\"";
			string strBookmark2 = "#" + strBookmark;

			return BracketLink("<a href=\"" + strPage + "?" + strKeyName + "=" +
				strKeyValue + strBookmark2 + "\" " + strTarget + ">" + strCaption + "</a>");
		}

		static public string MakeKeyPageLink1(string strCaption, string strPage,
			string strKeyName, string strKey, bool bPermission)
		{
			if (bPermission == false) return "";

			return MakeTargetedKeyPageLink1(strCaption, strPage,
				strKeyName, strKey, "", bPermission);
		}

		static public string MakeTargetedKeyPageLink1(string strCaption, string strPage,
			string strKeyName, string strKey, string strTarget, bool bPermission)
		{
			if (bPermission == false) return "";

			string strTarget2 = "";

			if (strTarget != string.Empty)
			{
				strTarget2 = "target=\"" + strTarget + "\" ";
			}

			return "<a href=\"" + strPage + "?" + strKeyName + "=" +
				strKey + "\" " + strTarget2 + ">" + strCaption + "</a>";
		}



		static public string MakeKeyPageLink2(string strCaption, string strPage,
			string strKeyName1, string strKey1, string strKeyName2,
			string strKey2, string strTarget, bool bPermission)
		{
			if (bPermission == false) return "";

			string strTarget2 = "";

			if (strTarget.Length > 0)
			{
				strTarget2 = "target=\"" + strTarget + "\" ";
			}


			return "<a href=\"" + strPage + "?" + strKeyName1 + "=" + strKey1 +
				"&" + strKeyName2 + "=" + strKey2 + "\" " + strTarget2 +
				">" + strCaption + "</a>";
		}


		static public string MakeKeyPageLink3(string strCaption, string strPage,
			string strKeyName1, string strKey1,
			string strKeyName2, string strKey2,
			string strKeyName3, string strKey3,
			bool bPermission)
		{
			if (bPermission == false) return "";
			return "<a href=\"" + strPage + "?" + strKeyName1 + "=" + strKey1 +
				"&" + strKeyName2 + "=" + strKey2 +
				"&" + strKeyName3 + "=" + strKey3 +
				"\">" + strCaption + "</a>";
		}

		static public string MakeTargetedKeyPageLink3(string strCaption, string strPage,
			string strKeyName1, string strKey1,
			string strKeyName2, string strKey2,
			string strKeyName3, string strKey3,
			string strTarget,
			bool bPermission)
		{
			if (bPermission == false) return "";

			string strTarget2 = "";

			if (strTarget.Length > 0)
			{
				strTarget2 = "target=\"" + strTarget + "\" ";
			}

			return "<a href=\"" + strPage + "?" + strKeyName1 + "=" + strKey1 +
				"&" + strKeyName2 + "=" + strKey2 +
				"&" + strKeyName3 + "=" + strKey3 + "\" " + strTarget2 +
				">" + strCaption + "</a>";
		}


		static public string MakeDeleteObjectLink(string strCaption, string strKey, bool bPermission)
		{
			if (bPermission == false) return "";
			return "<a href=\"DeleteConfirmForm.aspx?ObjectKey=" + strKey +
				"\">" + strCaption + "</a>";
		}

		static public string MakeTargetedPageLink(string strCaption,
			string strPage, string strTarget)
		{
			string strTarget2 = "";
			if (strTarget != string.Empty)
			{
				strTarget2 = "target=\"" + strTarget + "\"";
			}

			return "<a href=\"" + strPage + "\" " + strTarget2 + ">" + strCaption + "</a>";
		}

		static public string MakeLinkBar(string s1)
		{
			return MakeLinkBar(s1, "", "", "", "", "");
		}


		static public string MakeLinkBar(string s1, string s2)
		{
			return MakeLinkBar(s1, s2, "", "", "", "");
		}

		static public string MakeLinkBar(string s1, string s2, string s3)
		{
			return MakeLinkBar(s1, s2, s3, "", "", "");
		}

		static public string MakeLinkBar(string s1, string s2, string s3, string s4)
		{
			return MakeLinkBar(s1, s2, s3, s4, "", "");
		}

		static public string MakeLinkBar(string s1, string s2, string s3, string s4, string s5)
		{
			return MakeLinkBar(s1, s2, s3, s4, s5, "");
		}

		static public string MakeLinkBar(string s1, string s2, string s3, string s4, string s5, string s6)
		{
			string s = "";

			if (s1.Length > 0)
			{
				s += "[" + s1 + "]&nbsp;";
			}
			if (s2.Length > 0)
			{
				s += "[" + s2 + "]&nbsp;";
			}
			if (s3.Length > 0)
			{
				s += "[" + s3 + "]&nbsp;";
			}
			if (s4.Length > 0)
			{
				s += "[" + s4 + "]&nbsp;";
			}
			if (s5.Length > 0)
			{
				s += "[" + s5 + "]&nbsp;";
			}
			if (s6.Length > 0)
			{
				s += "[" + s6 + "]&nbsp;";
			}

			if (s != string.Empty)
			{
				return TextWriter.MakeParagraph(s);
			}

			return s;

		}

		static public string MakeLineBreakLinkBar(string s1, string s2, string s3)
		{
			string s = "";

			if (s1.Length > 0)
			{
				s += "[" + s1 + "]";
			}

			if (s.Length > 0)
			{
				s += "<br>";
			}

			if (s2.Length > 0)
			{
				s += "[" + s2 + "]";
			}

			if (s.Length > 0)
			{
				s += "<br>";
			}

			if (s3.Length > 0)
			{
				s += "[" + s3 + "]";
			}

			return s;
		}

		static public string MakeBookmarkDestination(string strCaption, string strBookmarkID)
		{
			string s;

			s = "<a name=\"" + strBookmarkID + "\">" + strCaption + "</a>";

			return s;
		}

		static public string MakeEmailLink(string strEmail, string strCaption)
		{
			string strURL = "<a href=\"mailto:" + strEmail + "\">" + strCaption + "</a>";
			return strURL;
		}

		static public string MakeImageLink(string strImageFileName)
		{
			string strImageTag = "<img border=\"0\" src=\"images/" + strImageFileName + "\" />&nbsp;";
			return strImageTag;
		}

		static public string MakeEditObjectLink(string strCaption, string strPage,
			string strKeyName, string strKey, bool bPermission)
		{
			return BracketLink(MakeKeyPageLink1(strCaption, strPage, strKeyName, strKey, bPermission));
		}


		static public string InlineLinkBar(string s1)
		{
			return InlineLinkBar(s1, "", "", "", "");
		}

		static public string InlineLinkBar(string s1, string s2)
		{
			return InlineLinkBar(s1, s2, "", "", "");
		}

		static public string InlineLinkBar(string s1, string s2, string s3)
		{
			return InlineLinkBar(s1, s2, s3, "", "");
		}

		static public string InlineLinkBar(string s1, string s2, string s3, string s4)
		{
			return InlineLinkBar(s1, s2, s3, s4, "");
		}


		static public string InlineLinkBar(string s1, string s2, string s3, string s4, string s5)
		{
			string s = "";

			if (s1.Length > 0)
			{
				s += "[" + s1 + "]&nbsp;";
			}
			if (s2.Length > 0)
			{
				s += "[" + s2 + "]&nbsp;";
			}
			if (s3.Length > 0)
			{
				s += "[" + s3 + "]&nbsp;";
			}
			if (s4.Length > 0)
			{
				s += "[" + s4 + "]&nbsp;";
			}
			if (s5.Length > 0)
			{
				s += "[" + s5 + "]&nbsp;";
			}

			return s;
		}

	}
}

