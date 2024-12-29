using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _tran_applicationreqforemp : _Common
    {
        private static IResourceProvider resourceProvider_tran_applicationreqforemp = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforemp.xml"));//DbResourceProvider(); //  


        public static string requestapplicationList
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("requestapplicationList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("requestapplicationCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("requestapplicationUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("requestapplicationDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string companyid
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("companyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("companyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesterid
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("requesterid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesteridRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("requesteridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string representativeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("representativeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string representativeidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("representativeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string licensetypeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("licensetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string licensetypeidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("licensetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesttypeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("requesttypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesttypeidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("requesttypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string numberofemployees
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("numberofemployees", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string numberofemployeesRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("numberofemployeesRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string numberofvehicle
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("numberofvehicle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emergencycontactnumber
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("emergencycontactnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenotypeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("mobilenotypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string submitdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("submitdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string approvedbymasteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("approvedbymasteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string approveddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("approveddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string expirydate
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("expirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusid
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("statusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isreadbyadmin
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("isreadbyadmin", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lastreadbyadminname
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("lastreadbyadminname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("startdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdateRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("startdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string enddateRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("enddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("enddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string contractdocument
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("contractdocument", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string requestapplicationidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("requestapplicationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string emergencycontactnumberRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("emergencycontactnumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string canenterafteroffice
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("canenterafteroffice", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string timingnote
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("timingnote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string gateidstring
        {
            get
            {
                return resourceProvider_tran_applicationreqforemp.GetResource("gateidstring", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}


