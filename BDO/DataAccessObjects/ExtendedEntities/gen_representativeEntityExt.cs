using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Collections.Generic;
using System.Linq;
using BDO.Core.DataAccessObjects.HRDomainModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_representativeEntity
    {

        #region Properties



        protected string _companyname;
        protected string _companynamear;
        protected string _nationalityname;
        protected string _nationalitynamear;


        [DataMember]
        [Display(Name = "companyname", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]

        public string companyname
        {
            get { return _companyname; }
            set { _companyname = value; }
        }


        [DataMember]
        [Display(Name = "companynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]

        public string companynamear
        {
            get { return _companynamear; }
            set { _companynamear = value; }
        }


        [DataMember]
        [Display(Name = "nationalityname", ResourceType = typeof(CLL.LLClasses.Models._gen_nationality))]

        public string nationalityname
        {
            get { return _nationalityname; }
            set { _nationalityname = value; }
        }

        [DataMember]
        [Display(Name = "nationalitynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_nationality))]

        public string nationalitynamear
        {
            get { return _nationalitynamear; }
            set { _nationalitynamear = value; }
        }
        #endregion


        #region Constructor
        public gen_representativeEntity(IDataReader reader, bool IsListViewShow, bool withRelationalData)
        {
            this.LoadFromReader(reader, IsListViewShow, withRelationalData);
        }

        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool withRelationalData)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeID"))) _representativeid = reader.GetInt64(reader.GetOrdinal("RepresentativeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeName"))) _representativename = reader.GetString(reader.GetOrdinal("RepresentativeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeNameAR"))) _representativenamear = reader.GetString(reader.GetOrdinal("RepresentativeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Designations"))) _designations = reader.GetString(reader.GetOrdinal("Designations"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilId"))) _civilid = reader.GetString(reader.GetOrdinal("CivilId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNo"))) _mobileno = reader.GetString(reader.GetOrdinal("MobileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeID"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeAddress"))) _representativeaddress = reader.GetString(reader.GetOrdinal("RepresentativeAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        #endregion
    }

}
