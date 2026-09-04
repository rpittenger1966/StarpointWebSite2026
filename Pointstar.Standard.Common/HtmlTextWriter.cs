using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pointstar.Standard.Common
{
	public class HtmlTextWriter
	{
		public HtmlTextWriter()
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


		static public string GetResponseContentType(string fileName)
		{
			string fileExtension = Path.GetExtension(fileName).ToLower();


			if (fileExtension == "323") return "text/h323";
			if (fileExtension == "acx") return "application/internet-property-stream";
			if (fileExtension == "ai") return "application/postscript";
			if (fileExtension == "aif") return "audio/x-aiff";
			if (fileExtension == "aifc") return "audio/x-aiff";
			if (fileExtension == "aiff") return "audio/x-aiff";
			if (fileExtension == "asf") return "video/x-ms-asf";
			if (fileExtension == "asr") return "video/x-ms-asf";
			if (fileExtension == "asx") return "video/x-ms-asf";
			if (fileExtension == "au") return "audio/basic";
			if (fileExtension == "avi") return "video/x-msvideo";
			if (fileExtension == "axs") return "application/olescript";
			if (fileExtension == "bas") return "text/plain";
			if (fileExtension == "bcpio") return "application/x-bcpio";
			if (fileExtension == "bin") return "application/octet-stream";
			if (fileExtension == "bmp") return "image/bmp";
			if (fileExtension == "c") return "text/plain";
			if (fileExtension == "cat") return "application/vnd.ms-pkiseccat";
			if (fileExtension == "cdf") return "application/x-cdf";
			if (fileExtension == "cer") return "application/x-x509-ca-cert";
			if (fileExtension == "class") return "application/octet-stream";
			if (fileExtension == "clp") return "application/x-msclip";
			if (fileExtension == "cmx") return "image/x-cmx";
			if (fileExtension == "cod") return "image/cis-cod";
			if (fileExtension == "cpio") return "application/x-cpio";
			if (fileExtension == "crd") return "application/x-mscardfile";
			if (fileExtension == "crl") return "application/pkix-crl";
			if (fileExtension == "crt") return "application/x-x509-ca-cert";
			if (fileExtension == "csh") return "application/x-csh";
			if (fileExtension == "css") return "text/css";
			if (fileExtension == "dcr") return "application/x-director";
			if (fileExtension == "der") return "application/x-x509-ca-cert";
			if (fileExtension == "dir") return "application/x-director";
			if (fileExtension == "dll") return "application/x-msdownload";
			if (fileExtension == "dms") return "application/octet-stream";
			if (fileExtension == "doc") return "application/msword";
			if (fileExtension == "dot") return "application/msword";
			if (fileExtension == "dvi") return "application/x-dvi";
			if (fileExtension == "dxr") return "application/x-director";
			if (fileExtension == "eps") return "application/postscript";
			if (fileExtension == "etx") return "text/x-setext";
			if (fileExtension == "evy") return "application/envoy";
			if (fileExtension == "exe") return "application/octet-stream";
			if (fileExtension == "fif") return "application/fractals";
			if (fileExtension == "flr") return "x-world/x-vrml";
			if (fileExtension == "gif") return "image/gif";
			if (fileExtension == "gtar") return "application/x-gtar";
			if (fileExtension == "gz") return "application/x-gzip";
			if (fileExtension == "h") return "text/plain";
			if (fileExtension == "hdf") return "application/x-hdf";
			if (fileExtension == "hlp") return "application/winhlp";
			if (fileExtension == "hqx") return "application/mac-binhex40";
			if (fileExtension == "hta") return "application/hta";
			if (fileExtension == "htc") return "text/x-component";
			if (fileExtension == "htm") return "text/html";
			if (fileExtension == "html") return "text/html";
			if (fileExtension == "htt") return "text/webviewhtml";
			if (fileExtension == "ico") return "image/x-icon";
			if (fileExtension == "ief") return "image/ief";
			if (fileExtension == "iii") return "application/x-iphone";
			if (fileExtension == "ins") return "application/x-internet-signup";
			if (fileExtension == "isp") return "application/x-internet-signup";
			if (fileExtension == "jfif") return "image/pipeg";
			if (fileExtension == "jpe") return "image/jpeg";
			if (fileExtension == "jpeg") return "image/jpeg";
			if (fileExtension == "jpg") return "image/jpeg";
			if (fileExtension == "js") return "application/x-javascript";
			if (fileExtension == "latex") return "application/x-latex";
			if (fileExtension == "lha") return "application/octet-stream";
			if (fileExtension == "lsf") return "video/x-la-asf";
			if (fileExtension == "lsx") return "video/x-la-asf";
			if (fileExtension == "lzh") return "application/octet-stream";
			if (fileExtension == "m13") return "application/x-msmediaview";
			if (fileExtension == "m14") return "application/x-msmediaview";
			if (fileExtension == "m3u") return "audio/x-mpegurl";
			if (fileExtension == "") return "application/x-troff-man";
			if (fileExtension == "mdb") return "application/x-msaccess";
			if (fileExtension == "me") return "application/x-troff-me";
			if (fileExtension == "mht") return "message/rfc822";
			if (fileExtension == "mhtml") return "message/rfc822";
			if (fileExtension == "mid") return "audio/mid";
			if (fileExtension == "mny") return "application/x-msmoney";
			if (fileExtension == "mov") return "video/quicktime";
			if (fileExtension == "movie") return "video/x-sgi-movie";
			if (fileExtension == "mp2") return "video/mpeg";
			if (fileExtension == "mp3") return "audio/mpeg";
			if (fileExtension == "mpa") return "video/mpeg";
			if (fileExtension == "mpe") return "video/mpeg";
			if (fileExtension == "mpeg") return "video/mpeg";
			if (fileExtension == "mpg") return "video/mpeg";
			if (fileExtension == "mpp") return "application/vnd.ms-project";
			if (fileExtension == "mpv2") return "video/mpeg";
			if (fileExtension == "ms") return "application/x-troff-ms";
			if (fileExtension == "mvb") return "application/x-msmediaview";
			if (fileExtension == "nws") return "message/rfc822";
			if (fileExtension == "oda") return "application/oda";
			if (fileExtension == "p10") return "application/pkcs10";
			if (fileExtension == "p12") return "application/x-pkcs12";
			if (fileExtension == "p7b") return "application/x-pkcs7-certificates";
			if (fileExtension == "p7c") return "application/x-pkcs7-mime";
			if (fileExtension == "p7m") return "application/x-pkcs7-mime";
			if (fileExtension == "p7r") return "application/x-pkcs7-certreqresp";
			if (fileExtension == "p7s") return "application/x-pkcs7-signature";
			if (fileExtension == "pbm") return "image/x-portable-bitmap";
			if (fileExtension == "pdf") return "application/pdf";
			if (fileExtension == "pfx") return "application/x-pkcs12";
			if (fileExtension == "pgm") return "image/x-portable-graymap";
			if (fileExtension == "pko") return "application/ynd.ms-pkipko";
			if (fileExtension == "pma") return "application/x-perfmon";
			if (fileExtension == "pmc") return "application/x-perfmon";
			if (fileExtension == "pml") return "application/x-perfmon";
			if (fileExtension == "pmr") return "application/x-perfmon";
			if (fileExtension == "pmw") return "application/x-perfmon";
			if (fileExtension == "pnm") return "image/x-portable-anymap";
			if (fileExtension == "pot") return "application/vnd.ms-powerpoint";
			if (fileExtension == "ppm") return "image/x-portable-pixmap";
			if (fileExtension == "pps") return "application/vnd.ms-powerpoint";
			if (fileExtension == "ppt") return "application/vnd.ms-powerpoint";
			if (fileExtension == "prf") return "application/pics-rules";
			if (fileExtension == "ps") return "application/postscript";
			if (fileExtension == "pub") return "application/x-mspublisher";
			if (fileExtension == "qt") return "video/quicktime";
			if (fileExtension == "ra") return "audio/x-pn-realaudio";
			if (fileExtension == "ram") return "audio/x-pn-realaudio";
			if (fileExtension == "ras") return "image/x-cmu-raster";
			if (fileExtension == "rgb") return "image/x-rgb";
			if (fileExtension == "rmi") return "audio/mid";
			if (fileExtension == "roff") return "application/x-troff";
			if (fileExtension == "rtf") return "application/rtf";
			if (fileExtension == "rtx") return "text/richtext";
			if (fileExtension == "scd") return "application/x-msschedule";
			if (fileExtension == "sct") return "text/scriptlet";
			if (fileExtension == "setpay") return "application/set-payment-initiation";
			if (fileExtension == "setreg") return "application/set-registration-initiation";
			if (fileExtension == "sh") return "application/x-sh";
			if (fileExtension == "shar") return "application/x-shar";
			if (fileExtension == "sit") return "application/x-stuffit";
			if (fileExtension == "snd") return "audio/basic";
			if (fileExtension == "spc") return "application/x-pkcs7-certificates";
			if (fileExtension == "spl") return "application/futuresplash";
			if (fileExtension == "src") return "application/x-wais-source";
			if (fileExtension == "sst") return "application/vnd.ms-pkicertstore";
			if (fileExtension == "stl") return "application/vnd.ms-pkistl";
			if (fileExtension == "stm") return "text/html";
			if (fileExtension == "sv4cpio") return "application/x-sv4cpio";
			if (fileExtension == "sv4crc") return "application/x-sv4crc";
			if (fileExtension == "t") return "application/x-troff";
			if (fileExtension == "tar") return "application/x-tar";
			if (fileExtension == "tcl") return "application/x-tcl";
			if (fileExtension == "tex") return "application/x-tex";
			if (fileExtension == "texi") return "application/x-texinfo";
			if (fileExtension == "texinfo") return "application/x-texinfo";
			if (fileExtension == "tgz") return "application/x-compressed";
			if (fileExtension == "tif") return "image/tiff";
			if (fileExtension == "tiff") return "image/tiff";
			if (fileExtension == "tr") return "application/x-troff";
			if (fileExtension == "trm") return "application/x-msterminal";
			if (fileExtension == "tsv") return "text/tab-separated-values";
			if (fileExtension == "txt") return "text/plain";
			if (fileExtension == "uls") return "text/iuls";
			if (fileExtension == "ustar") return "application/x-ustar";
			if (fileExtension == "vcf") return "text/x-vcard";
			if (fileExtension == "vrml") return "x-world/x-vrml";
			if (fileExtension == "wav") return "audio/x-wav";
			if (fileExtension == "wcm") return "application/vnd.ms-works";
			if (fileExtension == "wdb") return "application/vnd.ms-works";
			if (fileExtension == "wks") return "application/vnd.ms-works";
			if (fileExtension == "wmf") return "application/x-msmetafile";
			if (fileExtension == "wps") return "application/vnd.ms-works";
			if (fileExtension == "wri") return "application/x-mswrite";
			if (fileExtension == "wrl") return "x-world/x-vrml";
			if (fileExtension == "wrz") return "x-world/x-vrml";
			if (fileExtension == "xaf") return "x-world/x-vrml";
			if (fileExtension == "xbm") return "image/x-xbitmap";
			if (fileExtension == "xla") return "application/vnd.ms-excel";
			if (fileExtension == "xlc") return "application/vnd.ms-excel";
			if (fileExtension == "xlm") return "application/vnd.ms-excel";
			if (fileExtension == "xls") return "application/vnd.ms-excel";
			if (fileExtension == "xlt") return "application/vnd.ms-excel";
			if (fileExtension == "xlw") return "application/vnd.ms-excel";
			if (fileExtension == "xof") return "x-world/x-vrml";
			if (fileExtension == "xpm") return "image/x-xpixmap";
			if (fileExtension == "xwd") return "image/x-xwindowdump";
			if (fileExtension == "z") return "application/x-compress";
			if (fileExtension == "zip") return "application/zip";
			return "application/octet-stream";

		}

	} // end of class declaration

}