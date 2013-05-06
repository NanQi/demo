using System;
using System.Data;
using System.Collections.Generic;
using CustomerService.Model;
using System.Windows.Forms;
namespace CustomerService.BLL
{
	/// <summary>
	/// CustomerGroup
	/// </summary>
	public partial class CustomerGroup
	{
		private readonly CustomerService.DAL.CustomerGroup dal=new CustomerService.DAL.CustomerGroup();
		public CustomerGroup()
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
		public bool Add(CustomerService.Model.CustomerGroup model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CustomerService.Model.CustomerGroup model)
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
		public CustomerService.Model.CustomerGroup GetModel(Guid GUID)
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
		public List<CustomerService.Model.CustomerGroup> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CustomerService.Model.CustomerGroup> DataTableToList(DataTable dt)
		{
			List<CustomerService.Model.CustomerGroup> modelList = new List<CustomerService.Model.CustomerGroup>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CustomerService.Model.CustomerGroup model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new CustomerService.Model.CustomerGroup();
					if(dt.Rows[n]["GUID"]!=null && dt.Rows[n]["GUID"].ToString()!="")
					{
						model.GUID=new Guid(dt.Rows[n]["GUID"].ToString());
					}
					if(dt.Rows[n]["cName"]!=null && dt.Rows[n]["cName"].ToString()!="")
					{
					model.cName=dt.Rows[n]["cName"].ToString();
					}
					if(dt.Rows[n]["parentGUID"]!=null && dt.Rows[n]["parentGUID"].ToString()!="")
					{
						model.parentGUID=new Guid(dt.Rows[n]["parentGUID"].ToString());
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
        /// 获取树状客户组
        /// </summary>
        /// <returns></returns>
        public TreeNode GetCustomerGroup()
        {
            DataSet dst = GetAllList();

            DataTable dt = dst.Tables[0];

            //建立关系
            DataRelation relation = new DataRelation("FK_CustomerGroup", dt.Columns["GUID"], dt.Columns["parentGUID"]);
            dst.Relations.Add(relation);

            TreeNode root = new TreeNode();

            foreach (DataRow row in dt.Rows)
            {
                //找到顶层
                if (row[0].ToString() == Guid.Empty.ToString())
                {
                    root.Name = row[0].ToString();
                    root.Text = row[1].ToString();
                    TreeNode[] tns = GetChildNode(dt, row, relation);
                    if (tns != null)
                    {
                        root.Nodes.AddRange(tns);
                    }
                    break;
                }
            }

            return root;
        }
        /// <summary>
        /// 获得子集
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="row"></param>
        /// <param name="relation"></param>
        /// <returns></returns>
        private TreeNode[] GetChildNode(DataTable dt, DataRow row, DataRelation relation)
        {
            DataRow[] drs = row.GetChildRows(relation);

            TreeNode[] tns;

            //如果是顶层
            if (row[0].ToString() == Guid.Empty.ToString())
            {
                //如果子集为空(注意子集至少为1)
                //则返回null
                if (drs.Length <= 1)
                {
                    return null;
                }

                //不为空则设子集长度
                tns = new TreeNode[drs.Length - 1];
            }
            else
            {
                tns = new TreeNode[drs.Length];
            }

            //i控制drs行数,j控制tns索引
            for (int i = 0, j = 0; i < drs.Length; i++, j++)
            {
                //如果是顶层再次迭代
                if (drs[i][0].ToString() == Guid.Empty.ToString())
                {
                    j--;
                    continue;
                }

                tns[j] = new TreeNode();
                tns[j].Name = drs[i][0].ToString();
                tns[j].Text = drs[i][1].ToString();
                TreeNode[] childTns = GetChildNode(dt, drs[i], relation);
                if (childTns != null)
                {
                    tns[j].Nodes.AddRange(childTns);
                }
            }

            return tns;
        }

        /// <summary>
        /// 获得所属客户组层次关系
        /// </summary>
        public void GetParentSelected(ref List<string> lst, Guid guid)
        {
            Model.CustomerGroup model = GetModel(guid);

            lst.Add(GetModel(model.parentGUID).cName);

            //如果所属为顶层
            if (model.parentGUID == Guid.Empty)
            {
                return;
            }

            GetParentSelected(ref lst, model.parentGUID);
        }

        /// <summary>
        /// 获得客户组层次关系
        /// </summary>
        public void GetSelected(ref List<string> lst, Guid guid)
        {
            Model.CustomerGroup model = GetModel(guid);

            lst.Add(model.cName);

            //如果所属为顶层
            if (model.GUID == Guid.Empty)
            {
                return;
            }

            GetSelected(ref lst, model.parentGUID);
        }

        /// <summary>
        /// 获得选中的节点
        /// </summary>
        /// <param name="treeNodeCollection"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        public TreeNode GetParentSelectedNode(TreeNodeCollection treeNodeCollection, Guid guid)
        {
            Model.CustomerGroup model = GetModel(guid);

            return (treeNodeCollection.Find(model.parentGUID.ToString(), true))[0];
        }
    }
}

