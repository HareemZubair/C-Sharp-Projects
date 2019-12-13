using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myweb
{
    public partial class frmrecord : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;

        protected void Page_Load(object sender, EventArgs e)
        {
            qry = "select tblmember.mid,tblbook.status,tblbook.date, tblbook.book from tblbook join tblmember on tblbook.mid = tblmember.mid";

            obj.BindToDataList(qry, DataList1);
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}