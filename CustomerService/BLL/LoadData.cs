using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerService.BLL
{
    public class LoadData
    {
        public void Load()
        {
            BLL.Argument bll = new Argument();
            //客户编号
            Model.Argument modelCustomerNo = new Model.Argument();

            modelCustomerNo.aName = "FZ-KHXX-";
            modelCustomerNo.type = "客户编号";

            bll.Add(modelCustomerNo);
            //服务编号
            Model.Argument modelServiceNo = new Model.Argument();

            modelServiceNo.aName = "FX-XGL-";
            modelServiceNo.type = "服务编号";

            bll.Add(modelServiceNo);
        }
    }
}
