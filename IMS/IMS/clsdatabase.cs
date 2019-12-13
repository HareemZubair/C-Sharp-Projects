using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMS
{
    class clsdatabase
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=dbIMS;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        string qry;
        public static string user;

         public bool checkUser(string uid,string pass)
        {
        
            qry = "select * from tbluser where uid='" + uid + "' and upass='" + pass + "'";

            da = new SqlDataAdapter(qry, con);
            ds = new DataSet();
            da.Fill(ds, "tab");

            if (ds.Tables["tab"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void FindUser(string uid, string pass)
        {
            qry = "select * from tbluser where uid='" + uid + "' and upass='" + pass + "'";

            da = new SqlDataAdapter(qry, con);
            ds = new DataSet();
            da.Fill(ds, "tab");

                clsdatabase.user = ds.Tables["tab"].Rows[0]["ustatus"].ToString();  
        }

        public void bindGrid(string q,DataGridView dgv)
        {
            da = new SqlDataAdapter(q,con);
            ds = new DataSet();
            da.Fill(ds,"tab");
            dgv.DataSource = ds.Tables["tab"];
        }


        public void bindCombo(string q, ComboBox cbo,string dmember,string vmember)
        {
            da = new SqlDataAdapter(q, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            cbo.DataSource = ds.Tables["tab"];
            cbo.DisplayMember = dmember;
            cbo.ValueMember = vmember;
        }

        public void bindTextBox(string q, TextBox t, string columnnName)
        {
            da = new SqlDataAdapter(q, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            t.Text = ds.Tables["tab"].Rows[0][columnnName].ToString() ;
        }
        public void bindlabel(string q, Label t, string columnnName)
        {
            da = new SqlDataAdapter(q, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            t.Text = ds.Tables["tab"].Rows[0][columnnName].ToString();
        }
        public void bindCombobox2(string q, ComboBox t, string columnnName)
        {
            da = new SqlDataAdapter(q, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            t.Text = ds.Tables["tab"].Rows[0][columnnName].ToString();
        }

        public void bindtoCombo(string q, ComboBox cbo, string columnnName)
        {
            da = new SqlDataAdapter(q, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            cbo.Text = ds.Tables["tab"].Rows[0][columnnName].ToString();
        }

        public void Manipulate(string q,string Message)
        {
            //try
            //{
                cmd = new SqlCommand();
                cmd.CommandText = q;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(Message);
                con.Close();
            //}
            //catch (Exception ex)
            //{
               // MessageBox.Show("Some Error Occurecd! PlzTry Again");
               // con.Close();
            //}
           
        }
        public void IdGenrator(string q, Label l)
        {
            int I;
            da = new SqlDataAdapter(q, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            I = Convert.ToInt32(ds.Tables["tab"].Rows[0]["id"]);
            l.Text = I.ToString();
        }

        public string NewId(string fname,string tbname)
        {
            qry = "select isnull(max(" + fname + "),0) + 1 as ID from " + tbname;
            da = new SqlDataAdapter(qry, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            return ds.Tables["tab"].Rows[0]["id"].ToString();
            
        }


        public string FindField(string q, string colname)
        {   
            da = new SqlDataAdapter(q, con);
            ds = new DataSet();
            da.Fill(ds, "tab");

            return ds.Tables["tab"].Rows[0][colname].ToString();
        }

    }
}