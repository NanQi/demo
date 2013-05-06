using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGame
{
   public class BaseMessage
   {
      public virtual string Msg { get; set; }
   }

   public class BaseMessageEventArgs : EventArgs
   {
      public BaseMessageEventArgs()
      {

      }

      public BaseMessageEventArgs(BaseMessage msg)
      {
         this.Msg = msg.Msg;
      }

      public string Msg { get; set; }

      public override string ToString()
      {
         return Msg;
      }
   }
}
