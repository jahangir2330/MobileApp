using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "oc_paymentinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class oc_paymentinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _transactionid;
        protected string _transactioncode;
        protected long ? _memberregistrationid;
        protected long ? _ocfileid;
        protected DateTime ? _transactiondate;
        protected int ? _transactionselectedmonth;
        protected int ? _transactionselectedyear;
        protected string _paymenttransactioncode;
        protected bool ? _paysuccess;
        protected DateTime ? _paydate;
        protected decimal ? _amount;
        protected string _receiptjson;
                
        
        [DataMember]
        public long ? transactionid
        {
            get { return _transactionid; }
            set { _transactionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "transactioncode", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo), ErrorMessageResourceName = "transactioncodeRequired")]
        public string transactioncode
        {
            get { return _transactioncode; }
            set { _transactioncode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "memberregistrationid", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo), ErrorMessageResourceName = "memberregistrationidRequired")]
        public long ? memberregistrationid
        {
            get { return _memberregistrationid; }
            set { _memberregistrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ocfileid", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo), ErrorMessageResourceName = "ocfileidRequired")]
        public long ? ocfileid
        {
            get { return _ocfileid; }
            set { _ocfileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "transactiondate", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo), ErrorMessageResourceName = "transactiondateRequired")]
        public DateTime ? transactiondate
        {
            get { return _transactiondate; }
            set { _transactiondate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "transactionselectedmonth", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        public int ? transactionselectedmonth
        {
            get { return _transactionselectedmonth; }
            set { _transactionselectedmonth = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "transactionselectedyear", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        public int ? transactionselectedyear
        {
            get { return _transactionselectedyear; }
            set { _transactionselectedyear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "paymenttransactioncode", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo), ErrorMessageResourceName = "paymenttransactioncodeRequired")]
        public string paymenttransactioncode
        {
            get { return _paymenttransactioncode; }
            set { _paymenttransactioncode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "paysuccess", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        public bool ? paysuccess
        {
            get { return _paysuccess; }
            set { _paysuccess = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "paydate", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        public DateTime ? paydate
        {
            get { return _paydate; }
            set { _paydate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "amount", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        public decimal ? amount
        {
            get { return _amount; }
            set { _amount = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "receiptjson", ResourceType = typeof(CLL.LLClasses.Models._oc_paymentinfo))]
        public string receiptjson
        {
            get { return _receiptjson; }
            set { _receiptjson = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public oc_paymentinfoEntity():base()
        {
        }
        
        public oc_paymentinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public oc_paymentinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionID"))) _transactionid = reader.GetInt64(reader.GetOrdinal("TransactionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionCode"))) _transactioncode = reader.GetString(reader.GetOrdinal("TransactionCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("MemberRegistrationID"))) _memberregistrationid = reader.GetInt64(reader.GetOrdinal("MemberRegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCFileID"))) _ocfileid = reader.GetInt64(reader.GetOrdinal("OCFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionDate"))) _transactiondate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionSelectedMonth"))) _transactionselectedmonth = reader.GetInt32(reader.GetOrdinal("TransactionSelectedMonth"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionSelectedYear"))) _transactionselectedyear = reader.GetInt32(reader.GetOrdinal("TransactionSelectedYear"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaymentTransactionCode"))) _paymenttransactioncode = reader.GetString(reader.GetOrdinal("PaymentTransactionCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaySuccess"))) _paysuccess = reader.GetBoolean(reader.GetOrdinal("PaySuccess"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayDate"))) _paydate = reader.GetDateTime(reader.GetOrdinal("PayDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Amount"))) _amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReceiptJson"))) _receiptjson = reader.GetString(reader.GetOrdinal("ReceiptJson"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionID"))) _transactionid = reader.GetInt64(reader.GetOrdinal("TransactionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionCode"))) _transactioncode = reader.GetString(reader.GetOrdinal("TransactionCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("MemberRegistrationID"))) _memberregistrationid = reader.GetInt64(reader.GetOrdinal("MemberRegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCFileID"))) _ocfileid = reader.GetInt64(reader.GetOrdinal("OCFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionDate"))) _transactiondate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionSelectedMonth"))) _transactionselectedmonth = reader.GetInt32(reader.GetOrdinal("TransactionSelectedMonth"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionSelectedYear"))) _transactionselectedyear = reader.GetInt32(reader.GetOrdinal("TransactionSelectedYear"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaymentTransactionCode"))) _paymenttransactioncode = reader.GetString(reader.GetOrdinal("PaymentTransactionCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaySuccess"))) _paysuccess = reader.GetBoolean(reader.GetOrdinal("PaySuccess"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayDate"))) _paydate = reader.GetDateTime(reader.GetOrdinal("PayDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Amount"))) _amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReceiptJson"))) _receiptjson = reader.GetString(reader.GetOrdinal("ReceiptJson"));
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
