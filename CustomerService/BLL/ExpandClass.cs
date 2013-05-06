using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerService.BLL
{
    public static class ExpandClass
    {
        public static Guid GUID(this TreeNode tn)
        {
            return new Guid(tn.Name);
        }
    }
}
