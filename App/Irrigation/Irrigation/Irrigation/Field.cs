using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Irrigation
{
    class Field
    {
        PicReady _ready = new PicReady(11);
        internal PicReady Ready
        {
            get { return _ready; }
            set { _ready = value; }
        }

        private Field _isLinkL = null;
        internal Field IsLinkL
        {
            get { return _isLinkL; }
            set { _isLinkL = value; }
        }

        private Field _isLinkR = null;
        internal Field IsLinkR
        {
            get { return _isLinkR; }
            set { _isLinkR = value; }
        }

        private Field _isLinkT = null;
        internal Field IsLinkT
        {
            get { return _isLinkT; }
            set { _isLinkT = value; }
        }

        private Field _isLinkB = null;
        internal Field IsLinkB
        {
            get { return _isLinkB; }
            set { _isLinkB = value; }
        }

        private Image picField;
        internal Image PicField
        {
            get { return picField; }
            set { picField = value; }
        }

        //private bool 
    }
}
