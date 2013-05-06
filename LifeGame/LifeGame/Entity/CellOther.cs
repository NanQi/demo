using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Untity;
using System.Drawing;

namespace LifeGame
{
   public partial class Cell
   {
      /// <summary>
      /// 伤害
      /// </summary>
      /// <param name="cell"></param>
      public void Hurt(Cell cell)
      {
         int hurt = this.Attack;

         StringBuilder strMsg = new StringBuilder();
         strMsg.Append(this.ToString());

         if (IsHaveAbility(AbilityEnum.奋力一击))
         {
            hurt += this.Strength;
            strMsg.AppendFormat("[奋力一击](+{0})", this.Strength.ToString());
         }

         if (IsHaveAbility(AbilityEnum.击中要害))
         {
            hurt += 10 + this.Intelligence / 3 + 1;
            strMsg.AppendFormat("[击中要害](+{0})", 10 + this.Intelligence / 3 + 1);
         }

         if (IsHaveAbility(AbilityEnum.拌摔))
         {
            cell.State |= CellStateEnum.被拌摔;
            strMsg.Append("[拌摔]");
         }

         if (IsHaveAbility(AbilityEnum.专注))
         {
            this.Rival.Clear();
            this.Rival.Add(cell);
            strMsg.Append("[专注]");
         }

         if (IsHaveAbility(AbilityEnum.闪避) && _random.Probability(0.01 * cell.Dexterity))
         {
            GameMessage.AddMsg(new FightMessage()
            {
               Msg = cell.ToString() + "[闪避]" + this.ToString() + "的一次攻击",
               被攻击者 = cell,
               攻击者 = this
            });
            return;
         }

         bool isAlive = cell.GetHurt(hurt);

         strMsg.Append("对" + cell.ToString() + "造成" + hurt + "点伤害");
         GameMessage.AddMsg(new FightMessage() { Msg = strMsg.ToString(), 攻击者 = this, 被攻击者 = cell });

         cell.AddRival(this);

         if (isAlive)
         {
            if (IsHaveAbility(AbilityEnum.反击) && _random.Probability(0.05 * cell.Dexterity))
            {
               GameMessage.AddMsg(new FightMessage()
               {
                  Msg = cell.ToString() + "对" + this.ToString() + "进行[反击]",
                  被攻击者 = cell,
                  攻击者 = this
               });

               cell.Hurt(this);
            }
         }
         else
         {
            CellDeadEventArgs e = new CellDeadEventArgs();
            e.Killer = this;
            e.LastHurt = hurt;

            if (cell.Dead != null)
            {
               cell.Dead(cell, e);

               GameMessage.AddMsg(new FightMessage()
               {
                  Msg = this.ToString() + "杀死了" + cell.ToString(),
                  被攻击者 = cell,
                  攻击者 = this
               });
            }
         }
      }

      /// <summary>
      /// 下一步行动
      /// </summary>
      public void NextAction()
      {
         GetAbility();

         if (IsHaveState(CellStateEnum.被拌摔))
         {
            if (_random.Probability(0.05 * this.Dexterity))
            {
               State &= ~CellStateEnum.被拌摔;
            }
         }

         if (IsHaveAbility(AbilityEnum.谋而后动))
         {
            //
         }

         if (IsHaveAbility(AbilityEnum.走为上策))
         {
            //
         }

         if (IsHaveAbility(AbilityEnum.休息疗伤))
         {
            //
         }

         if (IsHaveAbility(AbilityEnum.知己知彼))
         {
            //
         }

         if (IsHaveAbility(AbilityEnum.渔翁得利))
         {
            //
         }

         double pro = 0.5;

         if (this.Rival.Count > 0)
         {
            Cell rivalCell = Rival.Where(rival => !rival.IsDisposed && rival != null).Where(rival =>
               this.Position.Within(this.Vision).Contains(rival.Position)).RandomElement();

            if (rivalCell != null)
            {
               Point targetPoint = rivalCell.Position.Within(1).RandomElement(p =>
                  !this.ParentWorldMapPanel.IsExist(p));

               if (!targetPoint.IsEmpty)
               {
                  this.Movement(targetPoint);
                  this.Hurt(rivalCell);
                  return;
               }
            }
         }

         if (_random.Probability(pro))
         {
            Wander();
            return;
         }

         if (_random.Probability(pro))
         {
            var lst = this.GetNearbyCells();
            if (lst.Count > 0)
            {
               Cell targetCell = lst.RandomElement();

               Point targetPoint = targetCell.Position.Within(1).RandomElement(p =>
                  !this.ParentWorldMapPanel.IsExist(p));

               if (!targetPoint.IsEmpty)
               {
                  this.Movement(targetPoint);
                  this.Hurt(targetCell);
                  return;
               }
            }
         }

         Rest();
      }
   }
}
