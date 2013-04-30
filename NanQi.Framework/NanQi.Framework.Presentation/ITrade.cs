using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NanQi.Framework.Presentation
{
    public interface ITrade : IDisposable
    {
        Guid GUID { get; set; }

        IDictionary<string, object> ViewState { get; set; }

        event EventHandler<TradeClosedEventArgs> TradeClosed;

        event EventHandler TradeLoad;
    }
}
