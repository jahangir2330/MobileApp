using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.DataAccessObjects.ExtendedEntities;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class oc_officersfileinfoEntity 
    {
        protected string _paramValue1;
        [DataMember]
        public string paramValue1
        {
            get { return _paramValue1; }
            set { _paramValue1 = value; this.OnChnaged(); }
        }

        protected long? _ocstatusid;
        [DataMember]
        public long? ocstatusid
        {
            get { return _ocstatusid; }
            set { _ocstatusid = value; this.OnChnaged(); }
        }

        protected OC_MilitaryInfoFromHrEntity _oc_militaryinfofromhrentity;
        [DataMember]
        public OC_MilitaryInfoFromHrEntity OC_MilitaryInfoFromHr
        {
            get { return _oc_militaryinfofromhrentity; }
            set { _oc_militaryinfofromhrentity = value; }
        }

        
        protected oc_registrationinfoEntity _oc_registrationinfo;
        [DataMember]
        public oc_registrationinfoEntity oc_registrationinfo
        {
            get { return _oc_registrationinfo; }
            set { _oc_registrationinfo = value; }
        }


        protected List<oc_familymembersinfoEntity> _oc_familymembersinfoList;
        [DataMember]
        public List<oc_familymembersinfoEntity> oc_familymembersinfoList
        {
            get { return _oc_familymembersinfoList; }
            set { _oc_familymembersinfoList = value; }
        }

        protected oc_paymentinfoEntity _oc_paymentinfo;
        [DataMember]
        public oc_paymentinfoEntity oc_paymentinfo
        {
            get { return _oc_paymentinfo; }
            set { _oc_paymentinfo = value; }
        }



        public void LoadFromReader_OCRegistrationProcess(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();

                if (!reader.IsDBNull(reader.GetOrdinal("OCFileID"))) _ocfileid = reader.GetInt64(reader.GetOrdinal("OCFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCCivilID"))) _occivilid = reader.GetInt64(reader.GetOrdinal("OCCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCMilitaryID"))) _ocmilitaryid = reader.GetInt64(reader.GetOrdinal("OCMilitaryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCEmailAddress"))) _ocemailaddress = reader.GetString(reader.GetOrdinal("OCEmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCPhoneNumber"))) _ocphonenumber = reader.GetString(reader.GetOrdinal("OCPhoneNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("OfficerPaciJsonData"))) _officerpacijsondata = reader.GetString(reader.GetOrdinal("OfficerPaciJsonData"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileCreationDate"))) _filecreationdate = reader.GetDateTime(reader.GetOrdinal("FileCreationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileIsActive"))) _fileisactive = reader.GetBoolean(reader.GetOrdinal("FileIsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrDataJsonData"))) _hrdatajsondata = reader.GetString(reader.GetOrdinal("HrDataJsonData"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSynced"))) _issynced = reader.GetBoolean(reader.GetOrdinal("IsSynced"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPaciSyncedDate"))) _lastpacisynceddate = reader.GetDateTime(reader.GetOrdinal("LastPaciSyncedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MemberIsRegistered"))) _memberisregistered = reader.GetBoolean(reader.GetOrdinal("MemberIsRegistered"));

                this.oc_registrationinfo = new oc_registrationinfoEntity();

                if (!reader.IsDBNull(reader.GetOrdinal("MemberRegistrationID"))) this.oc_registrationinfo.memberregistrationid = reader.GetInt64(reader.GetOrdinal("MemberRegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MemberShipCode"))) this.oc_registrationinfo.membershipcode = reader.GetString(reader.GetOrdinal("MemberShipCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCFamilyMemberID"))) this.oc_registrationinfo.ocfamilymemberid = reader.GetInt64(reader.GetOrdinal("OCFamilyMemberID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyMember"))) this.oc_registrationinfo.isfamilymember = reader.GetBoolean(reader.GetOrdinal("IsFamilyMember"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationDate"))) this.oc_registrationinfo.registrationdate = reader.GetDateTime(reader.GetOrdinal("RegistrationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) this.oc_registrationinfo.isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) this.oc_registrationinfo.isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) this.oc_registrationinfo.reviewdate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedNote"))) this.oc_registrationinfo.reviewednote = reader.GetString(reader.GetOrdinal("ReviewedNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) this.oc_registrationinfo.reviewedby = reader.GetString(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsBlocked"))) this.oc_registrationinfo.isblocked = reader.GetBoolean(reader.GetOrdinal("IsBlocked"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockedDate"))) this.oc_registrationinfo.blockeddate = reader.GetDateTime(reader.GetOrdinal("BlockedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockedNote"))) this.oc_registrationinfo.blockednote = reader.GetString(reader.GetOrdinal("BlockedNote"));

                this.oc_paymentinfo = new oc_paymentinfoEntity();
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionID"))) this.oc_paymentinfo.transactionid = reader.GetInt64(reader.GetOrdinal("TransactionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionCode"))) this.oc_paymentinfo.transactioncode = reader.GetString(reader.GetOrdinal("TransactionCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionDate"))) this.oc_paymentinfo.transactiondate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionSelectedMonth"))) this.oc_paymentinfo.transactionselectedmonth = reader.GetInt32(reader.GetOrdinal("TransactionSelectedMonth"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransactionSelectedYear"))) this.oc_paymentinfo.transactionselectedyear = reader.GetInt32(reader.GetOrdinal("TransactionSelectedYear"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaymentTransactionCode"))) this.oc_paymentinfo.paymenttransactioncode = reader.GetString(reader.GetOrdinal("PaymentTransactionCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaySuccess"))) this.oc_paymentinfo.paysuccess = reader.GetBoolean(reader.GetOrdinal("PaySuccess"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayDate"))) this.oc_paymentinfo.paydate = reader.GetDateTime(reader.GetOrdinal("PayDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Amount"))) this.oc_paymentinfo.amount = reader.GetDecimal(reader.GetOrdinal("Amount"));

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

        
    }

    public partial class DTOCRegistrationProcessDataEntity : DtParameters
    {
        [DataMember]
        public long? ocfileid { get; set; }
        [DataMember]
        public long? occivilid { get; set; }
        [DataMember]
        public long? ocmilitaryid { get; set; }
        [DataMember]
        public long? ocstatusid { get; set; }
        [DataMember]
        public bool? isreviewed { get; set; }
        [DataMember]
        public bool? isblocked { get; set; }
        [DataMember]
        public bool? isregistered { get; set; }
        [DataMember]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? registrationdatefrom { get; set; }
        [DataMember]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? registrationdateto { get; set; }
    }
}
