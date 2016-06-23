using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_delete : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=StuInfo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string a = name.Text.ToString().Trim();

        SqlCommand sel = new SqlCommand();
        sel.CommandText = "select count(*) from studentInfo where 学号= @stuNum";
        sel.Parameters.AddWithValue("@stuNum", a);
        sel.Connection = conn;
        conn.Open();
        int i = Convert.ToInt32(sel.ExecuteScalar());
        conn.Close();
        if (i == 1)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from studentInfo where 学号= @stuNum";
            cmd.Parameters.AddWithValue("@stuNum", a);
            cmd.Connection = conn;
            conn.Open();
            int m = Convert.ToInt32(cmd.ExecuteNonQuery());
            conn.Close();
            if (m == 1)
            {
                Response.Redirect("./delete.aspx");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('删除失败，请重试');</script>");

        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('删除失败，不存在该生信息');</script>");
            name.Text="";
        }
    }
    
    
}