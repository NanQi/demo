using System;
using System.Data;
using System.Collections.Generic;
using CustomerService.Model;
namespace CustomerService.BLL
{
	/// <summary>
	/// Customer
	/// </summary>
	public partial class Customer
	{
		private readonly CustomerService.DAL.Customer dal=new CustomerService.DAL.Customer();
		public Customer()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid GUID)
		{
			return dal.Exists(GUID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CustomerService.Model.Customer model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CustomerService.Model.Customer model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid GUID)
		{
			
			return dal.Delete(GUID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string GUIDlist )
		{
			return dal.DeleteList(GUIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CustomerService.Model.Customer GetModel(Guid GUID)
		{
			
			return dal.GetModel(GUID);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CustomerService.Model.Customer> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CustomerService.Model.Customer> DataTableToList(DataTable dt)
		{
			List<CustomerService.Model.Customer> modelList = new List<CustomerService.Model.Customer>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CustomerService.Model.Customer model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new CustomerService.Model.Customer();
					if(dt.Rows[n]["GUID"]!=null && dt.Rows[n]["GUID"].ToString()!="")
					{
						model.GUID=new Guid(dt.Rows[n]["GUID"].ToString());
					}
					if(dt.Rows[n]["cNO"]!=null && dt.Rows[n]["cNO"].ToString()!="")
					{
					model.cNO=dt.Rows[n]["cNO"].ToString();
					}
					if(dt.Rows[n]["parentGUID"]!=null && dt.Rows[n]["parentGUID"].ToString()!="")
					{
						model.parentGUID=new Guid(dt.Rows[n]["parentGUID"].ToString());
					}
					if(dt.Rows[n]["cName"]!=null && dt.Rows[n]["cName"].ToString()!="")
					{
					model.cName=dt.Rows[n]["cName"].ToString();
					}
					if(dt.Rows[n]["cMan"]!=null && dt.Rows[n]["cMan"].ToString()!="")
					{
					model.cMan=dt.Rows[n]["cMan"].ToString();
					}
					if(dt.Rows[n]["Tel"]!=null && dt.Rows[n]["Tel"].ToString()!="")
					{
					model.Tel=dt.Rows[n]["Tel"].ToString();
					}
					if(dt.Rows[n]["isGov"]!=null && dt.Rows[n]["isGov"].ToString()!="")
					{
						if((dt.Rows[n]["isGov"].ToString()=="1")||(dt.Rows[n]["isGov"].ToString().ToLower()=="true"))
						{
						model.isGov=true;
						}
						else
						{
							model.isGov=false;
						}
					}
					if(dt.Rows[n]["trade"]!=null && dt.Rows[n]["trade"].ToString()!="")
					{
					model.trade=dt.Rows[n]["trade"].ToString();
					}
					if(dt.Rows[n]["deptUp"]!=null && dt.Rows[n]["deptUp"].ToString()!="")
					{
					model.deptUp=dt.Rows[n]["deptUp"].ToString();
					}
					if(dt.Rows[n]["cType"]!=null && dt.Rows[n]["cType"].ToString()!="")
					{
					model.cType=dt.Rows[n]["cType"].ToString();
					}
					if(dt.Rows[n]["cStage"]!=null && dt.Rows[n]["cStage"].ToString()!="")
					{
					model.cStage=dt.Rows[n]["cStage"].ToString();
					}
					if(dt.Rows[n]["cStatus"]!=null && dt.Rows[n]["cStatus"].ToString()!="")
					{
					model.cStatus=dt.Rows[n]["cStatus"].ToString();
					}
					if(dt.Rows[n]["cLevel"]!=null && dt.Rows[n]["cLevel"].ToString()!="")
					{
					model.cLevel=dt.Rows[n]["cLevel"].ToString();
					}
					if(dt.Rows[n]["province"]!=null && dt.Rows[n]["province"].ToString()!="")
					{
					model.province=dt.Rows[n]["province"].ToString();
					}
					if(dt.Rows[n]["city"]!=null && dt.Rows[n]["city"].ToString()!="")
					{
					model.city=dt.Rows[n]["city"].ToString();
					}
					if(dt.Rows[n]["district"]!=null && dt.Rows[n]["district"].ToString()!="")
					{
					model.district=dt.Rows[n]["district"].ToString();
					}
					if(dt.Rows[n]["fax"]!=null && dt.Rows[n]["fax"].ToString()!="")
					{
					model.fax=dt.Rows[n]["fax"].ToString();
					}
					if(dt.Rows[n]["addresss"]!=null && dt.Rows[n]["addresss"].ToString()!="")
					{
					model.addresss=dt.Rows[n]["addresss"].ToString();
					}
					if(dt.Rows[n]["zip"]!=null && dt.Rows[n]["zip"].ToString()!="")
					{
					model.zip=dt.Rows[n]["zip"].ToString();
					}
					if(dt.Rows[n]["netSet"]!=null && dt.Rows[n]["netSet"].ToString()!="")
					{
					model.netSet=dt.Rows[n]["netSet"].ToString();
					}
					if(dt.Rows[n]["email"]!=null && dt.Rows[n]["email"].ToString()!="")
					{
					model.email=dt.Rows[n]["email"].ToString();
					}
					if(dt.Rows[n]["QQ"]!=null && dt.Rows[n]["QQ"].ToString()!="")
					{
					model.QQ=dt.Rows[n]["QQ"].ToString();
					}
					if(dt.Rows[n]["mode"]!=null && dt.Rows[n]["mode"].ToString()!="")
					{
					model.mode=dt.Rows[n]["mode"].ToString();
					}
					if(dt.Rows[n]["scope"]!=null && dt.Rows[n]["scope"].ToString()!="")
					{
					model.scope=dt.Rows[n]["scope"].ToString();
					}
					if(dt.Rows[n]["product"]!=null && dt.Rows[n]["product"].ToString()!="")
					{
					model.product=dt.Rows[n]["product"].ToString();
					}
					if(dt.Rows[n]["opponent"]!=null && dt.Rows[n]["opponent"].ToString()!="")
					{
					model.opponent=dt.Rows[n]["opponent"].ToString();
					}
					if(dt.Rows[n]["credit"]!=null && dt.Rows[n]["credit"].ToString()!="")
					{
					model.credit=dt.Rows[n]["credit"].ToString();
					}
					if(dt.Rows[n]["link1"]!=null && dt.Rows[n]["link1"].ToString()!="")
					{
					model.link1=dt.Rows[n]["link1"].ToString();
					}
					if(dt.Rows[n]["dept1"]!=null && dt.Rows[n]["dept1"].ToString()!="")
					{
					model.dept1=dt.Rows[n]["dept1"].ToString();
					}
					if(dt.Rows[n]["job1"]!=null && dt.Rows[n]["job1"].ToString()!="")
					{
					model.job1=dt.Rows[n]["job1"].ToString();
					}
					if(dt.Rows[n]["tel1"]!=null && dt.Rows[n]["tel1"].ToString()!="")
					{
					model.tel1=dt.Rows[n]["tel1"].ToString();
					}
					if(dt.Rows[n]["phone1"]!=null && dt.Rows[n]["phone1"].ToString()!="")
					{
					model.phone1=dt.Rows[n]["phone1"].ToString();
					}
					if(dt.Rows[n]["link2"]!=null && dt.Rows[n]["link2"].ToString()!="")
					{
					model.link2=dt.Rows[n]["link2"].ToString();
					}
					if(dt.Rows[n]["dept2"]!=null && dt.Rows[n]["dept2"].ToString()!="")
					{
					model.dept2=dt.Rows[n]["dept2"].ToString();
					}
					if(dt.Rows[n]["job2"]!=null && dt.Rows[n]["job2"].ToString()!="")
					{
					model.job2=dt.Rows[n]["job2"].ToString();
					}
					if(dt.Rows[n]["tel2"]!=null && dt.Rows[n]["tel2"].ToString()!="")
					{
					model.tel2=dt.Rows[n]["tel2"].ToString();
					}
					if(dt.Rows[n]["phone2"]!=null && dt.Rows[n]["phone2"].ToString()!="")
					{
					model.phone2=dt.Rows[n]["phone2"].ToString();
					}
					if(dt.Rows[n]["mapImg"]!=null && dt.Rows[n]["mapImg"].ToString()!="")
					{
						model.mapImg=(byte[])dt.Rows[n]["mapImg"];
					}
					if(dt.Rows[n]["drive"]!=null && dt.Rows[n]["drive"].ToString()!="")
					{
					model.drive=dt.Rows[n]["drive"].ToString();
					}
					if(dt.Rows[n]["bus"]!=null && dt.Rows[n]["bus"].ToString()!="")
					{
					model.bus=dt.Rows[n]["bus"].ToString();
					}
					if(dt.Rows[n]["createDate"]!=null && dt.Rows[n]["createDate"].ToString()!="")
					{
						model.createDate=DateTime.Parse(dt.Rows[n]["createDate"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method

        /// <summary>
        /// 获取最大ID
        /// </summary>
        /// <returns></returns>
        public string GetMaxID()
        {
            int i = dal.GetMaxID();
            return i.ToString("0000");
        }
	}
}

