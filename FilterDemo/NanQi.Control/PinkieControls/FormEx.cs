
/* By NanQi 201209 in Internet */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PinkieControls
{
   public class FormEx : Form
   {
      private Container _components;
      private float fadeTime = 10f;
      private Timer timer;

      public FormEx()
      {
         InitializeComponent();
      }

      [DefaultValue(1.0), Browsable(true)]
      public float FadeTime
      {
         get { return fadeTime; }
         set { fadeTime = value; }
      }

      protected override void Dispose(bool disposing)
      {
         if (disposing && (_components != null))
         {
            _components.Dispose();
         }
         base.Dispose(disposing);
      }

      private void InitializeComponent()
      {
         _components = new Container();
         timer = new Timer();
         timer.Tick += timer_Tick;
         AutoScaleBaseSize = new Size(5, 13);
         base.ClientSize = new Size(0x124, 0x10a);
         base.Name = "FormEx";
         Text = "Form1";
      }

      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);
         if (!base.DesignMode)
         {
            base.Opacity = 0.0;
            timer.Enabled = true;
         }
      }

      private void timer_Tick(object sender, EventArgs e)
      {
         base.Opacity += (timer.Interval)/fadeTime;
         timer.Enabled = base.Opacity < 1.0;
      }
   }
}