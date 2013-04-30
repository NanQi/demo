using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace NanQi.Framework.Presentation
{
    public interface IMain
    {
        TradeContainer TradeContainer { get; }

        void LoadMenu(IEnumerable<TradeMenu> menuSource);
    }
}
