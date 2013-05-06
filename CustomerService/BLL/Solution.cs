using System;
using System.Data;
using System.Collections.Generic;
using CustomerService.Model;
namespace CustomerService.BLL
{
	/// <summary>
	/// Solution
	/// </summary>
	public partial class Solution
	{
		private readonly CustomerService.DAL.Solution dal=new CustomerService.DAL.Solution();
		public Solution()
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
		public bool Add(CustomerService.Model.Solution model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CustomerService.Model.Solution model)
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
		public CustomerService.Model.Solution GetModel(Guid GUID)
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
		public List<CustomerService.Model.Solution> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CustomerService.Model.Solution> DataTableToList(DataTable dt)
		{
			List<CustomerService.Model.Solution> modelList = new List<CustomerService.Model.Solution>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CustomerService.Model.Solution model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new CustomerService.Model.Solution();
					if(dt.Rows[n]["GUID"]!=null && dt.Rows[n]["GUID"].ToString()!="")
					{
						model.GUID=new Guid(dt.Rows[n]["GUID"].ToString());
					}
					if(dt.Rows[n]["sDescribe"]!=null && dt.Rows[n]["sDescribe"].ToString()!="")
					{
					model.sDescribe=dt.Rows[n]["sDescribe"].ToString();
					}
					if(dt.Rows[n]["solution"]!=null && dt.Rows[n]["solution"].ToString()!="")
					{
					model.solution=dt.Rows[n]["solution"].ToString();
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
	}
}

