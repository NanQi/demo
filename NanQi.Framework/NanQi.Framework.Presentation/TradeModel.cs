using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NanQi.Framework.Presentation
{
    [Serializable]
    public class TradeModel
    {
        private Guid _guid;

        public Guid GUID
        {
            get { return _guid; }
            set { _guid = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _actionName;

        public string ActionName
        {
            get { return _actionName; }
            set { _actionName = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override bool Equals(object obj)
        {
            var trade = obj as TradeModel;
            if (trade == null) return false;

            if (trade._guid == _guid)
            {
                return true;
            }
            else if (trade._title == _title && trade._description == _description && trade._actionName == _actionName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return _title;
        }
    }
}
