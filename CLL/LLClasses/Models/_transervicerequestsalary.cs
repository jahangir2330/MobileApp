using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _transervicerequestsalary : _Common
    {
        private static IResourceProvider resourceProvider_transervicerequestsalary = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_transervicerequestsalary.xml"));//DbResourceProvider(); //  


        public static string transervicerequestsalaryList
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("transervicerequestsalaryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string transervicerequestsalaryCreate
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("transervicerequestsalaryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string transervicerequestsalaryUpdate
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("transervicerequestsalaryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string transervicerequestsalaryDetails
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("transervicerequestsalaryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string serviceid
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("serviceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serviceidRequired
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("serviceidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicemethod
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("servicemethod", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicemethodRequired
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("servicemethodRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicecontroller
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("servicecontroller", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicecontrollerRequired
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("servicecontrollerRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestercivilid
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("requestercivilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestercivilidRequired
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("requestercivilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestermilitaryid
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("requestermilitaryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestermilitaryidRequired
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("requestermilitaryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestdatetime
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("requestdatetime", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestdatetimeRequired
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("requestdatetimeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string securitytoken
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("securitytoken", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string securitytokenRequired
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("securitytokenRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string consumed
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("consumed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string consumedRequired
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("consumedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string consumeddatetime
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("consumeddatetime", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ademail
        {
            get
            {
                return resourceProvider_transervicerequestsalary.GetResource("ademail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
