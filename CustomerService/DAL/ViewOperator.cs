using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CustomerService.DBUtility;//Please add references
namespace CustomerService.DAL
{
    /// <summary>
    /// 数据访问类:ViewOperator
    /// </summary>
    public partial class ViewOperator
    {
        public ViewOperator()
        {
        }

        #region  Method

//        /// <summary>
//        /// 得到最大ID
//        /// </summary>
//        public int GetMaxId()
//        {
//            return DbHelperSQL.GetMaxID("id", "Tbl_Link");
//        }

//        /// <summary>
//        /// 是否存在该记录
//        /// </summary>
//        public bool Exists(int id)
//        {
//            int rowsAffected;
//            SqlParameter[] parameters = {
//                    new SqlParameter("@id", SqlDbType.Int,4)
//};
//            parameters[0].Value = id;

//            int result = DbHelperSQL.RunProcedure("Tbl_Link_Exists", parameters, out rowsAffected);
//            if (result == 1)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        /// <summary>
//        ///  增加一条数据
//        /// </summary>
//        public int Add(ICWebSite.Model.Link model)
//        {
//            int rowsAffected;
//            SqlParameter[] parameters = {
//                    new SqlParameter("@id", SqlDbType.Int,4),
//                    new SqlParameter("@name", SqlDbType.NVarChar,20),
//                    new SqlParameter("@webSite", SqlDbType.NVarChar,50),
//                    new SqlParameter("@imgPath", SqlDbType.NVarChar,50),
//                    new SqlParameter("@linkName", SqlDbType.NVarChar,20),
//                    new SqlParameter("@tel", SqlDbType.NVarChar,20),
//                    new SqlParameter("@email", SqlDbType.NVarChar,50),
//                    new SqlParameter("@priority", SqlDbType.Int,4),
//                    new SqlParameter("@isImgLink", SqlDbType.Bit,1),
//                    new SqlParameter("@isHomeVisible", SqlDbType.Bit,1),
//                    new SqlParameter("@isVisible", SqlDbType.Bit,1)};
//            parameters[0].Direction = ParameterDirection.Output;
//            parameters[1].Value = model.name;
//            parameters[2].Value = model.webSite;
//            parameters[3].Value = model.imgPath;
//            parameters[4].Value = model.linkName;
//            parameters[5].Value = model.tel;
//            parameters[6].Value = model.email;
//            parameters[7].Value = model.priority;
//            parameters[8].Value = model.isImgLink;
//            parameters[9].Value = model.isHomeVisible;
//            parameters[10].Value = model.isVisible;

//            DbHelperSQL.RunProcedure("Tbl_Link_ADD", parameters, out rowsAffected);
//            return (int)parameters[0].Value;
//        }

//        /// <summary>
//        ///  更新一条数据
//        /// </summary>
//        public bool Update(ICWebSite.Model.Link model)
//        {
//            int rowsAffected = 0;
//            SqlParameter[] parameters = {
//                    new SqlParameter("@id", SqlDbType.Int,4),
//                    new SqlParameter("@name", SqlDbType.NVarChar,20),
//                    new SqlParameter("@webSite", SqlDbType.NVarChar,50),
//                    new SqlParameter("@imgPath", SqlDbType.NVarChar,50),
//                    new SqlParameter("@linkName", SqlDbType.NVarChar,20),
//                    new SqlParameter("@tel", SqlDbType.NVarChar,20),
//                    new SqlParameter("@email", SqlDbType.NVarChar,50),
//                    new SqlParameter("@priority", SqlDbType.Int,4),
//                    new SqlParameter("@isImgLink", SqlDbType.Bit,1),
//                    new SqlParameter("@isHomeVisible", SqlDbType.Bit,1),
//                    new SqlParameter("@isVisible", SqlDbType.Bit,1)};
//            parameters[0].Value = model.id;
//            parameters[1].Value = model.name;
//            parameters[2].Value = model.webSite;
//            parameters[3].Value = model.imgPath;
//            parameters[4].Value = model.linkName;
//            parameters[5].Value = model.tel;
//            parameters[6].Value = model.email;
//            parameters[7].Value = model.priority;
//            parameters[8].Value = model.isImgLink;
//            parameters[9].Value = model.isHomeVisible;
//            parameters[10].Value = model.isVisible;

//            DbHelperSQL.RunProcedure("Tbl_Link_Update", parameters, out rowsAffected);
//            if (rowsAffected > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        /// <summary>
//        /// 删除一条数据
//        /// </summary>
//        public bool Delete(int id)
//        {
//            int rowsAffected = 0;
//            SqlParameter[] parameters = {
//                    new SqlParameter("@id", SqlDbType.Int,4)
//};
//            parameters[0].Value = id;

//            DbHelperSQL.RunProcedure("Tbl_Link_Delete", parameters, out rowsAffected);
//            if (rowsAffected > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        /// <summary>
//        /// 删除一条数据
//        /// </summary>
//        public bool DeleteList(string idlist)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("delete from Tbl_Link ");
//            strSql.Append(" where id in (" + idlist + ")  ");
//            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
//            if (rows > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        /// <summary>
//        /// 得到一个对象实体
//        /// </summary>
//        public ICWebSite.Model.Link GetModel(int id)
//        {
//            SqlParameter[] parameters = {
//                    new SqlParameter("@id", SqlDbType.Int,4)
//};
//            parameters[0].Value = id;

//            ICWebSite.Model.Link model = new ICWebSite.Model.Link();
//            DataSet ds = DbHelperSQL.RunProcedure("Tbl_Link_GetModel", parameters, "ds");
//            if (ds.Tables[0].Rows.Count > 0)
//            {
//                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
//                {
//                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
//                }
//                model.name = ds.Tables[0].Rows[0]["name"].ToString();
//                model.webSite = ds.Tables[0].Rows[0]["webSite"].ToString();
//                model.imgPath = ds.Tables[0].Rows[0]["imgPath"].ToString();
//                model.linkName = ds.Tables[0].Rows[0]["linkName"].ToString();
//                model.tel = ds.Tables[0].Rows[0]["tel"].ToString();
//                model.email = ds.Tables[0].Rows[0]["email"].ToString();
//                if (ds.Tables[0].Rows[0]["priority"].ToString() != "")
//                {
//                    model.priority = int.Parse(ds.Tables[0].Rows[0]["priority"].ToString());
//                }
//                if (ds.Tables[0].Rows[0]["isImgLink"].ToString() != "")
//                {
//                    if ((ds.Tables[0].Rows[0]["isImgLink"].ToString() == "1") || (ds.Tables[0].Rows[0]["isImgLink"].ToString().ToLower() == "true"))
//                    {
//                        model.isImgLink = true;
//                    }
//                    else
//                    {
//                        model.isImgLink = false;
//                    }
//                }
//                if (ds.Tables[0].Rows[0]["isHomeVisible"].ToString() != "")
//                {
//                    if ((ds.Tables[0].Rows[0]["isHomeVisible"].ToString() == "1") || (ds.Tables[0].Rows[0]["isHomeVisible"].ToString().ToLower() == "true"))
//                    {
//                        model.isHomeVisible = true;
//                    }
//                    else
//                    {
//                        model.isHomeVisible = false;
//                    }
//                }
//                if (ds.Tables[0].Rows[0]["isVisible"].ToString() != "")
//                {
//                    if ((ds.Tables[0].Rows[0]["isVisible"].ToString() == "1") || (ds.Tables[0].Rows[0]["isVisible"].ToString().ToLower() == "true"))
//                    {
//                        model.isVisible = true;
//                    }
//                    else
//                    {
//                        model.isVisible = false;
//                    }
//                }
//                return model;
//            }
//            else
//            {
//                return null;
//            }
//        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string tblName, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM " + tblName);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(string tblName, int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top);
            }
            strSql.Append(" * ");
            strSql.Append(" FROM " + tblName);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(string tblName, string fldname, int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = tblName;
            parameters[1].Value = fldname;
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 1;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }

        #endregion  Method

        /// <summary>
        /// 获得数据个数
        /// </summary>
        public int GetListCount(string tblName, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select COUNT(1) ");
            strSql.Append(" FROM " + tblName);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return (int)DbHelperSQL.GetSingle(strSql.ToString());
        }
    }
}
