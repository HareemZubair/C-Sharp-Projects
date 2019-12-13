using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace myweb
{
    public class clsweb
    {
        SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;

        string query;

        public void BindToDataList(string qry, DataList dl)
        {
            da = new SqlDataAdapter(qry, cn);
            ds = new DataSet();
            da.Fill(ds, "tab");
            dl.DataSource = ds.Tables["tab"];
            dl.DataBind();
        }

        public void BindToGridView(string qry, GridView gv)
        {
            da = new SqlDataAdapter(qry, cn);
            ds = new DataSet();
            da.Fill(ds, "tab");
            gv.DataSource = ds.Tables["tab"];
            gv.DataBind();
        }
    }
}