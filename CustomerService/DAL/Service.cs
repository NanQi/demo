using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CustomerService.DBUtility;//Please add references
namespace CustomerService.DAL
{
	/// <summary>
	/// 数据访问类:Service
	/// </summary>
	public partial class Service
	{
		public Service()
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

			int result= DbHelperSQL.RunProcedure("T_Service_Exists",parameters,out rowsAffected);
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
		public bool Add(CustomerService.Model.Service model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@sNO", SqlDbType.VarChar,50),
					new SqlParameter("@customer", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@acceptDate", SqlDbType.DateTime),
					new SqlParameter("@solutionDate", SqlDbType.DateTime),
					new SqlParameter("@type", SqlDbType.VarChar,20),
					new SqlParameter("@content", SqlDbType.VarChar,500),
					new SqlParameter("@result", SqlDbType.VarChar,100),
					new SqlParameter("@evaluate", SqlDbType.VarChar,50),
					new SqlParameter("@material", SqlDbType.VarChar,50),
					new SqlParameter("@materialMoney", SqlDbType.Money,8),
					new SqlParameter("@serviceMoney", SqlDbType.Money,8),
					new SqlParameter("@payStatus", SqlDbType.VarChar,50),
					new SqlParameter("@traffic", SqlDbType.VarChar,50),
					new SqlParameter("@employee", SqlDbType.VarChar,20),
					new SqlParameter("@createDate", SqlDbType.DateTime)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.sNO;
            parameters[2].Value = model.customer;
			parameters[3].Value = model.acceptDate;
			parameters[4].Value = model.solutionDate;
			parameters[5].Value = model.type;
			parameters[6].Value = model.content;
			parameters[7].Value = model.result;
			parameters[8].Value = model.evaluate;
			parameters[9].Value = model.material;
			parameters[10].Value = model.materialMoney;
			parameters[11].Value = model.serviceMoney;
			parameters[12].Value = model.payStatus;
			parameters[13].Value = model.traffic;
			parameters[14].Value = model.employee;
            parameters[15].Value = DateTime.Now;

            DbHelperSQL.RunProcedure("T_Service_ADD", parameters, out rowsAffected);
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
		public bool Update(CustomerService.Model.Service model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@sNO", SqlDbType.VarChar,50),
					new SqlParameter("@customer", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@acceptDate", SqlDbType.DateTime),
					new SqlParameter("@solutionDate", SqlDbType.DateTime),
					new SqlParameter("@type", SqlDbType.VarChar,20),
					new SqlParameter("@content", SqlDbType.VarChar,500),
					new SqlParameter("@result", SqlDbType.VarChar,100),
					new SqlParameter("@evaluate", SqlDbType.VarChar,50),
					new SqlParameter("@material", SqlDbType.VarChar,50),
					new SqlParameter("@materialMoney", SqlDbType.Money,8),
					new SqlParameter("@serviceMoney", SqlDbType.Money,8),
					new SqlParameter("@payStatus", SqlDbType.VarChar,50),
					new SqlParameter("@traffic", SqlDbType.VarChar,50),
					new SqlParameter("@employee", SqlDbType.VarChar,20),
					new SqlParameter("@createDate", SqlDbType.DateTime)};
			parameters[0].Value = model.GUID;
			parameters[1].Value = model.sNO;
			parameters[2].Value = model.customer;
			parameters[3].Value = model.acceptDate;
			parameters[4].Value = model.solutionDate;
			parameters[5].Value = model.type;
			parameters[6].Value = model.content;
			parameters[7].Value = model.result;
			parameters[8].Value = model.evaluate;
			parameters[9].Value = model.material;
			parameters[10].Value = model.materialMoney;
			parameters[11].Value = model.serviceMoney;
			parameters[12].Value = model.payStatus;
			parameters[13].Value = model.traffic;
			parameters[14].Value = model.employee;
			parameters[15].Value = model.createDate;

			DbHelperSQL.RunProcedure("T_Service_Update",parameters,out rowsAffected);
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

			DbHelperSQL.RunProcedure("T_Service_Delete",parameters,out rowsAffected);
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
			strSql.Append("delete from T_Service ");
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
		public CustomerService.Model.Service GetModel(Guid GUID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = GUID;

			CustomerService.Model.Service model=new CustomerService.Model.Service();
			DataSet ds= DbHelperSQL.RunProcedure("T_Service_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["GUID"]!=null && ds.Tables[0].Rows[0]["GUID"].ToString()!="")
				{
					model.GUID=new Guid(ds.Tables[0].Rows[0]["GUID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sNO"]!=null && ds.Tables[0].Rows[0]["sNO"].ToString()!="")
				{
					model.sNO=ds.Tables[0].Rows[0]["sNO"].ToString();
				}
				if(ds.Tables[0].Rows[0]["customer"]!=null && ds.Tables[0].Rows[0]["customer"].ToString()!="")
				{
					model.customer=new Guid(ds.Tables[0].Rows[0]["customer"].ToString());
				}
				if(ds.Tables[0].Rows[0]["acceptDate"]!=null && ds.Tables[0].Rows[0]["acceptDate"].ToString()!="")
				{
					model.acceptDate=DateTime.Parse(ds.Tables[0].Rows[0]["acceptDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["solutionDate"]!=null && ds.Tables[0].Rows[0]["solutionDate"].ToString()!="")
				{
					model.solutionDate=DateTime.Parse(ds.Tables[0].Rows[0]["solutionDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["type"]!=null && ds.Tables[0].Rows[0]["type"].ToString()!="")
				{
					model.type=ds.Tables[0].Rows[0]["type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["content"]!=null && ds.Tables[0].Rows[0]["content"].ToString()!="")
				{
					model.content=ds.Tables[0].Rows[0]["content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["result"]!=null && ds.Tables[0].Rows[0]["result"].ToString()!="")
				{
					model.result=ds.Tables[0].Rows[0]["result"].ToString();
				}
				if(ds.Tables[0].Rows[0]["evaluate"]!=null && ds.Tables[0].Rows[0]["evaluate"].ToString()!="")
				{
					model.evaluate=ds.Tables[0].Rows[0]["evaluate"].ToString();
				}
				if(ds.Tables[0].Rows[0]["material"]!=null && ds.Tables[0].Rows[0]["material"].ToString()!="")
				{
					model.material=ds.Tables[0].Rows[0]["material"].ToString();
				}
				if(ds.Tables[0].Rows[0]["materialMoney"]!=null && ds.Tables[0].Rows[0]["materialMoney"].ToString()!="")
				{
					model.materialMoney=decimal.Parse(ds.Tables[0].Rows[0]["materialMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["serviceMoney"]!=null && ds.Tables[0].Rows[0]["serviceMoney"].ToString()!="")
				{
					model.serviceMoney=decimal.Parse(ds.Tables[0].Rows[0]["serviceMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["payStatus"]!=null && ds.Tables[0].Rows[0]["payStatus"].ToString()!="")
				{
					model.payStatus=ds.Tables[0].Rows[0]["payStatus"].ToString();
				}
				if(ds.Tables[0].Rows[0]["traffic"]!=null && ds.Tables[0].Rows[0]["traffic"].ToString()!="")
				{
					model.traffic=ds.Tables[0].Rows[0]["traffic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["employee"]!=null && ds.Tables[0].Rows[0]["employee"].ToString()!="")
				{
					model.employee=ds.Tables[0].Rows[0]["employee"].ToString();
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
			strSql.Append("select GUID,sNO,customer,acceptDate,solutionDate,type,content,result,evaluate,material,materialMoney,serviceMoney,payStatus,traffic,employee,createDate ");
			strSql.Append(" FROM T_Service ");
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
			strSql.Append(" GUID,sNO,customer,acceptDate,solutionDate,type,content,result,evaluate,material,materialMoney,serviceMoney,payStatus,traffic,employee,createDate ");
			strSql.Append(" FROM T_Service ");
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
			parameters[0].Value = "T_Service";
			parameters[1].Value = "GUID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method

        /// <summary>
        /// 获取最大ID
        /// </summary>
        /// <returns></returns>
        public int GetMaxID()
        {
            return DbHelperSQL.GetMaxID("sNO", "T_Service");
        }
	}
}

