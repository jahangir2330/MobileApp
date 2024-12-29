using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_vehiclefiletypeEntity
    {
        #region Properties

        protected long? _requesttypeidforquery;

        [DataMember]
        public long? requesttypeidforquery
        {
            get { return _requesttypeidforquery; }
            set { _requesttypeidforquery = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        //public gen_vehiclefiletypeEntity():base()
        //{
        //}

        //public gen_vehiclefiletypeEntity(IDataReader reader)
        //{
        //    this.LoadFromReader(reader);
        //}

        // public gen_vehiclefiletypeEntity(IDataReader reader, bool IsListViewShow)
        //{
        //    this.LoadFromReader(reader, IsListViewShow);
        //}

        //protected void LoadFromReader(IDataReader reader)
        //{
        //    if (reader != null && !reader.IsClosed)
        //    {
        //        this.BaseSecurityParam = new SecurityCapsule();
        //        if (!reader.IsDBNull(reader.GetOrdinal("RequestFileTypeID"))) _vehiclefiletypeid = reader.GetInt64(reader.GetOrdinal("RequestFileTypeID"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("RequestFileTypeName"))) _vehiclefiletypename = reader.GetString(reader.GetOrdinal("RequestFileTypeName"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("RequestFileTypeNameAR"))) _vehiclefiletypenamear = reader.GetString(reader.GetOrdinal("RequestFileTypeNameAR"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("ErrorMessageForRequired"))) _errormessageforrequired = reader.GetString(reader.GetOrdinal("ErrorMessageForRequired"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("ErrorMessageForRequiredAR"))) _errormessageforrequiredar = reader.GetString(reader.GetOrdinal("ErrorMessageForRequiredAR"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
        //        if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
        //        CurrentState = EntityState.Unchanged;
        //    }
        //}

        #endregion



    }
}
