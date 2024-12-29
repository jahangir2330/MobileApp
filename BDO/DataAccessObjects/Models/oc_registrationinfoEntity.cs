using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "oc_registrationinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class oc_registrationinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _memberregistrationid;
        protected string _membershipcode;
        protected long ? _ocfileid;
        protected long ? _ocfamilymemberid;
        protected bool ? _isfamilymember;
        protected DateTime ? _registrationdate;
        protected bool ? _isactive;
        protected bool ? _isreviewed;
        protected DateTime ? _reviewdate;
        protected string _reviewednote;
        protected string _reviewedby;
        protected bool? _isblocked;
        protected DateTime ? _blockeddate;
        protected string _blockednote;
                
        
        [DataMember]
        public long ? memberregistrationid
        {
            get { return _memberregistrationid; }
            set { _memberregistrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "membershipcode", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo), ErrorMessageResourceName = "membershipcodeRequired")]
        public string membershipcode
        {
            get { return _membershipcode; }
            set { _membershipcode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ocfileid", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo), ErrorMessageResourceName = "ocfileidRequired")]
        public long ? ocfileid
        {
            get { return _ocfileid; }
            set { _ocfileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ocfamilymemberid", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        public long ? ocfamilymemberid
        {
            get { return _ocfamilymemberid; }
            set { _ocfamilymemberid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isfamilymember", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo), ErrorMessageResourceName = "isfamilymemberRequired")]
        public bool ? isfamilymember
        {
            get { return _isfamilymember; }
            set { _isfamilymember = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "registrationdate", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo), ErrorMessageResourceName = "registrationdateRequired")]
        public DateTime ? registrationdate
        {
            get { return _registrationdate; }
            set { _registrationdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isreviewed", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        public bool ? isreviewed
        {
            get { return _isreviewed; }
            set { _isreviewed = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "reviewdate", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        public DateTime ? reviewdate
        {
            get { return _reviewdate; }
            set { _reviewdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "reviewednote", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        public string reviewednote
        {
            get { return _reviewednote; }
            set { _reviewednote = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(256)]
        [Display(Name = "reviewedby", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        public string reviewedby
        {
            get { return _reviewedby; }
            set { _reviewedby = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isblocked", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        public bool? isblocked
        {
            get { return _isblocked; }
            set { _isblocked = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "blockeddate", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        public DateTime ? blockeddate
        {
            get { return _blockeddate; }
            set { _blockeddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "blockednote", ResourceType = typeof(CLL.LLClasses.Models._oc_registrationinfo))]
        public string blockednote
        {
            get { return _blockednote; }
            set { _blockednote = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public oc_registrationinfoEntity():base()
        {
        }
        
        public oc_registrationinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public oc_registrationinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("MemberRegistrationID"))) _memberregistrationid = reader.GetInt64(reader.GetOrdinal("MemberRegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MemberShipCode"))) _membershipcode = reader.GetString(reader.GetOrdinal("MemberShipCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCFileID"))) _ocfileid = reader.GetInt64(reader.GetOrdinal("OCFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCFamilyMemberID"))) _ocfamilymemberid = reader.GetInt64(reader.GetOrdinal("OCFamilyMemberID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyMember"))) _isfamilymember = reader.GetBoolean(reader.GetOrdinal("IsFamilyMember"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationDate"))) _registrationdate = reader.GetDateTime(reader.GetOrdinal("RegistrationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _reviewdate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedNote"))) _reviewednote = reader.GetString(reader.GetOrdinal("ReviewedNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetString(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsBlocked"))) _isblocked = reader.GetBoolean(reader.GetOrdinal("IsBlocked"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockedDate"))) _blockeddate = reader.GetDateTime(reader.GetOrdinal("BlockedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockedNote"))) _blockednote = reader.GetString(reader.GetOrdinal("BlockedNote"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("MemberRegistrationID"))) _memberregistrationid = reader.GetInt64(reader.GetOrdinal("MemberRegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MemberShipCode"))) _membershipcode = reader.GetString(reader.GetOrdinal("MemberShipCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCFileID"))) _ocfileid = reader.GetInt64(reader.GetOrdinal("OCFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCFamilyMemberID"))) _ocfamilymemberid = reader.GetInt64(reader.GetOrdinal("OCFamilyMemberID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyMember"))) _isfamilymember = reader.GetBoolean(reader.GetOrdinal("IsFamilyMember"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationDate"))) _registrationdate = reader.GetDateTime(reader.GetOrdinal("RegistrationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _reviewdate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedNote"))) _reviewednote = reader.GetString(reader.GetOrdinal("ReviewedNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetString(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsBlocked"))) _isblocked = reader.GetBoolean(reader.GetOrdinal("IsBlocked"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockedDate"))) _blockeddate = reader.GetDateTime(reader.GetOrdinal("BlockedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockedNote"))) _blockednote = reader.GetString(reader.GetOrdinal("BlockedNote"));
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
