using System;
namespace CustomerService.Model
{
	/// <summary>
	/// CustomerGroup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CustomerGroup
	{
		public CustomerGroup()
		{}
		#region Model
		private Guid _guid;
		private string _cname;
		private Guid _parentguid;
		private DateTime? _createdate;
		/// <summary>
		/// 
		/// </summary>
		public Guid GUID
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cName
		{
			set{ _cname=value;}
			get{return _cname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid parentGUID
		{
			set{ _parentguid=value;}
			get{return _parentguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? createDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		#endregion Model

	}
}

