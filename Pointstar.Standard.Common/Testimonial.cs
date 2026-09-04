using System;
using System.Collections.Generic;
using System.Text;

namespace Pointstar.Standard.Common
{
	public class Testimonial
	{
		static public string GetTestimonial()
		{
			int index = (DateTime.Now.Minute) % 3;


			switch (index)
			{
				case 1:
					return "I just purchased and have used for the first time your Super Slug software.<br />  The ease of use and overall value of this program is outstanding!";
				case 2:
					return "I just downloaded a trial version and this looks like <br />what I have been looking for, for a very long time.";
			}

			return "This software is great!  We plan to buy another seat, <br />waiting on purchase order.  The output is very readable and <br />options are fast and easy to use.";
		}


	}
}
