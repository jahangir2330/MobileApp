using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "trangrvfrontlinesubmitdatafilesEntity", Namespace = "http://www.KAF.com/types")]
    public partial class trangrvfrontlinesubmitdatafilesEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _grvfrontlinefileid;
        protected long ? _grvfrontlineid;
        protected string _fileurl;
        protected string _filename;
        protected string _fileextension;
                
        
        [DataMember]
        public long ? grvfrontlinefileid
        {
            get { return _grvfrontlinefileid; }
            set { _grvfrontlinefileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "grvfrontlineid", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdatafiles))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdatafiles), ErrorMessageResourceName = "grvfrontlineidRequired")]
        public long ? grvfrontlineid
        {
            get { return _grvfrontlineid; }
            set { _grvfrontlineid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "fileurl", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdatafiles))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdatafiles), ErrorMessageResourceName = "fileurlRequired")]
        public string fileurl
        {
            get { return _fileurl; }
            set { _fileurl = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filename", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdatafiles))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdatafiles), ErrorMessageResourceName = "filenameRequired")]
        public string filename
        {
            get { return _filename; }
            set { _filename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "fileextension", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdatafiles))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdatafiles), ErrorMessageResourceName = "fileextensionRequired")]
        public string fileextension
        {
            get { return _fileextension; }
            set { _fileextension = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public trangrvfrontlinesubmitdatafilesEntity():base()
        {
        }
        
        public trangrvfrontlinesubmitdatafilesEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public trangrvfrontlinesubmitdatafilesEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("GrvFrontLineFileID"))) _grvfrontlinefileid = reader.GetInt64(reader.GetOrdinal("GrvFrontLineFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GrvFrontLineID"))) _grvfrontlineid = reader.GetInt64(reader.GetOrdinal("GrvFrontLineID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileURL"))) _fileurl = reader.GetString(reader.GetOrdinal("FileURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileExtension"))) _fileextension = reader.GetString(reader.GetOrdinal("FileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("GrvFrontLineFileID"))) _grvfrontlinefileid = reader.GetInt64(reader.GetOrdinal("GrvFrontLineFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GrvFrontLineID"))) _grvfrontlineid = reader.GetInt64(reader.GetOrdinal("GrvFrontLineID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileURL"))) _fileurl = reader.GetString(reader.GetOrdinal("FileURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileExtension"))) _fileextension = reader.GetString(reader.GetOrdinal("FileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
