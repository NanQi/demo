using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LifeGame
{
   public partial class FrmMain : Form
   {
      #region field
      static FrmMain _instance;

      #endregion

      #region ctor
      public FrmMain()
      {
         InitializeComponent();

         GameMessage.AddMessage += Filter_FightMessage;
         GameMessage.AddMessage += Filter_AbilityMessage;
      }

      #endregion

      #region prop
      public static FrmMain Instance
      {
         get
         {
            if (_instance == null)
            {
               _instance = new FrmMain();
            }
            return FrmMain._instance;
         }
      }

      #endregion

      #region UIEvent
      private void btnCreatePlayerCell_Click(object sender, EventArgs e)
      {
         worldMapPanel1.AddCell();
      }

      private void worldMapPanel1_SelectedCellChanged(object sender, EventArgs e)
      {
         Cell cell = worldMapPanel1.SelectedCell;

         lblNo.Text = cell.No.ToString();
         lblEthnicity.Text = cell.Ethnicity.ToString();
         lblStrength.Text = cell.Strength.ToString();
         lblHP.Text = cell.HP.ToString();
         lblAttack.Text = cell.Attack.ToString();
         lblDexterity.Text = cell.Dexterity.ToString();
         lblSpeed.Text = cell.Speed.ToString();
         lblVision.Text = cell.Vision.ToString();
         lblIntelligence.Text = cell.Intelligence.ToString();
         lblMaxAbilityCount.Text = cell.MaxAbilityCount.ToString();
         lblAbility.Text = Convert.ToString(cell.Ability, 2).PadLeft(32, '0');
         lblState.Text = Convert.ToString(cell.State, 2).PadLeft(32, '0');

         if (sender != null)
         {
            timer1.Stop();
         }
      }

      private void lblVision_Click(object sender, EventArgs e)
      {
         if (worldMapPanel1.SelectedCell != null)
         {
            worldMapPanel1.GetVision(worldMapPanel1.SelectedCell);
         }
      }

      private void btnWander_Click(object sender, EventArgs e)
      {
         if (worldMapPanel1.SelectedCell != null)
         {
            worldMapPanel1.SelectedCell.Wander();
         }
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         Rule.GameTime++;

         foreach (var item in worldMapPanel1.Cells.OrderByDescending(cell => cell.Speed))
         {
            item.NextAction();
         }

         worldMapPanel1.Invalidate();

         if (worldMapPanel1.SelectedCell != null)
         {
            worldMapPanel1_SelectedCellChanged(null, null);
         }

         lblTime.Text = Rule.GameTime.ToString();
         lblDay.Text = Rule.IsDay ? "白天" : "黑夜";
      }

      private void btnStart_Click(object sender, EventArgs e)
      {
         timer1.Start();
      }

      private void btnStop_Click(object sender, EventArgs e)
      {
         timer1.Stop();
      }

      private void btnNext_Click(object sender, EventArgs e)
      {
         timer1_Tick(null, null);
      }

      private void btnAbility_Click(object sender, EventArgs e)
      {
         if (worldMapPanel1.SelectedCell != null)
         {
            worldMapPanel1.SelectedCell.Ability |= AbilityEnum.奋力一击;
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if (worldMapPanel1.SelectedCell != null)
         {
            worldMapPanel1.SelectedCell.Ability |= AbilityEnum.击中要害;
         }
      }

      private void btnCreateWorld_Click(object sender, EventArgs e)
      {
         int count = 10;

         int.TryParse(txtCellCount.Text, out count);

         for (int i = 0; i < count; i++)
         {
            worldMapPanel1.AddCell();
         }

         txtCellCount.Text = count.ToString();
      }

      private void chbxFightMessage_CheckedChanged(object sender, EventArgs e)
      {
         if (chbxFightMessage.Checked)
         {
            GameMessage.AddMessage += Filter_FightMessage;
         }
         else
         {
            GameMessage.AddMessage -= Filter_FightMessage;
         }
      }

      private void chbxAbilityMessage_CheckedChanged(object sender, EventArgs e)
      {
         if (chbxAbilityMessage.Checked)
         {
            GameMessage.AddMessage += Filter_AbilityMessage;
         }
         else
         {
            GameMessage.AddMessage -= Filter_AbilityMessage;
         }
      }

      #endregion











      #region Method

      #region private

      #region eventMethod

      void Filter_FightMessage(object sender, EventArgs e)
      {
         if (e is FightMessageEventArgs)
         {
            this.MessageListBox.Items.Add(e);
         }

         this.MessageListBox.SelectedIndex = MessageListBox.Items.Count - 1;
         this.MessageListBox.ClearSelected();
      }

      void Filter_AbilityMessage(object sender, EventArgs e)
      {
         if (e is AbilityMessageEventArgs)
         {
            this.MessageListBox.Items.Add(e);
         }

         this.MessageListBox.SelectedIndex = MessageListBox.Items.Count - 1;
         this.MessageListBox.ClearSelected();
      }

      #endregion

      #endregion

      #endregion












   }
}
