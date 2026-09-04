using System;
using System.Collections.Generic;
using System.Text;

namespace Pointstar.Standard.Common
{
	public class TextWriter : HtmlTextWriter
	{
		public TextWriter()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		static public string MakeParagraph(string s)
		{
			return "<p>" + s + "</p>";
		}

		static public string MakeLine(string s)
		{
			return s + "<br />";
		}

		static public string Span(string strClass, string strText)
		{
			return "<span class=\"" + strClass + "\">" + strText + "</span>";
		}

		static public string Div(string strClass, string strText)
		{
			return "<div class=\"" + strClass + "\">" + strText + "</div>";
		}

		static public string MakeH1Text(string s)
		{
			return "<h1>" + s + "</h1>";
		}

		static public string MakeH2Text(string s)
		{
			return "<h2>" + s + "</h2>";
		}

		static public string MakeH3Text(string s)
		{
			return "<h3>" + s + "</h3>";
		}

		static public string MakeH4Text(string s)
		{
			return "<h4>" + s + "</h4>";
		}

		static public string MakeH5Text(string s)
		{
			return "<h5>" + s + "</h5>";
		}

		static public string MakeH6Text(string s)
		{
			return "<h6>" + s + "</h6>";
		}

		static public string MakeItalicText(string s)
		{
			return "<i>" + s + "</i>";
		}

		static public string MakeBoldText(string s)
		{
			return "<b>" + s + "</b>";
		}

		static public string MakeReadOnlyText(string s)
		{
			return Span("readonly", s); ;
		}

		static public string MakeErrorString(string strError)
		{
			return HtmlTextWriter.Span("errorblock", strError);
		}

		static public string MakeErrorStringInline(string strError)
		{
			return HtmlTextWriter.Span("errorinline", strError);
		}


		static public string MakeHelpBlock(string strText)
		{
			return HtmlTextWriter.Span("helpblock", strText);
		}


	} // end of class declaration

}