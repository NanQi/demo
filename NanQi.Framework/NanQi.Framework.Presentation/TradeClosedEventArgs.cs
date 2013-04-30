using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NanQi.Framework.Presentation
{
    public class TradeClosedEventArgs : EventArgs
    {
        public Guid GUID { get; set; }
        public IDictionary<string, object> ExportArgs { get; set; }

        public TradeClosedEventArgs(Guid guid, IDictionary<string, object> exportArgs)
        {
            this.GUID = guid;
            this.ExportArgs = exportArgs;
        }
    }
}
