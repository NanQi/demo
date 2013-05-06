using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Untity;

namespace LifeGame
{
   public static class AbilityEnum
   {
      //攻击                                 
      public const int 攻击类型            = 0x10000000;

      /// <summary>
      /// 每1点力量增加1点攻击力
      /// </summary>
      public const int 奋力一击            = 0x10000001;
      /// <summary>
      /// 固定增加10点攻击力，每3点智力额外增加1点攻击力
      /// </summary>
      public const int 击中要害            = 0x11000002;
      /// <summary>
      /// 攻击使对手减速 Vision = 1
      /// </summary>
      public const int 拌摔                = 0x10000004;
      /// <summary>
      /// 认准一个对手
      /// </summary>
      public const int 专注                = 0x10000008;

      //被攻击
      public const int 被攻击类型          = 0x20000000;
      /// <summary>
      /// 每1点敏捷增加5%反击率
      /// </summary>
      public const int 反击                = 0x22110010;
      /// <summary>
      /// 每1点敏捷增加1%闪避率
      /// </summary>
      public const int 闪避                = 0x24000020;

      //思考
      public const int 思考类型            = 0x40000000;      
      /// <summary>
      /// 优先级5 行动前先判断一次自身状态
      /// </summary>
      public const int 谋而后动            = 0x48200040;
      /// <summary>
      /// 优先级4 判断自身状态不适合战斗则逃跑
      /// </summary>
      public const int 走为上策            = 0x40410080;
      /// <summary>
      /// 优先级3 判断自身血不满并周围没有人，则休息加血
      /// </summary>
      public const int 休息疗伤            = 0x40000100;
      /// <summary>
      /// 优先级2 判断所有对手弱点
      /// </summary>
      public const int 知己知彼            = 0x40821200;
      /// <summary>
      /// 优先级1 判断对手或周围目标，伺机而动
      /// </summary>
      public const int 渔翁得利            = 0x40042400;

      static Dictionary<int ,string> _dic;


      static AbilityEnum()
      {
         _dic = new Dictionary<int,string>();
         _dic.Add(奋力一击, "[奋力一击]");
         _dic.Add(击中要害, "[击中要害]");
         _dic.Add(拌摔, "[拌摔]");
         _dic.Add(专注, "[专注]");
         _dic.Add(反击, "[反击]");
         _dic.Add(闪避, "[闪避]");
         _dic.Add(谋而后动, "[谋而后动]");
         _dic.Add(走为上策, "[走为上策]");
         _dic.Add(休息疗伤, "[休息疗伤]");
         _dic.Add(知己知彼, "[知己知彼]");
         _dic.Add(渔翁得利, "[渔翁得利]");
      }


      public static Dictionary<int ,string> DictAbility
      {
         get { return _dic; }
         set { _dic = value; }
      }

      public static int RandomAbility()
      {
         return _dic.Select(kv => kv.Key).RandomElement();
      }

      public static string GetAbilityName(int abilityValue)
      {
         return _dic[abilityValue];
      }
   }
}
