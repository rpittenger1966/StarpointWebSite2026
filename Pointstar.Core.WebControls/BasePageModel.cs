using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pointstar.Core.WebControls
{
	public class BasePageModel : PageModel
	{
		public string TestText { get; set; }

		public BasePageModel()
		{
			TestText = "";
		}


		public string IpAddress
		{
			get
			{
				try
				{
					if (this.Request == null) return "";

					// https://stackoverflow.com/questions/28664686/how-do-i-get-client-ip-address-in-asp-net-core
					IPAddress remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
					string result = "";
					if (remoteIpAddress != null)
					{
						// If we got an IPV6 address, then we need to ask the network for the IPV4 address 
						// This usually only happens when the browser is on the same machine as the server.
						if (remoteIpAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
						{
							remoteIpAddress = System.Net.Dns.GetHostEntry(remoteIpAddress).AddressList
								.First(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
						}
						result = remoteIpAddress.ToString();
						return result;
					}

				}
				catch (Exception ex)
				{
					//                    ExceptionLogProvider.LogExceptionHelper(CurrentUserId, this.Request.GetDisplayUrl(), ex);
				}
				return "";
			}

		}

		public string UserAgent
		{
			get
			{
				try
				{
					return Request.Headers["User-Agent"].ToString();
				}
				catch
				{
				}
				return "";
			}
		}

		public string CurrentUrlDomainName
		{
			get
			{
				try
				{
					return Request.Host.Host;
				}
				catch { }
				return "";
			}

		}

		public bool IsMobilePath
		{
			get
			{
				string url = Request.Path.ToString().ToLower();
				if (url.IndexOf("/m/") >= 0) return true;
				return false;
			}
		}

		public bool IsMobileDevice
		{
			get
			{
				string userAgent = UserAgent;

				if (string.IsNullOrEmpty(userAgent))
					return false;

				//tablet
				if (Regex.IsMatch(userAgent, "(tablet|ipad|playbook|silk)|(android(?!.*mobile))", RegexOptions.IgnoreCase))
					return true;

				//mobile
				const string mobileRegex =
					"blackberry|iphone|mobile|windows ce|opera mini|htc|sony|palm|symbianos|ipad|ipod|blackberry|bada|kindle|symbian|sonyericsson|android|samsung|nokia|wap|motor";

				if (Regex.IsMatch(userAgent, mobileRegex, RegexOptions.IgnoreCase)) return true;

				//not mobile 
				return false;

			}
		}

		public bool IsLocalHost
		{
			get
			{
				string url = Request.GetDisplayUrl().ToLower();
				if (url.IndexOf("localhost:") >= 0) return true;
				return false;
			}
		}


		// returns the folder prefix to make a mobile url
		public string MobileFolder
		{
			get
			{
				if (IsMobilePath) return "/m";
				return "";
			}
		}

		//public string CurrentUrl
		//{
		//    get
		//    {
		//        return Request.GetDisplayUrl();
		//    }

		//}

		//public string BaseUrl
		//{
		//    get
		//    {

		//        return Request.BaseUrl();
		//    }

		//}

		//public bool IsLocalHost
		//{
		//    get
		//    {
		//        if (BaseUrl.IndexOf("localhost") > 0) return true;
		//        return false;
		//    }
		//}

		public string GetImagesFilePath(string webRootPath)
		{
			string filePath = Path.Combine(webRootPath, @"assets");
			return filePath;
		}


		public string ResolveUrl(string input)
		{
			return input;
		}


		public string Testimonial
		{
			get
			{
				return Pointstar.Standard.Common.Testimonial.GetTestimonial();
			}
		}

		public string LoggedInAs
		{
			get
			{
				return "Logged In As";
			}
		}

		public bool SignedIn
		{
			get
			{
				return false;
			}
		}


		

		public string CopyrightText
		{
			get
			{
				return "Copyright © " + Convert.ToString(DateTime.Today.Year) + " by Starpoint Software Inc.";
			}
		}

		public bool AllowOnlineOrdering
		{
			get
			{
				return DisplayManager.AllowOnlineOrdering();
			}
		}

	}  // end of class
}  // end of namespace
