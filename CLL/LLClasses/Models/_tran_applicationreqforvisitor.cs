using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _tran_applicationreqforvisitor : _Common
    {
        private static IResourceProvider resourceProvider_tran_applicationreqforvisitor = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforvisitor.xml"));


        public static string applicationreqforvisitorList
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("applicationreqforvisitorList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqforvisitorCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("applicationreqforvisitorCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqforvisitorUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("applicationreqforvisitorUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqforvisitorDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("applicationreqforvisitorDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string applicationreqforvisitorDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("applicationreqforvisitorDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string fullname
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string uniqueno
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("uniqueno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullnameRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("fullnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullnameen
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("fullnameen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullnameenRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("fullnameenRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("nationalityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("nationalityidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string licensetypeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("licensetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string licensetypeidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("licensetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emergencycontactnumber
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("emergencycontactnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emergencycontactnumberRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("emergencycontactnumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string mobilenotypeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("mobilenotypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("startdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdateRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("startdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("enddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string numberofdays
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("numberofdays", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("statusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string canenterafteroffice
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("canenterafteroffice", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string timingnote
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("timingnote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string jobtitle
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("jobtitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string jobtitleRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("jobtitleRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string idtype
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("idtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidnumber
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("civilidnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidnumberRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("civilidnumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidexpirydate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("civilidexpirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportnumber
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("passportnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visanumber
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("visanumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visanumberRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("visanumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaexpirydate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("visaexpirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaimagepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("visaimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reason
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("reason", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hasvehicle
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("hasvehicle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string carnumberplate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("carnumberplate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecolorid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("vehiclecolorid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleregistrationimagepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("vehicleregistrationimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personalpicurepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("personalpicurepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidimagepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("civilidimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidbacksideimagepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("civilidbacksideimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ispersonblocked
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("ispersonblocked", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personblockstartdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("personblockstartdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personblockenddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("personblockenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personblockedbyuserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("personblockedbyuserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personextentionenddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("personextentionenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personextendat
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("personextendat", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personextendbyuserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("personextendbyuserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isreadbyadmin
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("isreadbyadmin", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isreadbyadminRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("isreadbyadminRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lastreadbyadminname
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("lastreadbyadminname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string submitdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("submitdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string approvedbymasteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("approvedbymasteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string approveddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("approveddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitor.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
