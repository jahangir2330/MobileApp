using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _tran_applicationreqforvehicle : _Common
    {
        private static IResourceProvider resourceProvider_tran_applicationreqforvehicle = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforvehicle.xml"));//DbResourceProvider(); //  


        public static string requestvehicleList
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("requestvehicleList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehicleCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("requestvehicleCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehicleUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("requestvehicleUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehicleDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("requestvehicleDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string requestvehicleDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("requestvehicleDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string companyid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("companyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("companyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesterid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("requesterid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesteridRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("requesteridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string representativeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("representativeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string representativeidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("representativeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string licensetypeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("licensetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string licensetypeidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("licensetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesttypeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("requesttypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesttypeidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("requesttypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string numberofvehicle
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("numberofvehicle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string numberofvehicleRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("numberofvehicleRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emergencycontactnumber
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("emergencycontactnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenotypeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("mobilenotypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string submitdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("submitdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string approvedbymasteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("approvedbymasteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string approveddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("approveddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string expirydate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("expirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("statusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isreadbyadmin
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("isreadbyadmin", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isreadbyadminRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("isreadbyadminRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lastreadbyadminname
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("lastreadbyadminname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("startdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string startdateRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("startdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("enddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enddateRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("enddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string contractdocument
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("contractdocument", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string canenterafteroffice
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("canenterafteroffice", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string timingnote
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicle.GetResource("timingnote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
    }
}
