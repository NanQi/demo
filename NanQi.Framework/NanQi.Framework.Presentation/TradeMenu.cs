using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NanQi.Framework.Presentation
{
    public class TradeMenu : TradeModel
    {
        private IEnumerable<TradeMenu> _children;

        public IEnumerable<TradeMenu> Children
        {
            get { return _children; }
            set { _children = value; }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
