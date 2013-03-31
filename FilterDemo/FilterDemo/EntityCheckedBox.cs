
/* By NanQi 201209 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FilterDemo
{
   //给CheckBoxList用的Entiy
   public class EntityCheckedBox : EntitySimple
   {
      private bool _isChecked;
      ///获取或设置是否选择
      public bool IsChecked
      {
         get { return _isChecked; }
         set { _isChecked = value; }
      }

      private int _indexOfSource;
      ///获取或设置当前项位于源的索引
      public int IndexOfSource
      {
         get { return _indexOfSource; }
         set { _indexOfSource = value; }
      }

      ///重载构造函数，对几个必须属性进行赋�?
      public EntityCheckedBox(DataRow dr, bool isChecked, int index)
      {
         this.GUID = dr[0].ToString();
         this.Code = dr[1].ToString();
         this.Name = dr[2].ToString();

         this._isChecked = isChecked;
         this._indexOfSource = index;
      }
   }
}
