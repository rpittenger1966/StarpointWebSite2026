using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace Pointstar.Standard.Common
{
	public class StringFunctions
	{
		public StringFunctions()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		static public string MakeKey(string strPrefix)
		{
			System.Guid guid = System.Guid.NewGuid();
			return strPrefix + ":" + guid.ToString();
		}

		static public string FilterText(string strTextParam)
		{
			// Replaces malicous text with harmless equivalent
			string str1, str2;

			if (strTextParam == null) return "";

			// Disable certain HTML
			str1 = strTextParam.Replace("&", "&amp;");
			str2 = str1.Replace("\"", "&quot;");
			str1 = str2.Replace("<", "&lt;");
			str2 = str1.Replace(">", "&gt;");
			str1 = str2.Replace("<%", "&lt;%");
			str2 = str1.Replace("%>", "%&gt;");

			return FormatMultiLineText(str2);
		}

		static public string UnfilterText(string strTextParam)
		{
			// Replaces malicous text with harmless equivalent
			string str1, str2;

			if (strTextParam == null) return "";

			// Disable certain HTML
			str2 = strTextParam.Replace("&quot;", "\"");
			str1 = str2.Replace("&lt;", "<");
			str2 = str1.Replace("&gt;", ">");
			str1 = str2.Replace("&lt;%", "<%");
			str2 = str1.Replace("%&gt;", "%>");
			str1 = str2.Replace("&amp;", "&");

			return str1;
		}


		static public string ChangeFileExtension(string strSource, string strNewExtension)
		{
			return System.IO.Path.ChangeExtension(strSource, strNewExtension);

		}

		static public string EscapeSqlText(string strSource)
		{
			int n, nMax = strSource.Length;
			string s = "";

			char ch;
			for (n = 0; n < nMax; ++n)
			{
				ch = strSource[n];

				switch (ch)
				{
					case '\'':
					case '"':
						s += '_';
						break;
					default:
						s += ch;
						break;
				}
			}

			return s;
		}

		static public int CompareNoCase(string s1, string s2)
		{
			string ss1, ss2;
			ss1 = s1.ToLower();
			ss2 = s2.ToLower();
			return ss1.CompareTo(ss2);
		}

		static public string FormatDollars(Decimal d)
		{
			if (d == 0) return "-";

			string s = d.ToString("#.00");

			if (Math.Round(d) == d)
			{
				s = d.ToString("#");
			}

			return "$" + s;
		}

		public static string FormatCurrency(decimal d)
		{
			if (d == 0) return "-";
			return String.Format("{0:C}", d);
		}

		static public string FormatPercentage(double d)
		{
			return Convert.ToString(d * 100.0) + "%";
		}

		static public string MakeFullName(string strFirstName, string strLastName)
		{
			// Improve this function
			if (strFirstName == string.Empty)
			{
				return strLastName;
			}
			if (strLastName == string.Empty)
			{
				return strFirstName;
			}
			return strFirstName + " " + strLastName;
		}

		static public string Left(string s, int nMax)
		{
			if (s == null) return "";
			if (s.Length <= nMax) return s;
			return s.Substring(0, nMax);
		}

		// equivalent of the CString::Right function
		// not tested!
		static public string Right(string s, int nCount)
		{
			if (s == null) return "";
			if (nCount >= s.Length) return s;
			int nStartIndex = s.Length - nCount;
			return s.Substring(nStartIndex, nCount);
		}

		static public string RightToEnd(string s, int nStart)
		{
			int nLength = s.Length - nStart;
			return s.Substring(nStart, nLength);
		}

		static public string BoolString(bool value)
		{
			if (value) return "True";
			return "False";

		}


		static public string ToShortDateString(DateTime dt)
		{
			if (dt == DateTime.MinValue) return "";
			if (dt.ToOADate() == 0.0) return "";
			return dt.ToShortDateString();
		}

		static public string ToShortDateString(DateTime? dt)
		{
			if (dt == null) return "";
			return ToShortDateString((DateTime)dt);
		}

		static public string ToDateTimeString(DateTime dt)
		{
			if (dt == DateTime.MinValue) return "";
			if (dt.ToOADate() == 0.0) return "";
			return dt.ToString();
		}

		static public string ToDateTimeString(DateTime? dt)
		{
			if (dt == null) return "";
			return ToDateTimeString((DateTime)dt);
		}

		static public void ValidateEmailAddress(string email)
		{
			try
			{
				MailAddress addr = new MailAddress(email);
			}
			catch
			{
				throw new InvalidEmailAddressException(email);
			}
		}




		static public string MaxLength(string s, int max)
		{
			if (s.Length < max) return s;
			return s.Substring(0, max);
		}


		// supposedly removes all HTML froma string, but doesn't handle line breaks properly
		public static string RemoveHTML(string in_HTML)
		{
			string s = Regex.Replace(in_HTML, "<(.|\n)*?>", "");

			StringBuilder sb = new StringBuilder(s);

			sb.Replace("&amp;", "&");
			sb.Replace("&quot;", "\"");
			sb.Replace("&nbsp;", " ");
			sb.Replace("&rsquo;", "'");
			sb.Replace("&lsquo;", "'");
			sb.Replace("&rquo;", "\"");
			sb.Replace("&lquo;", "\"");
			sb.Replace("&rquot;", "\"");
			sb.Replace("&lquot;", "\"");
			sb.Replace("&mdash;", "--");
			sb.Replace("&ndash;", "-");
			sb.Replace("&copy;", "©");
			sb.Replace("&reg;", "®");
			sb.Replace("&nbsp;", " ");

			return sb.ToString();


		}

		// trim a string to not exceed a specified length.  If the string is trimmed, ... is appended
		public static string TrimLength(string s, int max)
		{
			if (String.IsNullOrEmpty(s)) return "";

			if (s.Length < max) return s;
			string sShort = s.Substring(0, max);

			char[] delimits = { ' ', '\t', '\n', '\r' };
			int index = sShort.LastIndexOfAny(delimits);
			if (index < 0) return sShort + "...";

			return sShort.Substring(0, index) + "...";
		}




		public static string MakeSlug(string source)
		{
			StringBuilder sb = new StringBuilder(source);
			int n, nMax = source.Length;
			for (n = 0; n < nMax; ++n)
			{
				if (Char.IsLetterOrDigit(sb[n])) continue;
				sb[n] = '_';
			}

			return sb.ToString();
		}

		public static string MakeLowerCaseHypenatedSlug(string source)
		{
			StringBuilder sb = new StringBuilder(source);
			int n, nMax = source.Length;
			for (n = 0; n < nMax; ++n)
			{
				if (Char.IsLetterOrDigit(sb[n])) continue;
				sb[n] = '-';
			}

			Regex regex = new Regex("[-]{1,100}");
			string final = regex.Replace(sb.ToString(), "-");

			return final.ToLower().TrimEnd('-');
		}


		static public string BuildHtmlFromPlainText(string text)
		{
			if (text == string.Empty) return "";

			StringBuilder sb = new StringBuilder(text);

			sb.Replace("&", "&amp;"); // always replace amp first
			sb.Replace("\"", "&quot;");
			sb.Replace("<", "&lt;");
			sb.Replace(">", "&gt;");
			sb.Replace("\t", "     ");
			sb.Replace("\r\n", "\n");
			sb.Replace("\n", "<br />"); // improves paragraph spacing

			return sb.ToString();
		}


		static public string FormatMultiLineText(string strText)
		{
			return BuildHtmlFromPlainText(strText);
			/*			// formats a multiline (ML) string.
			// replaces '\n' with '<br>'.
			if (strText == null) return "";
			if (strText.Length == 0) return "";

			string str1, str2;

			str1 = strText.Replace("\r\n", "\n");
			str2 = str1.Replace('\r', '\n');
			str1 = str2.Replace("\n", "<br>");

			return str1; */
		} // end of function



		static public string MakeCamelCase(string source)
		{
			// NOT DONE!

			StringBuilder sb = new StringBuilder(source);

			int n, nMax = sb.Length;
			char ch;
			for (n = 0; n < nMax - 1; ++n)
			{
				ch = sb[n];

				if (n == 0)
				{
					// capitalize first
					sb[n] = char.ToUpper(ch);
				}



			}


			return sb.ToString();
		}


		static public string IntToBoolString(int value)
		{
			if (value == 1) return "true";
			return "false";
		}


		static public string StripPhoneNumberToDigits(string source)
		{
			string source2 = source.ToLower();

			StringBuilder sb = new StringBuilder();

			foreach (Char ch in source2)
			{
				if (Char.IsDigit(ch)) sb.Append(ch);

				switch (ch)
				{
					case 'a':
					case 'b':
					case 'c':
						sb.Append('2');
						break;
					case 'd':
					case 'e':
					case 'f':
						sb.Append('3');
						break;
					case 'g':
					case 'h':
					case 'i':
						sb.Append('4');
						break;
					case 'j':
					case 'k':
					case 'l':
						sb.Append('5');
						break;
					case 'm':
					case 'n':
					case 'o':
						sb.Append('6');
						break;
					case 'p':
					case 'q':
					case 'r':
					case 's':
						sb.Append('7');
						break;
					case 't':
					case 'u':
					case 'v':
						sb.Append('8');
						break;
					case 'w':
					case 'x':
					case 'y':
					case 'z':
						sb.Append('9');
						break;
					default:
						break;
				}
			}

			return sb.ToString();
		}



		static public string MakeSafeUrl(string www)
		{
			string lower = www.ToLower();

			if (lower.IndexOf("http") == 0) return www;

			return String.Format("http://{0}", www);

		}


		static public int CountWords(string source)
		{
			StringBuilder sb = new StringBuilder(source);

			// turn all newlines to spaces
			sb.Replace("\r\n", " ");
			sb.Replace('\n', ' ');
			sb.Replace('\t', ' ');



			// replace misc with spaces
			sb.Replace(' ', ' ');
			sb.Replace(" – ", " ");
			sb.Replace('"', ' ');
			sb.Replace('(', ' ');
			sb.Replace(')', ' ');

			// replace sentance enders with spaces
			sb.Replace(". ", " ");
			sb.Replace("? ", " ");
			sb.Replace("! ", " ");
			sb.Replace("; ", " ");
			sb.Replace(": ", " ");

			string[] a = sb.ToString().Split(
					new char[] { ' ', ',' });

			int count = 0;
			string s2;

			foreach (string s in a)
			{
				s2 = s.Trim();
				if (s2.Length == 0) continue;

				//				Console.WriteLine("[" + s2 + "]");

				if (Char.IsLetterOrDigit(s2[0]))
				{
					++count;
				}
			}


			return count;
		}

		static public string BuildMercuryUniqueSignature(string plainTextSource, int signatureLength)
		{
			StringBuilder sb = new StringBuilder(signatureLength);

			int count = 0;
			foreach (char ch in plainTextSource)
			{
				if (Char.IsLetterOrDigit(ch))
				{
					sb.Append(Char.ToLower(ch));
					++count;
					if (count >= signatureLength) return sb.ToString();
				}
			}

			return sb.ToString();
		}


		static public string IsNullOrEmpty(string text, string alternate)
		{
			if (String.IsNullOrEmpty(text)) return alternate;
			return text;
		}

		static public string LinebreakBase64TextforHtml(string input, int lineLength)
		{
			int n, max = input.Length;
			int lines = ((max % lineLength) + 1) * 10;

			StringBuilder sb = new StringBuilder(max + lines);

			for (n = 0; n < max; ++n)
			{
				sb.Append(input[n]);
				if (((n + 1) % lineLength) == 0)
				{
					sb.Append("<br /> ");
				}
			}

			return sb.ToString();

		}


	} // end of class
}
