using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NanQi.Framework.Presentation
{
    public static class TradeExtension
    {
        public static IDictionary<string, object> ShowTrade(this ITrade iTrade, string actionName, IDictionary<string, object> importArgs = null)
        {
            var trade = TradeFactory.CreateTrade(actionName);
            var frm = trade as Form;

            if (frm == null)
            {
                return null;
            }
            else
            {
                trade.ViewState = importArgs;
                frm.ShowDialog();
                return trade.ViewState;
            }
        }

    }
}
