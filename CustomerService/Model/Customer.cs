using System;
namespace CustomerService.Model
{
	/// <summary>
	/// Customer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Customer
	{
		public Customer()
		{}
		#region Model
		private Guid _guid;
		private string _cno;
		private Guid _parentguid;
		private string _cname;
		private string _cman;
		private string _tel;
		private bool? _isgov;
		private string _trade;
		private string _deptup;
		private string _ctype;
		private string _cstage;
		private string _cstatus;
		private string _clevel;
		private string _province;
		private string _city;
		private string _district;
		private string _fax;
		private string _addresss;
		private string _zip;
		private string _netset;
		private string _email;
		private string _qq;
		private string _mode;
		private string _scope;
		private string _product;
		private string _opponent;
		private string _credit;
		private string _link1;
		private string _dept1;
		private string _job1;
		private string _tel1;
		private string _phone1;
		private string _link2;
		private string _dept2;
		private string _job2;
		private string _tel2;
		private string _phone2;
		private byte[] _mapimg;
		private string _drive;
		private string _bus;
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
		public string cNO
		{
			set{ _cno=value;}
			get{return _cno;}
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
		public string cName
		{
			set{ _cname=value;}
			get{return _cname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cMan
		{
			set{ _cman=value;}
			get{return _cman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? isGov
		{
			set{ _isgov=value;}
			get{return _isgov;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trade
		{
			set{ _trade=value;}
			get{return _trade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string deptUp
		{
			set{ _deptup=value;}
			get{return _deptup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cType
		{
			set{ _ctype=value;}
			get{return _ctype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cStage
		{
			set{ _cstage=value;}
			get{return _cstage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cStatus
		{
			set{ _cstatus=value;}
			get{return _cstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cLevel
		{
			set{ _clevel=value;}
			get{return _clevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string city
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string district
		{
			set{ _district=value;}
			get{return _district;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fax
		{
			set{ _fax=value;}
			get{return _fax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string addresss
		{
			set{ _addresss=value;}
			get{return _addresss;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zip
		{
			set{ _zip=value;}
			get{return _zip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string netSet
		{
			set{ _netset=value;}
			get{return _netset;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mode
		{
			set{ _mode=value;}
			get{return _mode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scope
		{
			set{ _scope=value;}
			get{return _scope;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string product
		{
			set{ _product=value;}
			get{return _product;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opponent
		{
			set{ _opponent=value;}
			get{return _opponent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string credit
		{
			set{ _credit=value;}
			get{return _credit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string link1
		{
			set{ _link1=value;}
			get{return _link1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dept1
		{
			set{ _dept1=value;}
			get{return _dept1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string job1
		{
			set{ _job1=value;}
			get{return _job1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel1
		{
			set{ _tel1=value;}
			get{return _tel1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone1
		{
			set{ _phone1=value;}
			get{return _phone1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string link2
		{
			set{ _link2=value;}
			get{return _link2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dept2
		{
			set{ _dept2=value;}
			get{return _dept2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string job2
		{
			set{ _job2=value;}
			get{return _job2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel2
		{
			set{ _tel2=value;}
			get{return _tel2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone2
		{
			set{ _phone2=value;}
			get{return _phone2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] mapImg
		{
			set{ _mapimg=value;}
			get{return _mapimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string drive
		{
			set{ _drive=value;}
			get{return _drive;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bus
		{
			set{ _bus=value;}
			get{return _bus;}
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

