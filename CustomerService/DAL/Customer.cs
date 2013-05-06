using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CustomerService.DBUtility;//Please add references
namespace CustomerService.DAL
{
	/// <summary>
	/// 数据访问类:Customer
	/// </summary>
	public partial class Customer
	{
		public Customer()
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

			int result= DbHelperSQL.RunProcedure("T_Customer_Exists",parameters,out rowsAffected);
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
		public bool Add(CustomerService.Model.Customer model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@cNO", SqlDbType.VarChar,50),
					new SqlParameter("@parentGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@cName", SqlDbType.VarChar,100),
					new SqlParameter("@cMan", SqlDbType.VarChar,20),
					new SqlParameter("@Tel", SqlDbType.VarChar,20),
					new SqlParameter("@isGov", SqlDbType.Bit,1),
					new SqlParameter("@trade", SqlDbType.VarChar,50),
					new SqlParameter("@deptUp", SqlDbType.VarChar,50),
					new SqlParameter("@cType", SqlDbType.VarChar,50),
					new SqlParameter("@cStage", SqlDbType.VarChar,50),
					new SqlParameter("@cStatus", SqlDbType.VarChar,50),
					new SqlParameter("@cLevel", SqlDbType.VarChar,50),
					new SqlParameter("@province", SqlDbType.VarChar,50),
					new SqlParameter("@city", SqlDbType.VarChar,50),
					new SqlParameter("@district", SqlDbType.VarChar,50),
					new SqlParameter("@fax", SqlDbType.VarChar,50),
					new SqlParameter("@addresss", SqlDbType.VarChar,500),
					new SqlParameter("@zip", SqlDbType.VarChar,10),
					new SqlParameter("@netSet", SqlDbType.VarChar,100),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@QQ", SqlDbType.VarChar,50),
					new SqlParameter("@mode", SqlDbType.VarChar,50),
					new SqlParameter("@scope", SqlDbType.VarChar,50),
					new SqlParameter("@product", SqlDbType.VarChar,50),
					new SqlParameter("@opponent", SqlDbType.VarChar,50),
					new SqlParameter("@credit", SqlDbType.VarChar,50),
					new SqlParameter("@link1", SqlDbType.VarChar,20),
					new SqlParameter("@dept1", SqlDbType.VarChar,50),
					new SqlParameter("@job1", SqlDbType.VarChar,50),
					new SqlParameter("@tel1", SqlDbType.VarChar,20),
					new SqlParameter("@phone1", SqlDbType.VarChar,20),
					new SqlParameter("@link2", SqlDbType.VarChar,20),
					new SqlParameter("@dept2", SqlDbType.VarChar,50),
					new SqlParameter("@job2", SqlDbType.VarChar,50),
					new SqlParameter("@tel2", SqlDbType.VarChar,20),
					new SqlParameter("@phone2", SqlDbType.VarChar,20),
					new SqlParameter("@mapImg", SqlDbType.Image),
					new SqlParameter("@drive", SqlDbType.NText),
					new SqlParameter("@bus", SqlDbType.NText),
					new SqlParameter("@createDate", SqlDbType.DateTime)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.cNO;
			parameters[2].Value = model.parentGUID;
			parameters[3].Value = model.cName;
			parameters[4].Value = model.cMan;
			parameters[5].Value = model.Tel;
			parameters[6].Value = model.isGov;
			parameters[7].Value = model.trade;
			parameters[8].Value = model.deptUp;
			parameters[9].Value = model.cType;
			parameters[10].Value = model.cStage;
			parameters[11].Value = model.cStatus;
			parameters[12].Value = model.cLevel;
			parameters[13].Value = model.province;
			parameters[14].Value = model.city;
			parameters[15].Value = model.district;
			parameters[16].Value = model.fax;
			parameters[17].Value = model.addresss;
			parameters[18].Value = model.zip;
			parameters[19].Value = model.netSet;
			parameters[20].Value = model.email;
			parameters[21].Value = model.QQ;
			parameters[22].Value = model.mode;
			parameters[23].Value = model.scope;
			parameters[24].Value = model.product;
			parameters[25].Value = model.opponent;
			parameters[26].Value = model.credit;
			parameters[27].Value = model.link1;
			parameters[28].Value = model.dept1;
			parameters[29].Value = model.job1;
			parameters[30].Value = model.tel1;
			parameters[31].Value = model.phone1;
			parameters[32].Value = model.link2;
			parameters[33].Value = model.dept2;
			parameters[34].Value = model.job2;
			parameters[35].Value = model.tel2;
			parameters[36].Value = model.phone2;
			parameters[37].Value = model.mapImg;
			parameters[38].Value = model.drive;
			parameters[39].Value = model.bus;
            parameters[40].Value = DateTime.Now;

			DbHelperSQL.RunProcedure("T_Customer_ADD",parameters,out rowsAffected);
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
		public bool Update(CustomerService.Model.Customer model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@cNO", SqlDbType.VarChar,50),
					new SqlParameter("@parentGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@cName", SqlDbType.VarChar,100),
					new SqlParameter("@cMan", SqlDbType.VarChar,20),
					new SqlParameter("@Tel", SqlDbType.VarChar,20),
					new SqlParameter("@isGov", SqlDbType.Bit,1),
					new SqlParameter("@trade", SqlDbType.VarChar,50),
					new SqlParameter("@deptUp", SqlDbType.VarChar,50),
					new SqlParameter("@cType", SqlDbType.VarChar,50),
					new SqlParameter("@cStage", SqlDbType.VarChar,50),
					new SqlParameter("@cStatus", SqlDbType.VarChar,50),
					new SqlParameter("@cLevel", SqlDbType.VarChar,50),
					new SqlParameter("@province", SqlDbType.VarChar,50),
					new SqlParameter("@city", SqlDbType.VarChar,50),
					new SqlParameter("@district", SqlDbType.VarChar,50),
					new SqlParameter("@fax", SqlDbType.VarChar,50),
					new SqlParameter("@addresss", SqlDbType.VarChar,500),
					new SqlParameter("@zip", SqlDbType.VarChar,10),
					new SqlParameter("@netSet", SqlDbType.VarChar,100),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@QQ", SqlDbType.VarChar,50),
					new SqlParameter("@mode", SqlDbType.VarChar,50),
					new SqlParameter("@scope", SqlDbType.VarChar,50),
					new SqlParameter("@product", SqlDbType.VarChar,50),
					new SqlParameter("@opponent", SqlDbType.VarChar,50),
					new SqlParameter("@credit", SqlDbType.VarChar,50),
					new SqlParameter("@link1", SqlDbType.VarChar,20),
					new SqlParameter("@dept1", SqlDbType.VarChar,50),
					new SqlParameter("@job1", SqlDbType.VarChar,50),
					new SqlParameter("@tel1", SqlDbType.VarChar,20),
					new SqlParameter("@phone1", SqlDbType.VarChar,20),
					new SqlParameter("@link2", SqlDbType.VarChar,20),
					new SqlParameter("@dept2", SqlDbType.VarChar,50),
					new SqlParameter("@job2", SqlDbType.VarChar,50),
					new SqlParameter("@tel2", SqlDbType.VarChar,20),
					new SqlParameter("@phone2", SqlDbType.VarChar,20),
					new SqlParameter("@mapImg", SqlDbType.Image),
					new SqlParameter("@drive", SqlDbType.NText),
					new SqlParameter("@bus", SqlDbType.NText),
					new SqlParameter("@createDate", SqlDbType.DateTime)};
			parameters[0].Value = model.GUID;
			parameters[1].Value = model.cNO;
			parameters[2].Value = model.parentGUID;
			parameters[3].Value = model.cName;
			parameters[4].Value = model.cMan;
			parameters[5].Value = model.Tel;
			parameters[6].Value = model.isGov;
			parameters[7].Value = model.trade;
			parameters[8].Value = model.deptUp;
			parameters[9].Value = model.cType;
			parameters[10].Value = model.cStage;
			parameters[11].Value = model.cStatus;
			parameters[12].Value = model.cLevel;
			parameters[13].Value = model.province;
			parameters[14].Value = model.city;
			parameters[15].Value = model.district;
			parameters[16].Value = model.fax;
			parameters[17].Value = model.addresss;
			parameters[18].Value = model.zip;
			parameters[19].Value = model.netSet;
			parameters[20].Value = model.email;
			parameters[21].Value = model.QQ;
			parameters[22].Value = model.mode;
			parameters[23].Value = model.scope;
			parameters[24].Value = model.product;
			parameters[25].Value = model.opponent;
			parameters[26].Value = model.credit;
			parameters[27].Value = model.link1;
			parameters[28].Value = model.dept1;
			parameters[29].Value = model.job1;
			parameters[30].Value = model.tel1;
			parameters[31].Value = model.phone1;
			parameters[32].Value = model.link2;
			parameters[33].Value = model.dept2;
			parameters[34].Value = model.job2;
			parameters[35].Value = model.tel2;
			parameters[36].Value = model.phone2;
			parameters[37].Value = model.mapImg;
			parameters[38].Value = model.drive;
			parameters[39].Value = model.bus;
			parameters[40].Value = model.createDate;

			DbHelperSQL.RunProcedure("T_Customer_Update",parameters,out rowsAffected);
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

			DbHelperSQL.RunProcedure("T_Customer_Delete",parameters,out rowsAffected);
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
			strSql.Append("delete from T_Customer ");
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
		public CustomerService.Model.Customer GetModel(Guid GUID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@GUID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = GUID;

			CustomerService.Model.Customer model=new CustomerService.Model.Customer();
			DataSet ds= DbHelperSQL.RunProcedure("T_Customer_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["GUID"]!=null && ds.Tables[0].Rows[0]["GUID"].ToString()!="")
				{
					model.GUID=new Guid(ds.Tables[0].Rows[0]["GUID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cNO"]!=null && ds.Tables[0].Rows[0]["cNO"].ToString()!="")
				{
					model.cNO=ds.Tables[0].Rows[0]["cNO"].ToString();
				}
				if(ds.Tables[0].Rows[0]["parentGUID"]!=null && ds.Tables[0].Rows[0]["parentGUID"].ToString()!="")
				{
					model.parentGUID=new Guid(ds.Tables[0].Rows[0]["parentGUID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cName"]!=null && ds.Tables[0].Rows[0]["cName"].ToString()!="")
				{
					model.cName=ds.Tables[0].Rows[0]["cName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cMan"]!=null && ds.Tables[0].Rows[0]["cMan"].ToString()!="")
				{
					model.cMan=ds.Tables[0].Rows[0]["cMan"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null && ds.Tables[0].Rows[0]["Tel"].ToString()!="")
				{
					model.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["isGov"]!=null && ds.Tables[0].Rows[0]["isGov"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["isGov"].ToString()=="1")||(ds.Tables[0].Rows[0]["isGov"].ToString().ToLower()=="true"))
					{
						model.isGov=true;
					}
					else
					{
						model.isGov=false;
					}
				}
				if(ds.Tables[0].Rows[0]["trade"]!=null && ds.Tables[0].Rows[0]["trade"].ToString()!="")
				{
					model.trade=ds.Tables[0].Rows[0]["trade"].ToString();
				}
				if(ds.Tables[0].Rows[0]["deptUp"]!=null && ds.Tables[0].Rows[0]["deptUp"].ToString()!="")
				{
					model.deptUp=ds.Tables[0].Rows[0]["deptUp"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cType"]!=null && ds.Tables[0].Rows[0]["cType"].ToString()!="")
				{
					model.cType=ds.Tables[0].Rows[0]["cType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cStage"]!=null && ds.Tables[0].Rows[0]["cStage"].ToString()!="")
				{
					model.cStage=ds.Tables[0].Rows[0]["cStage"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cStatus"]!=null && ds.Tables[0].Rows[0]["cStatus"].ToString()!="")
				{
					model.cStatus=ds.Tables[0].Rows[0]["cStatus"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cLevel"]!=null && ds.Tables[0].Rows[0]["cLevel"].ToString()!="")
				{
					model.cLevel=ds.Tables[0].Rows[0]["cLevel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["province"]!=null && ds.Tables[0].Rows[0]["province"].ToString()!="")
				{
					model.province=ds.Tables[0].Rows[0]["province"].ToString();
				}
				if(ds.Tables[0].Rows[0]["city"]!=null && ds.Tables[0].Rows[0]["city"].ToString()!="")
				{
					model.city=ds.Tables[0].Rows[0]["city"].ToString();
				}
				if(ds.Tables[0].Rows[0]["district"]!=null && ds.Tables[0].Rows[0]["district"].ToString()!="")
				{
					model.district=ds.Tables[0].Rows[0]["district"].ToString();
				}
				if(ds.Tables[0].Rows[0]["fax"]!=null && ds.Tables[0].Rows[0]["fax"].ToString()!="")
				{
					model.fax=ds.Tables[0].Rows[0]["fax"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addresss"]!=null && ds.Tables[0].Rows[0]["addresss"].ToString()!="")
				{
					model.addresss=ds.Tables[0].Rows[0]["addresss"].ToString();
				}
				if(ds.Tables[0].Rows[0]["zip"]!=null && ds.Tables[0].Rows[0]["zip"].ToString()!="")
				{
					model.zip=ds.Tables[0].Rows[0]["zip"].ToString();
				}
				if(ds.Tables[0].Rows[0]["netSet"]!=null && ds.Tables[0].Rows[0]["netSet"].ToString()!="")
				{
					model.netSet=ds.Tables[0].Rows[0]["netSet"].ToString();
				}
				if(ds.Tables[0].Rows[0]["email"]!=null && ds.Tables[0].Rows[0]["email"].ToString()!="")
				{
					model.email=ds.Tables[0].Rows[0]["email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QQ"]!=null && ds.Tables[0].Rows[0]["QQ"].ToString()!="")
				{
					model.QQ=ds.Tables[0].Rows[0]["QQ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["mode"]!=null && ds.Tables[0].Rows[0]["mode"].ToString()!="")
				{
					model.mode=ds.Tables[0].Rows[0]["mode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["scope"]!=null && ds.Tables[0].Rows[0]["scope"].ToString()!="")
				{
					model.scope=ds.Tables[0].Rows[0]["scope"].ToString();
				}
				if(ds.Tables[0].Rows[0]["product"]!=null && ds.Tables[0].Rows[0]["product"].ToString()!="")
				{
					model.product=ds.Tables[0].Rows[0]["product"].ToString();
				}
				if(ds.Tables[0].Rows[0]["opponent"]!=null && ds.Tables[0].Rows[0]["opponent"].ToString()!="")
				{
					model.opponent=ds.Tables[0].Rows[0]["opponent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["credit"]!=null && ds.Tables[0].Rows[0]["credit"].ToString()!="")
				{
					model.credit=ds.Tables[0].Rows[0]["credit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["link1"]!=null && ds.Tables[0].Rows[0]["link1"].ToString()!="")
				{
					model.link1=ds.Tables[0].Rows[0]["link1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["dept1"]!=null && ds.Tables[0].Rows[0]["dept1"].ToString()!="")
				{
					model.dept1=ds.Tables[0].Rows[0]["dept1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["job1"]!=null && ds.Tables[0].Rows[0]["job1"].ToString()!="")
				{
					model.job1=ds.Tables[0].Rows[0]["job1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["tel1"]!=null && ds.Tables[0].Rows[0]["tel1"].ToString()!="")
				{
					model.tel1=ds.Tables[0].Rows[0]["tel1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["phone1"]!=null && ds.Tables[0].Rows[0]["phone1"].ToString()!="")
				{
					model.phone1=ds.Tables[0].Rows[0]["phone1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["link2"]!=null && ds.Tables[0].Rows[0]["link2"].ToString()!="")
				{
					model.link2=ds.Tables[0].Rows[0]["link2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["dept2"]!=null && ds.Tables[0].Rows[0]["dept2"].ToString()!="")
				{
					model.dept2=ds.Tables[0].Rows[0]["dept2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["job2"]!=null && ds.Tables[0].Rows[0]["job2"].ToString()!="")
				{
					model.job2=ds.Tables[0].Rows[0]["job2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["tel2"]!=null && ds.Tables[0].Rows[0]["tel2"].ToString()!="")
				{
					model.tel2=ds.Tables[0].Rows[0]["tel2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["phone2"]!=null && ds.Tables[0].Rows[0]["phone2"].ToString()!="")
				{
					model.phone2=ds.Tables[0].Rows[0]["phone2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["mapImg"]!=null && ds.Tables[0].Rows[0]["mapImg"].ToString()!="")
				{
					model.mapImg=(byte[])ds.Tables[0].Rows[0]["mapImg"];
				}
				if(ds.Tables[0].Rows[0]["drive"]!=null && ds.Tables[0].Rows[0]["drive"].ToString()!="")
				{
					model.drive=ds.Tables[0].Rows[0]["drive"].ToString();
				}
				if(ds.Tables[0].Rows[0]["bus"]!=null && ds.Tables[0].Rows[0]["bus"].ToString()!="")
				{
					model.bus=ds.Tables[0].Rows[0]["bus"].ToString();
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
			strSql.Append("select GUID,cNO,parentGUID,cName,cMan,Tel,isGov,trade,deptUp,cType,cStage,cStatus,cLevel,province,city,district,fax,addresss,zip,netSet,email,QQ,mode,scope,product,opponent,credit,link1,dept1,job1,tel1,phone1,link2,dept2,job2,tel2,phone2,mapImg,drive,bus,createDate ");
			strSql.Append(" FROM T_Customer ");
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
			strSql.Append(" GUID,cNO,parentGUID,cName,cMan,Tel,isGov,trade,deptUp,cType,cStage,cStatus,cLevel,province,city,district,fax,addresss,zip,netSet,email,QQ,mode,scope,product,opponent,credit,link1,dept1,job1,tel1,phone1,link2,dept2,job2,tel2,phone2,mapImg,drive,bus,createDate ");
			strSql.Append(" FROM T_Customer ");
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
			parameters[0].Value = "T_Customer";
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
            return DbHelperSQL.GetMaxID("cNO", "T_Customer");
        }
	}
}

