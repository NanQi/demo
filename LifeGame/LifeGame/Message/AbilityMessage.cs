using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGame
{
   public class AbilityMessage : BaseMessage
   {
      public Cell 触发单位 { get; set; }
      public int 获得的技能 { get; set; }
   }


   public class AbilityMessageEventArgs : BaseMessageEventArgs
   {
      public AbilityMessageEventArgs()
      {

      }

      public AbilityMessageEventArgs(AbilityMessage msg)
         : base(msg)
      {
         this.触发单位 = msg.触发单位;
         this.获得的技能 = msg.获得的技能;
      }
      
      public Cell 触发单位 { get; set; }
      public int 获得的技能 { get; set; }

      public override string ToString()
      {
         if (string.IsNullOrEmpty(Msg))
         {
            return 触发单位.ToString() + "获得技能" + AbilityEnum.GetAbilityName(获得的技能);
         }

         return base.ToString();
      }
   }
}
