using System;
namespace CustomerService.Model
{
	/// <summary>
	/// Operator:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Operator
	{
		public Operator()
		{}
		#region Model
		private Guid _guid;
		private Guid _user;
		private string _content;
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
		public Guid user
		{
			set{ _user=value;}
			get{return _user;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string content
		{
			set{ _content=value;}
			get{return _content;}
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

