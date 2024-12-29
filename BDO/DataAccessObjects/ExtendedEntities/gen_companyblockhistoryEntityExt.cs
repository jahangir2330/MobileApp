using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using BDO.Core.DataAccessObjects.CommonEntities;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_companyblockhistoryEntity
    {
        protected string _companyname;
        protected string _companynamear;

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "companyname", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companyname
        {
            get { return _companyname; }
            set { _companyname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "companynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companynamear
        {
            get { return _companynamear; }
            set { _companynamear = value; this.OnChnaged(); }
        }
        #region Region Image
        protected reg_studentfilestorageEntity _contractdocument;
        protected string _contractdocumentfilepath;

        [DataMember]
        [MaxLength(550)]
        public string contractdocumentfilepath
        {
            get { return _contractdocumentfilepath; }
            set { _contractdocumentfilepath = value; this.OnChnaged(); }
        }

        [DataMember]
        public reg_studentfilestorageEntity contractdocument { get => _contractdocument; set => _contractdocument = value; }



        #endregion Region Image


        public gen_companyblockhistoryEntity(IDataReader reader, bool IsListViewShow, bool relationalTableData)
        {
            this.LoadFromReader(reader, IsListViewShow, relationalTableData);
        }
        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool relationalTableData)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyBlockHistoryID"))) _companyblockhistoryid = reader.GetInt64(reader.GetOrdinal("CompanyBlockHistoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyBlockHistorySummary"))) _companyblockhistorysummary = reader.GetString(reader.GetOrdinal("CompanyBlockHistorySummary"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyBlockHistoryDescription"))) _companyblockhistorydescription = reader.GetString(reader.GetOrdinal("CompanyBlockHistoryDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockTypeId"))) _blocktypeid = reader.GetInt64(reader.GetOrdinal("BlockTypeId"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyNameAR"))) _companynamear = reader.GetString(reader.GetOrdinal("CompanyNameAR"));
                CurrentState = EntityState.Unchanged;
            }
        }


    }

    public class dtcompanyblockhistory : DtParameters
    {
        protected long? _companyid;

        [DataMember]
        public long? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }
    }

}
