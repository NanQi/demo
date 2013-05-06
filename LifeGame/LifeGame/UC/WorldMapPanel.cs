using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Untity;

namespace LifeGame
{
   public class WorldMapPanel : Panel
   {
      private List<Cell> _lstCell = new List<Cell>();

      Cell _selectedCell;

      #region ctor

      public WorldMapPanel()
      {
         SetStyle(
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw |
            ControlStyles.AllPaintingInWmPaint, true);

         this.Width = Rule.ROWS * Rule.CELLWIDTH + 1;
         this.Height = Rule.ROWS * Rule.CELLWIDTH + 1;
      }

      #endregion

      #region Override
      protected override void OnPaint(PaintEventArgs e)
      {
         base.OnPaint(e);

         Graphics g = e.Graphics;

         //网格
         for (int i = 0; i < Rule.ROWS + 1; i++)
         {
            g.DrawLine(Rule.GRIDPEN,
               0, i * Rule.CELLWIDTH,
               Rule.CELLWIDTH * Rule.ROWS, i * Rule.CELLWIDTH);
         }

         for (int i = 0; i < Rule.COLUMNS + 1; i++)
         {
            g.DrawLine(Rule.GRIDPEN,
               i * Rule.CELLWIDTH, 0,
               i * Rule.CELLWIDTH, Rule.CELLWIDTH * Rule.COLUMNS);
         }

      }
      #endregion

      #region prop

      public Cell SelectedCell 
      {
         get
         {
            return _selectedCell;
         }
         set
         {
            _selectedCell = value;
            if (SelectedCellChanged != null)
            {
               SelectedCellChanged(value, null);
            }
         }
      }

      public List<Cell> Cells
      {
         get { return _lstCell; }
      }

      #endregion

      #region Method

      #region private

      #endregion

      public Cell AddCell()
      {
         Cell cell = new Cell();
         cell.BackColor = Color.Gray;

         if (cell.Strength > 10)
         {
            cell.BackColor = Color.Red;
         }
         else if (cell.Dexterity > 10)
         {
            cell.BackColor = Color.Green;
         }
         else if (cell.Intelligence > 10)
         {
            cell.BackColor = Color.Blue;
         }

         return AddCell(cell);
      }

      public Cell AddCell(Cell cell)
      {
         if (_lstCell.Count > Rule.ROWS * Rule.COLUMNS / 3)
         {
            return null;
         }

         while (_lstCell.Select(cl => cl.Position).Contains(cell.Position))
         {
            cell.RandomPosition();
         }

         cell.No = _lstCell.Count;
         cell.ParentWorldMapPanel = this;
         while (!cell.GetAbility()) ;
         cell.Dead += (sender, e) => 
            {
               _lstCell.Remove(cell);
               this.Controls.Remove(cell);
            };
         cell.PositionChanged += (sender, e) => 
            {
               cell.Location = GetLocation(e.TargetPosition);
            };
         _lstCell.Add(cell);
         this.Controls.Add(cell);

         this.Invalidate(cell.ClientRectangle);

         return cell;
      }

      public Cell GetCellByPosition(Point position)
      {
         return _lstCell.Find(cell => cell.Position == position);
      }

      

      public Cell GetCellByNo(int no)
      {
         return _lstCell.Find(cell => cell.No == no);
      }

      public bool IsExist(Point position)
      {
         return _lstCell.Exists(cell => cell.Position == position);
      }

      public bool IsContainForRect(Point position)
      {
         return this.ClientRectangle.Contains(GetLocation(position));
      }

      public void GetVision(Cell cell)
      {
         Graphics g = this.CreateGraphics();
         foreach (var item in cell.Position.Within(cell.Vision).Select(p => GetLocation(p)))
         {
            g.FillRectangle(new SolidBrush(Color.Gold), new Rectangle(item, new Size(Rule.CELLWIDTH - 1, Rule.CELLWIDTH - 1)));
         }
      }

      #region static

      public static Point GetLocation(int rowIndex, int columnIndex)
      {
         return new Point(rowIndex * Rule.CELLWIDTH + 1, columnIndex * Rule.CELLWIDTH + 1);
      }

      public static Point GetLocation(Point p)
      {
         return GetLocation(p.X, p.Y);
      }

      #endregion

      #endregion

      #region event

      public event EventHandler SelectedCellChanged;

      #endregion
   }
}
