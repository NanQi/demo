using System;
using System.Data;
using System.Collections.Generic;
using CustomerService.Model;
namespace CustomerService.BLL
{
	/// <summary>
	/// Service
	/// </summary>
	public partial class Service
	{
		private readonly CustomerService.DAL.Service dal=new CustomerService.DAL.Service();
		public Service()
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
		public bool Add(CustomerService.Model.Service model)
		{
		    return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CustomerService.Model.Service model)
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
		public CustomerService.Model.Service GetModel(Guid GUID)
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
		public List<CustomerService.Model.Service> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CustomerService.Model.Service> DataTableToList(DataTable dt)
		{
			List<CustomerService.Model.Service> modelList = new List<CustomerService.Model.Service>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CustomerService.Model.Service model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new CustomerService.Model.Service();
					if(dt.Rows[n]["GUID"]!=null && dt.Rows[n]["GUID"].ToString()!="")
					{
						model.GUID=new Guid(dt.Rows[n]["GUID"].ToString());
					}
					if(dt.Rows[n]["sNO"]!=null && dt.Rows[n]["sNO"].ToString()!="")
					{
					model.sNO=dt.Rows[n]["sNO"].ToString();
					}
					if(dt.Rows[n]["customer"]!=null && dt.Rows[n]["customer"].ToString()!="")
					{
						model.customer=new Guid(dt.Rows[n]["customer"].ToString());
					}
					if(dt.Rows[n]["acceptDate"]!=null && dt.Rows[n]["acceptDate"].ToString()!="")
					{
						model.acceptDate=DateTime.Parse(dt.Rows[n]["acceptDate"].ToString());
					}
					if(dt.Rows[n]["solutionDate"]!=null && dt.Rows[n]["solutionDate"].ToString()!="")
					{
						model.solutionDate=DateTime.Parse(dt.Rows[n]["solutionDate"].ToString());
					}
					if(dt.Rows[n]["type"]!=null && dt.Rows[n]["type"].ToString()!="")
					{
					model.type=dt.Rows[n]["type"].ToString();
					}
					if(dt.Rows[n]["content"]!=null && dt.Rows[n]["content"].ToString()!="")
					{
					model.content=dt.Rows[n]["content"].ToString();
					}
					if(dt.Rows[n]["result"]!=null && dt.Rows[n]["result"].ToString()!="")
					{
					model.result=dt.Rows[n]["result"].ToString();
					}
					if(dt.Rows[n]["evaluate"]!=null && dt.Rows[n]["evaluate"].ToString()!="")
					{
					model.evaluate=dt.Rows[n]["evaluate"].ToString();
					}
					if(dt.Rows[n]["material"]!=null && dt.Rows[n]["material"].ToString()!="")
					{
					model.material=dt.Rows[n]["material"].ToString();
					}
					if(dt.Rows[n]["materialMoney"]!=null && dt.Rows[n]["materialMoney"].ToString()!="")
					{
						model.materialMoney=decimal.Parse(dt.Rows[n]["materialMoney"].ToString());
					}
					if(dt.Rows[n]["serviceMoney"]!=null && dt.Rows[n]["serviceMoney"].ToString()!="")
					{
						model.serviceMoney=decimal.Parse(dt.Rows[n]["serviceMoney"].ToString());
					}
					if(dt.Rows[n]["payStatus"]!=null && dt.Rows[n]["payStatus"].ToString()!="")
					{
					model.payStatus=dt.Rows[n]["payStatus"].ToString();
					}
					if(dt.Rows[n]["traffic"]!=null && dt.Rows[n]["traffic"].ToString()!="")
					{
					model.traffic=dt.Rows[n]["traffic"].ToString();
					}
					if(dt.Rows[n]["employee"]!=null && dt.Rows[n]["employee"].ToString()!="")
					{
					model.employee=dt.Rows[n]["employee"].ToString();
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

