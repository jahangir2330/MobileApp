using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Data;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "dashboardmodel", Namespace = "http://www.number1solutions.com/types")]
    public class dashboardModel : BaseEntity
    {

        #region Region Property
        public string _rolename { get; set; }
        public long? _companyid { get; set; }
        public string _tablename { get; set; }
        public string _iconname { get; set; }
		public long? _categoryid { get; set; }
		public string _cssclass { get; set; }
        public long? _valuename { get; set; }
        public long? _newitem { get; set; }
        public string _linkurl { get; set; }

        [DataMember]
        public string rolename
        {
            get { return _rolename; }
            set { _rolename = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }
        [DataMember]
        public string tablename
        {
            get { return _tablename; }
            set { _tablename = value; this.OnChnaged(); }
        }


        //[DataMember]
        //public string banglaname
        //{
        //    get { return _banglaname; }
        //    set { _banglaname = value; this.OnChnaged(); }
        //}

        //[DataMember]
        //public string arabicname
        //{
        //    get { return _arabicname; }
        //    set { _arabicname = value; this.OnChnaged(); }
        //}

        [DataMember]
        public string iconname
        {
            get { return _iconname; }
            set { _iconname = value; this.OnChnaged(); }
        }

		[DataMember]
		public long? categoryid
		{
			get { return _categoryid; }
			set { _categoryid = value; this.OnChnaged(); }
		}
		[DataMember]
        public string cssclass
        {
            get { return _cssclass; }
            set { _cssclass = value; this.OnChnaged(); }
        }
        [DataMember]
        public string linkurl
        {
            get { return _linkurl; }
            set { _linkurl = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? valuename
        {
            get { return _valuename; }
            set { _valuename = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? newitem
        {
            get { return _newitem; }
            set { _newitem = value; this.OnChnaged(); }
        }
        #endregion


        #region Constructor

        public dashboardModel() : base()
        {
        }

        public dashboardModel(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("TableName"))) _tablename = reader.GetString(reader.GetOrdinal("TableName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("BanglaName"))) _banglaname = reader.GetString(reader.GetOrdinal("BanglaName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("ArabicName"))) _arabicname = reader.GetString(reader.GetOrdinal("ArabicName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IconName"))) _iconname = reader.GetString(reader.GetOrdinal("IconName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CssClass"))) _cssclass = reader.GetString(reader.GetOrdinal("CssClass"));
                if (!reader.IsDBNull(reader.GetOrdinal("ValueName"))) _valuename = reader.GetInt32(reader.GetOrdinal("ValueName"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewItem"))) _newitem = reader.GetInt32(reader.GetOrdinal("NewItem"));
                if (!reader.IsDBNull(reader.GetOrdinal("CategoryId"))) _categoryid = reader.GetInt32(reader.GetOrdinal("CategoryId"));
                if (!reader.IsDBNull(reader.GetOrdinal("LinkUrl"))) _linkurl = reader.GetString(reader.GetOrdinal("LinkUrl"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TransId"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransId"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        #endregion

    }
}
