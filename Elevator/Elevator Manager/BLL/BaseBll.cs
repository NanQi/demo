using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class BaseBll
    {
        public DAL.SqlHelper dal;

        public BaseBll()
        {
            dal = new DAL.SqlHelper();
        }

        /// <summary>
        /// 验证所给的字符串是否符合所给的正则表达式
        /// </summary>
        /// <param name="strIn">要验证的字符串</param>
        /// <param name="reg">正则表达式</param>
        /// <returns></returns>
        public static bool IsValid(string strIn, string reg)
        {
            return Regex.IsMatch(strIn, reg);
        }

        /// <summary>
        /// 验证是否符合长度
        /// </summary>
        /// <param name="strIn">要验证的字符串</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public bool IsLength(string strIn, int length)
        {
            if (Encoding.Default.GetBytes(strIn).Length > length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 验证是否有特殊字符
        /// </summary>
        /// <param name="strIn">要验证的字符串</param>
        /// <returns></returns>
        public bool IsHaveChar(string strIn)
        {
            return Regex.Match(strIn, @"[%&',;=?$\x22]+").Success;
        }

        /// <summary>
        /// 验证是否是有效的手机号
        /// </summary>
        /// <param name="strIn">要验证的字符串</param>
        /// <returns></returns>
        public bool IsValidPhone(string strIn)
        {
            return IsValid(strIn, @"^[1][0-9]{10}$");
        }

        /// <summary>
        /// 验证是否是正整数
        /// </summary>
        /// <param name="strIn">要验证的字符串</param>
        /// <returns></returns>
        public bool IsValidInt(string strIn)
        {
            return IsValid(strIn, @"^[0-9]*[1-9][0-9]*$");
        }

        /// <summary>
        /// 验证是否是有效的电话
        /// </summary>
        /// <param name="strIn">要验证的字符串</param>
        /// <returns></returns>
        public bool IsValidTel(string strIn)
        {
            return IsValid(strIn, @"^((\d{3,4})|\d{3,4}-)?\d{6,7}[0-9]$");
        }

        /// <summary>
        /// 验证是否是有效的钱数
        /// </summary>
        /// <param name="strIn">要验证的字符串</param>
        /// <returns></returns>
        public bool IsValidMoney(string strIn)
        {
            if (!IsValid(strIn, @"^[0-9.]*$"))
            {
                return false;
            }

            if (IsValid(strIn, @"^[1-9]\d{0,3}(.[0-9]{1,4})?[0-9]$"))
            {
                decimal dec;
                try
                {
                    dec = Convert.ToDecimal(strIn);
                }
                catch (Exception)
                {
                    return false;
                }

                if (dec >= 100000M)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 验证是否是有效的电子邮件
        /// </summary>
        /// <param name="strIn">要验证的字符串</param>
        /// <returns></returns>
        public bool IsValidEmail(string strIn)
        {
            return IsValid(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        /// <summary>
        /// 验证是否是有效的身份证   
        /// </summary>
        /// <param name="strIn">需要验证的字符串</param>
        /// <param name="brith">出生日期</param>
        /// <returns></returns>
        public bool IsValidCard(string strIn, string brith)
        {
            if (IsValid(strIn, @"^\d{15}|\d{18}$"))
            {
                StringBuilder sb = new StringBuilder(@"^[1-9]\d{5}");
                StringBuilder sbr = new StringBuilder(brith);

                sbr.Replace("年", "");
                sbr.Replace("月", "");
                sbr.Replace("日", "");

                brith = sbr.ToString();

                if (strIn.Length == 15)
                {
                    brith = brith.Substring(2);
                    sb.Append(brith);
                    sb.Append(@"\d{3}$");

                    return IsValid(strIn, sb.ToString());
                }
                else
                {
                    sb.Append(brith);
                    sb.Append(@"(\d{3})[0-9|X|x]$");

                    return IsValid(strIn, sb.ToString());
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 隐藏后三位
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public string ReplaceEndChar(string strIn)
        {
            if (IsValidEmail(strIn))
            {
                return Regex.Replace(strIn,
                @"\w{1,3}@",
                "***@");
            }
            else
            {
                return Regex.Replace(strIn,
                @"\d{3}$",
                "***");
            }
        }

        /// <summary>
        /// 给定表名,获得下一个ID,实现主键的自动增长
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public string GetNextId(string tblName)
        {
            string strResult = dal.ExecuteScalar("UP_GetMaxId",
               new SqlParameter("@TableName", tblName)).ToString();

            //判断有无数据
            if (strResult.Length != 0)
            {
                int i = Convert.ToInt32(
                   strResult.Substring(strResult.Length - 4));
                i++;
                return tblName + i.ToString();
            }
            else
            {
                return tblName + "1001";
            }
        }

        /// <summary>
        /// 获得视图信息
        /// </summary>
        /// <param name="tblName">去掉前缀的表名</param>
        /// <returns></returns>
        public DataTable GetViewInfo(string tblName)
        {
            return dal.ExecuteDataTable("UP_View_GetInfo", tblName,
                new SqlParameter("@TableName", tblName));
        }
    }
}
