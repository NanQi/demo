using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace VisualCryptography
{
   public partial class Form1 : Form
   {
      bool[][] _unit;

      bool[] _resultCode;
      bool[] _resultMsg;

      readonly byte[] DEF_CODE = System.Text.Encoding.Default.GetBytes("c?Teow9i.fbqr-:z");

      public Form1()
      {
         InitializeComponent();

         _unit = new bool[][] { new bool[] { true, false, false, true }, new bool[] { false, true, true, false } };
      }

      private void button1_Click(object sender, EventArgs e)
      {
         //密码
         byte[] code = System.Text.Encoding.Default.GetBytes(textBox1.Text.Trim());

         if (code.Length == 0)
         {
            code = DEF_CODE;
         }
         else if (code.Length > 16)
         {
            code = code.Take(16).ToArray();
         }
         else
         {
            while (code.Length < 4)
            {
               code = code.Concat(code).ToArray();
            }
         }

         code = code.Concat(DEF_CODE.Skip(code.Length)).ToArray();

         IEnumerable<byte> tmpDataCode = Enumerable.Empty<byte>();

         for (int i = 0; i < code.Length; i += 4)
         {
            tmpDataCode = tmpDataCode.Concat(SHA512Encrypt(code.Where((by, index) => (index & 3) == (i / 4 & 3)).ToArray()));
         }

         bool[] dataCode = tmpDataCode.Select(by => Convert.ToBoolean(by & 1)).ToArray();

         //字模
         Bitmap bmp = new Bitmap(16, 16);
         Graphics g = Graphics.FromImage(bmp);
         g.FillRectangle(Brushes.White, new Rectangle() { X = 0, Y = 0, Height = 16, Width = 16 });
         g.DrawString(textBox2.Text, textBox2.Font, Brushes.Black, Point.Empty);

         bool[] dataMsg = Enumerable.Range(0, 256).Select(a => new { x = a % 16, y = a / 16 })
             .Select(x => bmp.GetPixel(x.x, x.y).GetBrightness() > 0.5f ? false : true).ToArray();

         //差异
         bool[] dataDiff = dataCode.ToArray();

         if (dataMsg.Length == dataCode.Length)
         {
            for (int i = 0; i < dataMsg.Length; i++)
            {
               dataDiff[i] = dataMsg[i] ? dataDiff[i] : !dataDiff[i];
            }
         }

         //密匙
         IEnumerable<bool> tmpResultCode = Enumerable.Empty<bool>();

         foreach (var item in dataCode)
         {
            tmpResultCode = tmpResultCode.Concat(_unit[Convert.ToInt32(item)]);
         }

         _resultCode = tmpResultCode.ToArray();


         //消息
         IEnumerable<bool> tmpResultMsg = Enumerable.Empty<bool>();

         foreach (var item in dataDiff)
         {
            tmpResultMsg = tmpResultMsg.Concat(_unit[Convert.ToInt32(item)]);
         }

         _resultMsg = tmpResultMsg.ToArray();

         pictureBox1.Invalidate();
         pictureBox2.Invalidate();
      }

      /// <summary>
      /// SHA512加密，不可逆转
      /// </summary>
      private byte[] SHA512Encrypt(byte[] code)
      {
         System.Security.Cryptography.SHA512 s512 = new System.Security.Cryptography.SHA512Managed();
         byte[] result = s512.ComputeHash(code);
         s512.Clear();
         return result;
      }

      void Draw(Graphics g, bool[] data)
      {
         for (int i = 0; i < 16; i++)
         for (int j = 0; j < 16; j++)
         for (int k = 0; k < 4; k++)
         {
            Brush brush = data[j * 4 * 16 + i * 4 + k] ? Brushes.Black : Brushes.White;

            if (k < 2)
               g.FillRectangle(brush, new Rectangle() { X = i * 16 + k * 8, Y = j * 16, Width = 8, Height = 8 });
            else
               g.FillRectangle(brush, new Rectangle() { X = i * 16 + (k - 2) * 8, Y = j * 16 + 8, Width = 8, Height = 8 });
         }
      }

      private void pictureBox1_Paint(object sender, PaintEventArgs e)
      {
         if (_resultCode != null)
         {
            Draw(e.Graphics, _resultCode);
         }
      }

      private void pictureBox2_Paint(object sender, PaintEventArgs e)
      {
         if (_resultMsg != null)
         {
            Draw(e.Graphics, _resultMsg);
         }
      }

      private void textBox2_TextChanged(object sender, EventArgs e)
      {
         textBox2.Text = textBox2.Text.Length > 0 ? textBox2.Text.Substring(textBox2.Text.Length - 1) : "";
         textBox2.SelectionStart = textBox1.Text.Length;
      }
   }
}
