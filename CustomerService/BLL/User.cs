using System;
using System.Data;
using System.Collections.Generic;
using CustomerService.Model;
namespace CustomerService.BLL
{
	/// <summary>
	/// User
	/// </summary>
	public partial class User
	{
		private readonly CustomerService.DAL.User dal=new CustomerService.DAL.User();
		public User()
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
		public bool Add(CustomerService.Model.User model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CustomerService.Model.User model)
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
		public CustomerService.Model.User GetModel(Guid GUID)
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
		public List<CustomerService.Model.User> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CustomerService.Model.User> DataTableToList(DataTable dt)
		{
			List<CustomerService.Model.User> modelList = new List<CustomerService.Model.User>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CustomerService.Model.User model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new CustomerService.Model.User();
					if(dt.Rows[n]["GUID"]!=null && dt.Rows[n]["GUID"].ToString()!="")
					{
						model.GUID=new Guid(dt.Rows[n]["GUID"].ToString());
					}
					if(dt.Rows[n]["uID"]!=null && dt.Rows[n]["uID"].ToString()!="")
					{
					model.uID=dt.Rows[n]["uID"].ToString();
					}
					if(dt.Rows[n]["pwd"]!=null && dt.Rows[n]["pwd"].ToString()!="")
					{
					model.pwd=dt.Rows[n]["pwd"].ToString();
					}
					if(dt.Rows[n]["power"]!=null && dt.Rows[n]["power"].ToString()!="")
					{
					model.power=dt.Rows[n]["power"].ToString();
					}
					if(dt.Rows[n]["uName"]!=null && dt.Rows[n]["uName"].ToString()!="")
					{
					model.uName=dt.Rows[n]["uName"].ToString();
					}
					if(dt.Rows[n]["isEnable"]!=null && dt.Rows[n]["isEnable"].ToString()!="")
					{
						if((dt.Rows[n]["isEnable"].ToString()=="1")||(dt.Rows[n]["isEnable"].ToString().ToLower()=="true"))
						{
						model.isEnable=true;
						}
						else
						{
							model.isEnable=false;
						}
					}
					if(dt.Rows[n]["isOnline"]!=null && dt.Rows[n]["isOnline"].ToString()!="")
					{
						if((dt.Rows[n]["isOnline"].ToString()=="1")||(dt.Rows[n]["isOnline"].ToString().ToLower()=="true"))
						{
						model.isOnline=true;
						}
						else
						{
							model.isOnline=false;
						}
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

