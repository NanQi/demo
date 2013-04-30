using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NanQi.Framework.Control;
using NanQi.Framework.Presentation;
using System.Collections;

namespace NanQi.Project.Form1
{
    public partial class T_UserManager : NormalTradeWindow
    {
        public T_UserManager()
        {
            InitializeComponent();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            List<string> lstUserList = new List<string>();

            lstUserList.Add("张三");
            lstUserList.Add("李四");
            lstUserList.Add("王五");


            var dic = new Dictionary<string, object>();
            dic.Add("UserList", lstUserList);
            var result = this.ShowTrade("NanQi.Project.Form2.T_ChooseUser", dic);

            var chooseList = result["ChooseList"] as IEnumerable;

            StringBuilder str = new StringBuilder();

            foreach (var item in chooseList)
            {
                str.AppendLine(item.ToString());
            }

            MessageBox.Show(str.ToString());
        }
    }
}
