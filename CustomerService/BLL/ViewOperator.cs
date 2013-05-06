using System;
using System.Data;
using System.Collections.Generic;
using CustomerService.Model;
using System.Text;
namespace CustomerService.BLL
{
    /// <summary>
    /// Link
    /// </summary>
    public partial class ViewOperator
    {
        private readonly CustomerService.DAL.ViewOperator dal = new CustomerService.DAL.ViewOperator();
        public ViewOperator()
        {
        }
        #region  Method

        ///// <summary>
        ///// 得到最大ID
        ///// </summary>
        //public int GetMaxId()
        //{
        //    return dal.GetMaxId();
        //}

        ///// <summary>
        ///// 是否存在该记录
        ///// </summary>
        //public bool Exists(int id)
        //{
        //    return dal.Exists(id);
        //}

        ///// <summary>
        ///// 增加一条数据
        ///// </summary>
        //public int Add(ICWebSite.Model.Link model)
        //{
        //    return dal.Add(model);
        //}

        ///// <summary>
        ///// 更新一条数据
        ///// </summary>
        //public bool Update(ICWebSite.Model.Link model)
        //{
        //    return dal.Update(model);
        //}

        ///// <summary>
        ///// 删除一条数据
        ///// </summary>
        //public bool Delete(int id)
        //{

        //    return dal.Delete(id);
        //}
        ///// <summary>
        ///// 删除一条数据
        ///// </summary>
        //public bool DeleteList(string idlist)
        //{
        //    return dal.DeleteList(idlist);
        //}

        ///// <summary>
        ///// 得到一个对象实体
        ///// </summary>
        //public ICWebSite.Model.Link GetModel(int id)
        //{

        //    return dal.GetModel(id);
        //}

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public ICWebSite.Model.Link GetModelByCache(int id)
        //{

        //    string CacheKey = "LinkModel-" + id;
        //    object objModel = NanQi.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = NanQi.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                NanQi.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch
        //        {
        //        }
        //    }
        //    return (ICWebSite.Model.Link)objModel;
        //}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string tblName, string strWhere)
        {
            return dal.GetList(tblName, strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(string tblName, int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(tblName, Top, strWhere, filedOrder);
        }
        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public List<ICWebSite.Model.Link> GetModelList(string strWhere)
        //{
        //    DataSet ds = dal.GetList(strWhere);
        //    return DataTableToList(ds.Tables[0]);
        //}
        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public List<ICWebSite.Model.Link> DataTableToList(DataTable dt)
        //{
        //    List<ICWebSite.Model.Link> modelList = new List<ICWebSite.Model.Link>();
        //    int rowsCount = dt.Rows.Count;
        //    if (rowsCount > 0)
        //    {
        //        ICWebSite.Model.Link model;
        //        for (int n = 0; n < rowsCount; n++)
        //        {
        //            model = new ICWebSite.Model.Link();
        //            if (dt.Rows[n]["id"].ToString() != "")
        //            {
        //                model.id = int.Parse(dt.Rows[n]["id"].ToString());
        //            }
        //            model.name = dt.Rows[n]["name"].ToString();
        //            model.webSite = dt.Rows[n]["webSite"].ToString();
        //            model.imgPath = dt.Rows[n]["imgPath"].ToString();
        //            model.linkName = dt.Rows[n]["linkName"].ToString();
        //            model.tel = dt.Rows[n]["tel"].ToString();
        //            model.email = dt.Rows[n]["email"].ToString();
        //            if (dt.Rows[n]["priority"].ToString() != "")
        //            {
        //                model.priority = int.Parse(dt.Rows[n]["priority"].ToString());
        //            }
        //            if (dt.Rows[n]["isImgLink"].ToString() != "")
        //            {
        //                if ((dt.Rows[n]["isImgLink"].ToString() == "1") || (dt.Rows[n]["isImgLink"].ToString().ToLower() == "true"))
        //                {
        //                    model.isImgLink = true;
        //                }
        //                else
        //                {
        //                    model.isImgLink = false;
        //                }
        //            }
        //            if (dt.Rows[n]["isHomeVisible"].ToString() != "")
        //            {
        //                if ((dt.Rows[n]["isHomeVisible"].ToString() == "1") || (dt.Rows[n]["isHomeVisible"].ToString().ToLower() == "true"))
        //                {
        //                    model.isHomeVisible = true;
        //                }
        //                else
        //                {
        //                    model.isHomeVisible = false;
        //                }
        //            }
        //            if (dt.Rows[n]["isVisible"].ToString() != "")
        //            {
        //                if ((dt.Rows[n]["isVisible"].ToString() == "1") || (dt.Rows[n]["isVisible"].ToString().ToLower() == "true"))
        //                {
        //                    model.isVisible = true;
        //                }
        //                else
        //                {
        //                    model.isVisible = false;
        //                }
        //            }
        //            modelList.Add(model);
        //        }
        //    }
        //    return modelList;
        //}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList(string tblName)
        {
            return GetList(tblName, "");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(string tblName, string fldname, int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(tblName, fldname, PageSize, PageIndex, strWhere);
        }

        #endregion  Method

        /// <summary>
        /// 获得数据个数
        /// </summary>
        public int GetListCount(string tblName, string strWhere)
        {
            return dal.GetListCount(tblName, strWhere);
        }
    }
}
