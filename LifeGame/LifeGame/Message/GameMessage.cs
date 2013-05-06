using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGame
{
   public static class GameMessage
   {
      static List<BaseMessage> _lstMessage = new List<BaseMessage>();

      public static List<BaseMessage> Messages
      {
         get { return GameMessage._lstMessage; }
      }

      public static event MessageEventHandle AddMessage;
      public delegate void MessageEventHandle(object sender, BaseMessageEventArgs e);

      public static void AddMsg(BaseMessage msg)
      {
         _lstMessage.Add(msg);

         if (AddMessage != null)
         {
            if (msg is FightMessage)
            {
               FightMessage fight = msg as FightMessage;
               AddMessage(fight.攻击者, new FightMessageEventArgs(fight));
            }
            else if (msg is AbilityMessage)
            {
               AbilityMessage ability = msg as AbilityMessage;
               AddMessage(ability.触发单位, new AbilityMessageEventArgs(ability));
            }
         }
      }
   }
}
