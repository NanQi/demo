using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace NanQi.Framework.Presentation
{
    public class TradeContainer : DockPanel
    {
        public Guid OpenTrade(string actionName, IDictionary<string, object> importArgs = null)
        {
            var trade = TradeFactory.CreateTrade(actionName);

            if (trade == null)
            {
                return Guid.Empty;
            }
            else
            {
                trade.ViewState = importArgs;
                return OpenTrade(trade);
            }
        }

        public Guid OpenTrade(ITrade trade)
        {
            DockContent dock = trade as DockContent;

            if (dock == null)
            {
                return Guid.Empty;
            }
            else
            {
                if (trade.GUID == Guid.Empty)
                {
                    trade.GUID = Guid.NewGuid();
                }

                dock.Show(this);

                return trade.GUID;
            }
        }
    }
}
