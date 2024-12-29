using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

	public class _gen_requester : _Common
	{
		private static IResourceProvider resourceProvider_gen_requester = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_requester.xml"));//DbResourceProvider(); //  


		public static string requesterList
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("requesterList", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string requesterCreate
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("requesterCreate", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string requesterUpdate
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("requesterUpdate", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string requesterDetails
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("requesterDetails", CultureInfo.CurrentUICulture.Name) as String;
			}
		}


		public static string requestername
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("requestername", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string requesternameRequired
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("requesternameRequired", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string requesternamear
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("requesternamear", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string companyid
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("companyid", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string companyidRequired
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("companyidRequired", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string nationalityid
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("nationalityid", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string nationalityidRequired
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("nationalityidRequired", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string designations
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("designations", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string civilid
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string civilidRequired
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("civilidRequired", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string mobileno
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("mobileno", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string mobilenotypeid
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("mobilenotypeid", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string mobilenotypeidRequired
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("mobilenotypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string emailaddress
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("emailaddress", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string imagepath
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("imagepath", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string isactive
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string remarks
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string updateinfo
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string tranformactionid
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
			}
		}

		public static string requesternamearRequired
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("requesternamearRequired", CultureInfo.CurrentUICulture.Name) as String;
			}
		}

		public static string mobilenoRequired
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("mobilenoRequired", CultureInfo.CurrentUICulture.Name) as String;
			}
		}

		public static string emailaddressRequired
		{
			get
			{
				return resourceProvider_gen_requester.GetResource("emailaddressRequired", CultureInfo.CurrentUICulture.Name) as String;
			}
		}


	}
}
