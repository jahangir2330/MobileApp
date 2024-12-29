using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_studentfilestorageEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_studentfilestorageEntity : BaseEntity
    {
        #region Properties
        private string _base64file;
        private string fullFtpFilePath;

        protected long? _basicfileid;
        protected long? _requestfiletypeid;
        protected long? _fileconfigid;
        protected string _foldercontentid;
        protected string _datatablename;
        protected string _pkcolumnname;
        protected long? _pkcolumnid;
        protected string _userfilename;
        protected string _filepath;
        protected string _filename;
        protected string _filetype;
        protected string _extension;
        protected string _comment;


        [DataMember]
        public string base64file { get => _base64file; set => _base64file = value; }

        [DataMember]
        public string FullFtpFilePath { get => fullFtpFilePath; set => fullFtpFilePath = value; }


        [DataMember]
        public long? basicfileid
        {
            get { return _basicfileid; }
            set { _basicfileid = value; this.OnChnaged(); }
        }

       // [DataMember]
       // [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
       //// [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "basicinfoidRequired")]
       // public long? basicinfoid
       // {
       //     get { return _basicinfoid; }
       //     set { _basicinfoid = value; this.OnChnaged(); }
       // }


        [DataMember]
        [Display(Name = "requestfiletypeid", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "basicinfoidRequired")]
        public long? requestfiletypeid
        {
            get { return _requestfiletypeid; }
            set { _requestfiletypeid = value; this.OnChnaged(); }
        }

        //[DataMember]
        //[Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        ////[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "registrationidRequired")]
        //public long? registrationid
        //{
        //    get { return _registrationid; }
        //    set { _registrationid = value; this.OnChnaged(); }
        //}

        [DataMember]
        [Display(Name = "fileconfigid", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "fileconfigidRequired")]
        public long? fileconfigid
        {
            get { return _fileconfigid; }
            set { _fileconfigid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(252)]
        [Display(Name = "foldercontentid", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        public string foldercontentid
        {
            get { return _foldercontentid; }
            set { _foldercontentid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "datatablename", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "datatablenameRequired")]
        public string datatablename
        {
            get { return _datatablename; }
            set { _datatablename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "pkcolumnname", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "pkcolumnnameRequired")]
        public string pkcolumnname
        {
            get { return _pkcolumnname; }
            set { _pkcolumnname = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "pkcolumnid", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "pkcolumnidRequired")]
        public long? pkcolumnid
        {
            get { return _pkcolumnid; }
            set { _pkcolumnid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "userfilename", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "userfilenameRequired")]
        public string userfilename
        {
            get { return _userfilename; }
            set { _userfilename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filepath", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "filepathRequired")]
        public string filepath
        {
            get { return _filepath; }
            set { _filepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filename", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
       // [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "filenameRequired")]
        public string filename
        {
            get { return _filename; }
            set { _filename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filetype", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "filetypeRequired")]
        public string filetype
        {
            get { return _filetype; }
            set { _filetype = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "extension", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage), ErrorMessageResourceName = "extensionRequired")]
        public string extension
        {
            get { return _extension; }
            set { _extension = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(350)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._reg_studentfilestorage))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public reg_studentfilestorageEntity() : base()
        {
        }

        public reg_studentfilestorageEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public reg_studentfilestorageEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BasicFileID"))) _basicfileid = reader.GetInt64(reader.GetOrdinal("BasicFileID"));
              //  if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigID"))) _fileconfigid = reader.GetInt64(reader.GetOrdinal("FileConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FolderContentId"))) _foldercontentid = reader.GetString(reader.GetOrdinal("FolderContentId"));
                if (!reader.IsDBNull(reader.GetOrdinal("DataTableName"))) _datatablename = reader.GetString(reader.GetOrdinal("DataTableName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PKColumnName"))) _pkcolumnname = reader.GetString(reader.GetOrdinal("PKColumnName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PKColumnId"))) _pkcolumnid = reader.GetInt64(reader.GetOrdinal("PKColumnId"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserFileName"))) _userfilename = reader.GetString(reader.GetOrdinal("UserFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("BasicFileID"))) _basicfileid = reader.GetInt64(reader.GetOrdinal("BasicFileID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigID"))) _fileconfigid = reader.GetInt64(reader.GetOrdinal("FileConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FolderContentId"))) _foldercontentid = reader.GetString(reader.GetOrdinal("FolderContentId"));
                if (!reader.IsDBNull(reader.GetOrdinal("DataTableName"))) _datatablename = reader.GetString(reader.GetOrdinal("DataTableName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PKColumnName"))) _pkcolumnname = reader.GetString(reader.GetOrdinal("PKColumnName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PKColumnId"))) _pkcolumnid = reader.GetInt64(reader.GetOrdinal("PKColumnId"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserFileName"))) _userfilename = reader.GetString(reader.GetOrdinal("UserFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
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
