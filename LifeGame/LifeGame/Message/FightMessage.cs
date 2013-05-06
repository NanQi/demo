using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGame
{
   public class FightMessage : BaseMessage
   {
      public Cell 攻击者 { get; set; }
      public Cell 被攻击者 { get; set; }
   }

   public class FightMessageEventArgs : BaseMessageEventArgs
   {
      public FightMessageEventArgs()
      {

      }

      public FightMessageEventArgs(FightMessage msg)
         : base(msg)
      {
         this.攻击者 = msg.攻击者;
         this.被攻击者 = msg.被攻击者;
      }

      public Cell 攻击者 { get; set; }
      public Cell 被攻击者 { get; set; }
   }
}
