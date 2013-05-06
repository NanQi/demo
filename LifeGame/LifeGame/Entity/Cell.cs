using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Untity;

namespace LifeGame
{
   public partial class Cell : Label
   {
      #region Field

      RandomUntity _random = new RandomUntity();

      int _rowIndex;

      int _columnIndex;

      int _hp;

      int _L_Strength = Rule.可获取属性点;
      int _L_Dexterity = Rule.可获取属性点;
      int _L_Intelligence = Rule.可获取属性点;

      #endregion

      #region ctor

      public Cell()
      {
         RandomPosition();
         AutoSize = false;
         this.Width = Rule.CELLWIDTH - 1;
         this.Height = Rule.CELLWIDTH - 1;
         this.Cursor = System.Windows.Forms.Cursors.Hand;

         this.Rival = new List<Cell>();

         this.Strength = Rule.初始属性点;
         this.Dexterity = Rule.初始属性点;
         this.Intelligence = Rule.初始属性点;

         this.Ethnicity = (EthnicityEnum)_random.Next(2);

         int dice0 = Rule.Dice3;//优劣

         int dice1 = Rule.Dice3;
         int dice2 = Rule.Dice3;
         int dice3 = Rule.可分配点 + dice0 - dice1 - dice2;
         int[] arr = { dice1, dice2, dice3 };

         int[] index = _random.GetNotRepeatRandom(1, 3, 3);

         this.Strength += arr[index[0] - 1];
         this.Dexterity += arr[index[1] - 1];
         this.Intelligence += arr[index[2] - 1];

         this.MaxHP = Rule.初始HP + Strength * 5;
         this._hp = MaxHP;

         this.Dead += (sender, e) => this.Dispose();

      }

      #endregion

      #region prop

      public int No { get; set; }

      public WorldMapPanel ParentWorldMapPanel { get; set; }

      /// <summary>
      /// 种族
      /// </summary>
      public EthnicityEnum Ethnicity { get; set; }

      /// <summary>
      /// 力量
      /// </summary>
      public int Strength { get; set; }

      /// <summary>
      /// 敏捷
      /// </summary>
      public int Dexterity { get; set; }

      /// <summary>
      /// 智力
      /// </summary>
      public int Intelligence { get; set; }

      /// <summary>
      /// 获取或设置细胞位置
      /// </summary>
      public Point Position
      {
         get
         {
            return new Point(_rowIndex, _columnIndex);
         }
         set
         {
            CellMoveEventArgs e = new CellMoveEventArgs();
            e.OriginPosition = this.Position;
            e.TargetPosition = value;

            this._rowIndex = value.X;
            this._columnIndex = value.Y;

            if (PositionChanged != null)
            {
               PositionChanged(this, e);
            }
         }
      }

      /// <summary>
      /// 血量
      /// </summary>
      public int HP
      {
         get
         {
            return _hp;
         }
         set
         {
            if (value > MaxHP)
            {
               _hp = MaxHP;
            }
            else
            {
               _hp = value;
            }

            if (_hp < 0 && _hp > -10)
            {
               State |= CellStateEnum.濒死;
            }
            else
            {
               State &= ~CellStateEnum.濒死;
            }
         }
      }

      /// <summary>
      /// 最大生命值
      /// </summary>
      public int MaxHP { get; set; }

      /// <summary>
      /// 攻击
      /// </summary>
      public int Attack
      {
         get
         {
            return Strength + Rule.Dice;
         }
      }

      /// <summary>
      /// 速度
      /// </summary>
      public int Speed
      {
         get
         {
            return Rule.初始速度 + Dexterity;
         }
      }

      /// <summary>
      /// 视野
      /// </summary>
      public int Vision
      {
         get
         {
            if (IsHaveState(CellStateEnum.被拌摔))
            {
               return 1;
            }

            int offset = Dexterity / 3;
            return (Rule.IsDay ? Rule.初始白天视野 : Rule.初始夜晚视野) + offset;
         }
      }

      /// <summary>
      /// 能力
      /// </summary>
      public int Ability
      {
         get;
         set;
      }

      /// <summary>
      /// 最大能力数量
      /// </summary>
      public int MaxAbilityCount
      {
         get
         {
            return Rule.初始能力 + Intelligence;
         }
      }

      /// <summary>
      /// 状态
      /// </summary>
      public int State { get; set; }

      /// <summary>
      /// 对手
      /// </summary>
      public List<Cell> Rival { get; set; }

      #endregion

      #region Override

      protected override void OnClick(EventArgs e)
      {
         base.OnClick(e);

         if (ParentWorldMapPanel != null)
         {
            ParentWorldMapPanel.SelectedCell = this;
         }
      }

      public override string ToString()
      {
         return this.No + "号细胞";
      }

      #endregion

      #region Method

      #region private

      public bool GetAbility()
      {
         int haveCount = BitOperator.GetBinaryCount(this.Ability);
         int ablitity = AbilityEnum.RandomAbility();
         int abilityCount = BitOperator.GetBinaryCount(ablitity);

         if (this.MaxAbilityCount >= (haveCount + abilityCount) && !this.IsHaveAbility(ablitity))
         {
            this.Ability |= ablitity;
            GameMessage.AddMsg(new AbilityMessage(){ 触发单位 = this, 获得的技能 = ablitity } );
            return true;
         }

         return false;
      }

      public List<Cell> GetNearbyCells()
      {
         return this.Position.Within(this.Vision).Where(
            p => this.ParentWorldMapPanel.IsExist(p) &&
                  this.ParentWorldMapPanel.IsContainForRect(p))
                     .Select(position => this.ParentWorldMapPanel.GetCellByPosition(position)).ToList();
      }

      void AddRival(Cell cell)
      {
         this.Rival.Add(cell);
      }

      /// <summary>
      /// 受到伤害
      /// </summary>
      /// <param name="hurt"></param>
      /// <returns></returns>
      bool GetHurt(int hurt)
      {
         bool isAlive = true;

         HP -= hurt;

         if (HP <= -10)
         {
            isAlive = false;
         }

         //大量伤害(Massive Damage)
         if (hurt > 30)
         {
            if (Rule.Dice < 5)
            {
               isAlive = false;
            }
         }

         return isAlive;
      }

      bool IsHaveAbility(int ability)
      {
         if ((Ability & ability) == ability)
         {
            return true;
         }

         return false;
      }

      bool IsHaveState(int state)
      {
         if ((State & state) == state)
         {
            return true;
         }

         return false;
      }

      /// <summary>
      /// 运动
      /// </summary>
      /// <param name="targetPosition"></param>
      void Movement(Point targetPosition)
      {
         this.Position = targetPosition;

         if (_random.Probability(Rule.获取属性点几率) && this._L_Dexterity > 0)
         {
            this._L_Dexterity--;
            this.Dexterity++;
         }

         if (_random.Probability(Rule.获取属性点几率) && this._L_Strength > 0)
         {
            this._L_Strength--;
            this.Strength++;
         }
      }

      #endregion

      /// <summary>
      /// 漫步
      /// </summary>
      /// <returns></returns>
      public bool Wander()
      {
         Point targetPosition = this.Position.Within(this.Vision).RandomElement(
            p => !this.ParentWorldMapPanel.IsExist(p) &&
               this.ParentWorldMapPanel.IsContainForRect(p));

         if (targetPosition.IsEmpty)
         {
            Rest();
            return false;
         }

         Movement(targetPosition);
         return true;
      }

      /// <summary>
      /// 休息
      /// </summary>
      public void Rest()
      {
         this.HP += Rule.Dice;

         if (_random.Probability(Rule.获取属性点几率) && this._L_Intelligence > 0)
         {
            this._L_Intelligence--;
            this.Intelligence++;
         }
      }

      /// <summary>
      /// 随机位置
      /// </summary>
      public void RandomPosition()
      {
         _rowIndex = _random.Next(Rule.ROWS);
         _columnIndex = _random.Next(Rule.COLUMNS);

         this.Location = WorldMapPanel.GetLocation(_rowIndex, _columnIndex);
      }

      #endregion

      #region event

      public delegate void CellDeadEventHandler(object sender, CellDeadEventArgs e);
      public event CellDeadEventHandler Dead;

      public delegate void CellMoveEventHandler(object sender, CellMoveEventArgs e);
      public event CellMoveEventHandler PositionChanged;


      #endregion

   }
}
