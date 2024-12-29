using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
	[Serializable]
	[DataContract(Name = "gen_companyblockhistoryEntity", Namespace = "http://www.KAF.com/types")]
	public partial class gen_companyblockhistoryEntity : BaseEntity
	{
		#region Properties

		protected long? _companyblockhistoryid;
		protected long? _companyid;
		protected string _companyblockhistorysummary;
		protected string _companyblockhistorydescription;
		protected string _filepath;
		protected long? _blocktypeid;
		protected bool? _isactive;
		protected string _remarks;
		protected string _updateinfo;
		protected long? _tranformactionid;


		[DataMember]
		public long? companyblockhistoryid
		{
			get { return _companyblockhistoryid; }
			set { _companyblockhistoryid = value; this.OnChnaged(); }
		}

		[DataMember]
		[Display(Name = "companyid", ResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory))]
		[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory), ErrorMessageResourceName = "companyidRequired")]
		public long? companyid
		{
			get { return _companyid; }
			set { _companyid = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(250)]
		[Display(Name = "companyblockhistorysummary", ResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory))]
		[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory), ErrorMessageResourceName = "companyblockhistorysummaryRequired")]
		public string companyblockhistorysummary
		{
			get { return _companyblockhistorysummary; }
			set { _companyblockhistorysummary = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(500)]
		[Display(Name = "companyblockhistorydescription", ResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory))]
		[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory), ErrorMessageResourceName = "companyblockhistorydescriptionRequired")]
		public string companyblockhistorydescription
		{
			get { return _companyblockhistorydescription; }
			set { _companyblockhistorydescription = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(150)]
		[Display(Name = "filepath", ResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory))]
		public string filepath
		{
			get { return _filepath; }
			set { _filepath = value; this.OnChnaged(); }
		}

		[DataMember]
		[Display(Name = "blocktypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory))]
		public long? blocktypeid
		{
			get { return _blocktypeid; }
			set { _blocktypeid = value; this.OnChnaged(); }
		}

		[DataMember]
		[Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory))]
		public bool? isactive
		{
			get { return _isactive; }
			set { _isactive = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(550)]
		[Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory))]
		public string remarks
		{
			get { return _remarks; }
			set { _remarks = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(550)]
		[Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory))]
		public string updateinfo
		{
			get { return _updateinfo; }
			set { _updateinfo = value; this.OnChnaged(); }
		}

		[DataMember]
		[Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_companyblockhistory))]
		public long? tranformactionid
		{
			get { return _tranformactionid; }
			set { _tranformactionid = value; this.OnChnaged(); }
		}


		#endregion

		#region Constructor

		public gen_companyblockhistoryEntity() : base()
		{
		}

		public gen_companyblockhistoryEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		public gen_companyblockhistoryEntity(IDataReader reader, bool IsListViewShow)
		{
			this.LoadFromReader(reader, IsListViewShow);
		}



		protected void LoadFromReader(IDataReader reader)
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
				CurrentState = EntityState.Unchanged;
			}
		}


		protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
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
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion



	}
}
