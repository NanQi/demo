using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Collections;
using System.Data;

namespace CustomerService.DBUtility
{
    public class XMLHelper
    {
        public XMLHelper()
        {
        }
        /// <summary>
        /// 获取登录列表
        /// </summary>
        /// <returns></returns>
        public static List<string> GetList()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(@"xml\Remember.xml");

            DataTable dt = dst.Tables["LoginNameList"];

            List<string> lst = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                lst.Add(row["LoginName"].ToString());
            }
            return lst;
        }
        /// <summary>
        /// 获取上次记录的账号
        /// </summary>
        /// <returns></returns>
        public static string GetRememberLoginName()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"xml\Remember.xml");
            XmlNode root = doc.SelectSingleNode("Remember");
            string loginName = root.Attributes["RememberLoginName"].Value;
            return loginName;
        }
        /// <summary>
        /// 添加登录列表
        /// </summary>
        /// <param name="name">账号</param>
        public static void Append(string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"xml\Remember.xml");
            XmlNode root = doc.SelectSingleNode("Remember");
            XmlElement xe = doc.CreateElement("LoginNameList");
            XmlNode xn = doc.CreateNode(XmlNodeType.Attribute, "LoginName", "");
            xn.Value = name;
            xe.Attributes.SetNamedItem(xn);
            root.AppendChild(xe);
            doc.Save(@"xml\Remember.xml");
        }
        /// <summary>
        /// 设置上次记住的账号
        /// </summary>
        /// <param name="name">账号</param>
        public static void SetRemember(string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"xml\Remember.xml");
            XmlNode root = doc.SelectSingleNode("Remember");
            XmlNode att = root.Attributes["RememberLoginName"];
            att.Value = name;
            doc.Save(@"xml\Remember.xml");
        }
        /// <summary>
        /// 获取省列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetProvinces()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(@"xml\Provinces.xml");

            DataTable dt = dst.Tables["Province"];

            return dt;
        }
        /// <summary>
        /// 根据省ID获取城市列表
        /// </summary>
        /// <param name="id">省份ID</param>
        /// <returns></returns>
        public static DataView GetCities(int id)
        {
            DataSet dst = new DataSet();
            dst.ReadXml(@"xml\Cities.xml");

            DataTable dt = dst.Tables["City"];

            DataView dv = dt.DefaultView;
            dv.RowFilter = "PID = " + id;

            return dv;
        }
        /// <summary>
        /// 根据市ID获取区列表
        /// </summary>
        /// <param name="id">市ID</param>
        /// <returns></returns>
        public static DataView GetDistricts(int id)
        {
            DataSet dst = new DataSet();
            dst.ReadXml(@"xml\Districts.xml");

            DataTable dt = dst.Tables["District"];

            DataView dv = dt.DefaultView;
            dv.RowFilter = "CID = " + id;

            return dv;
        }
    }
}
