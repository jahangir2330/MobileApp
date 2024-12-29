using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _tran_applicationreqforempdetl : _Common
    {
        private static IResourceProvider resourceProvider_tran_applicationreqforempdetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforempdetl.xml"));//DbResourceProvider(); //  


        public static string requestemployeeList
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("requestemployeeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestemployeeCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("requestemployeeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestemployeeUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("requestemployeeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestemployeeDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("requestemployeeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string requestemployeeDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("requestemployeeDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string requestapplicationid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("requestapplicationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("requestapplicationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullname
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullnameRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("fullnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullnameen
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("fullnameen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullnameenRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("fullnameenRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("nationalityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("nationalityidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string jobtitle
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("jobtitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string jobtitleRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("jobtitleRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string idtype
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("idtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidnumber
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("civilidnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidnumberRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("civilidnumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidexpirydate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("civilidexpirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportnumber
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("passportnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hasvehicle
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("hasvehicle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string carnumberplate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("carnumberplate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecolorid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("vehiclecolorid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecoloridRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("vehiclecoloridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleregistrationimagepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("vehicleregistrationimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string carnumberplateRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("carnumberplateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personalpicurepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("personalpicurepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidimagepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("civilidimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidbacksideimagepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("civilidbacksideimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ispersonblocked
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("ispersonblocked", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personblockstartdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("personblockstartdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personblockenddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("personblockenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personblockedbyuserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("personblockedbyuserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personextentionenddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("personextentionenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personextendat
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("personextendat", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personextendbyuserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("personextendbyuserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforempdetl.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        //public static string Unicodecharactersarenotallowed
        //{
        //    get
        //    {
        //        return resourceProvider_tran_applicationreqforempdetl.GetResource("Unicodecharactersarenotallowed", CultureInfo.CurrentUICulture.Name) as String;
        //    }
        //}

    }
}


