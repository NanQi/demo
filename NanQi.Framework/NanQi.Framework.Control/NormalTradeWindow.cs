using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NanQi.Framework.Presentation;
using WeifenLuo.WinFormsUI.Docking;
using System.Threading;

namespace NanQi.Framework.Control
{
    public partial class NormalTradeWindow : DockContent, ITrade
    {
        #region Field

        Guid _guid = Guid.NewGuid();
        IDictionary<string, object> _viewState = new Dictionary<string, object>();

        #endregion
        public NormalTradeWindow()
        {
            InitializeComponent();

            this.Load += OnTradeLoad;
            this.FormClosed += OnTradeClosed;
        }

        void OnTradeLoad(object sender, EventArgs e)
        {
            EventHandler tmp = Interlocked.CompareExchange(ref TradeLoad, null, null);
            if (tmp != null)
            {
                tmp(sender, e);
            }
        }

        void OnTradeClosed(object sender, FormClosedEventArgs e)
        {
            EventHandler<TradeClosedEventArgs> tmp = Interlocked.CompareExchange(ref TradeClosed, null, null);
            if (tmp != null)
            {
                TradeClosedEventArgs args = new TradeClosedEventArgs(_guid, null);
                tmp(sender, args);

                _viewState = args.ExportArgs;
            }
        }

        #region ITrade 成员

        public Guid GUID
        {
            get
            {
                return _guid;
            }
            set
            {
                _guid = value;
            }
        }

        public IDictionary<string, object> ViewState
        {
            get
            {
                return _viewState;
            }
            set
            {
                _viewState = value;
            }
        }

        public event EventHandler<TradeClosedEventArgs> TradeClosed;

        public event EventHandler TradeLoad;

        #endregion
    }
}
