using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CustomerService.DBUtility;//Please add references
namespace CustomerService.DAL
{
	/// <summary>
	/// 数据访问类:User
	/// </summary>
	public partial class User
	{
		public User()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid GUID)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = GUID;

			int result= DbHelperSQL.RunProcedure("T_User_Exists",parameters,out rowsAffected);
			if(result==1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		///  增加一条数据
		/// </summary>
		public bool Add(CustomerService.Model.User model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@uID", SqlDbType.VarChar,50),
					new SqlParameter("@pwd", SqlDbType.VarChar,50),
					new SqlParameter("@power", SqlDbType.VarChar,500),
					new SqlParameter("@uName", SqlDbType.VarChar,20),
					new SqlParameter("@isEnable", SqlDbType.Bit,1),
					new SqlParameter("@isOnline", SqlDbType.Bit,1),
					new SqlParameter("@createDate", SqlDbType.DateTime)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.uID;
			parameters[2].Value = model.pwd;
			parameters[3].Value = model.power;
			parameters[4].Value = model.uName;
			parameters[5].Value = model.isEnable;
			parameters[6].Value = model.isOnline;
            parameters[7].Value = DateTime.Now;

            DbHelperSQL.RunProcedure("T_User_ADD", parameters, out rowsAffected);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(CustomerService.Model.User model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@uID", SqlDbType.VarChar,50),
					new SqlParameter("@pwd", SqlDbType.VarChar,50),
					new SqlParameter("@power", SqlDbType.VarChar,500),
					new SqlParameter("@uName", SqlDbType.VarChar,20),
					new SqlParameter("@isEnable", SqlDbType.Bit,1),
					new SqlParameter("@isOnline", SqlDbType.Bit,1),
					new SqlParameter("@createDate", SqlDbType.DateTime)};
			parameters[0].Value = model.GUID;
			parameters[1].Value = model.uID;
			parameters[2].Value = model.pwd;
			parameters[3].Value = model.power;
			parameters[4].Value = model.uName;
			parameters[5].Value = model.isEnable;
			parameters[6].Value = model.isOnline;
			parameters[7].Value = model.createDate;

			DbHelperSQL.RunProcedure("T_User_Update",parameters,out rowsAffected);
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid GUID)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = GUID;

			DbHelperSQL.RunProcedure("T_User_Delete",parameters,out rowsAffected);
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string GUIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_User ");
			strSql.Append(" where GUID in ("+GUIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CustomerService.Model.User GetModel(Guid GUID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = GUID;

			CustomerService.Model.User model=new CustomerService.Model.User();
			DataSet ds= DbHelperSQL.RunProcedure("T_User_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["GUID"]!=null && ds.Tables[0].Rows[0]["GUID"].ToString()!="")
				{
					model.GUID=new Guid(ds.Tables[0].Rows[0]["GUID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["uID"]!=null && ds.Tables[0].Rows[0]["uID"].ToString()!="")
				{
					model.uID=ds.Tables[0].Rows[0]["uID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pwd"]!=null && ds.Tables[0].Rows[0]["pwd"].ToString()!="")
				{
					model.pwd=ds.Tables[0].Rows[0]["pwd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["power"]!=null && ds.Tables[0].Rows[0]["power"].ToString()!="")
				{
					model.power=ds.Tables[0].Rows[0]["power"].ToString();
				}
				if(ds.Tables[0].Rows[0]["uName"]!=null && ds.Tables[0].Rows[0]["uName"].ToString()!="")
				{
					model.uName=ds.Tables[0].Rows[0]["uName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["isEnable"]!=null && ds.Tables[0].Rows[0]["isEnable"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["isEnable"].ToString()=="1")||(ds.Tables[0].Rows[0]["isEnable"].ToString().ToLower()=="true"))
					{
						model.isEnable=true;
					}
					else
					{
						model.isEnable=false;
					}
				}
				if(ds.Tables[0].Rows[0]["isOnline"]!=null && ds.Tables[0].Rows[0]["isOnline"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["isOnline"].ToString()=="1")||(ds.Tables[0].Rows[0]["isOnline"].ToString().ToLower()=="true"))
					{
						model.isOnline=true;
					}
					else
					{
						model.isOnline=false;
					}
				}
				if(ds.Tables[0].Rows[0]["createDate"]!=null && ds.Tables[0].Rows[0]["createDate"].ToString()!="")
				{
					model.createDate=DateTime.Parse(ds.Tables[0].Rows[0]["createDate"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select GUID,uID,pwd,power,uName,isEnable,isOnline,createDate ");
			strSql.Append(" FROM T_User ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" GUID,uID,pwd,power,uName,isEnable,isOnline,createDate ");
			strSql.Append(" FROM T_User ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
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
			parameters[0].Value = "T_User";
			parameters[1].Value = "GUID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

