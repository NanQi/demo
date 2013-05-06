using System;
namespace CustomerService.Model
{
	/// <summary>
	/// Service:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Service
	{
		public Service()
		{}
		#region Model
		private Guid _guid;
		private string _sno;
		private Guid _customer;
		private DateTime? _acceptdate;
		private DateTime? _solutiondate;
		private string _type;
		private string _content;
		private string _result;
		private string _evaluate;
		private string _material;
		private decimal? _materialmoney;
		private decimal? _servicemoney;
		private string _paystatus;
		private string _traffic;
		private string _employee;
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
		public string sNO
		{
			set{ _sno=value;}
			get{return _sno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid customer
		{
			set{ _customer=value;}
			get{return _customer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? acceptDate
		{
			set{ _acceptdate=value;}
			get{return _acceptdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? solutionDate
		{
			set{ _solutiondate=value;}
			get{return _solutiondate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type
		{
			set{ _type=value;}
			get{return _type;}
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
		public string result
		{
			set{ _result=value;}
			get{return _result;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string evaluate
		{
			set{ _evaluate=value;}
			get{return _evaluate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string material
		{
			set{ _material=value;}
			get{return _material;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? materialMoney
		{
			set{ _materialmoney=value;}
			get{return _materialmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? serviceMoney
		{
			set{ _servicemoney=value;}
			get{return _servicemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string payStatus
		{
			set{ _paystatus=value;}
			get{return _paystatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string traffic
		{
			set{ _traffic=value;}
			get{return _traffic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string employee
		{
			set{ _employee=value;}
			get{return _employee;}
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

