using System;
namespace CustomerService.Model
{
	/// <summary>
	/// Solution:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Solution
	{
		public Solution()
		{}
		#region Model
		private Guid _guid;
		private string _sdescribe;
		private string _solution;
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
		public string sDescribe
		{
			set{ _sdescribe=value;}
			get{return _sdescribe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string solution
		{
			set{ _solution=value;}
			get{return _solution;}
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

