
/* By NanQi 201209 in Internet */

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace NanQi.Controls
{
   [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
   public class LoadingCircleToolStripMenuItem : ToolStripControlHost
   {
      public LoadingCircleToolStripMenuItem() : base(new LoadingCircle())
      {
      }

      [RefreshProperties(RefreshProperties.All),
       DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
      public LoadingCircle LoadingCircleControl
      {
         get { return (base.Control as LoadingCircle); }
      }

      public override Size GetPreferredSize(Size constrainingSize)
      {
         return LoadingCircleControl.GetPreferredSize(constrainingSize);
      }
   }
}