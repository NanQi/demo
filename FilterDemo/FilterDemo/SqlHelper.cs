using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FilterDemo
{
   public static class SqlHelper
   {
      static DataTable _dtSource;

      static SqlHelper()
      {
         _dtSource = new DataTable();

         _dtSource.Columns.Add("GUID", typeof(string));
         _dtSource.Columns.Add("编号", typeof(string));
         _dtSource.Columns.Add("姓名", typeof(string));
         _dtSource.Columns.Add("工资", typeof(decimal));
         _dtSource.Columns.Add("生日", typeof(DateTime));

         for (int i = 0; i < 360; i++)
         {
            DataRow row = _dtSource.NewRow();
            row["GUID"] = Guid.NewGuid().ToString();
            row["编号"] = "1701" + i.ToString("000");
            row["姓名"] = "张三" + i.ToString("000");
            row["工资"] = 3500.00d + i;
            row["生日"] = new DateTime(1981, 1, 1).AddDays(i);
            _dtSource.Rows.Add(row);

            row = _dtSource.NewRow();
            row["GUID"] = Guid.NewGuid().ToString();
            row["编号"] = "1702" + i.ToString("000");
            row["姓名"] = "李四" + i.ToString("000");
            row["工资"] = 4000.00d + i;
            row["生日"] = new DateTime(1982, 2, 2).AddDays(i);
            _dtSource.Rows.Add(row);

            row = _dtSource.NewRow();
            row["GUID"] = Guid.NewGuid().ToString();
            row["编号"] = "1703" + i.ToString("000");
            row["姓名"] = "王五" + i.ToString("000");
            row["工资"] = 4500.00d + i;
            row["生日"] = new DateTime(1983, 3, 3).AddDays(i);
            _dtSource.Rows.Add(row);
         }
      }

      /// <summary>
      /// 格式化SQL查询变量，通过转义字符避免查询异常
      /// </summary>
      /// <param name="strQuery">传入参数</param>
      /// <returns></returns>
      public static string FormatSql(string strQuery)
      {
         //strQuery = strQuery.Replace("/", "//");
         strQuery = strQuery.Replace("'", "''");
         //strQuery = strQuery.Replace("%", "/%");
         return strQuery;
      }

      /// <summary>
      /// 模拟查询
      /// </summary>
      /// <param name="strWhere">条件</param>
      /// <returns></returns>
      public static DataTable GetData(string strWhere)
      {
         DataTable dt = _dtSource.Clone();

         foreach (DataRow row in _dtSource.Select(strWhere))
         {
            dt.ImportRow(row);
         }

         return dt;
      }
   }
}
