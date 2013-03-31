
/*简易实体类 By NanQi 20120614*/

namespace FilterDemo
{
   /// <summary>
   /// 简易实体类 ? 通用目的
   /// 包括GUID,Code,Name,Description的一个实体类,重写了ToString方法---Code + "---" + Name
   /// </summary>
   public class EntitySimple
   {
      private string _guid;
      private string _code;
      private string _name;
      private string _description;
      private object _tag;

      public EntitySimple()
      {
         
      }
      ///重载构造函数，可直接给以，隔开的三项（GUID,Code,Name）
      public EntitySimple(string strRow)
      {
         string[] strData = strRow.Split('|');
         this._guid = strData[0];
         this._code = strData[1];
         this._name = strData[2];
      }

      ///获取或设置GUID
      public string GUID
      {
         get { return _guid; }
         set { _guid = value; }
      }
      
      ///获取或设置Code
      public string Code
      {
         get { return _code; }
         set { _code = value; }
      }

      ///获取或设置Name
      public string Name
      {
         get { return _name; }
         set { _name = value; }
      }

      ///获取或设置描述信息
      public string Description
      {
         get { return _description; }
         set { _description = value; }
      }

      ///获取或设置Tag
      public object Tag
      {
         get { return _tag; }
         set { _tag = value; }
      }

      ///获取或设置显示的值（Code + "---" + Name）
      public string Display
      {
         get
         { 
            return Code + "---" + Name; 
         }
      }

      ///重写ToString方法，返回Dispaly值
      public override string ToString()
      {
         return Display;
      }

      /// <summary>
      /// 重写Equals方法，只要GUID相等则相等
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public override bool Equals(object obj)
      {
         if (obj is EntitySimple)
         {
            EntitySimple entity = obj as EntitySimple;

            if (entity.GUID == this.GUID)
            {
               return true;
            }
         }

         return false;
      }

      ///重写GetHashCode，返回GUID的HashCode
      public override int GetHashCode()
      {
         return this.GUID.GetHashCode();
      }
   }
}
